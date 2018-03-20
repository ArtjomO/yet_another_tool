using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Yet_another_tool
{
    class Read_write_xml
    {
        public string path = "C:/Users/Артём/Desktop//Tables.xml";

        private List<Table> tableList = new List<Table>();

        public List<Table> Read()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Table>));
            XmlReader reader = XmlReader.Create(path);
            tableList = (List<Table>)serializer.Deserialize(reader);
            reader.Close();

            return tableList;
        }
    }
}
