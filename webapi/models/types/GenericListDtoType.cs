using System.Net.Http.Headers;
using webapi.models.dto;

namespace webapi.models.types
{
    public class GenericListTypeDto
    {
        public Guid id { get; set; }

        public SignatureDto signature {get; set;} = new SignatureDto();

        public CommentDto comment {get; set;} = new CommentDto();

    }
}