using Microsoft.AspNetCore.Mvc;
using webapi.models;
using webapi.datacontext;
using webapi.models.kitchen;
using webapi.models.form;

namespace webap.controllers
{

    public class CashierListController : MainController
    {

        private readonly DataContext _context;
        public CashierListController(DataContext context) {
            _context = context;
        }

        [HttpPost]
        [Route(nameof(GetAllLists))]
        public async Task<IActionResult> GetAllLists() {
            return Ok(_context.cashierChecklist.ToList());
        }
        
        [HttpGet]
        [Route(nameof(GetListById))]
        public async Task<IActionResult> GetListById(Guid id) {
            CashierChecklist cashierList = _context.cashierChecklist.Where(list => list.id == id).FirstOrDefault()!;             
            cashierList.comment = _context.comment.Where(list => list.id == cashierList.commentId).FirstOrDefault()!;
            cashierList.signature = _context.signature.Where(list => list.id == cashierList.signatureId).FirstOrDefault()!;
            return Ok(cashierList);
        }

        [HttpPost]
        [Route(nameof(Create))]
        public async Task<IActionResult> Create([FromBody] CashierChecklist list) {
         
            _context.Add(list);
            await _context.SaveChangesAsync();            
            return Ok(list);
        }

    }
}
