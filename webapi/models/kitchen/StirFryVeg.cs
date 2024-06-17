using web.models;

namespace webapi.models.kitchen
{
    public class StirFryVeg {

        public Guid id;
        bool stirFryVeg {get; set;} = false;

        public MainList mainList = new MainList();

        public Guid mainListId;

 
    }
}