﻿using System;
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
            Read_write_xml xml = new Read_write_xml();
            List<Table> tableList = new List<Table>();
            tableList = xml.Read();                             // Getting list of tables

            if (tableList.Any())
            {
            for (int i = 0; i < tableList.Count; i++)           // If list is not emty - loop trough list and render each table in UI
                {
                    MgBox.positionY += 30;
                    var arr = table.create(
                       tableList[i].name,
                       tableList[i].number,
                       tableList[i].id,
                       tableList[i].path_lxd,
                       tableList[i].tbl_ip);                          

                    foreach (var el in arr)
                    {
                        //if (el.Name == "table_name")
                        //{
                        //    ContextMenu tbl_context = new ContextMenu();
                        //    tbl_context.MenuItems.Add("edit", new EventHandler(context_edit_clic));
                        //    tbl_context.MenuItems.Add("delete", new EventHandler(context_edit_clic));
                        //    el.ContextMenu = tbl_context;
                        //}
                        this.Controls.Add(el);
                    }
                }
            }
        }

        

        protected void context_edit_clic(object sender, EventArgs e)
        {
            MgBox.editState = true;
            Read_write_xml xml = new Read_write_xml();
            List<Table> tableList = new List<Table>();

            tableList = xml.Read();

            MenuItem item = (sender as MenuItem);

            ContextMenu owner = item.Parent as ContextMenu;

            switch (item.Text)
            {
                case "delete":
                    int itemToRemove = tableList.FindIndex(i => i.name == owner.SourceControl.Text);
                    tableList.RemoveAt(itemToRemove);
                    xml.Write(tableList);

                    Application.Restart();
                    break;
                case "edit":
                    MgBox.tableToEdit = tableList.Find(i => i.name == owner.SourceControl.Text).name;

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
    }
}
