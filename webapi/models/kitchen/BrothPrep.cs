using webapi.models.types;

namespace webapi.models.kitchen
{
    public class BrothPrep : GenericAttributeType {
      
        public bool washMeats {get; set;} = false;
        public bool fillPots {get; set;} = false;
        public bool prepVegetables {get; set;} = false;
        public bool monitorPots {get; set;} = false;
        public bool boilBroths {get; set;} = false;

  


    }
}