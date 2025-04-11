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
    public partial class Frm_Login : Form
    {
        Form MDIOBJ;
        public Frm_Login(Form OBJ)
        {
            InitializeComponent();
            MDIOBJ = OBJ;
        }
        public void User_Login()
        {
            try
            {
                DataTable DT = new DataTable();
                Cls_User_Account obj_user_account = new Cls_User_Account();
                obj_user_account.User_id = txt_userid.Text;
                obj_user_account.Password = txt_password.Text;

                DT = obj_user_account.User_Account_Login();
                if (DT.Rows.Count == 1)
                {
                    string type = DT.Rows[0][3].ToString();
                    switch (type)
                    {
                        case "0":
                            {
                                MDIOBJ.Controls[0].Enabled = true;
                                this.Close();
                            }
                            break;
                        case "1":
                            {

                            }
                            break;
                        default: { }
                            break;
                    }                   
                }
                else
                {
                    lbl_error.Visible = true;
                }
                txt_password.Text = "";
                txt_userid.Text = "";
                txt_userid.Focus();
            }
            catch { }            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                User_Login();
            }
            catch
            {
            }
        }

        private void txt_userid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_password.Focus();
            }
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                User_Login();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
            MDIOBJ.Close();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }    
    }
}
