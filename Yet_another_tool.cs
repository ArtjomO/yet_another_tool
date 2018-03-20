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

namespace Yet_another_tool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            readAndAdd();
        }

        public void readAndAdd()
        {
            Table table = new Table();
            List<Table> tableList = new List<Table>();
            Read_write_xml xml = new Read_write_xml();

            if (File.Exists(xml.path))
            {
                tableList = xml.Read();

                int y = tableList[tableList.Count - 1].tablePositionY + 20;

            for (int i = 0; i < tableList.Count; i++)
                {
                    this.Controls.Add(table.render(
                        tableList[i].name, 
                        tableList[i].tablePositionY));
                    y += 20;
                }
            }
        }

        private void open_crt_tbl_Click(object sender, EventArgs e)
        {
            Create_table create_table = new Create_table(this);
            create_table.ShowDialog();
        }
    }
}
