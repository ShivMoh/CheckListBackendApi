using System.Net.Http.Headers;

namespace webapi.models.types
{
    public class GenericListType
    {
        public Guid id { get; set; } = new Guid();

        public Signature signature {get; set;} = new Signature();

        public DateTime startDate {get; set;} = new DateTime();
        public DateTime endDate {get; set;} = new DateTime();
        public Comment comment {get; set;} = new Comment();

        public Guid commentId {get; set;} = new Guid();
        public Guid signatureId {get; set;} = new Guid();

        public ListReferenceType listReferenceType  {get; set;} = new ListReferenceType();

        public Guid listReferenceTypeId {get; set;} = new Guid();

        public bool submitted {get; set;} =  false;

    }
}