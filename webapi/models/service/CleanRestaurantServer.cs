
namespace webapi.models.kitchen
{
    public class CleanRestaurantServer {

        public Guid id;
        public bool sweep {get; set;} = false;
        public bool wipeTables {get; set;} = false;
        public bool fixFurniture {get; set;} = false;
 
        public Guid listId {get; set;}

    }
}