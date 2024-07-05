using webapi.models.types;
namespace webapi.models.kitchen
{
    public class CleanRestaurantServer : GenericAttributeType {

  
        public bool sweep {get; set;} = false;
        public bool wipeTables {get; set;} = false;
        public bool fixFurniture {get; set;} = false;
 

    }
}