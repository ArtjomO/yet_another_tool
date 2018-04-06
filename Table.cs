using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
using System.Diagnostics;



namespace Yet_another_tool
{
    public class Table
    {
        public string name, number, path_lxd, id, tbl_ip;

        protected void Btn_handler_Click(object sender, EventArgs e)
        {
            Process.Start(path_lxd);
            Process.Start("vnc://" + tbl_ip);
        }
        
        protected void context_delete_Click(object sender, EventArgs e)
        {
            Read_write_xml xml = new Read_write_xml();
            List<Table> tableList = new List<Table>();

            tableList = xml.Read();

            MenuItem item = (sender as MenuItem);
            
            ContextMenu owner = item.Parent as ContextMenu;

            int itemToRemove = tableList.FindIndex(i => i.name == owner.SourceControl.Text);
            tableList.RemoveAt(itemToRemove);
            xml.Write(tableList);
        
            Application.Restart();
        }
    
        protected void context_edit_clic(object sender, EventArgs e) // this doesnt work must clean mgbox
        {
            Read_write_xml xml = new Read_write_xml();
            List<Table> tableList = new List<Table>();

            tableList = xml.Read();

            MenuItem item = (sender as MenuItem);

            ContextMenu owner = item.Parent as ContextMenu;

            //int itemToEdit = tableList.FindIndex(i => i.name == owner.SourceControl.Text);

            MgBox.tableToEdit = tableList.Find(i => i.name == owner.SourceControl.Text).name;
            MessageBox.Show(MgBox.tableToEdit);

            Create_table create_table = new Create_table(MgBox.form);
        }

    public List<Control> create(string name, string number, string id, string path_lxd, string tbl_ip)
        {
            this.name = name;
            this.number = number;
            this.path_lxd = path_lxd;
            this.id = id;
            this.tbl_ip = tbl_ip;

            ContextMenu tbl_context = new ContextMenu();
            tbl_context.MenuItems.Add("edit", new EventHandler(context_edit_clic));
            tbl_context.MenuItems.Add("delete", new EventHandler(context_delete_Click));
            
            Label tbl_name_label = new Label();
            tbl_name_label.Location = new Point(50, MgBox.positionY);
            tbl_name_label.Text = name;
            tbl_name_label.AutoSize = true;
            tbl_name_label.ContextMenu = tbl_context;
            

            Label tbl_number_label = new Label();
            tbl_number_label.Location = new Point(13, MgBox.positionY);
            tbl_number_label.Text = number;
            tbl_number_label.AutoSize = true;
            //tbl_number_label.ContextMenu = tbl_context;

            Button tbl_open_btn = new Button();
            tbl_open_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tbl_open_btn.Location = new System.Drawing.Point(130, MgBox.positionY);
            tbl_open_btn.Size = new System.Drawing.Size(55, 20);

            tbl_open_btn.Text = "Open";
            tbl_open_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            tbl_open_btn.UseVisualStyleBackColor = false;
            tbl_open_btn.Click += new EventHandler(Btn_handler_Click);

            List<Control> controlList = new List<Control>();
            controlList.Add(tbl_name_label);
            controlList.Add(tbl_number_label);
            controlList.Add(tbl_open_btn);

            return controlList;
        }

    }    
}
