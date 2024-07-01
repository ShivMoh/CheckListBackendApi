using webapi.models.kitchen;
using webapi.models.service;
using webapi.models;
using webapi.models.files;

namespace webapi.models.form
{
    public class ServiceCheckList {
        public Guid id {get;}
        public AromaticsServer aromaticsServer {get; set;} = new AromaticsServer();
 
        public CleanRestaurantServer cleanRestaurantServer {get; set;} = new CleanRestaurantServer();
        public FinalPrepServer finalPrepServer {get; set;} = new FinalPrepServer();
        public PrepSaucesServer prepSaucesServer {get; set;} = new PrepSaucesServer();

        public SaladPrepServer saladPrepServer {get; set;} = new SaladPrepServer();
        public DateOnly date {get; set;} = new DateOnly();

        public Signature signature {get; set;} = new Signature();

        public Guid signatureId {get; set;}
        public Comment comment {get; set;} = new Comment();
        public Guid commentId {get; set;}

        public ICollection<FileType>? files {get; set;} = [];

    }
}