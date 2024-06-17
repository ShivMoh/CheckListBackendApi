using web.models;

namespace webapi.models.kitchen
{
    public class CleanRestaurantServer {

        public Guid id;
        bool sweep {get; set;} = false;
        bool wipeTables {get; set;} = false;
        bool fixFurniture {get; set;} = false;
 
        public MainList mainList = new MainList();

        public Guid mainListId;

    }
}