using webapi.models.types;
namespace webapi.models.kitchen
{
    public class FinalPrepServerDto : GenericAttributeTypeDto {

        public bool turnOnTv {get; set;} = false;
        public bool openingStandup {get; set;} = false;
        public bool listUnavailableItems {get; set;} = false;


 
    }
}