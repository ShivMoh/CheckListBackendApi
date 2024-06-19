namespace webapi.models
{
    public class Comment
    {

        public Guid id;
        
        public string comment {get; set;} = String.Empty;
        public Guid mainListId;
    }
}