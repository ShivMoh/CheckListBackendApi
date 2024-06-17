using web.models;

namespace webapi.models.kitchen
{
    public class FinalPrepServer {

        public Guid id;
        bool turnOnTv {get; set;} = false;
        bool openingStandup {get; set;} = false;
        bool listUnavailableItem {get; set;} = false;

        public MainList mainList = new MainList();

        public Guid mainListId;

 
    }
}