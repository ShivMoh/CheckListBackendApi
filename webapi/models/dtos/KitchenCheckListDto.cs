using webapi.models.kitchen;
using webapi.models.service;
using webapi.models.dto.kitchen;
using webapi.models.types;

namespace webapi.models.dto
{
    public class KitchenCheckListDto : GenericListTypeDto{
        
        public AromaticsDto aromatics {get; set;} = new AromaticsDto();
        public ArrivalBasicsDto arrivalBasics {get; set;} = new ArrivalBasicsDto();
        public BrothPrepDto brothPrep {get; set;} = new BrothPrepDto();
        public FinalPrepDto finalPrep {get; set;} = new FinalPrepDto();
        public PrepProteinsDto prepProteins {get; set;} = new PrepProteinsDto();
        public PrepSaucesDto prepSauces {get; set;} = new PrepSaucesDto();
        public SaladPrepDto saladPrep {get; set;} = new SaladPrepDto();
        public StirFryVegDto stirFryVeg {get; set;} = new StirFryVegDto();
        public ToppingsPrepDto toppingsPrep {get; set;} = new ToppingsPrepDto();

        // public Guid fileContainerTypeId {get; set;} = new Guid();
    }
}