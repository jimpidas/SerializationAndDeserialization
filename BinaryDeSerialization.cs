using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace SerializationAndDeserialization
{
    class BinaryDeSerialization
    {
        public void DeSerialization()
        {
            FileStream fileStream = new FileStream(@"C:\Users\Dell\DotNetProjects\SerilizationDemo\Example.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserializationdemo = (Demo)formatter.Deserialize(fileStream);
            Console.WriteLine($"Application name {deserializationdemo.ApplicationName} ---ApplicationId    {deserializationdemo.ApplicationId}");
            Console.ReadKey();
        }
    }
}
