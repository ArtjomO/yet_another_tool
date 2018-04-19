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
        public string Name, Number, Path_lxd, Id, Tbl_ip;

        protected void Btn_handler_Click(object sender, EventArgs e)
        {
            Process.Start(Path_lxd);
            Process.Start("vnc://" + Tbl_ip);
        }
        
        public List<Control> Create(string name, string number, string id, string path_lxd, string tbl_ip)
        {
            this.Name = name;
            this.Number = number;
            this.Path_lxd = path_lxd;
            this.Id = id;
            this.Tbl_ip = tbl_ip;

            Label tbl_name_label = new Label();
            tbl_name_label.Location = new Point(50, MgBox.positionY);
            tbl_name_label.Text = name;
            tbl_name_label.Name = "table_name";
            tbl_name_label.AutoSize = true;
            
            Label tbl_number_label = new Label();
            tbl_number_label.Location = new Point(13, MgBox.positionY);
            tbl_number_label.Text = number;
            tbl_number_label.AutoSize = true;

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
