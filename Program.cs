using System;

namespace SerializationAndDeserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySerialization obj = new BinarySerialization();
            obj.Serialization();
            BinaryDeSerialization objDesrialize = new BinaryDeSerialization();
            objDesrialize.DeSerialization();
            JsonSerilization1 json = new JsonSerilization1();
            json.JsonSerilize();
            JsonDeserealization deserealization = new JsonDeserealization();
            deserealization.JsonDesrialize();
            XMLSerialization xML = new XMLSerialization();
            xML.SerializeXML();
        }
    }
}
