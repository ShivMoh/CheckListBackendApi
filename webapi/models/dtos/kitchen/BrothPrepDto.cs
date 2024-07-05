using webapi.models;
using webapi.models.types;

namespace webapi.models.dto.kitchen
{
    public class BrothPrepDto : GenericAttributeTypeDto{

        public bool washMeats {get; set;} = false;
        public bool fillPots {get; set;} = false;
        public bool prepVegetables {get; set;} = false;
        public bool monitorPots {get; set;} = false;
        public bool boilBroths {get; set;} = false;



    }
}