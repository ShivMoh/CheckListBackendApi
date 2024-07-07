using Microsoft.AspNetCore.Mvc;
using webapi.models;
using webapi.datacontext;
using webapi.models.kitchen;
using webapi.models.form;
using MapsterMapper;
using webapi.models.dto;
using webapi.models.service;

namespace webap.controllers
{

    public class ServiceListController : MainController
    {

        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public ServiceListController(DataContext context, IMapper mapper) {
            _context = context;
            _mapper = mapper;

        }

        [HttpPost]
        [Route(nameof(GetAllLists))]

        public async Task<IActionResult> GetAllLists() {
            List<ServiceCheckList> mainLists = new List<ServiceCheckList>();
            List<ServiceCheckList> lists = _context.serviceCheckList.Where(list => list.submitted == true).OrderByDescending(list => list.endDate).ToList();
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

        // [HttpPost]
        // [Route(nameof(Create))]
        // public async Task<IActionResult> Create([FromBody] ServiceCheckList list) {
       
        //     _context.Add(list);
        //     await _context.SaveChangesAsync();            
        //     return Ok(list);
        // }
           [HttpGet]
        [Route(nameof(CreateBlank))]
        public async Task<IActionResult> CreateBlank() {
            ServiceCheckList serviceCheckList = new ServiceCheckList();
            serviceCheckList.startDate = DateTime.Now;
            serviceCheckList.submitted = false;
            _context.Add(serviceCheckList);
            await _context.SaveChangesAsync();         
            return Ok(serviceCheckList);
        }

        [HttpPost]
        [Route(nameof(SubmitForm))]
        public async Task<IActionResult> SubmitForm([FromBody] ServiceCheckListDto list) {
            ServiceCheckList serviceCheckList = _context.serviceCheckList.Where(serviceCheckList => serviceCheckList.id == list.id).FirstOrDefault()!;

            AromaticsServer aromaticsServer = _context.aromaticsServer.Where(aromaticsServer => aromaticsServer.listId == list.id).FirstOrDefault()!;
            CleanRestaurantServer cleanRestaurantServer = _context.cleanRestaurantServer.Where(cleanRestaurantServer => cleanRestaurantServer.listId == list.id).FirstOrDefault()!;
            FinalPrepServer finalPrepServer = _context.finalPrepServer.Where(finalPrepServer => finalPrepServer.listId == list.id).FirstOrDefault()!;
            PrepSaucesServer prepSaucesServer = _context.prepSaucesServer.Where(prepSaucesServer => prepSaucesServer.listId == list.id).FirstOrDefault()!;
            SaladPrepServer saladPrepServer = _context.saladPrepServer.Where(saladPrepServer => saladPrepServer.listId == list.id).FirstOrDefault()!;
            Signature signature = _context.signature.Where(aromatic => aromatic.id == serviceCheckList.signatureId).FirstOrDefault()!;
            Comment comment = _context.comment.Where(aromatic => aromatic.id == serviceCheckList.commentId).FirstOrDefault()!;

            aromaticsServer = _mapper.Map<AromaticsServer>(list.aromaticsServer);
            cleanRestaurantServer = _mapper.Map<CleanRestaurantServer>(list.cleanRestaurantServer);
            finalPrepServer = _mapper.Map<FinalPrepServer>(list.finalPrepServer);
            prepSaucesServer = _mapper.Map<PrepSaucesServer>(list.prepSaucesServer);
            saladPrepServer = _mapper.Map<SaladPrepServer>(list.saladPrepServer);
            
            signature.name = list.signature.name;
            comment.comment = list.comment.comment;
          
            aromaticsServer.listId = list.id; 
            aromaticsServer.fileContainer = _context.fileContainerType.Where(container => container.id == aromaticsServer.fileContainerTypeId).FirstOrDefault()!;

            cleanRestaurantServer.listId = list.id;             
            cleanRestaurantServer.fileContainer = _context.fileContainerType.Where(container => container.id == cleanRestaurantServer.fileContainerTypeId).FirstOrDefault()!;

            finalPrepServer.listId = list.id; 
            finalPrepServer.fileContainer = _context.fileContainerType.Where(container => container.id == finalPrepServer.fileContainerTypeId).FirstOrDefault()!;

            prepSaucesServer.listId = list.id; 
            prepSaucesServer.fileContainer = _context.fileContainerType.Where(container => container.id == prepSaucesServer.fileContainerTypeId).FirstOrDefault()!;

            saladPrepServer.listId = list.id;
            saladPrepServer.fileContainer = _context.fileContainerType.Where(container => container.id == saladPrepServer.fileContainerTypeId).FirstOrDefault()!;

            serviceCheckList.endDate = DateTime.Now;
            serviceCheckList.submitted = true;

         
            _context.aromaticsServer.Update(aromaticsServer);
            _context.cleanRestaurantServer.Update(cleanRestaurantServer);
            _context.finalPrepServer.Update(finalPrepServer);
            _context.prepSaucesServer.Update(prepSaucesServer);
            _context.saladPrepServer.Update(saladPrepServer);
            _context.signature.Update(signature);
            _context.comment.Update(comment);
            _context.Update(serviceCheckList);

            await _context.SaveChangesAsync();

            return Ok(serviceCheckList);
        } 

        [HttpPost]
        [Route(nameof(SaveCurrentState))]
        public async Task<IActionResult> SaveCurrentState([FromBody] ServiceCheckListDto list) {
            ServiceCheckList serviceCheckList = _context.serviceCheckList.Where(serviceCheckList => serviceCheckList.id == list.id).FirstOrDefault()!;

            AromaticsServer aromaticsServer = _context.aromaticsServer.Where(aromaticsServer => aromaticsServer.listId == list.id).FirstOrDefault()!;
            CleanRestaurantServer cleanRestaurantServer = _context.cleanRestaurantServer.Where(cleanRestaurantServer => cleanRestaurantServer.listId == list.id).FirstOrDefault()!;
            FinalPrepServer finalPrepServer = _context.finalPrepServer.Where(finalPrepServer => finalPrepServer.listId == list.id).FirstOrDefault()!;
            PrepSaucesServer prepSaucesServer = _context.prepSaucesServer.Where(prepSaucesServer => prepSaucesServer.listId == list.id).FirstOrDefault()!;
            SaladPrepServer saladPrepServer = _context.saladPrepServer.Where(saladPrepServer => saladPrepServer.listId == list.id).FirstOrDefault()!;
            Signature signature = _context.signature.Where(aromatic => aromatic.id == serviceCheckList.signatureId).FirstOrDefault()!;
            Comment comment = _context.comment.Where(aromatic => aromatic.id == serviceCheckList.commentId).FirstOrDefault()!;

            aromaticsServer = _mapper.Map<AromaticsServer>(list.aromaticsServer);
            cleanRestaurantServer = _mapper.Map<CleanRestaurantServer>(list.cleanRestaurantServer);
            finalPrepServer = _mapper.Map<FinalPrepServer>(list.finalPrepServer);
            prepSaucesServer = _mapper.Map<PrepSaucesServer>(list.prepSaucesServer);
            saladPrepServer = _mapper.Map<SaladPrepServer>(list.saladPrepServer);
            
            signature.name = list.signature.name;
            comment.comment = list.comment.comment;
          
            
            signature.name = list.signature.name;
            comment.comment = list.comment.comment;
          
            aromaticsServer.listId = list.id; 
            aromaticsServer.fileContainer = _context.fileContainerType.Where(container => container.id == aromaticsServer.fileContainerTypeId).FirstOrDefault()!;

            cleanRestaurantServer.listId = list.id;             
            cleanRestaurantServer.fileContainer = _context.fileContainerType.Where(container => container.id == cleanRestaurantServer.fileContainerTypeId).FirstOrDefault()!;

            finalPrepServer.listId = list.id; 
            finalPrepServer.fileContainer = _context.fileContainerType.Where(container => container.id == finalPrepServer.fileContainerTypeId).FirstOrDefault()!;

            prepSaucesServer.listId = list.id; 
            prepSaucesServer.fileContainer = _context.fileContainerType.Where(container => container.id == prepSaucesServer.fileContainerTypeId).FirstOrDefault()!;

            saladPrepServer.listId = list.id;
            saladPrepServer.fileContainer = _context.fileContainerType.Where(container => container.id == saladPrepServer.fileContainerTypeId).FirstOrDefault()!;

            _context.aromaticsServer.Update(aromaticsServer);
            _context.cleanRestaurantServer.Update(cleanRestaurantServer);
            _context.finalPrepServer.Update(finalPrepServer);
            _context.prepSaucesServer.Update(prepSaucesServer);
            _context.saladPrepServer.Update(saladPrepServer);
            _context.signature.Update(signature);

            _context.comment.Update(comment);
            _context.Update(serviceCheckList);

            await _context.SaveChangesAsync();

            return Ok(serviceCheckList);
        } 

        [HttpGet]
        [Route(nameof(GetUnsubmittedForm))]
        public async Task<IActionResult> GetUnsubmittedForm(Guid id) {
            ServiceCheckList mainList = _context.serviceCheckList.Where(mainlist => mainlist.submitted == false).FirstOrDefault()!;
            
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

        [HttpGet]
        [Route(nameof(CheckIfBlankFormExists))]
        public async Task<IActionResult> CheckIfBlankFormExists() {
            if (_context.serviceCheckList.Count() == 0) return Ok(false);
            if (_context.serviceCheckList.Any(list => list.submitted == false)) {
                return Ok(true);
            }
            return Ok(false);
        } 

    }
}
