using webapi.models.kitchen;
using webapi.models.service;

namespace web.models
{
    public class MainList {

        public Guid id;
        public Aromatics aromatics {get; set;} = new Aromatics();

        public ArrivalBasics arrivalBasics {get; set;} = new ArrivalBasics();

        public BrothPrep brothPrep {get; set;} = new BrothPrep();
        public FinalPrep finalPrep {get; set;} = new FinalPrep();
        public PrepProteins prepProteins {get; set;} = new PrepProteins();
        public PrepSauces prepSauces {get; set;} = new PrepSauces();
        public SaladPrep saladPrep {get; set;} = new SaladPrep();
        public StirFryVeg stirFryVeg {get; set;} = new StirFryVeg();
        public ToppingsPrep toppingsPrep {get; set;} = new ToppingsPrep();
        public AromaticServer aromaticServer {get; set;} = new AromaticServer();
        public CleanRestaurantServer cleanRestaurantServer {get; set;} = new CleanRestaurantServer();
        public FinalPrepServer finalPrepServer {get; set;} = new FinalPrepServer();
        public PrepSaucesServer prepSaucesServer {get; set;} = new PrepSaucesServer();

        public SaladPrepServer saladPrepServer {get; set;} = new SaladPrepServer();

    }    
}