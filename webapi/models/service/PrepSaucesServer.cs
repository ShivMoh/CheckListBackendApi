using webapi.models;

namespace webapi.models.kitchen
{
    public class PrepSaucesServer {

        public Guid id;
        public bool coconutWater {get; set;} = false;
        public Guid listId {get; set;}

    }
}