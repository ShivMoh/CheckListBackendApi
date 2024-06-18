namespace webapi.models
{
    public class Signature
    {

        public Guid id;
        public string kitchenName {get; set;} = String.Empty;
        public string serviceName {get; set;} = String.Empty;

        public DateOnly kitchenDate {get; set;} = new DateOnly();
        public DateOnly serviceDate {get; set;} = new DateOnly();

        public Guid mainListId;
    }
}