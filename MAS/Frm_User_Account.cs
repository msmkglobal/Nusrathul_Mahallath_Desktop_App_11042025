using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace MAS
{
    public partial class Frm_User_Account : Form
    {
        Cls_User_Account obj_user_account;
        public Frm_User_Account()
        {
            InitializeComponent();
        }
        public byte[] ImageToByteArray(System.Drawing.Image ImageIn)
        {
            MemoryStream ms = new MemoryStream();
            ImageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            return ms.ToArray();
        }
        public void Clear_control()
        {
            try
            {
                t2_txt_userid.Text = "";
                t2_txt_username.Text = "";
                t2_txt_password.Text = "";
                cmb_type.Text="             Choose";
                t2_pbxphoto.BackgroundImage = t2_pbxphoto.ErrorImage;
                rdb_enable.Checked = true;
                t2_txt_username.Focus();
            }
            catch
            {
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            slabel_date.Text = DateTime.Now.ToLongDateString();
            slabel_time.Text = DateTime.Now.ToShortTimeString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int type = -1;
            obj_user_account = new Cls_User_Account();
            try
            {
                int i = tcl_new_user.Controls.Count;
                for (int j = 0; j < i; j++)
                {
                    if ((string)tcl_new_user.Controls[j].Tag == "V" && tcl_new_user.Controls[j].Text == "")
                    {
                        tcl_new_user.Controls[j].Focus();
                        return;
                    }
                }
                if (cmb_type.SelectedIndex == -1)
                {
                    cmb_type.Focus();
                    return;
                }
                obj_user_account.User_id = t2_txt_userid.Text;
                obj_user_account.User_name = t2_txt_username.Text;
                obj_user_account.Password = t2_txt_password.Text;

                type = cmb_type.SelectedIndex;
                obj_user_account.Type = type.ToString();

                obj_user_account.Photo = ImageToByteArray(t2_pbxphoto.BackgroundImage);

                if (rdb_enable.Checked == true)
                    obj_user_account.Status = "E";
                else
                    obj_user_account.Status = "D";
                if (obj_user_account.User_Account_Save()>0)
                {
                    MessageBox.Show("New User Created!","User Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_control();
                }
            }
            catch(Exception Err)
            {
                MessageBox.Show(Err.Message.ToString(), "User Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void lbl_brows_MouseEnter(object sender, EventArgs e)
        {
            lbl_brows.ForeColor = Color.Red;
        }

        private void lbl_brows_MouseLeave(object sender, EventArgs e)
        {
            lbl_brows.ForeColor = Color.Black;
        }

        private void lbl_cancel_MouseEnter(object sender, EventArgs e)
        {
            lbl_cancel.ForeColor = Color.Red;
        }

        private void lbl_cancel_MouseLeave(object sender, EventArgs e)
        {
            lbl_cancel.ForeColor = Color.Black;
        }

        private void gbx_information_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_brows_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "JPEG Image(*jpeg)|*.jpg|Bitmap(*bmp)|*.bmp";
                open.Multiselect = false;
                if (open.ShowDialog(this) != DialogResult.Cancel)
                {
                    t2_pbxphoto.BackgroundImage = Image.FromFile(open.FileName);
                }
            }
            catch
            {
            }
        }

        private void lbl_cancel_Click(object sender, EventArgs e)
        {
            t2_pbxphoto.BackgroundImage = t2_pbxphoto.ErrorImage;
        }

        private void tcl_users_Click(object sender, EventArgs e)
        {
            
        }

        private void Frm_User_Account_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uSERACCOUNTDataSet1.USER_ACCOUNT' table. You can move, or remove it, as needed.
           

        }

        private void t2_txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                t2_txt_userid.Focus();
            }
        }

        private void t2_txt_userid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                t2_txt_password.Focus();
            }

        }

        private void t2_txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmb_type.Focus();
            }
        }

        private void tcl_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void tcl_MouseClick(object sender, MouseEventArgs e)
        {
            Load_Users();
           
        }

        public void Load_Users()
        {
            DataTable DT = new DataTable();
            try
            {
                txt_name.Text = "";
                txt_status.Text = "";
                txt_type.Text = "";
                txt_userid.Text = "";
                pbx_user.BackgroundImage = pbx_user.ErrorImage;
                DT.Clear();
                lb_users.Items.Clear();
                obj_user_account = new Cls_User_Account();
                DT = obj_user_account.User_Account_Select_All();
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    lb_users.Items.Add(DT.Rows[i][0].ToString());
                }
            }
            catch
            {
            }
        }

        private void lb_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btn_loaduers_Click(object sender, EventArgs e)
        {
            Load_Users();
        }

        private void lb_users_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable DT = new DataTable();
            try
            {
                DT.Clear();
                obj_user_account = new Cls_User_Account();

                obj_user_account.User_id = lb_users.SelectedItem.ToString();
                DT = obj_user_account.User_Account_Select_Id();

                txt_userid.Text = DT.Rows[0][0].ToString();
                txt_name.Text = DT.Rows[0][1].ToString();
                if (DT.Rows[0][3].ToString() == "0")
                    txt_type.Text = "Administrator";
                else if (DT.Rows[0][3].ToString() == "1")
                    txt_type.Text = "User";
                txt_status.Text = DT.Rows[0][5].ToString();

                Byte[] Photo = new Byte[0];
                Photo = (Byte[])(DT.Rows[0][4]);
                MemoryStream Photostream = new MemoryStream(Photo);
                pbx_user.BackgroundImage = Image.FromStream(Photostream);


            }
            catch
            {
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
           
            try
            {
                obj_user_account = new Cls_User_Account();
                obj_user_account.User_id = t3_txt_userid.Text;
                obj_user_account.Paswd_old = txt_currentpaswd.Text;
                obj_user_account.Password = txt_newpaswd.Text;
                if (obj_user_account.User_Account_Change_Paswd() > 0)
                {
                    MessageBox.Show("Password Updated!", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Wrong Password or User ID!", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            t3_txt_userid.Text = "";
            txt_currentpaswd.Text = "";
            txt_newpaswd.Text = "";
            t3_txt_userid.Focus();
        }

        private void t2_l6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
