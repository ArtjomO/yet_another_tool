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
            readAndAdd();
        }

        // Reading from XML onProgramStart and rendering existing tables in UI
        public void readAndAdd(List<Table> list = null, Panel overlay = null)
        {
            tbl_list_panel.Visible = true;
            pnl_search_overlay.Visible = false;

            Table table = new Table();
            Read_write_xml.Read();                              // Getting list of tables and store it in Mgbox
            MgBox.positionY = 10;
            List<Table> tableList = list ?? MgBox.tableList;
            Panel placeToRender = overlay ?? tbl_list_panel;

            if (placeToRender == overlay)
            {
                tbl_list_panel.Visible = false;
                overlay.Visible = true;
            }

            placeToRender.Controls.Clear();

            if (tableList.Any())
            {
            for (int i = 0; i < tableList.Count; i++)           // If list is not emty - loop trough list and render each table in UI
                {
                    table.Create(
                        tableList[i].Name,
                        tableList[i].Number,
                        tableList[i].Id,
                        tableList[i].Path_lxd,
                        tableList[i].Tbl_ip,
                        MgBox.positionY);

                    placeToRender.Controls.Add(table.GetPanel());

                    MgBox.positionY += 30;
                }
            }
        }

        private void tbl_list_panel_ControlAdded(object sender, ControlEventArgs e)
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
            List<Table> tableList = MgBox.tableList;

            MenuItem item = (sender as MenuItem);

            ContextMenu owner = item.Parent as ContextMenu;

            switch (item.Text)
            {
                case "delete":
                    int itemToRemove = tableList.FindIndex(i => i.Name == owner.SourceControl.Text);
                    tableList.RemoveAt(itemToRemove);
                    Read_write_xml.Write(tableList);

                    readAndAdd();
                    //Application.Restart();
                    break;
                case "edit":
                    MgBox.editState = true;
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
                readAndAdd();
                tbl_list_panel.Visible = true;
                pnl_search_overlay.Visible = false;
                return;
            } else
            {
                string numberToSearch = search_bar.Text;

                List<Table> result = MgBox.tableList.FindAll(i => i.Number.Contains(numberToSearch));

                readAndAdd(result, null); //pnl_search_overlay
            }
        }
    }
}
