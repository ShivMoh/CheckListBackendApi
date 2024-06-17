using web.models;

namespace webapi.models.kitchen
{
    public class SaladPrepServer {

        public Guid id;
        bool stirSaladVegeServerLights {get; set;} = false;
        bool stirSalidVegeServerRemove {get; set;} = false;

        public MainList mainList = new MainList();

        public Guid mainListId;

    }
}