using web.models;

namespace webapi.models.service
{
    public class AromaticServer {

        public Guid id;
        bool cleanGlass {get; set;} = false;

        public MainList mainList = new MainList();

        public Guid mainListId;

 
    }
}