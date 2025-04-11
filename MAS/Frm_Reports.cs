using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAS
{
    public partial class Frm_Reports : Form
    {
        Cls_Community_Master obj_cmnty_master;
        DataTable DT;

        public Frm_Reports()
        {
            InitializeComponent();
        }

        private void c_Search_TextChanged(object sender, EventArgs e)
        {
            obj_cmnty_master = new Cls_Community_Master();
            try
            {
                DT = new DataTable();
                obj_cmnty_master.Resi_id = c_search_text.Text;
                DT = obj_cmnty_master.community_master_election_list_print();
                if (DT.Rows.Count > 0)
                {
                    c_gridview.DataSource = DT;
                }
                else
                {
                    c_gridview.DataSource = "";
                }

            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Printer Obj_Printer = new Frm_Printer(DT, "ELECTION_LIST");
                Obj_Printer.Show();
            }
            catch { }
        }

        private void Frm_Reports_Load(object sender, EventArgs e)
        {

        }
    }
}
