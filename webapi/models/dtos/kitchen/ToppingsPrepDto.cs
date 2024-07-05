using webapi.models;
using webapi.models.types;

namespace webapi.models.dto.kitchen
{
    public class ToppingsPrepDto : GenericAttributeTypeDto {

        public bool blanchChoy {get; set;} = false;
        public bool friedRicePrep {get; set;} = false;


 
    }
}