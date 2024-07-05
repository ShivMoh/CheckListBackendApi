using webapi.models;
using webapi.models.types;

namespace webapi.models.dto.kitchen
{
    public class ArrivalBasicsDto : GenericAttributeTypeDto{

        public bool powerOnLights {get; set;} = false;
        public bool powerOnKitchenAcOnly {get; set;} = false;

    }
}