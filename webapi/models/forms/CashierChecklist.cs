using webapi.models.files;

namespace webapi.models.form
{
    public class CashierChecklist
    {

        public Guid id;

        public bool checkCash {get; set;}
        public bool ensureChange {get; set;}
        public bool ensurePrinter {get; set;}
        public bool tidyWorkstation {get; set;}

        public Comment? comment {get; set;} = new Comment();

        public Signature? signature {get; set;} = new Signature();

        public DateOnly date {get; set;} = new DateOnly();

        public Guid? commentId {get; set;}
        public Guid? signatureId {get; set;}

    }

}