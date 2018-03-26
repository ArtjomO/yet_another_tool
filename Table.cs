using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;



namespace Yet_another_tool
{
    public class Table
    {
        public string name, number, path_lxd, id;
        public int tablePositionX, tablePositionY;

        public void create(string name, string number, string id, string path_lxd, int posX, int posY)
        {
            this.name = name;
            this.number = number;
            this.path_lxd = path_lxd;
            this.id = id;
            this.tablePositionX = posX;
            this.tablePositionY = posY;
        }

        public List<Control> render(string name, string number, int posX, int posY)
        {
            Label tbl_name_label = new Label();
            tbl_name_label.Location = new Point(13, posY);
            tbl_name_label.Text = name;
            tbl_name_label.AutoSize = true;

            Label tbl_number_label = new Label();
            tbl_number_label.Location = new Point(posX, posY);
            tbl_number_label.Text = number;
            tbl_number_label.AutoSize = true;

            Control[] controls = new Control[] { tbl_name_label, tbl_number_label };

            List<Control> controlList = new List<Control>();
            controlList.Add(tbl_name_label);
            controlList.Add(tbl_number_label);

            return controlList;


        }
    }    
}
