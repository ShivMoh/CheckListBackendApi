using webapi.models.types;

namespace webapi.models.kitchen
{
    public class Aromatics : GenericAttributeType {


        public bool prepAromatics {get; set;} = false;
        public bool readyDeserts {get; set;} = false;
        
    }
}