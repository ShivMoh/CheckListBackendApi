using webapi.models.kitchen;
using webapi.models.service;

namespace webapi.models.form
{
    public class KitchenCheckList {
        public Guid id {get;}
        public Aromatics aromatics {get; set;} = new Aromatics();
        public ArrivalBasics arrivalBasics {get; set;} = new ArrivalBasics();
        public BrothPrep brothPrep {get; set;} = new BrothPrep();
        public FinalPrep finalPrep {get; set;} = new FinalPrep();
        public PrepProteins prepProteins {get; set;} = new PrepProteins();
        public PrepSauces prepSauces {get; set;} = new PrepSauces();
        public SaladPrep saladPrep {get; set;} = new SaladPrep();
        public StirFryVeg stirFryVeg {get; set;} = new StirFryVeg();
        public ToppingsPrep toppingsPrep {get; set;} = new ToppingsPrep();
    
        public DateOnly date {get; set;} = new DateOnly();

        public Signature signature {get; set;} = new Signature();

        public Guid signatureId {get; set;}
        public Comment comment {get; set;} = new Comment();
        public Guid commentId {get; set;}

    }
}