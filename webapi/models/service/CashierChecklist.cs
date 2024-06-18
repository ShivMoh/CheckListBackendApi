namespace webapi.models.kitchen
{
    public class CashierChecklist
    {

        public Guid id;

        public bool checkCash {get; set;}
        public bool ensureChange {get; set;}
        public bool ensurePrinter {get; set;}
        public bool tidyWorkstation {get; set;}
        public Guid mainListId {get; set;}

    }
}