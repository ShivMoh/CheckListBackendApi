using webapi.models;

namespace webapi.models.kitchen
{
    public class PrepProteins {
        public Guid id;

        public bool prepFish {get; set;} = false;
        public bool prepMeatOrange {get; set;} = false;
        public bool prepSkewers {get; set;} = false;
        public bool prepTofu {get; set;} = false;
        public bool prepWings {get; set;} = false;
        public bool prepareChickenChashu {get; set;} = false;
        public bool prepareChickenKatsu {get; set;} = false;
        public bool prepareShrimpNobo {get; set;} = false;
        public bool prepareShrimpTempura {get; set;} = false;
        public bool prepareSousVideBeef {get; set;} = false;
        public bool seasonSalmon {get; set;} = false;

        public Guid listId {get; set;}


    }
}