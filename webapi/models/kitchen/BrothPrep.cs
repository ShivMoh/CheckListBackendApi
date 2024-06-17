using web.models;

namespace webapi.models.kitchen
{
    public class BrothPrep {
        public Guid id;

        bool washMeats {get; set;} = false;
        bool fillPots {get; set;} = false;
        bool prepVegetables {get; set;} = false;
        bool monitorPots {get; set;} = false;
        bool boilBroths {get; set;} = false;

        public MainList mainList = new MainList();

        public Guid mainListId;


    }
}