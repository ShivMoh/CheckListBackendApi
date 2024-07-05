using webapi.models.kitchen;
using webapi.models.service;
using webapi.models;
using webapi.models.types;

namespace webapi.models.form
{
    public class ServiceCheckList : GenericListType {
  
        public AromaticsServer aromaticsServer {get; set;} = new AromaticsServer();
 
        public CleanRestaurantServer cleanRestaurantServer {get; set;} = new CleanRestaurantServer();
        public FinalPrepServer finalPrepServer {get; set;} = new FinalPrepServer();
        public PrepSaucesServer prepSaucesServer {get; set;} = new PrepSaucesServer();

        public SaladPrepServer saladPrepServer {get; set;} = new SaladPrepServer();

    }
}