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
        }

        private void tbl_create_Click(object sender, EventArgs e)
        {
            // Needed for creating and opening the file
            string path = "C:/Users/Артём/Desktop//Tables.xml";

            // Creating a table object
            Table table = new Table();
            table.create(tbl_name.Text, tbl_num.Text, tbl_id.Text);

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
                tableList.Add(table);

                // Rewrite the old XML 
                FileStream file = File.Create(path);
                serializer.Serialize(file, tableList);
                file.Close();

                MessageBox.Show("Table is added: " + table.name + " : " + table.number);

                // Emty the textboxes
                tbl_name.Text = "";
                tbl_num.Text = "";
                tbl_id.Text = "";
            }
            else
            {
                // Adding first table to the list
                tableList.Add(table);

                // Creating a new XML
                FileStream file = File.Create(path);
                serializer.Serialize(file, tableList);
                file.Close();

                MessageBox.Show("Table is created: " + table.name + " : " + table.number);

                tbl_name.Text = "";
                tbl_num.Text = "";
                tbl_id.Text = "";
            }
        }
    }
}
