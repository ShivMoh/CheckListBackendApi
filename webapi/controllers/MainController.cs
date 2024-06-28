using Microsoft.AspNetCore.Mvc;
using webapi.models;
using webapi.datacontext;
using webapi.models.kitchen;

namespace webap.controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class MainController : ControllerBase
    {
        // GET: MainController

        // private DataContext _context;
        // public MainController(DataContext context) {
        //     _context = context;
        // }

        // [HttpGet]
        // public ActionResult Index()
        // {
        //     return Ok("this is working now");
        // }

        // [HttpPost]
        // [Route(nameof(GetAllLists))]

        // public async Task<IActionResult> GetAllLists() {
        //     List<MainList> mainLists = new List<MainList>();
        //     List<MainList> lists = _context.mainList.OrderByDescending(list => list.date).ToList();
        //     foreach (MainList mainList in lists)
        //     {
        //         Guid listId = mainList.id; 

        //         mainList.aromatics = _context.aromatics.Where(aromatic => aromatic.listId == listId).FirstOrDefault()!;
        //         mainList.arrivalBasics = _context.arrivalBasics.Where(arrivalBasic => arrivalBasic.listId == listId).FirstOrDefault()!;
        //         mainList.brothPrep = _context.brothPrep.Where(brothPrep => brothPrep.listId == listId).FirstOrDefault()!;
        //         mainList.finalPrep = _context.finalPrep.Where(finalPrep => finalPrep.listId == listId).FirstOrDefault()!;
        //         mainList.prepProteins = _context.prepProteins.Where(prepProteins => prepProteins.listId == listId).FirstOrDefault()!;
        //         mainList.prepSauces = _context.prepSauces.Where(prepSauces => prepSauces.listId == listId).FirstOrDefault()!;
        //         mainList.saladPrep = _context.saladPrep.Where(saladPrep => saladPrep.listId == listId).FirstOrDefault()!;
        //         mainList.stirFryVeg = _context.stirFryVeg.Where(stirFryVeg => stirFryVeg.listId == listId).FirstOrDefault()!;
        //         mainList.toppingsPrep = _context.toppingsPrep.Where(toppingsPrep => toppingsPrep.listId == listId).FirstOrDefault()!;
        //         mainList.aromaticsServer = _context.aromaticsServer.Where(aromaticServer => aromaticServer.listId == listId).FirstOrDefault()!;
        //         mainList.cleanRestaurantServer = _context.cleanRestaurantServer.Where(cleanRestaurantServer => cleanRestaurantServer.listId == listId).FirstOrDefault()!;
        //         mainList.finalPrepServer = _context.finalPrepServer.Where(finalPrepServer => finalPrepServer.listId == listId).FirstOrDefault()!;
        //         mainList.prepSaucesServer = _context.prepSaucesServer.Where(prepSaucesServer => prepSaucesServer.listId == listId).FirstOrDefault()!;
        //         mainList.saladPrepServer = _context.saladPrepServer.Where(saladPrepServer => saladPrepServer.listId == listId).FirstOrDefault()!;
        //         mainList.cashierChecklist = _context.cashierChecklist.Where(cashierChecklist => cashierChecklist.listId == listId).FirstOrDefault()!;
        //         mainList.stockOpeningCheckList = _context.stockOpeningCheckList.Where(stockOpeningCheckList => stockOpeningCheckList.listId == listId).FirstOrDefault()!;
        //         mainList.signature = _context.signature.Where(signature => signature.listId == listId).FirstOrDefault()!;
        //         mainList.comment = _context.comment.Where(comment => comment.listId == listId).FirstOrDefault()!;

        //         mainLists.Add(mainList);
        //     }

        //     return Ok(mainLists);
        // }

        
        // [HttpGet]
        // [Route(nameof(GetListById))]
        // public async Task<IActionResult> GetListById(Guid id) {
        //     MainList mainList = _context.mainList.Where(mainlist => mainlist.id == id).FirstOrDefault()!;
            
        //     if (mainList == null) return NotFound();

        //     Guid listId = mainList.id; 

        //     mainList.aromatics = _context.aromatics.Where(aromatic => aromatic.listId == listId).FirstOrDefault()!;
        //     mainList.arrivalBasics = _context.arrivalBasics.Where(arrivalBasic => arrivalBasic.listId == listId).FirstOrDefault()!;
        //     mainList.brothPrep = _context.brothPrep.Where(brothPrep => brothPrep.listId == listId).FirstOrDefault()!;
        //     mainList.finalPrep = _context.finalPrep.Where(finalPrep => finalPrep.listId == listId).FirstOrDefault()!;
        //     mainList.prepProteins = _context.prepProteins.Where(prepProteins => prepProteins.listId == listId).FirstOrDefault()!;
        //     mainList.prepSauces = _context.prepSauces.Where(prepSauces => prepSauces.listId == listId).FirstOrDefault()!;
        //     mainList.saladPrep = _context.saladPrep.Where(saladPrep => saladPrep.listId == listId).FirstOrDefault()!;
        //     mainList.stirFryVeg = _context.stirFryVeg.Where(stirFryVeg => stirFryVeg.listId == listId).FirstOrDefault()!;
        //     mainList.toppingsPrep = _context.toppingsPrep.Where(toppingsPrep => toppingsPrep.listId == listId).FirstOrDefault()!;
        //     mainList.aromaticsServer = _context.aromaticsServer.Where(aromaticsServer => aromaticsServer.listId == listId).FirstOrDefault()!;
        //     mainList.cleanRestaurantServer = _context.cleanRestaurantServer.Where(cleanRestaurantServer => cleanRestaurantServer.listId == listId).FirstOrDefault()!;
        //     mainList.finalPrepServer = _context.finalPrepServer.Where(finalPrepServer => finalPrepServer.listId == listId).FirstOrDefault()!;
        //     mainList.prepSaucesServer = _context.prepSaucesServer.Where(prepSaucesServer => prepSaucesServer.listId == listId).FirstOrDefault()!;
        //     mainList.saladPrepServer = _context.saladPrepServer.Where(saladPrepServer => saladPrepServer.listId == listId).FirstOrDefault()!;
        //     mainList.cashierChecklist = _context.cashierChecklist.Where(cashierChecklist => cashierChecklist.listId == listId).FirstOrDefault()!;
        //     mainList.stockOpeningCheckList = _context.stockOpeningCheckList.Where(stockOpeningCheckList => stockOpeningCheckList.listId == listId).FirstOrDefault()!;
        //     mainList.signature = _context.signature.Where(signature => signature.listId == listId).FirstOrDefault()!;
        //     mainList.comment = _context.comment.Where(comment => comment.listId == listId).FirstOrDefault()!;

        //     return Ok(mainList);
        // }

        // [HttpPost]
        // [Route(nameof(Create))]
        // public async Task<IActionResult> Create([FromBody] MainList list) {
       
        //     _context.Add(list);
        //     await _context.SaveChangesAsync();            
        //     return Ok(list);
        // }

    }
}
