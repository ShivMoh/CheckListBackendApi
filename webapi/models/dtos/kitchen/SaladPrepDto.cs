using webapi.models;
using webapi.models.types;

namespace webapi.models.dto.kitchen
{
    public class SaladPrepDto : GenericAttributeTypeDto {

        public bool prepSaladVeg {get; set;} = false;


    }
}