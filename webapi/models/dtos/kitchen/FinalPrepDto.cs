using webapi.models;
using webapi.models.types;

namespace webapi.models.dto.kitchen
{
    public class FinalPrepDto : GenericAttributeTypeDto {

        public bool informServiceTeam {get; set;} = false;
        public bool readyStation {get; set;} = false;


    }
}