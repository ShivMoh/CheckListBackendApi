namespace webapi.models.types
{
    public class FileType
    {

        public Guid id { get; set; }
        public string name { get; set; } = string.Empty;
        public string path {get; set;} = string.Empty;     

        public string label {get; set;} = string.Empty;
        public Guid filesContainerTypeId {get; set;} = new Guid();
        public Guid listReferenceId {get; set;} = new Guid();
        
    }
}