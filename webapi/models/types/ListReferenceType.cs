namespace webapi.models.types
{
    public class ListReferenceType
    {
        public Guid id { get; set; }

        public ICollection<FileType> files = new List<FileType>();
    }
}