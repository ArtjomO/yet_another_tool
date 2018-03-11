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
            string path = "C:/Users/Артём/Desktop//Tables.xml";
            
            if (File.Exists(path))
            {
                MessageBox.Show("File 'Tables.xml' exists!");
            }
            else
            {
                FileStream file = File.Create(path);

                Table table = new Table();
                table.create(tbl_name.Text, tbl_num.Text, tbl_id.Text);

                Table[] tables = new Table[5];
                tables[0] = table;

                XmlSerializer x = new XmlSerializer(tables.GetType());
                x.Serialize(file, tables);
                file.Close();
            }
        }
    }
}
