using webapi.models.types;
namespace webapi.models.kitchen
{
    public class StockOpeningCheckListDto : GenericListTypeDto {

        public StockTaskDto stockTask {get; set;} = new StockTaskDto();

    }
}