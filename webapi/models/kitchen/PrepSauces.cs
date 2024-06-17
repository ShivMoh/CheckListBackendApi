using web.models;

namespace webapi.models.kitchen
{
    public class PrepSauces {

        public Guid id;
        bool senseiSauce {get; set;} = false;
        bool finishingSauce {get; set;} = false;

        public MainList mainList = new MainList();

        public Guid mainListId;

    }
}