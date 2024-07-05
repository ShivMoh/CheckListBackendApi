using webapi.models.types;
namespace webapi.models.kitchen
{
    public class CashierTaskDto : GenericAttributeTypeDto {

        public bool checkCash {get; set;}
        public bool ensureChange {get; set;}
        public bool ensurePrinter {get; set;}
        public bool tidyWorkstation {get; set;}
 

    }
}