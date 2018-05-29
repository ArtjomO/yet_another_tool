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
                if (!validate(tbl_name.Text, tbl_num.Text, tbl_id.Text))   //, path_to_lxd        // This validator is dumb but, oh well..
                {                                                                               // 
                    return;
                }

                MgBox.positionY = tableList.Any() ? MgBox.positionY += 30 : MgBox.positionY = 10;

                table.Create(tbl_name.Text, tbl_num.Text, tbl_id.Text, path_to_lxd, tbl_ip.Text, MgBox.positionY);

                Panel tblPanel = table.GetPanel();                             // Creating new table object and returning list of elements which has to be rendered

                tableList.Add(table);                                                           // Adding created table to table list

                Read_write_xml.Write(tableList, table.Number + " added", true);     // Writi with backup

                table_list_form.readAndAdd();

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
                if (!validate(tbl_name.Text, tbl_num.Text, tbl_id.Text))   //, path_to_lxd        // This validator is dumb but, oh well..
                {                                                                               // 
                    return;
                }

                int tableToEditIndex = tableList.FindIndex(i => i.Name == MgBox.tableToEdit);

                Table tableObj = tableList[tableToEditIndex];

                tableObj.Name = tbl_name.Text.Trim();
                tableObj.Number = tbl_num.Text.Trim();
                tableObj.Id = tbl_id.Text.Trim();
                tableObj.Path_lxd = path_to_lxd;
                tableObj.Tbl_ip = tbl_ip.Text.Trim();

                tableList[tableToEditIndex] = tableObj;

                Read_write_xml.Write(tableList, tbl_num.Text.Trim() + " edited", true); // W

                this.Close();
                table_list_form.readAndAdd();
            }
        }

        //private void path_lxd_Click(object sender, EventArgs e)                         // Selecting path to .lxd file
        //{
        //    using (FileDialog path = new OpenFileDialog())
        //    {
        //        if (DialogResult.OK == path.ShowDialog())
        //        {
        //            path_to_lxd = path.FileName;
        //            //MessageBox.Show(path_to_lxd);
        //        }
        //    }
        //}

        private bool validate(string name, string number, string id) //, string path
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(number) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(tbl_ip.Text)) //string.IsNullOrEmpty(path) ||
            {
                MessageBox.Show("Every field must be specified! Don't forget about '.lxd' file.");
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
