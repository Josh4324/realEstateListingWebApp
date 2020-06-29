using System;

namespace EstateApp.Data.Entities
{
    public abstract class BaseEntity
    {
        public string id {get; set;}
        public DateTime Created {get; set;}
        public DateTime ModifiedAt {get; set;}
        public DateTime DeleteAt {get; set;}
    }
}