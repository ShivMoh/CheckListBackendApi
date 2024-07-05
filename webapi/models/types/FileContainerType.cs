namespace webapi.models.types
{
    public class FileContainerType
    {

        public Guid id { get; set; }
        public ICollection<FileType> files {get; set;} = new List<FileType>();

    }
}