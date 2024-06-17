using web.models;

namespace webapi.models.kitchen
{
    public class FinalPrep {
        public Guid id;

        bool informServiceTeam {get; set;} = false;
        bool readyStation {get; set;} = false;

        public MainList mainList = new MainList();

        public Guid mainListId;

    }
}