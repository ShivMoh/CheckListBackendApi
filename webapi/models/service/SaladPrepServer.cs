

namespace webapi.models.kitchen
{
    public class SaladPrepServer {

        public Guid id;
        public bool stirSaladVegeServerLights {get; set;} = false;
        public bool stirSalidVegeServerRemove {get; set;} = false;

        public Guid mainListId {get; set;}

    }
}