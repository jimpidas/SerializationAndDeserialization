using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SerializationAndDeserialization
{
    class JsonDeserealization
    {
        public void JsonDesrialize()
        {
            string json = @"{'Name' : 'Sam','Description' : 'Welcome to universe'}";
           BlogSites1 obj = JsonConvert.DeserializeObject<BlogSites1>(json);
            Console.WriteLine(obj.Name);
        }
    }
    [DataContract]
    class BlogSites1
    {
        [DataMember]
        
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; } 
    }
}

