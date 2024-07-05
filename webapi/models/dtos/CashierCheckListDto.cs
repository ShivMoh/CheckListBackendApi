using webapi.models.kitchen;
using webapi.models.service;
using webapi.models.dto.kitchen;
using webapi.models.types;

namespace webapi.models.dto
{
    public class CashierChecklistDto : GenericListTypeDto {
        
        public CashierTask cashierTask {get; set;} = new CashierTask();
        // public Guid fileContainerTypeId {get; set;} = new Guid();
    }
}