using web.models;

namespace webapi.models.kitchen
{
    public class ArrivalBasics {
        public Guid id;

        bool powerOnLights {get; set;} = false;
        bool powerOnKitchenAcOnly {get; set;} = false;

        public MainList mainList = new MainList();

        public Guid mainListId;

    }
}