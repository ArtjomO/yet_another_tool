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
    public partial class Create_table : Form
    {
        Main table_list_form;
        public Create_table(Main frm)
        {
            InitializeComponent();
            table_list_form = frm;
        }

        private void tbl_create_Click(object sender, EventArgs e)
        {
            Table table = new Table();                                                      // Creating a table object
            List<Table> tableList = new List<Table>();                                      // Creating list of tables
            Read_write_xml xml = new Read_write_xml();                                      // Creating read / write XML tool?!

            tableList = xml.Read();                                                         // Getting list of tables from XML

            int y = 120;                                                                    // Initial Y position of table if table list is to be created now

            if (tableList.Any()) y = tableList[tableList.Count - 1].tablePositionY + 20;     // Checking if list is empty or not, Y position depends on it
            
            table.create(tbl_name.Text, tbl_num.Text, tbl_id.Text, y);                      // Creating new table object
            tableList.Add(table);                                                           // Adding created table to table list

            xml.Write(tableList);                                                           // Writing new XML list

            table_list_form.Controls.Add(table.render(table.name, table.tablePositionY));   // Rendering table in Main form UI

            MessageBox.Show("Table is added: " + table.name + " : " + table.number);

            // Emty the textboxes
            tbl_name.Text = "";
            tbl_num.Text = "";
            tbl_id.Text = "";
        }
    }
}
