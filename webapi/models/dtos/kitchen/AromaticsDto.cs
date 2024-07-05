using webapi.models;
using webapi.models.types;

namespace webapi.models.dto.kitchen
{
    public class AromaticsDto : GenericAttributeTypeDto {

     
        public bool prepAromatics {get; set;} = false;
        public bool readyDeserts {get; set;} = false;

   

    }
}