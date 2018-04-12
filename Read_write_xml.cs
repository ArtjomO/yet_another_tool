using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Yet_another_tool
{
    public static class Read_write_xml
    {
        private static string path = "C:/Users/Артём/Desktop//Table list.xml";
        //public string path = "C:/Users/chiefsm/Desktop//Table list.xml";

        //private List<Table> tableList = new List<Table>();
        public static List<Table> tableList;
        public static List<Table> Read()
        {
            if (File.Exists(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Table>));
                XmlReader reader = XmlReader.Create(path);
                tableList = (List<Table>)serializer.Deserialize(reader);
                reader.Close();

                MgBox.tableList = tableList;
                return tableList;                                                     // Returns list with tables
            }

            return tableList;                                                         // Returns empty list
        }

        static void Write(List<Table> list)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Table>));
            FileStream stream = File.Create(path);
            serializer.Serialize(stream, list);
            stream.Close();
        }
    }
}
