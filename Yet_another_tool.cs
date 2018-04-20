using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yet_another_tool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            readAndAdd(this);
        }

        // Reading from XML onProgramStart and rendering existing tables in UI
        public void readAndAdd(Main frm)
        {
            Table table = new Table();
            Read_write_xml.Read();                              // Getting list of tables and store it in Mgbox
            List<Table> tableList = MgBox.tableList;

            if (tableList.Any())
            {
            for (int i = 0; i < tableList.Count; i++)           // If list is not emty - loop trough list and render each table in UI
                {
                    MgBox.positionY += 30;
                    table.Create(
                        tableList[i].Name,
                        tableList[i].Number,
                        tableList[i].Id,
                        tableList[i].Path_lxd,
                        tableList[i].Tbl_ip,
                        MgBox.positionY);

                    List<Control> controlList = table.GetControlList();                   

                    foreach (var control in controlList)
                    {
                        Controls.Add(control);
                    }
                }
            }
        }

        private void Main_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control.Name == "table_name")
            {
                ContextMenu tbl_context = new ContextMenu();
                tbl_context.MenuItems.Add("edit", new EventHandler(context_edit_clic));
                tbl_context.MenuItems.Add("delete", new EventHandler(context_edit_clic));
                e.Control.ContextMenu = tbl_context;
            }
        }

        protected void context_edit_clic(object sender, EventArgs e)
        {
            MgBox.editState = true;
            List<Table> tableList = MgBox.tableList;

            MenuItem item = (sender as MenuItem);

            ContextMenu owner = item.Parent as ContextMenu;

            switch (item.Text)
            {
                case "delete":
                    int itemToRemove = tableList.FindIndex(i => i.Name == owner.SourceControl.Text);
                    tableList.RemoveAt(itemToRemove);
                    Read_write_xml.Write(tableList);

                    Application.Restart();
                    break;
                case "edit":
                    MgBox.tableToEdit = tableList.Find(i => i.Name == owner.SourceControl.Text).Name;

                    Create_table create_table = new Create_table(this);     // Initializing Create_table form and passing this form "designer?!?" as a parameter
                    create_table.ShowDialog();
                    break;
            }
        }

        // Open create table dialog
        private void open_crt_tbl_Click(object sender, EventArgs e)
        {
            Create_table create_table = new Create_table(this);     // Initializing Create_table form and passing this form "designer?!?" as a parameter
            create_table.ShowDialog();
        }

        private void search_bar_TextChanged(object sender, EventArgs e)
        {
            if (search_bar.Text == "")
            {
                search_result.Controls.Clear();
                MgBox.SearchPosY = 15;
                return;
            }
            Table table = new Table();
            string number = search_bar.Text;

            List<Table> result = MgBox.tableList.FindAll(i => i.Number == number);
            for (int i = 0; i < result.Count; i++)
            {

                table.Create(result[i].Name, result[i].Number, result[i].Id, result[i].Path_lxd, result[i].Tbl_ip, MgBox.SearchPosY);
                List<Control> controlList = table.GetControlList();
                
                foreach (var control in controlList)
                {
                    search_result.Controls.Add(control);
                }
                MgBox.SearchPosY += 30;
            }
        }
    }
}
