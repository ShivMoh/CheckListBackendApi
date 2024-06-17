using web.models;

namespace webapi.models.kitchen
{
    public class SaladPrep {

        public Guid id;
        bool prepSaladVeg {get; set;} = false;

        public MainList mainList = new MainList();

        public Guid mainListId;

    }
}