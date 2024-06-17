using web.models;

namespace webapi.models.kitchen
{
    public class PrepSaucesServer {

        public Guid id;
        bool coconutWater {get; set;} = false;
        public MainList mainList = new MainList();

        public Guid mainListId;

    }
}