using Microsoft.AspNetCore.Mvc;
using webapi.models;
using webapi.datacontext;
using webapi.models.kitchen;
using webapi.models.form;
using MapsterMapper;

namespace webap.controllers
{


    public class StockListController : MainController
    {

        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public StockListController(DataContext context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        [Route(nameof(GetAllLists))]

        public async Task<IActionResult> GetAllLists() {
            List<StockOpeningCheckList> stockLists = new List<StockOpeningCheckList>(); 
            List<StockOpeningCheckList> lists = _context.stockOpeningCheckList.OrderByDescending(list => list.endDate).ToList();
            foreach (StockOpeningCheckList stockList in lists)
            {
                stockList.stockTask = _context.stockTask.Where(list => list.listId == stockList.id).FirstOrDefault()!;
                stockList.comment = _context.comment.Where(list => list.id == stockList.commentId).FirstOrDefault()!;
                stockList.signature = _context.signature.Where(list => list.id == stockList.signatureId).FirstOrDefault()!;
                stockLists.Add(stockList);
            }
            return Ok(stockLists);
        }

        
        [HttpGet]
        [Route(nameof(GetListById))]
        public async Task<IActionResult> GetListById(Guid id) {
            StockOpeningCheckList stockList = _context.stockOpeningCheckList.Where(list => list.id == id).FirstOrDefault()!;             

            if (stockList == null) return NotFound();

            stockList.stockTask = _context.stockTask.Where(list => list.listId == stockList.id).FirstOrDefault()!;
            stockList.comment = _context.comment.Where(list => list.id == stockList.commentId).FirstOrDefault()!;
            stockList.signature = _context.signature.Where(list => list.id == stockList.signatureId).FirstOrDefault()!;

            return Ok(stockList);
        }

        [HttpGet]
        [Route(nameof(CreateBlank))]
        public async Task<IActionResult> CreateBlank() {
            StockOpeningCheckList stockOpeningList = new StockOpeningCheckList();
            stockOpeningList.startDate = DateTime.UtcNow;
            stockOpeningList.submitted = false;
            _context.Add(stockOpeningList);
            await _context.SaveChangesAsync();         
            return Ok(stockOpeningList);
        }


            [HttpPost]
        [Route(nameof(SubmitForm))]
        public async Task<IActionResult> SubmitForm([FromBody] StockOpeningCheckListDto list) {
            StockOpeningCheckList stockOpeningCheckList = _context.stockOpeningCheckList.Where(stockOpeningCheckList => stockOpeningCheckList.id == list.id).FirstOrDefault()!;

            StockTask stockTask = _context.stockTask.Where(stockTask => stockTask.listId == stockOpeningCheckList.id).FirstOrDefault()!;

            Signature signature = _context.signature.Where(aromatic => aromatic.id == stockOpeningCheckList.signatureId).FirstOrDefault()!;
            Comment comment = _context.comment.Where(aromatic => aromatic.id == stockOpeningCheckList.commentId).FirstOrDefault()!;

            stockTask = _mapper.Map<StockTask>(list.stockTask);
            
            signature.name = list.signature.name;
            comment.comment = list.comment.comment;
          
            stockTask.listId = list.id; 
            stockTask.fileContainer = _context.fileContainerType.Where(container => container.id == stockTask.fileContainerTypeId).FirstOrDefault()!;

            _context.stockTask.Update(stockTask);
            _context.signature.Update(signature);
            _context.comment.Update(comment);

            stockOpeningCheckList.endDate = DateTime.UtcNow;
            stockOpeningCheckList.submitted = true;

            _context.Update(stockOpeningCheckList);

            await _context.SaveChangesAsync();

            return Ok(stockOpeningCheckList);
        } 


        [HttpPost]
        [Route(nameof(SaveCurrentState))]
        public async Task<IActionResult> SaveCurrentState([FromBody] StockOpeningCheckListDto list) {
            StockOpeningCheckList stockOpeningCheckList = _context.stockOpeningCheckList.Where(stockOpeningCheckList => stockOpeningCheckList.id == list.id).FirstOrDefault()!;

            StockTask stockTask = _context.stockTask.Where(stockTask => stockTask.listId == stockOpeningCheckList.id).FirstOrDefault()!;
            Signature signature = _context.signature.Where(aromatic => aromatic.id == stockOpeningCheckList.signatureId).FirstOrDefault()!;
            Comment comment = _context.comment.Where(aromatic => aromatic.id == stockOpeningCheckList.commentId).FirstOrDefault()!;

            stockTask = _mapper.Map<StockTask>(list.stockTask);
            
            signature.name = list.signature.name;
            comment.comment = list.comment.comment;
          
            stockTask.listId = list.id; 
            stockTask.fileContainer = _context.fileContainerType.Where(container => container.id == stockTask.fileContainerTypeId).FirstOrDefault()!;

            _context.stockTask.Update(stockTask);
            _context.signature.Update(signature);
            _context.comment.Update(comment);

            _context.Update(stockOpeningCheckList);

            await _context.SaveChangesAsync();

            return Ok(stockOpeningCheckList);
        }

        
        [HttpGet]
        [Route(nameof(CheckIfBlankFormExists))]
        public async Task<IActionResult> CheckIfBlankFormExists() {
            if (_context.stockOpeningCheckList.Count() == 0) return Ok(false);
            if (_context.stockOpeningCheckList.Any(list => list.submitted == false)) {
                return Ok(true);
            }
            return Ok(false);
        }  

        [HttpGet]
        [Route(nameof(GetUnsubmittedForm))]
        public async Task<IActionResult> GetUnsubmittedForm(Guid id) {
            StockOpeningCheckList stockOpeningCheckList = _context.stockOpeningCheckList.Where(list => list.submitted == false).FirstOrDefault()!;             
            
            if (stockOpeningCheckList == null) return NotFound();

            stockOpeningCheckList.stockTask = _context.stockTask.Where(stockTask => stockTask.listId == stockOpeningCheckList.id).FirstOrDefault()!;
            stockOpeningCheckList.comment = _context.comment.Where(list => list.id == stockOpeningCheckList.commentId).FirstOrDefault()!;
            stockOpeningCheckList.signature = _context.signature.Where(list => list.id == stockOpeningCheckList.signatureId).FirstOrDefault()!;
            return Ok(stockOpeningCheckList);
        }




        // [HttpPost]
        // [Route(nameof(Create))]
        // public async Task<IActionResult> Create([FromBody] StockOpeningCheckList stockOpeningCheckList) {

        //     _context.Add(stockOpeningCheckList);
        //     await _context.SaveChangesAsync();            
        //     return Ok(stockOpeningCheckList);
        // }

    }
}
