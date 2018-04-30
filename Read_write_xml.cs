using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Yet_another_tool
{
    static class Read_write_xml
    {
        //public static string path = "C:/Users/Артём/Desktop//Table list.xml";
        public static string path = "Table list.xml";
        public static string backPath = "/list backups/";

        private static List<Table> tableList;

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

            MgBox.tableList = new List<Table>();
            return MgBox.tableList;                                                         // Returns empty list
        }

        public static void Write(List<Table> list, string changes = null, bool backup = false)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Table>));
            FileStream stream = File.Create(path);
            serializer.Serialize(stream, list);
            stream.Close();

            if (backup)
            {
                string now = DateTime.Now.ToString("dd-MM-yyyy--HH-mm-ss");
                FileStream backupStream = File.Create("list backups//" + changes.ToUpper() + " " + now + " Local time.xml");
                serializer.Serialize(backupStream, list);
                backupStream.Close();
            }

            MgBox.tableList = list;
        }
    }
}
