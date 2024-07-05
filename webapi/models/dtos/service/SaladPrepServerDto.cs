
using webapi.models.types;
namespace webapi.models.kitchen
{
    public class SaladPrepServerDto : GenericAttributeTypeDto{

        public bool stirSaladVegeServerLights {get; set;} = false;
        public bool stirSaladVegeServerRemove {get; set;} = false;

    }
}