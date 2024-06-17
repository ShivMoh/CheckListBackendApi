using web.models;

namespace webapi.models.kitchen
{
    public class Aromatics {

        public Guid id;
        bool prepAromatics {get; set;} = false;
        bool readyDeserts {get; set;} = false;

        public MainList mainList = new MainList();

        public Guid mainListId;

    }
}