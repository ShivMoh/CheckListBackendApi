using webapi.models;

namespace webapi.models.kitchen
{
    public class SaladPrep {

        public Guid id;
        public bool prepSaladVeg {get; set;} = false;

        public Guid mainListId {get; set;}

    }
}