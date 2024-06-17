using web.models;

namespace webapi.models.kitchen
{
    public class ToppingsPrep {

        public Guid id;
        bool blanchChoy {get; set;} = false;
        bool friedRicePrep {get; set;} = false;

        public MainList mainList = new MainList();

        public Guid mainListId;

 
    }
}