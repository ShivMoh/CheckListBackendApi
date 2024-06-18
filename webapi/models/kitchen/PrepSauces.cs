using webapi.models;

namespace webapi.models.kitchen
{
    public class PrepSauces {

        public Guid id;
        public bool senseiSauce {get; set;} = false;
        public bool finishingSauce {get; set;} = false;

        public Guid mainListId {get; set;}

    }
}