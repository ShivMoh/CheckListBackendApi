using webapi.models;

namespace webapi.models.kitchen
{
    public class ArrivalBasics {
        public Guid id;

        public bool powerOnLights {get; set;} = false;
        public bool powerOnKitchenAcOnly {get; set;} = false;


        public Guid mainListId {get; set;}

    }
}