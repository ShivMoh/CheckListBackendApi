
namespace webapi.models.kitchen
{
    public class FinalPrepServer {

        public Guid id;
        public bool turnOnTv {get; set;} = false;
        public bool openingStandup {get; set;} = false;
        public bool listUnavailableItem {get; set;} = false;

        public Guid mainListId {get; set;}

 
    }
}