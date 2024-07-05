using webapi.models;
using webapi.models.types;

namespace webapi.models.dto.kitchen
{
    public class PrepSaucesDto : GenericAttributeTypeDto {

        public bool senseiSauce {get; set;} = false;
        public bool finishingSauce {get; set;} = false;


    }
}