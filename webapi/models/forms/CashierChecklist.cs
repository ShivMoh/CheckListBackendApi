using webapi.models.kitchen;
using webapi.models.types;

namespace webapi.models.form
{
    public class CashierChecklist : GenericListType
    {

        public CashierTask cashierTask {get; set;} = new CashierTask();
    
    }

}