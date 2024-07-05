using webapi.models.types;

namespace webapi.models.kitchen
{
    public class FinalPrep : GenericAttributeType {

        public bool informServiceTeam {get; set;} = false;
        public bool readyStation {get; set;} = false;

    }
}