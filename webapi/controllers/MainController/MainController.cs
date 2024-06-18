using Microsoft.AspNetCore.Mvc;
using webapi.models;
using webapi.datacontext;
using webapi.models.kitchen;

namespace webap.controllers
{

    [ApiController]
    [Route("api/controller")]
    public class MainController : Controller
    {
        // GET: MainController

        private DataContext _context;
        public MainController(DataContext context) {
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
            List<MainList> mainLists = new List<MainList>();
            List<MainList> lists = _context.mainList.OrderByDescending(list => list.date).ToList();
            foreach (MainList mainList in lists)
            {
                Guid mainListId = mainList.id; 

                mainList.aromatics = _context.aromatics.Where(aromatic => aromatic.mainListId == mainListId).FirstOrDefault()!;
                mainList.arrivalBasics = _context.arrivalBasics.Where(arrivalBasic => arrivalBasic.mainListId == mainListId).FirstOrDefault()!;
                mainList.brothPrep = _context.brothPrep.Where(brothPrep => brothPrep.mainListId == mainListId).FirstOrDefault()!;
                mainList.finalPrep = _context.finalPrep.Where(finalPrep => finalPrep.mainListId == mainListId).FirstOrDefault()!;
                mainList.prepProteins = _context.prepProteins.Where(prepProteins => prepProteins.mainListId == mainListId).FirstOrDefault()!;
                mainList.prepSauces = _context.prepSauces.Where(prepSauces => prepSauces.mainListId == mainListId).FirstOrDefault()!;
                mainList.saladPrep = _context.saladPrep.Where(saladPrep => saladPrep.mainListId == mainListId).FirstOrDefault()!;
                mainList.stirFryVeg = _context.stirFryVeg.Where(stirFryVeg => stirFryVeg.mainListId == mainListId).FirstOrDefault()!;
                mainList.toppingsPrep = _context.toppingsPrep.Where(toppingsPrep => toppingsPrep.mainListId == mainListId).FirstOrDefault()!;
                mainList.aromaticsServer = _context.aromaticsServer.Where(aromaticServer => aromaticServer.mainListId == mainListId).FirstOrDefault()!;
                mainList.cleanRestaurantServer = _context.cleanRestaurantServer.Where(cleanRestaurantServer => cleanRestaurantServer.mainListId == mainListId).FirstOrDefault()!;
                mainList.finalPrepServer = _context.finalPrepServer.Where(finalPrepServer => finalPrepServer.mainListId == mainListId).FirstOrDefault()!;
                mainList.prepSaucesServer = _context.prepSaucesServer.Where(prepSaucesServer => prepSaucesServer.mainListId == mainListId).FirstOrDefault()!;
                mainList.saladPrepServer = _context.saladPrepServer.Where(saladPrepServer => saladPrepServer.mainListId == mainListId).FirstOrDefault()!;
                mainList.cashierChecklist = _context.cashierChecklist.Where(cashierChecklist => cashierChecklist.mainListId == mainListId).FirstOrDefault()!;
                mainList.stockOpeningCheckList = _context.stockOpeningCheckList.Where(stockOpeningCheckList => stockOpeningCheckList.mainListId == mainListId).FirstOrDefault()!;
                mainList.signature = _context.signature.Where(signature => signature.mainListId == mainListId).FirstOrDefault()!;

                mainLists.Add(mainList);
            }

            return Ok(mainLists);
        }

        
        [HttpGet]
        [Route(nameof(GetListById))]
        public async Task<IActionResult> GetListById(Guid id) {
            MainList mainList = _context.mainList.Where(mainlist => mainlist.id == id).FirstOrDefault()!;
            
            if (mainList == null) return NotFound();

            Guid mainListId = mainList.id; 

            mainList.aromatics = _context.aromatics.Where(aromatic => aromatic.mainListId == mainListId).FirstOrDefault()!;
            mainList.arrivalBasics = _context.arrivalBasics.Where(arrivalBasic => arrivalBasic.mainListId == mainListId).FirstOrDefault()!;
            mainList.brothPrep = _context.brothPrep.Where(brothPrep => brothPrep.mainListId == mainListId).FirstOrDefault()!;
            mainList.finalPrep = _context.finalPrep.Where(finalPrep => finalPrep.mainListId == mainListId).FirstOrDefault()!;
            mainList.prepProteins = _context.prepProteins.Where(prepProteins => prepProteins.mainListId == mainListId).FirstOrDefault()!;
            mainList.prepSauces = _context.prepSauces.Where(prepSauces => prepSauces.mainListId == mainListId).FirstOrDefault()!;
            mainList.saladPrep = _context.saladPrep.Where(saladPrep => saladPrep.mainListId == mainListId).FirstOrDefault()!;
            mainList.stirFryVeg = _context.stirFryVeg.Where(stirFryVeg => stirFryVeg.mainListId == mainListId).FirstOrDefault()!;
            mainList.toppingsPrep = _context.toppingsPrep.Where(toppingsPrep => toppingsPrep.mainListId == mainListId).FirstOrDefault()!;
            mainList.aromaticsServer = _context.aromaticsServer.Where(aromaticsServer => aromaticsServer.mainListId == mainListId).FirstOrDefault()!;
            mainList.cleanRestaurantServer = _context.cleanRestaurantServer.Where(cleanRestaurantServer => cleanRestaurantServer.mainListId == mainListId).FirstOrDefault()!;
            mainList.finalPrepServer = _context.finalPrepServer.Where(finalPrepServer => finalPrepServer.mainListId == mainListId).FirstOrDefault()!;
            mainList.prepSaucesServer = _context.prepSaucesServer.Where(prepSaucesServer => prepSaucesServer.mainListId == mainListId).FirstOrDefault()!;
            mainList.saladPrepServer = _context.saladPrepServer.Where(saladPrepServer => saladPrepServer.mainListId == mainListId).FirstOrDefault()!;
            mainList.cashierChecklist = _context.cashierChecklist.Where(cashierChecklist => cashierChecklist.mainListId == mainListId).FirstOrDefault()!;
            mainList.stockOpeningCheckList = _context.stockOpeningCheckList.Where(stockOpeningCheckList => stockOpeningCheckList.mainListId == mainListId).FirstOrDefault()!;
            mainList.signature = _context.signature.Where(signature => signature.mainListId == mainListId).FirstOrDefault()!;

            return Ok(mainList);
        }

        [HttpPost]
        [Route(nameof(Create))]
        public async Task<IActionResult> Create([FromBody] MainList list) {
       
            _context.Add(list);
            await _context.SaveChangesAsync();            
            return Ok(list);
        }

    }
}
