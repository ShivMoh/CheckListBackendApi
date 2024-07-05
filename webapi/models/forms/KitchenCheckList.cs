using webapi.models.kitchen;
using webapi.models.service;
using webapi.models.types;

namespace webapi.models.form
{
    public class KitchenCheckList : GenericListType {
    
        public Aromatics aromatics {get; set;} = new Aromatics();
        public ArrivalBasics arrivalBasics {get; set;} = new ArrivalBasics();
        public BrothPrep brothPrep {get; set;} = new BrothPrep();
        public FinalPrep finalPrep {get; set;} = new FinalPrep();
        public PrepProteins prepProteins {get; set;} = new PrepProteins();
        public PrepSauces prepSauces {get; set;} = new PrepSauces();
        public SaladPrep saladPrep {get; set;} = new SaladPrep();
        public StirFryVeg stirFryVeg {get; set;} = new StirFryVeg();
        public ToppingsPrep toppingsPrep {get; set;} = new ToppingsPrep();
    
    }
}