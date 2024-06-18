
namespace webapi.models.kitchen
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

        public Guid mainListId {get; set;}
        

    }
}