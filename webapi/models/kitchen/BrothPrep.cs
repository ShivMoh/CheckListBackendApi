using webapi.models;

namespace webapi.models.kitchen
{
    public class BrothPrep {
        public Guid id;

        public bool washMeats {get; set;} = false;
        public bool fillPots {get; set;} = false;
        public bool prepVegetables {get; set;} = false;
        public bool monitorPots {get; set;} = false;
        public bool boilBroths {get; set;} = false;

        public Guid listId {get; set;}


    }
}