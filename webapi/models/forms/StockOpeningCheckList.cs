using webapi.models;
using webapi.models.kitchen;
using webapi.models.types;

namespace webapi.models.form
{
    public class StockOpeningCheckList : GenericListType
    {
      public StockTask stockTask {get; set;} = new StockTask();
    }
}