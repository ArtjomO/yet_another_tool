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
using System.Reflection;


namespace Yet_another_tool
{
    public partial class Create_table : Form
    {
        List<Table> tableList = MgBox.tableList;                                      // Creating list of tables

        Main table_list_form;
        public Create_table(Main frm)
        {
            InitializeComponent();
            table_list_form = frm;

            if (MgBox.editState)
            {
                int tableToEdit = tableList.FindIndex(i => i.Name == MgBox.tableToEdit);

                this.Text = "Edit table: " + tableList[tableToEdit].Number;
                tbl_create.Text = "Edit";

                tbl_name.Text = tableList[tableToEdit].Name;
                tbl_num.Text = tableList[tableToEdit].Number;
                tbl_id.Text = tableList[tableToEdit].Id;
                path_to_lxd = tableList[tableToEdit].Path_lxd;
                tbl_ip.Text = tableList[tableToEdit].Tbl_ip;
            }
        }
        
        public string path_to_lxd;                                                          // Storing path after user has selected file in path_lxd_Click
        
        private void tbl_create_Click(object sender, EventArgs e)
        {
            Table table = new Table();                                                      // Creating a table object

            if (!MgBox.editState)
            {
                //if (!validate(tbl_name.Text, tbl_num.Text, tbl_id.Text, path_to_lxd))           // This validator is dumb but, oh well..
                //{                                                                               // 
                //    return;
                //}

                if (tableList.Any())     // Checking if list is empty or not, Y position depends on it
                {
                    MgBox.positionY += 30;
                }
                else
                {
                    MgBox.positionY = 100;
                }

                table.Create(tbl_name.Text, tbl_num.Text, tbl_id.Text, path_to_lxd, tbl_ip.Text, MgBox.positionY);

                List<Control> controlList = table.GetControlList();                             // Creating new table object and returning list of elements which has to be rendered

                tableList.Add(table);                                                           // Adding created table to table list

                Read_write_xml.Write(tableList);                                                           // Writing new XML list

                table_list_form.readAndAdd();

                //foreach (var control in controlList)                                                         // Rendering tables in Main form UI
                //{
                //    table_list_form.Controls.Add(control);
                //}

                MessageBox.Show("Table is added: " + table.Name + " : " + table.Number);

                // Emty the textboxes
                tbl_name.Text = "";
                tbl_num.Text = "";
                tbl_id.Text = "";
                tbl_ip.Text = "";
                path_to_lxd = "";
            }
            else
            {
                int tableToEdit = tableList.FindIndex(i => i.Name == MgBox.tableToEdit);

                tableList[tableToEdit].Name = tbl_name.Text.Trim();
                tableList[tableToEdit].Number = tbl_num.Text.Trim();
                tableList[tableToEdit].Id = tbl_id.Text.Trim();
                tableList[tableToEdit].Path_lxd = path_to_lxd;
                tableList[tableToEdit].Tbl_ip = tbl_ip.Text.Trim();


                //MgBox.tableList = tableList;
                //table_list_form.Controls.Clear();
                //MgBox.positionY = 210;
                Read_write_xml.Write(tableList);
                table_list_form.readAndAdd();
                this.Close();
                //Application.Restart();
            }
        }

        private void path_lxd_Click(object sender, EventArgs e)                         // Selecting path to .lxd file
        {
            using (FileDialog path = new OpenFileDialog())
            {
                if (DialogResult.OK == path.ShowDialog())
                {
                    path_to_lxd = path.FileName;
                    MessageBox.Show(path_to_lxd);
                }
            }
        }

        private bool validate(string name, string number, string id, string path)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(number) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(path) || string.IsNullOrEmpty(tbl_ip.Text))
            {
                MessageBox.Show("Every field and Path to lxd must be specified");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Create_table_FormClosing(object sender, FormClosingEventArgs e)
        {
            MgBox.editState = false;
        }
    }
}
