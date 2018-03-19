using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace Yet_another_tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            readAndAdd();
        }

        public void readAndAdd()
        {
            string path = "C:/Users/Артём/Desktop//Tables.xml";

            List<Table> tableList = new List<Table>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Table>));

            if (File.Exists(path))
            {
                // Deserialize the list
                XmlReader reader = XmlReader.Create(path);
                tableList = (List<Table>)serializer.Deserialize(reader);
                reader.Close();
                
                Table table = new Table();

                int y = tableList[tableList.Count - 1].tablePositionY + 20;

            for (int i = 0; i < tableList.Count; i++)
                {
                    this.Controls.Add(table.render(
                        tableList[i].name, 
                        tableList[i].tablePositionY));
                    y += 20;
                }
            }
        }

        private void tbl_create_Click(object sender, EventArgs e)
        {
            // Needed for creating and opening the file
            string path = "C:/Users/Артём/Desktop//Tables.xml";

            // Creating a table object
            Table table = new Table();

            // Creating list of tables
            List<Table> tableList = new List<Table>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Table>));

            // If XML of tables exists open and add a table to the list, else - create new and add first table
            if (File.Exists(path))
            {
                // Deserialize the list
                XmlReader reader = XmlReader.Create(path);
                tableList = (List<Table>)serializer.Deserialize(reader);
                reader.Close();

                // Add table to list
                int y = tableList[tableList.Count - 1].tablePositionY + 20;
                table.create(tbl_name.Text, tbl_num.Text, tbl_id.Text, y);
                tableList.Add(table);

                // Rewrite the old XML 
                FileStream file = File.Create(path);
                serializer.Serialize(file, tableList);
                file.Close();

                // Rendering table in UI
                this.Controls.Add(table.render(table.name, table.tablePositionY));

                MessageBox.Show("Table is added: " + table.name + " : " + table.number);

                // Emty the textboxes
                tbl_name.Text = "";
                tbl_num.Text = "";
                tbl_id.Text = "";
            }
            else
            {
                // Adding first table to the list
                table.create(tbl_name.Text, tbl_num.Text, tbl_id.Text, 120);
                tableList.Add(table);
                
                // Creating a new XML
                FileStream file = File.Create(path);
                serializer.Serialize(file, tableList);
                file.Close();

                // Rendering table info in UI
                this.Controls.Add(table.render(table.name, table.tablePositionY));

                MessageBox.Show("Table is created: " + table.name + " : " + table.number);

                // Emty the textboxes
                tbl_name.Text = "";
                tbl_num.Text = "";
                tbl_id.Text = "";
            }
        }
    }
}
