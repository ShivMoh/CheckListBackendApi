using webapi.models.types;

namespace webapi.models.kitchen
{
    public class ArrivalBasics : GenericAttributeType {


        public bool powerOnLights {get; set;} = false;
        public bool powerOnKitchenAcOnly {get; set;} = false;


    }
}