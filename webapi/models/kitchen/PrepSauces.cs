using webapi.models.types;

namespace webapi.models.kitchen
{
    public class PrepSauces : GenericAttributeType{

        public bool senseiSauce {get; set;} = false;
        public bool finishingSauce {get; set;} = false;


    }
}