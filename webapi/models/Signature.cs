namespace webapi.models
{
    public class Signature
    {

        public Guid id;
        public string name {get; set;} = String.Empty;

        public DateOnly date {get; set;} = new DateOnly();

   
    }
}