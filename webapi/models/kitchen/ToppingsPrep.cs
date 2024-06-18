using webapi.models;

namespace webapi.models.kitchen
{
    public class ToppingsPrep {

        public Guid id;
        public bool blanchChoy {get; set;} = false;
        public bool friedRicePrep {get; set;} = false;

        public Guid mainListId {get; set;}

 
    }
}