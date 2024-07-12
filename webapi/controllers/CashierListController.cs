using Microsoft.AspNetCore.Mvc;
using webapi.models;
using webapi.datacontext;
using webapi.models.kitchen;
using webapi.models.form;
using webapi.models.dto;
using MapsterMapper;

namespace webap.controllers
{

    public class CashierListController : MainController
    {

        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public CashierListController(DataContext context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        [Route(nameof(GetAllLists))]
        public async Task<IActionResult> GetAllLists() {

            List<CashierChecklist> mainLists = new List<CashierChecklist>();
            List<CashierChecklist> lists = _context.cashierChecklist.Where(list => list.submitted == true).OrderByDescending(list => list.endDate).ToList();
            foreach (CashierChecklist mainList in lists)
            {
                Guid listId = mainList.id; 
                mainList.cashierTask = _context.cashierTask.Where(cashierTask => cashierTask.listId == listId).FirstOrDefault()!;
                mainList.signature = _context.signature.Where(signature => signature.id == mainList.signatureId).FirstOrDefault()!;
                mainList.comment = _context.comment.Where(comment => comment.id == mainList.commentId).FirstOrDefault()!;

                mainLists.Add(mainList);
            }
            return Ok(_context.cashierChecklist.ToList());
        }
        
        [HttpGet]
        [Route(nameof(GetListById))]
        public async Task<IActionResult> GetListById(Guid id) {
            CashierChecklist cashierList = _context.cashierChecklist.Where(list => list.id == id).FirstOrDefault()!;             

            if (cashierList == null) return NotFound();

            cashierList.cashierTask = _context.cashierTask.Where(cashierTask => cashierTask.listId == cashierList.id).FirstOrDefault()!;
            cashierList.comment = _context.comment.Where(list => list.id == cashierList.commentId).FirstOrDefault()!;
            cashierList.signature = _context.signature.Where(list => list.id == cashierList.signatureId).FirstOrDefault()!;
            return Ok(cashierList);
        }

        [HttpGet]
        [Route(nameof(CreateBlank))]
        public async Task<IActionResult> CreateBlank() {
            CashierChecklist cashierChecklist = new CashierChecklist();
            cashierChecklist.startDate = DateTime.Now;
            cashierChecklist.submitted = false;
            _context.Add(cashierChecklist);
            await _context.SaveChangesAsync();         
            return Ok(cashierChecklist);
        }

         [HttpPost]
        [Route(nameof(SubmitForm))]
        public async Task<IActionResult> SubmitForm([FromBody] CashierChecklistDto list) {
            CashierChecklist cashierChecklist = _context.cashierChecklist.Where(cashierChecklist => cashierChecklist.id == list.id).FirstOrDefault()!;

            CashierTask cashierTask = _context.cashierTask.Where(cashierTask => cashierTask.listId == list.id).FirstOrDefault()!;
            Signature signature = _context.signature.Where(aromatic => aromatic.id == cashierChecklist.signatureId).FirstOrDefault()!;
            Comment comment = _context.comment.Where(aromatic => aromatic.id == cashierChecklist.commentId).FirstOrDefault()!;

            cashierTask = _mapper.Map<CashierTask>(list.cashierTask);
            
            signature.name = list.signature.name;
            comment.comment = list.comment.comment;
          
            cashierTask.listId = list.id; 
            cashierTask.fileContainer = _context.fileContainerType.Where(container => container.id == cashierTask.fileContainerTypeId).FirstOrDefault()!;


            cashierChecklist.endDate = DateTime.Now;
            cashierChecklist.submitted = true;
            
            _context.cashierTask.Update(cashierTask);
            _context.signature.Update(signature);
            _context.comment.Update(comment);
            _context.Update(cashierChecklist);

            await _context.SaveChangesAsync();

            return Ok(cashierChecklist);
        } 


         [HttpPost]
        [Route(nameof(SaveCurrentState))]
        public async Task<IActionResult> SaveCurrentState([FromBody] CashierChecklistDto list) {
            CashierChecklist cashierChecklist = _context.cashierChecklist.Where(cashierChecklist => cashierChecklist.id == list.id).FirstOrDefault()!;

            CashierTask cashierTask = _context.cashierTask.Where(cashierTask => cashierTask.listId == list.id).FirstOrDefault()!;
            Signature signature = _context.signature.Where(aromatic => aromatic.id == cashierChecklist.signatureId).FirstOrDefault()!;
            Comment comment = _context.comment.Where(aromatic => aromatic.id == cashierChecklist.commentId).FirstOrDefault()!;

            cashierTask = _mapper.Map<CashierTask>(list.cashierTask);
            
            signature.name = list.signature.name;
            comment.comment = list.comment.comment;
          
            cashierTask.listId = list.id; 
            cashierTask.fileContainer = _context.fileContainerType.Where(container => container.id == cashierTask.fileContainerTypeId).FirstOrDefault()!;

            _context.cashierTask.Update(cashierTask);
            _context.signature.Update(signature);
            _context.comment.Update(comment);
            _context.Update(cashierChecklist);

            await _context.SaveChangesAsync();

            return Ok(cashierChecklist);
        } 

        [HttpGet]
        [Route(nameof(GetUnsubmittedForm))]
        public async Task<IActionResult> GetUnsubmittedForm(Guid id) {
            CashierChecklist cashierList = _context.cashierChecklist.Where(list => list.submitted == false).FirstOrDefault()!;             
            
            if (cashierList == null) return NotFound();

            cashierList.cashierTask = _context.cashierTask.Where(cashierTask => cashierTask.listId == cashierList.id).FirstOrDefault()!;
            cashierList.comment = _context.comment.Where(list => list.id == cashierList.commentId).FirstOrDefault()!;
            cashierList.signature = _context.signature.Where(list => list.id == cashierList.signatureId).FirstOrDefault()!;
            return Ok(cashierList);
        }


        [HttpGet]
        [Route(nameof(CheckIfBlankFormExists))]
        public async Task<IActionResult> CheckIfBlankFormExists() {
            if (_context.cashierChecklist.Count() == 0) return Ok(false);
            if (_context.cashierChecklist.Any(list => list.submitted == false)) {
                return Ok(true);
            }
            return Ok(false);
        } 
        // [HttpPost]
        // [Route(nameof(Create))]
        // public async Task<IActionResult> Create([FromBody] CashierChecklist list) {
         
        //     _context.Add(list);
        //     await _context.SaveChangesAsync();            
        //     return Ok(list);
        // }

    }
}
