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
    public partial class Frm_Mahallu : Form
    {
       // Cls_Db DBO = new Cls_Db();
        Cls_mahallumaster Dbomahallu;
        public void Clear_Control()
        {
            try
            {
                txtmahalname.Text = "";
                txtmosque.Text = "";
                txtaddress.Text = "";
                txtpincode.Text = "";
                txtdistrict.Text = "";
                txtstate.Text = "";
                txtphone.Text = "";
                txtkhabarsthany.Text = "";
                txtbuildingnum.Text = "";
                txtwardnum.Text = "";
                txtpanjayath.Text = "";
                txtvillage.Text = "";
                txtthaluk.Text = "";
                txtblock.Text = "";
                txtsince.Text = "";
                txtarea.Text = "";

            }
            catch 
            {
            }
        }
        
        public void Mahallu_Refresh()
        {
            DataTable DT = new DataTable();
            Dbomahallu = new Cls_mahallumaster();
            DT = Dbomahallu.Mahallumaster_read();            
            if (DT.Rows.Count > 0)
            {
                txtmisid.Text = DT.Rows[0]["MISID"].ToString();
                txtmahalname.Text = DT.Rows[0]["Mahal_Name"].ToString();
                txtmosque.Text = DT.Rows[0]["Mosq_Name"].ToString();
                txtmosque.Text = DT.Rows[0]["Type"].ToString();
                txtmosque.Text = DT.Rows[0]["Place"].ToString();
                txtbuildingnum.Text = DT.Rows[0]["Bldg_Num"].ToString();                
                txtaddress.Text = DT.Rows[0]["Address"].ToString();
                txtpincode.Text = DT.Rows[0]["Pincode"].ToString();
                txtpanjayath.Text = DT.Rows[0]["Panjayath"].ToString();
                txtvillage.Text = DT.Rows[0]["Village"].ToString();
                txtthaluk.Text = DT.Rows[0]["Thaluk"].ToString();
                txtblock.Text = DT.Rows[0]["Block_Num"].ToString();
                txtwardnum.Text = DT.Rows[0]["Ward_Num"].ToString();
                txtdistrict.Text = DT.Rows[0]["District"].ToString();
                txtstate.Text = DT.Rows[0]["State"].ToString();
                txtkhabarsthany.Text = DT.Rows[0]["Khabar_Sthany"].ToString();
                txtarea.Text = DT.Rows[0]["Area"].ToString();
                txtsince.Text = DT.Rows[0]["Since"].ToString();
                txtphone.Text = DT.Rows[0]["Phone"].ToString();


            }
        }    
       
       
        //
        public Frm_Mahallu()
        {
            InitializeComponent();
        }

        private void Frm_Mahallu_Load(object sender, EventArgs e)
        {
            try
            {
                Mahallu_Refresh();               
            }
            catch
            {
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void btn_save_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Dbomahallu = new Cls_mahallumaster();
        //        Dbomahallu.MAHAL_NAME = txtmahalname.Text;
        //        Dbomahallu.MOSQ_NAME = txtmosque.Text;
        //        Dbomahallu.TYPE = txtbuildingnum.Text;
        //        Dbomahallu.PLACE = txtbuildingnum.Text;
        //        Dbomahallu.BLDG_NUM = txtbuildingnum.Text;
        //        Dbomahallu.ADDRESS = txtaddress.Text;
        //        Dbomahallu.PINCODE = txtpincode.Text;
        //        Dbomahallu.PANJAYATH = txtpanjayath.Text;
        //        Dbomahallu.VILLAGE = txtvillage.Text;
        //        Dbomahallu.THALUK = txtthaluk.Text;
        //        Dbomahallu.BLOCK_NUM = txtblock.Text;
        //        Dbomahallu.WARD_NUM = txtwardnum.Text;
        //        Dbomahallu.DISTRICT = txtdistrict.Text;
        //        Dbomahallu.STATE = txtstate.Text;
        //        Dbomahallu.KHABAR_STHANY = txtkhabarsthany.Text;
        //        Dbomahallu.AREA = Convert.ToUInt32(txtarea.Text);
        //        Dbomahallu.SINCE = txtsince.Text;
        //        Dbomahallu.PHONE = txtphone.Text;
        //        if (Dbomahallu.Mahallu_Master_Save() > 0)
        //        {
        //            MessageBox.Show("Data Saved Succesfully");
        //        }

        //    }
        //    catch
        //    {
                

        //    }
        //    Clear_Control();

        //}

        private void btn_edit_Click(object sender, EventArgs e)
        {
            

        }
        

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mahallu_Refresh();
        }

        private void txtpincode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox t = (TextBox)sender;
                Int64 i = Convert.ToInt64(t.Text);
            }
            catch
            {
                SendKeys.Send("{BS}");

            }
        }

        private void txtmosque_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtaddress.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtaddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtpincode.Focus();
                }
            }
            catch
            {
            }
        }

        private void txt_pincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtdistrict.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtdistrict_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtstate.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtstate_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtphone.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtkhabarsthany.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtkhabarsthany_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtbuildingnum.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtbuildingnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtwardnum.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtwardnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtpanjayath.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtpanjayath_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtvillage.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtvillage_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtthaluk.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtthaluk_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtblock.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtblock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            txtsince.Focus();
        }

        private void txtsince_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            txtarea.Focus();
        }

        private void txtmahalname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtmosque.Focus();
        }

        private void txtbuildingnum_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtwardnum.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtmosque_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtaddress.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtaddress_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtpincode.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtpincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtdistrict.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtdistrict_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtstate.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtstate_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtphone.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtphone_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtkhabarsthany.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtkhabarsthany_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtbuildingnum.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtbuildingnum_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtwardnum.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtwardnum_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtpanjayath.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtpanjayath_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtvillage.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtvillage_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtthaluk.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtthaluk_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtblock.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtblock_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtsince.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtsince_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtarea.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtarea_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btn_edit_Click_1(object sender, EventArgs e)
        {
            try
            {
                int result = 0;

                result = ((int)MessageBox.Show("Are you sure you want to permanently change this file?", "Mahallu[MAS]", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (result == (int)DialogResult.Yes)
                {
                    for (int i = 0; i < gbx_mahallu.Controls.Count; i++)
                    {
                        if ((string)gbx_mahallu.Controls[i].Tag == "M" && gbx_mahallu.Controls[i].Text == "")
                        {
                            MessageBox.Show("Empty text box not allowed!", "Mahallu[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            gbx_mahallu.Controls[i].Focus();
                            return;
                        }
                    }
                    Dbomahallu = new Cls_mahallumaster();
                    Dbomahallu.Misid = txtmisid.Text;
                    Dbomahallu.MAHAL_NAME = txtmahalname.Text;
                    Dbomahallu.MOSQ_NAME = txtmosque.Text;
                    Dbomahallu.TYPE = txtbuildingnum.Text;
                    Dbomahallu.PLACE = txtbuildingnum.Text;
                    Dbomahallu.BLDG_NUM = txtbuildingnum.Text;
                    Dbomahallu.ADDRESS = txtaddress.Text;
                    Dbomahallu.PINCODE = txtpincode.Text;
                    Dbomahallu.PANJAYATH = txtpanjayath.Text;
                    Dbomahallu.VILLAGE = txtvillage.Text;
                    Dbomahallu.THALUK = txtthaluk.Text;
                    Dbomahallu.BLOCK_NUM = txtblock.Text;
                    Dbomahallu.WARD_NUM = txtwardnum.Text;
                    Dbomahallu.DISTRICT = txtdistrict.Text;
                    Dbomahallu.STATE = txtstate.Text;
                    Dbomahallu.KHABAR_STHANY = txtkhabarsthany.Text;
                    Dbomahallu.AREA = Convert.ToUInt32(txtarea.Text);
                    Dbomahallu.SINCE = txtsince.Text;
                    Dbomahallu.PHONE = txtphone.Text;
                }
                else
                {
                    return;
                }
                if (Dbomahallu.Mahallu_Master_Edit() > 0)
                {
                    MessageBox.Show("File Updated Succesfully", "Mahallu[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mahallu_Refresh();
                }

            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message.ToString(), "Mahallu[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
           
        }

        

    }      
}
