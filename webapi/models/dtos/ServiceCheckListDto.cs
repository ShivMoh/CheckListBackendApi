using webapi.models.kitchen;
using webapi.models.service;
using webapi.models.dto.kitchen;
using webapi.models.types;

namespace webapi.models.dto
{
    public class ServiceCheckListDto : GenericListTypeDto {
        
        public AromaticsServer aromaticsServer {get; set;} = new AromaticsServer();
 
        public CleanRestaurantServer cleanRestaurantServer {get; set;} = new CleanRestaurantServer();
        public FinalPrepServer finalPrepServer {get; set;} = new FinalPrepServer();
        public PrepSaucesServer prepSaucesServer {get; set;} = new PrepSaucesServer();

        public SaladPrepServer saladPrepServer {get; set;} = new SaladPrepServer();

        // public Guid fileContainerTypeId {get; set;} = new Guid();
    }
}