namespace webapi.models.files
{
    public class FileType
    {

        public Guid id { get; set; }
        public string name { get; set; } = string.Empty;

        public string path {get; set;} = string.Empty;     
        public Guid? listId {get; set;}
    }
}