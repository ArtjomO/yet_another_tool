﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
using System.IO;
using System.Diagnostics;


namespace Yet_another_tool
{
    public struct Table
    {
        public string Name, Number, Path_lxd, Id, Tbl_ip;

        [XmlIgnore]
        public int PosY;

        public void Create(string name, string number, string id, string path_lxd, string tbl_ip, int posY)
        {
            Name = name.Trim();
            Number = number.Trim();
            Path_lxd = path_lxd;
            Id = id.Trim();
            Tbl_ip = tbl_ip.Trim();
            PosY = posY;
        }
        public void Btn_handler_Click(object sender, EventArgs e)
        {
            try
            {
                //Process.Start("Path_lxd");
                Process.Start("lxd\\" + Number + ".lxd");
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message + " no Path_lxd");
            }
            
            try
            {
                if (Tbl_ip.Count() > 0)
                {
                    Process.Start("vnc://" + Tbl_ip);
                }
                else
                {
                    MessageBox.Show("Table IP is not specified!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " no VNC");
            }
        }
        
        public Panel GetPanel()
        {
            Label tbl_name_label = new Label();
            tbl_name_label.Location = new Point(107, 3);
            tbl_name_label.Text = Name;
            tbl_name_label.Name = "table_name";
            tbl_name_label.AutoSize = true;
            tbl_name_label.ForeColor = Tbl_ip == "" || !(File.Exists("lxd\\" + Number + ".lxd")) ? Color.Red : Color.Black;

            Label tbl_number_label = new Label();
            tbl_number_label.Location = new Point(62, 3);
            tbl_number_label.Text = Number;
            tbl_number_label.AutoSize = true;

            Button tbl_open_btn = new Button();
            tbl_open_btn.Font = new Font("Microsoft Sans Serif", 7.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            tbl_open_btn.Location = new Point(0, 0);
            tbl_open_btn.Size = new Size(55, 20);
            tbl_open_btn.Text = "Open";
            tbl_open_btn.TextAlign = ContentAlignment.TopCenter;
            tbl_open_btn.UseVisualStyleBackColor = false;
            tbl_open_btn.Click += new EventHandler(Btn_handler_Click);

            Panel singleTbPanel = new Panel();
            singleTbPanel.Location = new Point(5, PosY);
            singleTbPanel.Size = new Size(320, 20);

            singleTbPanel.Controls.Add(tbl_name_label);
            singleTbPanel.Controls.Add(tbl_number_label);
            singleTbPanel.Controls.Add(tbl_open_btn);

            return singleTbPanel;
        }
    }    
}
