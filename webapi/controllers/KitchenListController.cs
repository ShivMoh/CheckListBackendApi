using Microsoft.AspNetCore.Mvc;
using webapi.models;
using webapi.datacontext;
using webapi.models.kitchen;
using webapi.models.form;
using webapi.models.files;

namespace webap.controllers
{

  
    public class KitchenListController : MainController
    {

        private DataContext _context;
        public KitchenListController(DataContext context) {
            _context = context;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return Ok("this is working now");
        }

        [HttpPost]
        [Route(nameof(GetAllLists))]

        public async Task<IActionResult> GetAllLists() {
            List<KitchenCheckList> mainLists = new List<KitchenCheckList>();
            List<KitchenCheckList> lists = _context.kitchenCheckList.OrderByDescending(list => list.date).ToList();
            foreach (KitchenCheckList mainList in lists)
            {
                Guid listId = mainList.id; 

                mainList.aromatics = _context.aromatics.Where(aromatic => aromatic.listId == listId).FirstOrDefault()!;
                mainList.arrivalBasics = _context.arrivalBasics.Where(arrivalBasic => arrivalBasic.listId == listId).FirstOrDefault()!;
                mainList.brothPrep = _context.brothPrep.Where(brothPrep => brothPrep.listId == listId).FirstOrDefault()!;
                mainList.finalPrep = _context.finalPrep.Where(finalPrep => finalPrep.listId == listId).FirstOrDefault()!;
                mainList.prepProteins = _context.prepProteins.Where(prepProteins => prepProteins.listId == listId).FirstOrDefault()!;
                mainList.prepSauces = _context.prepSauces.Where(prepSauces => prepSauces.listId == listId).FirstOrDefault()!;
                mainList.saladPrep = _context.saladPrep.Where(saladPrep => saladPrep.listId == listId).FirstOrDefault()!;
                mainList.stirFryVeg = _context.stirFryVeg.Where(stirFryVeg => stirFryVeg.listId == listId).FirstOrDefault()!;
                mainList.toppingsPrep = _context.toppingsPrep.Where(toppingsPrep => toppingsPrep.listId == listId).FirstOrDefault()!;
                mainList.comment = _context.comment.Where(list => list.id == mainList.commentId).FirstOrDefault()!;
                mainList.signature = _context.signature.Where(list => list.id == mainList.signatureId).FirstOrDefault()!;
                mainLists.Add(mainList);
            }

            return Ok(mainLists);
        }

        
        [HttpGet]
        [Route(nameof(GetListById))]
        public async Task<IActionResult> GetListById(Guid id) {
            KitchenCheckList mainList = _context.kitchenCheckList.Where(mainlist => mainlist.id == id).FirstOrDefault()!;
            
            if (mainList == null) return NotFound();

            Guid listId = mainList.id; 

            mainList.aromatics = _context.aromatics.Where(aromatic => aromatic.listId == listId).FirstOrDefault()!;
            mainList.arrivalBasics = _context.arrivalBasics.Where(arrivalBasic => arrivalBasic.listId == listId).FirstOrDefault()!;
            mainList.brothPrep = _context.brothPrep.Where(brothPrep => brothPrep.listId == listId).FirstOrDefault()!;
            mainList.finalPrep = _context.finalPrep.Where(finalPrep => finalPrep.listId == listId).FirstOrDefault()!;
            mainList.prepProteins = _context.prepProteins.Where(prepProteins => prepProteins.listId == listId).FirstOrDefault()!;
            mainList.prepSauces = _context.prepSauces.Where(prepSauces => prepSauces.listId == listId).FirstOrDefault()!;
            mainList.saladPrep = _context.saladPrep.Where(saladPrep => saladPrep.listId == listId).FirstOrDefault()!;
            mainList.stirFryVeg = _context.stirFryVeg.Where(stirFryVeg => stirFryVeg.listId == listId).FirstOrDefault()!;
            mainList.toppingsPrep = _context.toppingsPrep.Where(toppingsPrep => toppingsPrep.listId == listId).FirstOrDefault()!;
            mainList.comment = _context.comment.Where(list => list.id == mainList.commentId).FirstOrDefault()!;
            mainList.signature = _context.signature.Where(list => list.id == mainList.signatureId).FirstOrDefault()!;

            return Ok(mainList);
        }

        [HttpPost]
        [Route(nameof(Create))]
        public async Task<IActionResult> Create([FromBody] KitchenCheckList list) {
       
            _context.Add(list);
            await _context.SaveChangesAsync();         
            return Ok(list);
        }


       
        


    }
}
