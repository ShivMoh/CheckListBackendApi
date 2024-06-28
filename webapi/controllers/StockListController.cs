using Microsoft.AspNetCore.Mvc;
using webapi.models;
using webapi.datacontext;
using webapi.models.kitchen;
using webapi.models.form;

namespace webap.controllers
{


    public class StockListController : MainController
    {

        private readonly DataContext _context;
        public StockListController(DataContext context) {
            _context = context;
        }

        [HttpPost]
        [Route(nameof(GetAllLists))]

        public async Task<IActionResult> GetAllLists() {
            List<StockOpeningCheckList> stockLists = new List<StockOpeningCheckList>(); 
            List<StockOpeningCheckList> lists = _context.stockOpeningCheckList.OrderByDescending(list => list.date).ToList();
            foreach (StockOpeningCheckList stockList in lists)
            {
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
            stockList.comment = _context.comment.Where(list => list.id == stockList.commentId).FirstOrDefault()!;
            stockList.signature = _context.signature.Where(list => list.id == stockList.signatureId).FirstOrDefault()!;

            return Ok(stockList);
        }

        [HttpPost]
        [Route(nameof(Create))]
        public async Task<IActionResult> Create([FromBody] StockOpeningCheckList list) {

            _context.Add(list);
            await _context.SaveChangesAsync();            
            return Ok(list);
        }

    }
}
