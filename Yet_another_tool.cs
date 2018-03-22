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

        // Reading from XML onProgramStart and rendering existing tables in UI
        public void readAndAdd()
        {
            Read_write_xml xml = new Read_write_xml();
            Table table = new Table();
            List<Table> tableList = new List<Table>();

            tableList = xml.Read();                             // Getting list of tables

            if (tableList.Any())
            {
            for (int i = 0; i < tableList.Count; i++)           // If list is not emty - loop trough list and render each table in UI
                {
                    this.Controls.Add(table.render(
                        tableList[i].name,
                        tableList[i].tablePositionY));
                }
            }
        }

        // Open create table dialog
        private void open_crt_tbl_Click(object sender, EventArgs e)
        {
            Create_table create_table = new Create_table(this);
            create_table.ShowDialog();
        }
    }
}
