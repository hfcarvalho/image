using System;
using System.Collections.Generic;

namespace Model
{
    public class Resource
    {
        public const string BASE_PATH = "C:";

        public Resource(string name, User owner, string path = null)
        {
            Name = name;
            Owner = owner;
            Path = path;
        }

        public string Name { get; set; }

        public long IdResource;

        public User Owner { get; set; }

        public string Path;

        public string Description;

        public IEnumerable<Audit> Auditings;

        public virtual string getCalculatedPath()
        {
            return BASE_PATH + "/" + Path;
        }

        
    }
}
