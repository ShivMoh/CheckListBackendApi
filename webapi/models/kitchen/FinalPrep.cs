using webapi.models;

namespace webapi.models.kitchen
{
    public class FinalPrep {
        public Guid id;

        public bool informServiceTeam {get; set;} = false;
        public bool readyStation {get; set;} = false;

        public Guid mainListId {get; set;}

    }
}