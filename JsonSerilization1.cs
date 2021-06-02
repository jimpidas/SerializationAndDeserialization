using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SerializationAndDeserialization
{
    class JsonSerilization1
    {
        public void JsonSerilize()
        {
            BlogSites obj = new BlogSites();
            string JsonData = JsonConvert.SerializeObject(obj);
            Console.WriteLine(JsonData);
        }
    }
    [DataContract]
    class BlogSites
    {
        [DataMember]
        public string name { get; set; } = "Sam";
        [DataMember]
        public string Description { get; set; } = "Welcome to Universe";
    }
}
