using Microsoft.AspNetCore.Mvc;
using webapi.models;
using webapi.datacontext;
using webapi.models.kitchen;
using webapi.models.form;
using webapi.models.types;
using webapi.models.dto;
using Mapster;
using MapsterMapper;

namespace webap.controllers
{

  
    public class KitchenListController : MainController
    {

        private DataContext _context;

        private readonly IMapper _mapper;
        public KitchenListController(DataContext context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
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
            List<KitchenCheckList> lists = _context.kitchenCheckList.OrderByDescending(list => list.endDate).ToList();
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
            KitchenCheckList mainList = _context.kitchenCheckList.Where(list => list.id == id ).FirstOrDefault()!;
            
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
        public async Task<IActionResult> Create([FromBody] KitchenCheckListDto list) {
            KitchenCheckList kitchenCheckList = _mapper.Map<KitchenCheckList>(list);
            _context.Add(kitchenCheckList);
            await _context.SaveChangesAsync();         
            return Ok(kitchenCheckList);
        }

        [HttpGet]
        [Route(nameof(CreateBlank))]
        public async Task<IActionResult> CreateBlank() {
            KitchenCheckList kitchenCheckList = new KitchenCheckList();
            kitchenCheckList.startDate = DateTime.UtcNow;
            kitchenCheckList.submitted = false;
            _context.Add(kitchenCheckList);
            await _context.SaveChangesAsync();         
            return Ok(kitchenCheckList);
        }

        [HttpPost]
        [Route(nameof(SubmitForm))]
        public async Task<IActionResult> SubmitForm([FromBody] KitchenCheckListDto list) {
            KitchenCheckList kitchenCheckList = _context.kitchenCheckList.Where(kitchenList => kitchenList.id == list.id).FirstOrDefault()!;
            Aromatics aromatics = _context.aromatics.Where(aromatic => aromatic.listId == list.id).FirstOrDefault()!;
            BrothPrep brothPrep = _context.brothPrep.Where(aromatic => aromatic.listId == list.id).FirstOrDefault()!;
            ArrivalBasics arrivalBasics = _context.arrivalBasics.Where(aromatic => aromatic.listId == list.id).FirstOrDefault()!;
            FinalPrep finalPrep = _context.finalPrep.Where(aromatic => aromatic.listId == list.id).FirstOrDefault()!;
            ToppingsPrep toppingsPrep = _context.toppingsPrep.Where(aromatic => aromatic.listId == list.id).FirstOrDefault()!;
            PrepProteins prepProteins = _context.prepProteins.Where(aromatic => aromatic.listId == list.id).FirstOrDefault()!;
            StirFryVeg stirFryVeg = _context.stirFryVeg.Where(aromatic => aromatic.listId == list.id).FirstOrDefault()!;
            SaladPrep saladPrep = _context.saladPrep.Where(aromatic => aromatic.listId == list.id).FirstOrDefault()!;
            PrepSauces prepSauces = _context.prepSauces.Where(aromatic => aromatic.listId == list.id).FirstOrDefault()!;

            Signature signature = _context.signature.Where(aromatic => aromatic.id == kitchenCheckList.signatureId).FirstOrDefault()!;
            Comment comment = _context.comment.Where(aromatic => aromatic.id == kitchenCheckList.commentId).FirstOrDefault()!;

            aromatics = _mapper.Map<Aromatics>(list.aromatics);
            arrivalBasics = _mapper.Map<ArrivalBasics>(list.arrivalBasics);
            brothPrep = _mapper.Map<BrothPrep>(list.brothPrep);
            finalPrep =  _mapper.Map<FinalPrep>(list.finalPrep);
            toppingsPrep = _mapper.Map<ToppingsPrep>(list.toppingsPrep);
            prepProteins = _mapper.Map<PrepProteins>(list.prepProteins);
            saladPrep = _mapper.Map<SaladPrep>(list.saladPrep);
            stirFryVeg = _mapper.Map<StirFryVeg>(list.stirFryVeg);
            prepSauces = _mapper.Map<PrepSauces>(list.prepSauces);

            signature.name = list.signature.name;
            comment.comment = list.comment.comment;
          
            aromatics.listId = list.id; 
            aromatics.fileContainer = _context.fileContainerType.Where(container => container.id == aromatics.fileContainerTypeId).FirstOrDefault()!;

            arrivalBasics.listId = list.id;             
            arrivalBasics.fileContainer = _context.fileContainerType.Where(container => container.id == arrivalBasics.fileContainerTypeId).FirstOrDefault()!;

            brothPrep.listId = list.id; 
            brothPrep.fileContainer = _context.fileContainerType.Where(container => container.id == brothPrep.fileContainerTypeId).FirstOrDefault()!;

            finalPrep.listId = list.id; 
            finalPrep.fileContainer = _context.fileContainerType.Where(container => container.id == finalPrep.fileContainerTypeId).FirstOrDefault()!;

            toppingsPrep.listId = list.id;
            toppingsPrep.fileContainer = _context.fileContainerType.Where(container => container.id == toppingsPrep.fileContainerTypeId).FirstOrDefault()!;

            prepProteins.listId = list.id; 
            prepProteins.fileContainer = _context.fileContainerType.Where(container => container.id == toppingsPrep.fileContainerTypeId).FirstOrDefault()!;

            saladPrep.listId = list.id; 
            saladPrep.fileContainer = _context.fileContainerType.Where(container => container.id == saladPrep.fileContainerTypeId).FirstOrDefault()!;

            stirFryVeg.listId = list.id; 
            stirFryVeg.fileContainer = _context.fileContainerType.Where(container => container.id == stirFryVeg.fileContainerTypeId).FirstOrDefault()!;

            prepSauces.listId = list.id;
            prepSauces.fileContainer = _context.fileContainerType.Where(container => container.id == prepSauces.fileContainerTypeId).FirstOrDefault()!;

            kitchenCheckList.endDate = DateTime.UtcNow;
            kitchenCheckList.submitted = true;

         
            _context.aromatics.Update(aromatics);
            _context.arrivalBasics.Update(arrivalBasics);
            _context.brothPrep.Update(brothPrep);
            _context.finalPrep.Update(finalPrep);
            _context.toppingsPrep.Update(toppingsPrep);
            _context.prepProteins.Update(prepProteins);
            _context.saladPrep.Update(saladPrep);
            _context.stirFryVeg.Update(stirFryVeg);
            _context.prepSauces.Update(prepSauces);
            _context.signature.Update(signature);
            _context.comment.Update(comment);
            _context.Update(kitchenCheckList);

            await _context.SaveChangesAsync();

            return Ok(kitchenCheckList);
        } 

        [HttpPost]
        [Route(nameof(SaveCurrentState))]
        public async Task<IActionResult> SaveCurrentState([FromBody] KitchenCheckListDto list) {
            KitchenCheckList kitchenCheckList = _context.kitchenCheckList.Where(kitchenList => kitchenList.id == list.id).FirstOrDefault()!;
            Aromatics aromatics = _context.aromatics.Where(aromatic => aromatic.listId == list.id).FirstOrDefault()!;
            BrothPrep brothPrep = _context.brothPrep.Where(aromatic => aromatic.listId == list.id).FirstOrDefault()!;
            ArrivalBasics arrivalBasics = _context.arrivalBasics.Where(aromatic => aromatic.listId == list.id).FirstOrDefault()!;
            FinalPrep finalPrep = _context.finalPrep.Where(aromatic => aromatic.listId == list.id).FirstOrDefault()!;
            ToppingsPrep toppingsPrep = _context.toppingsPrep.Where(aromatic => aromatic.listId == list.id).FirstOrDefault()!;
            PrepProteins prepProteins = _context.prepProteins.Where(aromatic => aromatic.listId == list.id).FirstOrDefault()!;
            StirFryVeg stirFryVeg = _context.stirFryVeg.Where(aromatic => aromatic.listId == list.id).FirstOrDefault()!;
            SaladPrep saladPrep = _context.saladPrep.Where(aromatic => aromatic.listId == list.id).FirstOrDefault()!;
            PrepSauces prepSauces = _context.prepSauces.Where(aromatic => aromatic.listId == list.id).FirstOrDefault()!;

            Signature signature = _context.signature.Where(aromatic => aromatic.id == kitchenCheckList.signatureId).FirstOrDefault()!;
            Comment comment = _context.comment.Where(aromatic => aromatic.id == kitchenCheckList.commentId).FirstOrDefault()!;

            aromatics = _mapper.Map<Aromatics>(list.aromatics);
            arrivalBasics = _mapper.Map<ArrivalBasics>(list.arrivalBasics);
            brothPrep = _mapper.Map<BrothPrep>(list.brothPrep);
            finalPrep =  _mapper.Map<FinalPrep>(list.finalPrep);
            toppingsPrep = _mapper.Map<ToppingsPrep>(list.toppingsPrep);
            prepProteins = _mapper.Map<PrepProteins>(list.prepProteins);
            saladPrep = _mapper.Map<SaladPrep>(list.saladPrep);
            stirFryVeg = _mapper.Map<StirFryVeg>(list.stirFryVeg);
            prepSauces = _mapper.Map<PrepSauces>(list.prepSauces);

            signature.name = list.signature.name;
            comment.comment = list.comment.comment;
          
             aromatics.listId = list.id; 
            aromatics.fileContainer = _context.fileContainerType.Where(container => container.id == aromatics.fileContainerTypeId).FirstOrDefault()!;

            arrivalBasics.listId = list.id;             
            arrivalBasics.fileContainer = _context.fileContainerType.Where(container => container.id == arrivalBasics.fileContainerTypeId).FirstOrDefault()!;

            brothPrep.listId = list.id; 
            brothPrep.fileContainer = _context.fileContainerType.Where(container => container.id == brothPrep.fileContainerTypeId).FirstOrDefault()!;

            finalPrep.listId = list.id; 
            finalPrep.fileContainer = _context.fileContainerType.Where(container => container.id == finalPrep.fileContainerTypeId).FirstOrDefault()!;

            toppingsPrep.listId = list.id;
            toppingsPrep.fileContainer = _context.fileContainerType.Where(container => container.id == toppingsPrep.fileContainerTypeId).FirstOrDefault()!;

            prepProteins.listId = list.id; 
            prepProteins.fileContainer = _context.fileContainerType.Where(container => container.id == toppingsPrep.fileContainerTypeId).FirstOrDefault()!;

            saladPrep.listId = list.id; 
            saladPrep.fileContainer = _context.fileContainerType.Where(container => container.id == saladPrep.fileContainerTypeId).FirstOrDefault()!;

            stirFryVeg.listId = list.id; 
            stirFryVeg.fileContainer = _context.fileContainerType.Where(container => container.id == stirFryVeg.fileContainerTypeId).FirstOrDefault()!;

            prepSauces.listId = list.id;
            prepSauces.fileContainer = _context.fileContainerType.Where(container => container.id == prepSauces.fileContainerTypeId).FirstOrDefault()!;

            _context.aromatics.Update(aromatics);
            _context.arrivalBasics.Update(arrivalBasics);
            _context.brothPrep.Update(brothPrep);
            _context.finalPrep.Update(finalPrep);
            _context.toppingsPrep.Update(toppingsPrep);
            _context.prepProteins.Update(prepProteins);
            _context.saladPrep.Update(saladPrep);
            _context.stirFryVeg.Update(stirFryVeg);
            _context.prepSauces.Update(prepSauces);

            _context.signature.Update(signature);
            _context.comment.Update(comment);

            await _context.SaveChangesAsync();

            return Ok(kitchenCheckList);
        } 


        [HttpGet]
        [Route(nameof(CheckIfBlankFormExists))]
        public async Task<IActionResult> CheckIfBlankFormExists() {
            if (_context.kitchenCheckList.Count() == 0) return Ok(false);
            if (_context.kitchenCheckList.Any(list => list.submitted == false)) {
                return Ok(true);
            }
            return Ok(false);
        } 

        [HttpGet]
        [Route(nameof(GetUnsubmittedForm))]
        public async Task<IActionResult> GetUnsubmittedForm() {
            KitchenCheckList mainList = _context.kitchenCheckList.Where(list => list.submitted == false).FirstOrDefault()!;
            if (mainList == null) return NotFound();
            mainList.aromatics = _context.aromatics.Where(aromatic => aromatic.listId == mainList.id).FirstOrDefault()!;
            mainList.arrivalBasics = _context.arrivalBasics.Where(arrivalBasic => arrivalBasic.listId == mainList.id).FirstOrDefault()!;
            mainList.brothPrep = _context.brothPrep.Where(brothPrep => brothPrep.listId == mainList.id).FirstOrDefault()!;
            mainList.finalPrep = _context.finalPrep.Where(finalPrep => finalPrep.listId == mainList.id).FirstOrDefault()!;
            mainList.prepProteins = _context.prepProteins.Where(prepProteins => prepProteins.listId == mainList.id).FirstOrDefault()!;
            mainList.prepSauces = _context.prepSauces.Where(prepSauces => prepSauces.listId == mainList.id).FirstOrDefault()!;
            mainList.saladPrep = _context.saladPrep.Where(saladPrep => saladPrep.listId == mainList.id).FirstOrDefault()!;
            mainList.stirFryVeg = _context.stirFryVeg.Where(stirFryVeg => stirFryVeg.listId == mainList.id).FirstOrDefault()!;
            mainList.toppingsPrep = _context.toppingsPrep.Where(toppingsPrep => toppingsPrep.listId == mainList.id).FirstOrDefault()!;
            mainList.comment = _context.comment.Where(list => list.id == mainList.commentId).FirstOrDefault()!;
            mainList.signature = _context.signature.Where(list => list.id == mainList.signatureId).FirstOrDefault()!;

            return Ok(mainList);
        }


        private KitchenCheckList mapValues(KitchenCheckListDto list, KitchenCheckList kitchenCheckList) {

            
            
            // kitchenCheckList.id = list.id;
            // kitchenCheckList.aromatics.prepAromatics = list.aromatics.prepAromatics;
            // kitchenCheckList.aromatics.readyDeserts = list.aromatics.readyDeserts;
            
            // kitchenCheckList.arrivalBasics.powerOnLights = list.arrivalBasics.powerOnLights;
            // kitchenCheckList.arrivalBasics.powerOnKitchenAcOnly = list.arrivalBasics.powerOnKitchenAcOnly;

            // kitchenCheckList.brothPrep.washMeats = list.brothPrep.washMeats;
            // kitchenCheckList.brothPrep.fillPots = list.brothPrep.fillPots;
            // kitchenCheckList.brothPrep.prepVegetables = list.brothPrep.prepVegetables;
            // kitchenCheckList.brothPrep.monitorPots = list.brothPrep.monitorPots;
            // kitchenCheckList.brothPrep.boilBroths = list.brothPrep.boilBroths;

            // kitchenCheckList.finalPrep.informServiceTeam = list.finalPrep.informServiceTeam;
            // kitchenCheckList.finalPrep.readyStation = list.finalPrep.readyStation;

            // kitchenCheckList.prepProteins.prepFish = list.prepProteins.prepFish;
            // kitchenCheckList.prepProteins.prepMeatOrange = list.prepProteins.prepMeatOrange;
            // kitchenCheckList.prepProteins.prepSkewers = list.prepProteins.prepSkewers;
            // kitchenCheckList.prepProteins.prepTofu = list.prepProteins.prepTofu;
            // kitchenCheckList.prepProteins.prepWings = list.prepProteins.prepWings;
            // kitchenCheckList.prepProteins.prepareChickenChashu = list.prepProteins.prepareChickenChashu;
            // kitchenCheckList.prepProteins.prepareChickenKatsu = list.prepProteins.prepareChickenKatsu;
            // kitchenCheckList.prepProteins.prepareShrimpTempura = list.prepProteins.prepareShrimpTempura;
            // kitchenCheckList.prepProteins.prepareShrimpNobo = list.prepProteins.prepareShrimpNobo;
            // kitchenCheckList.prepProteins.prepareSousVideBeef = list.prepProteins.prepareSousVideBeef;
            // kitchenCheckList.prepProteins.seasonSalmon = list.prepProteins.seasonSalmon;

            // kitchenCheckList.prepSauces.senseiSauce = list.prepSauces.senseiSauce;
            // kitchenCheckList.prepSauces.finishingSauce = list.prepSauces.finishingSauce;

            // kitchenCheckList.saladPrep.prepSaladVeg = list.saladPrep.prepSaladVeg;

            // kitchenCheckList.stirFryVeg.stirFryVeg = list.stirFryVeg.stirFryVeg;

            // kitchenCheckList.toppingsPrep.blanchChoy = list.toppingsPrep.blanchChoy;
            // kitchenCheckList.toppingsPrep.friedRicePrep = list.toppingsPrep.friedRicePrep;

            kitchenCheckList.aromatics = _mapper.Map<Aromatics>(list.aromatics);
            kitchenCheckList.brothPrep = _mapper.Map<BrothPrep>(list.brothPrep);
            kitchenCheckList.finalPrep =  _mapper.Map<FinalPrep>(list.finalPrep);
            kitchenCheckList.toppingsPrep = _mapper.Map<ToppingsPrep>(list.toppingsPrep);
            kitchenCheckList.prepProteins = _mapper.Map<PrepProteins>(list.prepProteins);
            kitchenCheckList.saladPrep = _mapper.Map<SaladPrep>(list.saladPrep);
            kitchenCheckList.stirFryVeg = _mapper.Map<StirFryVeg>(list.stirFryVeg);
            kitchenCheckList.signature = _mapper.Map<Signature>(list.signature);
            kitchenCheckList.comment = _mapper.Map<Comment>(list.comment);


            kitchenCheckList.aromatics.listId = list.id; 
            kitchenCheckList.arrivalBasics.listId = list.id; 
            kitchenCheckList.brothPrep.listId = list.id; 
            kitchenCheckList.finalPrep.listId = list.id; 
            kitchenCheckList.toppingsPrep.listId = list.id;
            kitchenCheckList.prepProteins.listId = list.id; 
            kitchenCheckList.saladPrep.listId = list.id; 
            kitchenCheckList.stirFryVeg.listId = list.id; 


            return kitchenCheckList;
        }
    }
}
