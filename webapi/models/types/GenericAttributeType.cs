using System.Collections.ObjectModel;

namespace webapi.models.types
{
    public abstract class GenericAttributeType
    {

        public Guid id;
        
        public Guid listId {get; set;}

        public Guid fileContainerTypeId {get; set;}

        public FileContainerType fileContainer {get; set;} = new FileContainerType();
        
    }
}