using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace SerializationAndDeserialization
{
    class XMLSerialization
    {
        public void SerializeXML()
        {
            XmlSerializer ser = new XmlSerializer(typeof(orderForm));
            FileStream fileStream = new FileStream(@"C:\Users\Dell\DotNetProjects\SerializationAndDeserialization\XmlExample.txt", FileMode.Create);
            orderForm orderForm = new orderForm();
            DateTime date = new DateTime(2019, 12, 21);
            orderForm.orderData = date;
            ser.Serialize(fileStream, orderForm);
        }
    }
    public class orderForm
    {
        public DateTime orderData;
    }
}
