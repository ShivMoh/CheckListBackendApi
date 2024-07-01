namespace webapi.models.files
{
    public class FileType
    {

        public Guid id { get; set; }
        public string name { get; set; } = string.Empty;
        // public byte[] fileData { get; set; } = [];
        public string type { get; set; } = string.Empty;
        
        public string lastModified {get; set;} = string.Empty;
        public DateTime lastModifiedDate { get; set; } = DateTime.Now;

        public string size {get; set;} = string.Empty;

        public int progress {get; set;} 
        public Guid? listId {get; set;}
    }
}