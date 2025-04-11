using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MAS
{
    public partial class Frm_MAS_MDI : Form
    {
        Frm_Dashboard obj_frm_dashboard = null;
        Frm_Login obj_frm_login = null;
        Frm_Mahallu obj_frm_mahallu = null;
        Frm_Commitee_Master obj_frm_cmty_master = null;
        Frm_Commitee_Member obj_frm_cmty_member = null;
        Frm_Residence obj_frm_residence = null;
        Frm_Community obj_frm_cmnty = null;
        Frm_Education obj_frm_education = null;
        Frm_Job obj_frm_job = null;
        Frm_Employee obj_frm_employee = null;
        Frm_User_Account obj_frm_user_account = null;
        Frm_User_Interface obj_frm_user_interface=null;
        Frm_Marriage_Registration obj_frm_marriage_registration = null;
        Frm_Search obj_frm_search = null;
        Frm_Passbook_Print obj_passbook_print = null;
        Frm_Receipt obj_frm_receipt = null;

        Cls_mahallumaster obj_cls_mahallumaster;
      
        public Frm_MAS_MDI()
        {
            InitializeComponent();
        }

        //Invoke Functions

        public void Invoke_frm_mahallu()
        {
            try
            {
                if (obj_frm_mahallu == null || !obj_frm_mahallu.IsHandleCreated)
                {
                    obj_frm_mahallu = new Frm_Mahallu();
                    obj_frm_mahallu.MdiParent = this;
                    obj_frm_mahallu.Dock = DockStyle.Fill;
                    obj_frm_mahallu.Show();
                }
                else
                {
                    obj_frm_mahallu.Activate();
                    obj_frm_mahallu.WindowState = FormWindowState.Normal;
                }
            }
            catch
            {
            }
        }

        public void Invoke_frm_committee()
        {
            try
            {
                if (obj_frm_cmty_master == null || !obj_frm_cmty_master.IsHandleCreated)
                {
                    obj_frm_cmty_master = new Frm_Commitee_Master();
                    obj_frm_cmty_master.MdiParent = this;
                    obj_frm_cmty_master.Dock = DockStyle.Fill;
                    obj_frm_cmty_master.Show();
                }
                else
                {
                    obj_frm_cmty_master.Activate();
                    obj_frm_cmty_master.WindowState = FormWindowState.Normal;
                }
            }
            catch
            {
            }
        }

        public void Invoke_frm_committee_member()
        {
            try
            {
                if (obj_frm_cmty_member == null || !obj_frm_cmty_member.IsHandleCreated)
                {
                    obj_frm_cmty_member = new Frm_Commitee_Member();
                    obj_frm_cmty_member.MdiParent = this;
                    obj_frm_cmty_member.Dock = DockStyle.Fill;
                    obj_frm_cmty_member.Show();
                }
                else
                {
                    obj_frm_cmty_member.Activate();
                    obj_frm_cmty_member.WindowState = FormWindowState.Normal;
                }
            }
            catch
            {
            }
        }

        public void Invoke_frm_residence()
        {
            try
            {
                if (obj_frm_residence == null || !obj_frm_residence.IsHandleCreated)
                {
                    obj_frm_residence = new Frm_Residence();
                    obj_frm_residence.MdiParent = this;
                    obj_frm_residence.Dock = DockStyle.Fill;     
                    obj_frm_residence.Show();
                }
                else
                {
                    obj_frm_residence.Activate();
                    obj_frm_residence.WindowState = FormWindowState.Normal;
                }
            }
            catch
            {
            }
        }

        public void Invoke_frm_community_master()
        {
            try
            {
                if (obj_frm_cmnty == null || !obj_frm_cmnty.IsHandleCreated)
                {
                    obj_frm_cmnty = new Frm_Community();
                    obj_frm_cmnty.MdiParent = this;
                    obj_frm_cmnty.Dock = DockStyle.Fill;
                    obj_frm_cmnty.Show();
                }
                else
                {
                    obj_frm_cmnty.Activate();
                    obj_frm_cmnty.WindowState = FormWindowState.Normal;
                }
            }
            catch
            {
            }
        }

        public void Invoke_frm_education()
        {
            try
            {
                if (obj_frm_education == null || !obj_frm_education.IsHandleCreated)
                {
                    obj_frm_education = new Frm_Education();
                    obj_frm_education.MdiParent = this;
                    obj_frm_education.Dock = DockStyle.Fill; 
                    obj_frm_education.Show();
                }
                else
                {
                    obj_frm_education.Activate();
                    obj_frm_education.WindowState = FormWindowState.Normal;
                }
            }
            catch
            {
            }
        }

        public void Invoke_frm_job()
        {
            try
            {
                if (obj_frm_job == null || !obj_frm_job.IsHandleCreated)
                {
                    obj_frm_job = new Frm_Job();
                    obj_frm_job.MdiParent = this;
                    obj_frm_job.Dock = DockStyle.Fill;
                    obj_frm_job.Show();
                }
                else
                {
                    obj_frm_job.Activate();
                    obj_frm_job.WindowState = FormWindowState.Normal;
                }
            }
            catch
            {
            }
        }

        public void Invoke_frm_employee()
        {
            try
            {
                if (obj_frm_employee == null || !obj_frm_employee.IsHandleCreated)
                {
                    obj_frm_employee = new Frm_Employee();
                    obj_frm_employee.MdiParent = this;
                    obj_frm_employee.Show();
                }
                else
                {
                    obj_frm_employee.Activate();
                    obj_frm_employee.WindowState = FormWindowState.Maximized;
                }
            }
            catch
            {
            }
        }

        public void Invoke_frm_Marriage()
        {
            try
            {
                if (obj_frm_marriage_registration == null || !obj_frm_marriage_registration.IsHandleCreated)
                {
                    obj_frm_marriage_registration = new Frm_Marriage_Registration();
                    obj_frm_marriage_registration.MdiParent = this;
                    obj_frm_marriage_registration.Show();
                }
                else
                {
                    obj_frm_marriage_registration.Activate();
                    obj_frm_marriage_registration.WindowState = FormWindowState.Maximized;
                }
            }
            catch
            {
            }
        }

        public void Invoke_frm_useraccount()
        {
            try
            {
                if (obj_frm_user_account == null || !obj_frm_user_account.IsHandleCreated)
                {
                    obj_frm_user_account = new Frm_User_Account();
                    obj_frm_user_account.MdiParent = this;
                    obj_frm_user_account.Show();
                }
                else
                {
                    obj_frm_user_account.Activate();
                    obj_frm_user_account.WindowState = FormWindowState.Maximized;
                }
            }
            catch
            {
            }
        }

        public void Invoke_frm_user_interface()
        {
            try
            {
                if (obj_frm_user_interface == null || !obj_frm_user_interface.IsHandleCreated)
                {
                    obj_frm_user_interface = new Frm_User_Interface();
                    obj_frm_user_interface.MdiParent = this;
                    obj_frm_user_interface.Show();
                }
                else
                {
                    obj_frm_user_interface.Activate();
                    obj_frm_user_interface.WindowState = FormWindowState.Maximized;
                }
            }
            catch
            {
            }
        }

        public void Invoke_frm_search()
        {
            try
            {
                if (obj_frm_search == null || !obj_frm_search.IsHandleCreated)
                {
                    obj_frm_search = new Frm_Search();
                    obj_frm_search.MdiParent= this;
                    obj_frm_search.Show();
                }
                else
                {
                    obj_frm_search.Activate();
                    obj_frm_search.WindowState = FormWindowState.Maximized;
                }
            }
            catch
            {
            }
        }
        
        public void Invoke_frm_passbook_print()
        {
            try
            {
                if (obj_passbook_print == null || !obj_passbook_print.IsHandleCreated)
                {
                    obj_passbook_print = new Frm_Passbook_Print();
                    obj_passbook_print.MdiParent = this;
                    obj_passbook_print.Show();
                }
                else
                {
                    obj_passbook_print.Activate();
                    obj_passbook_print.WindowState = FormWindowState.Maximized;
                }
            }
            catch
            {
            }
        }

        public void Invoke_frm_dashboard()
        {
            try
            {
                if (obj_frm_dashboard == null || !obj_frm_dashboard.IsHandleCreated)
                {
                    obj_frm_dashboard = new Frm_Dashboard();
                    obj_frm_dashboard.MdiParent = this;
                    obj_frm_dashboard.Show();
                }
                else
                {
                    obj_frm_dashboard.Activate();
                    obj_frm_dashboard.WindowState = FormWindowState.Maximized;
                }
            }
            catch { }
        }

        public void Invoke_frm_receipt()
        {
            try
            {
                if (obj_frm_receipt == null || !obj_frm_receipt.IsHandleCreated)
                {
                    obj_frm_receipt = new Frm_Receipt();
                    obj_frm_receipt.MdiParent = this;
                    obj_frm_receipt.Dock = DockStyle.Fill;
                    obj_frm_receipt.Show();
                }
                else
                {
                    obj_frm_receipt.Activate();
                    obj_frm_receipt.WindowState = FormWindowState.Normal;
                }
            }
            catch
            {
            }
        }
        //
        public void Load_Mdi()
        {
            this.Controls[0].Enabled = false;
            obj_frm_login = new Frm_Login(this);
            obj_frm_login.MdiParent = this;
            obj_frm_login.Show();
        }

        //End of invoke functions

        private void btn_committee_Click(object sender, EventArgs e)
        {
            Invoke_frm_committee();
        }

        private void Frm_MAS_MDI_Load(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            try
            {
                obj_cls_mahallumaster=new Cls_mahallumaster();
                Invoke_frm_dashboard();
                DT = obj_cls_mahallumaster.Select_Mis_Info_For_Mdipanel();
                if(DT.Rows.Count==1)
                {
                    this.Text = DT.Rows[0][1] + "   [" + DT.Rows[0][0] + " " + DT.Rows[0][3] + " -" + DT.Rows[0][4] + "]".ToString() + "-ICM";
                }
                //Load_Mdi();
                //lbl_date.Text = System.DateTime.Now.ToShortDateString();
                //Cls_Db Obj_Db = new Cls_Db();
                //DataTable DT = new DataTable();
                //SqlCommand CMD = new SqlCommand("SELECT * FROM RESIDENCE_MASTER");
                //DT = Obj_Db.Read(CMD);    
                //if(DT.Rows.Count>9)
                //{
                //    this.Controls[0].Enabled = false;
                //    MessageBox.Show("Sorry! This is the Demo Version Software! Please visit www.aptorasoftasia.com");
                //}
            }
            catch
            {
            }
        }

        private void btn_committee_member_Click(object sender, EventArgs e)
        {
            Invoke_frm_committee_member();
        }

        private void btn_mahallu_Click(object sender, EventArgs e)
        {
            Invoke_frm_mahallu();
        }

        private void btn_residence_Click(object sender, EventArgs e)
        {
            Invoke_frm_residence();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Invoke_frm_education();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            try
            {
                this.Controls[0].Enabled = false;
                obj_frm_login = new Frm_Login(this);
                obj_frm_login.MdiParent = this;
                obj_frm_login.Show();
            }
            catch(Exception Err)
            {
                MessageBox.Show(Err.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            Invoke_frm_useraccount();
        }

        private void btn_communittee_Click(object sender, EventArgs e)
        {
            Invoke_frm_community_master();
        }

        private void btn_occupation_Click(object sender, EventArgs e)
        {
            Invoke_frm_job();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            Invoke_frm_employee();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                Invoke_frm_search();
            }
            catch
            {
            }
        }

        private void btn_commitee_Click(object sender, EventArgs e)
        {
            Invoke_frm_committee();
        }

        private void btn_Cmnty_member_Click(object sender, EventArgs e)
        {
            Invoke_frm_committee_member();
        }

        private void btn_cmnty_Click(object sender, EventArgs e)
        {
            Invoke_frm_community_master();
        }

        private void btn_cmnt_education_Click(object sender, EventArgs e)
        {
            Invoke_frm_education();
        }

        private void btn_mahal_Click(object sender, EventArgs e)
        {
            Invoke_frm_mahallu();
        }

        private void btn_residance_Click(object sender, EventArgs e)
        {
            Invoke_frm_residence();
        }

        private void btn_job_Click(object sender, EventArgs e)
        {
            Invoke_frm_job();
        }

        private void btn_employ_Click(object sender, EventArgs e)
        {
            Invoke_frm_employee();
        }

        private void btn_marriage_Click(object sender, EventArgs e)
        {
            Invoke_frm_Marriage();
        }

        private void menu_house_Click(object sender, EventArgs e)
        {
            
        }

        private void menu_community_Click(object sender, EventArgs e)
        {
            
        }

        private void menu_education_Click(object sender, EventArgs e)
        {
            Invoke_frm_education();
        }

        private void menu_profession_Click(object sender, EventArgs e)
        {
            Invoke_frm_job();
        }

        private void menu_passbook_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void finance_receipt_Click(object sender, EventArgs e)
        {
           
        }

        private void houseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoke_frm_residence();
        }

        private void familyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoke_frm_community_master();
        }

        private void receiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoke_frm_receipt();
        }

        private void passbookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoke_frm_passbook_print();
        }

        private void educationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoke_frm_education();
        }

        private void professionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoke_frm_job();
        }

       

       

       

       

        

       


       

       
    }
}
