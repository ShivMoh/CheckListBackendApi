using webapi.models;
using webapi.models.files;

namespace webapi.models.form
{
    public class StockOpeningCheckList
    {
        public Guid id;
        public bool beverages {get; set;}
        public bool checkUtensils {get; set;}
        public bool coldCups {get; set;}
        public bool condiments {get; set;}
        public bool ramenBar {get; set;}
        public bool straws {get; set;}
        public bool takeoutBox {get; set;}
        public bool teaBags {get; set;}
        public bool tissues {get; set;}
        public bool tissuesPacks {get; set;}
        public bool towels {get; set;}


        public Comment comment {get; set;} = new Comment();

        public Signature signature {get; set;} = new Signature();

        public DateOnly date {get; set;} = new DateOnly();

        public Guid commentId {get; set;}
        public Guid signatureId {get; set;}
        
        public ICollection<FileType>? files {get; set;} = [];

    }
}