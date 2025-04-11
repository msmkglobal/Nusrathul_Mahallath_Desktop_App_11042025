using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MAS
{
    public partial class Frm_User_Interface : Form
    {

        Cls_Residence_Master obj_residence_master;
        public Frm_User_Interface()
        {
            InitializeComponent();
        }        

        private void Frm_User_Interface_Load(object sender, EventArgs e)
        {
            try
            {
                obj_residence_master = new Cls_Residence_Master();
                DataTable DT = new DataTable();
                //obj_residence_master.Resi_id = Convert.ToInt32(Lbox_Residence.SelectedItem.ToString());
                DT = obj_residence_master.Residence_Select_All();
                Lbox_Residence.DataSource = DT;
                Lbox_Residence.DisplayMember = DT.Columns[0].ToString();

            }
            catch
            {
            }

        }

        private void Lbox_Residence_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
          

        private void Lbox_community_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gpbx_residence_Enter(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

    }
}
