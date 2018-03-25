using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Drawing;



namespace Yet_another_tool
{
    public class Table
    {
        public string name, number, path_lxd, id;
        public int tablePositionY;
        
        public void create(string name, string number, string id, string path_lxd, int posY)
        {
            this.name = name;
            this.number = number;
            this.path_lxd = path_lxd;
            this.id = id;
            this.tablePositionY = posY;
        }

        public Control render(string name, int posY)
        {
            Label tbl_name_label = new Label();
            tbl_name_label.Location = new Point(13, posY);
            tbl_name_label.Text = name;
            tbl_name_label.AutoSize = true;
            return tbl_name_label;
        }
    }    
}
