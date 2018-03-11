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

            Table table = new Table();
            table.create(tbl_name.Text, tbl_num.Text, tbl_id.Text);

            if (File.Exists(path))
            {
                MessageBox.Show("File 'Tables.xml' exists!");


            }
            else
            {
                FileStream file = File.Create(path);

                Table_list list = new Table_list();
                list.TableList = new List<Table>();
                list.TableList.Add(table);

                XmlSerializer x = new XmlSerializer(list.GetType());
                x.Serialize(file, list);
                file.Close();

                MessageBox.Show("Table is created: " + table.name + " : " + table.number);

                tbl_name.Text = "";
                tbl_num.Text = "";
                tbl_id.Text = "";


            }
        }
    }
}
