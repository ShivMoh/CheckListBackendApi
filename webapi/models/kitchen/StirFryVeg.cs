using webapi.models;

namespace webapi.models.kitchen
{
    public class StirFryVeg {

        public Guid id;
        public bool stirFryVeg {get; set;} = false;

        public Guid listId {get; set;}

 
    }
}