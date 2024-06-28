using webapi.models;

namespace webapi.models.kitchen
{
    public class Aromatics {

        public Guid id;
        public bool prepAromatics {get; set;} = false;
        public bool readyDeserts {get; set;} = false;

        public Guid listId {get; set;} 

    }
}