using web.models;

namespace webapi.models.kitchen
{
    public class PrepProteins {
        public Guid id;

        bool prepFish {get; set;} = false;
        bool prepMeatOrange {get; set;} = false;
        bool prepSkewers {get; set;} = false;
        bool prepTofu {get; set;} = false;
        bool prepWings {get; set;} = false;
        bool prepareChickenChashu {get; set;} = false;
        bool prepareChickenKatsu {get; set;} = false;
        bool prepareShrimpNobo {get; set;} = false;
        bool prepareShrimpTempura {get; set;} = false;
        bool prepareSousVideBeef {get; set;} = false;
        bool seasonSalmon {get; set;} = false;

        public MainList mainList = new MainList();

        public Guid mainListId;


    }
}