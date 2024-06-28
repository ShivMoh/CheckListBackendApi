using Microsoft.AspNetCore.Mvc;
using webapi.models;
using webapi.datacontext;
using webapi.models.kitchen;
using webapi.models.form;

namespace webap.controllers
{

    public class ServiceListController : MainController
    {

        private readonly DataContext _context;
        public ServiceListController(DataContext context) {
            _context = context;
        }

        [HttpPost]
        [Route(nameof(GetAllLists))]

        public async Task<IActionResult> GetAllLists() {
            List<ServiceCheckList> mainLists = new List<ServiceCheckList>();
            List<ServiceCheckList> lists = _context.serviceCheckList.OrderByDescending(list => list.date).ToList();
            foreach (ServiceCheckList mainList in lists)
            {
                Guid listId = mainList.id; 
                mainList.aromaticsServer = _context.aromaticsServer.Where(aromaticServer => aromaticServer.listId == listId).FirstOrDefault()!;
                mainList.cleanRestaurantServer = _context.cleanRestaurantServer.Where(cleanRestaurantServer => cleanRestaurantServer.listId == listId).FirstOrDefault()!;
                mainList.finalPrepServer = _context.finalPrepServer.Where(finalPrepServer => finalPrepServer.listId == listId).FirstOrDefault()!;
                mainList.prepSaucesServer = _context.prepSaucesServer.Where(prepSaucesServer => prepSaucesServer.listId == listId).FirstOrDefault()!;
                mainList.saladPrepServer = _context.saladPrepServer.Where(saladPrepServer => saladPrepServer.listId == listId).FirstOrDefault()!;
                mainList.signature = _context.signature.Where(signature => signature.id == mainList.signatureId).FirstOrDefault()!;
                mainList.comment = _context.comment.Where(comment => comment.id == mainList.commentId).FirstOrDefault()!;

                mainLists.Add(mainList);
            }

            return Ok(mainLists);
        }

        
        [HttpGet]
        [Route(nameof(GetListById))]
        public async Task<IActionResult> GetListById(Guid id) {
            ServiceCheckList mainList = _context.serviceCheckList.Where(mainlist => mainlist.id == id).FirstOrDefault()!;
            
            if (mainList == null) return NotFound();

            Guid listId = mainList.id; 

            mainList.aromaticsServer = _context.aromaticsServer.Where(aromaticsServer => aromaticsServer.listId == listId).FirstOrDefault()!;
            mainList.cleanRestaurantServer = _context.cleanRestaurantServer.Where(cleanRestaurantServer => cleanRestaurantServer.listId == listId).FirstOrDefault()!;
            mainList.finalPrepServer = _context.finalPrepServer.Where(finalPrepServer => finalPrepServer.listId == listId).FirstOrDefault()!;
            mainList.prepSaucesServer = _context.prepSaucesServer.Where(prepSaucesServer => prepSaucesServer.listId == listId).FirstOrDefault()!;
            mainList.saladPrepServer = _context.saladPrepServer.Where(saladPrepServer => saladPrepServer.listId == listId).FirstOrDefault()!;
            mainList.signature = _context.signature.Where(signature => signature.id == mainList.signatureId).FirstOrDefault()!;
            mainList.comment = _context.comment.Where(comment => comment.id == mainList.commentId).FirstOrDefault()!;

            return Ok(mainList);
        }

        [HttpPost]
        [Route(nameof(Create))]
        public async Task<IActionResult> Create([FromBody] ServiceCheckList list) {
       
            _context.Add(list);
            await _context.SaveChangesAsync();            
            return Ok(list);
        }

    }
}
