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
    public partial class Frm_Marriage_Registration : Form
    {
        Cls_Marriage_Registration Obj_Marriage_Reg;
        public Frm_Marriage_Registration()
        {
            InitializeComponent();
        }

        private void Frm_Marriage_Registration_Load(object sender, EventArgs e)
        {
            Marriage_Get_Id();
            dgv_marrage.Enabled = false;
            txt_govt_reg_no.Focus();
        }
        public void Clear_Controls()
        {
            try
            {
                txt_reg_no.Text = "";
                txt_govt_reg_no.Text = "";
                txt_certificate_no.Text = "";
                dtp_date.Text = DateTime.Now.ToShortTimeString();
                txt_place.Text = "";
                txt_mahallu.Text = "";
                txt_mahar.Text = "";
                txt_mdone.Text = "";
                txt_certrcvd.Text = "";
                txt_secretrary.Text = "";
                txt_president.Text = "";
                txt_narration.Text = "";
                txt_b_cmntid.Text = "";
                txt_b_name.Text = "";
                txt_b_number.Text = "";
                txt_b_dob.Text = "";
                txt_b_age.Text = "";
                txt_b_occupation.Text = "";
                txt_b_father.Text = "";
                txt_b_mother.Text = "";
                txt_b_mahallu.Text = "";
                txt_b_house.Text = "";
                txt_b_po.Text = "";
                txt_b_district.Text = "";
                txt_b_state.Text = "";
                txt_b_country.Text = "";
                txt_b_nomrg.Text = "";
                txt_b_reason.Text = "";
                txt_b_witness1.Text = "";
                txt_b_witness2.Text = "";
                txt_g_cmntid.Text = "";
                txt_g_name.Text = "";
                txt_g_number.Text = "";
                txt_g_dob.Text = "";
                txt_g_age.Text = "";
                txt_g_occupation.Text = "";
                txt_g_father.Text = "";
                txt_g_mother.Text = "";
                txt_g_mahallu.Text = "";
                txt_g_house.Text = "";
                txt_g_po.Text = "";
                txt_g_district.Text = "";
                txt_g_state.Text = "";
                txt_g_country.Text = "";
                txt_g_nomrg.Text = "";
                txt_g_reason.Text = "";
                txt_g_witness1.Text = "";
                txt_g_witness2.Text = "";         

                //pbx_bride.Image = BackgroundImage;
                //pbx_groom.Image = BackgroundImage;

            }
            catch
            {
            }
        }
        public void Marriage_Get_Id()
        {
            try
            {
                Obj_Marriage_Reg = new Cls_Marriage_Registration();
                int Rid = Obj_Marriage_Reg.Marriage_Register_Get_Id();
                txt_reg_no.Text = Rid.ToString();
            }
            catch
            {

            }

        }
        public void Controls_Enable(string key)
        {
            try
            {
                if (key == "False")
                {
                    //txt_reg_no.Enabled = true;
                    txt_govt_reg_no.Enabled = true;
                    txt_certificate_no.Enabled = true;
                    dtp_date.Enabled = true;
                    txt_place.Enabled = true;
                    txt_mahallu.Enabled = true;
                    txt_mahar.Enabled = true;
                    txt_mdone.Enabled = true;
                    txt_certrcvd.Enabled = true;
                    txt_secretrary.Enabled = true;
                    txt_president.Enabled = true;
                    txt_narration.Enabled = true;
                    txt_b_cmntid.Enabled = true;
                    txt_b_name.Enabled = true;
                    txt_b_number.Enabled = true;
                    txt_b_dob.Enabled = true;
                    txt_b_age.Enabled = true;
                    txt_b_occupation.Enabled = true;
                    txt_b_father.Enabled = true;
                    txt_b_mother.Enabled = true;
                    txt_b_mahallu.Enabled = true;
                    txt_b_house.Enabled = true;
                    txt_b_po.Enabled = true;
                    txt_b_district.Enabled = true;
                    txt_b_state.Enabled = true;
                    txt_b_country.Enabled = true;
                    txt_b_nomrg.Enabled = true;
                    txt_b_reason.Enabled = true;
                    txt_b_witness1.Enabled = true;
                    txt_b_witness2.Enabled = true;
                    txt_g_cmntid.Enabled = true;
                    txt_g_name.Enabled = true;
                    txt_g_number.Enabled = true;
                    txt_g_dob.Enabled = true;
                    txt_g_age.Enabled = true;
                    txt_g_occupation.Enabled = true;
                    txt_g_father.Enabled = true;
                    txt_g_mother.Enabled = true;
                    txt_g_mahallu.Enabled = true;
                    txt_g_house.Enabled = true;
                    txt_g_po.Enabled = true;
                    txt_g_district.Enabled = true;
                    txt_g_state.Enabled = true;
                    txt_g_country.Enabled = true;
                    txt_g_nomrg.Enabled = true;
                    txt_g_reason.Enabled = true;
                    txt_g_witness1.Enabled = true;
                    txt_g_witness2.Enabled = true;

                }
                if (key == "True")
                {
                    //txt_reg_no.Enabled = false;
                    txt_govt_reg_no.Enabled = false;
                    txt_certificate_no.Enabled = false;
                    dtp_date.Enabled = false;
                    txt_place.Enabled = false;
                    txt_mahallu.Enabled = false;
                    txt_mahar.Enabled = false;
                    txt_mdone.Enabled = false;
                    txt_certrcvd.Enabled = false;
                    txt_secretrary.Enabled = false;
                    txt_president.Enabled = false;
                    txt_narration.Enabled = false;
                    txt_b_cmntid.Enabled = false;
                    txt_b_name.Enabled = false;
                    txt_b_number.Enabled = false;
                    txt_b_dob.Enabled = false;
                    txt_b_age.Enabled = false;
                    txt_b_occupation.Enabled = false;
                    txt_b_father.Enabled = false;
                    txt_b_mother.Enabled = false;
                    txt_b_mahallu.Enabled = false;
                    txt_b_house.Enabled = false;
                    txt_b_po.Enabled = false;
                    txt_b_district.Enabled = false;
                    txt_b_state.Enabled = false;
                    txt_b_country.Enabled = false;
                    txt_b_nomrg.Enabled = false;
                    txt_b_reason.Enabled = false;
                    txt_b_witness1.Enabled = false;
                    txt_b_witness2.Enabled = false;
                    txt_g_cmntid.Enabled = false;
                    txt_g_name.Enabled = false;
                    txt_g_number.Enabled = false;
                    txt_g_dob.Enabled = false;
                    txt_g_age.Enabled = false;
                    txt_g_occupation.Enabled = false;
                    txt_g_father.Enabled = false;
                    txt_g_mother.Enabled = false;
                    txt_g_mahallu.Enabled = false;
                    txt_g_house.Enabled = false;
                    txt_g_po.Enabled = false;
                    txt_g_district.Enabled = false;
                    txt_g_state.Enabled = false;
                    txt_g_country.Enabled = false;
                    txt_g_nomrg.Enabled = false;
                    txt_g_reason.Enabled = false;
                    txt_g_witness1.Enabled = false;
                    txt_g_witness2.Enabled = false;

                }
            }
            catch
            {
            }
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            return ms.ToArray();
        }
        private void Marriage_Bind_Controls(string Keys)
        {
            DataTable DT = new DataTable();
            try
            {
                DT.Rows.Clear();
                Obj_Marriage_Reg = new Cls_Marriage_Registration();
                if (Keys != "")
                {
                    Controls_Enable("True");
                    Obj_Marriage_Reg.Key = Keys;
                    DT = Obj_Marriage_Reg.Marriage_Register_Select_By_Id();
                    dgv_marrage.DataSource = DT;

                    txt_reg_no.Text = DT.Rows[0][0].ToString();
                    txt_govt_reg_no.Text = DT.Rows[0][1].ToString();
                    txt_certificate_no.Text = DT.Rows[0][2].ToString();
                    dtp_date.Text = DT.Rows[0][3].ToString();
                    txt_place.Text = DT.Rows[0][4].ToString();
                    txt_mahallu.Text = DT.Rows[0][5].ToString();
                    txt_mahar.Text = DT.Rows[0][6].ToString();
                    txt_mdone.Text = DT.Rows[0][7].ToString();
                    txt_certrcvd.Text = DT.Rows[0][8].ToString();
                    txt_secretrary.Text = DT.Rows[0][9].ToString();
                    txt_president.Text = DT.Rows[0][10].ToString();
                    txt_b_cmntid.Text = DT.Rows[0][11].ToString();
                    txt_b_name.Text = DT.Rows[0][12].ToString();
                    txt_b_number.Text = DT.Rows[0][13].ToString();
                    txt_b_dob.Text = DT.Rows[0][14].ToString();
                    txt_b_age.Text = DT.Rows[0][15].ToString();
                    txt_b_occupation.Text = DT.Rows[0][16].ToString();
                    txt_b_father.Text = DT.Rows[0][17].ToString();
                    txt_b_mother.Text = DT.Rows[0][18].ToString();
                    txt_b_mahallu.Text = DT.Rows[0][19].ToString();
                    txt_b_house.Text = DT.Rows[0][20].ToString();
                    txt_b_po.Text = DT.Rows[0][21].ToString();
                    txt_b_district.Text = DT.Rows[0][22].ToString();
                    txt_b_state.Text = DT.Rows[0][23].ToString();
                    txt_b_country.Text = DT.Rows[0][24].ToString();
                    txt_b_nomrg.Text = DT.Rows[0][25].ToString();
                    txt_b_reason.Text = DT.Rows[0][26].ToString();

                    byte[] Photo = new byte[0];
                    Photo = (byte[])(DT.Rows[0][27]);
                    MemoryStream Photostream = new MemoryStream(Photo);
                    pbx_bride.BackgroundImage = Image.FromStream(Photostream);
                   

                    txt_b_witness1.Text = DT.Rows[0][28].ToString();
                    txt_b_witness2.Text = DT.Rows[0][29].ToString();
                    txt_g_cmntid.Text = DT.Rows[0][30].ToString();
                    txt_g_name.Text = DT.Rows[0][31].ToString();
                    txt_g_number.Text = DT.Rows[0][32].ToString();
                    txt_g_dob.Text = DT.Rows[0][33].ToString();
                    txt_g_age.Text = DT.Rows[0][34].ToString();
                    txt_g_occupation.Text = DT.Rows[0][35].ToString();
                    txt_g_father.Text = DT.Rows[0][36].ToString();
                    txt_g_mother.Text = DT.Rows[0][37].ToString();
                    txt_g_mahallu.Text = DT.Rows[0][38].ToString();
                    txt_g_house.Text = DT.Rows[0][39].ToString();
                    txt_g_po.Text = DT.Rows[0][40].ToString();
                    txt_g_district.Text = DT.Rows[0][41].ToString();
                    txt_g_state.Text = DT.Rows[0][42].ToString();
                    txt_g_country.Text = DT.Rows[0][43].ToString();
                    txt_g_nomrg.Text = DT.Rows[0][44].ToString();
                    txt_g_reason.Text = DT.Rows[0][45].ToString();

                    
                    Photo = (byte[])(DT.Rows[0][46]);
                    MemoryStream Photostreams = new MemoryStream(Photo);
                    pbx_groom.BackgroundImage = Image.FromStream(Photostreams);

                    txt_g_witness1.Text = DT.Rows[0][47].ToString();
                    txt_g_witness2.Text = DT.Rows[0][48].ToString();
                    txt_narration.Text = DT.Rows[0][49].ToString();                   


                }
                else
                {
                    Clear_Controls();
                    btn_save.Enabled = true;
                    Controls_Enable("True");
                    txt_search.Focus();
                }
            }
            catch { }
        }

        public void Marriage_Search_By_key(string key)
        {
            try
            {
                if (key != "")
                {
                    dgv_marrage.DataSource = null;
                    DataTable DT = new DataTable();
                    Obj_Marriage_Reg = new Cls_Marriage_Registration();
                    Obj_Marriage_Reg.Key = key;
                    DT = Obj_Marriage_Reg.Marriage_Register_Select_By_key();
                    dgv_marrage.DataSource = DT;
                }
                else
                {
                    dgv_marrage.DataSource = null;
                }
            }
            catch
            {
            }
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                int result = (int)MessageBox.Show("Do you want to clear the data?", "Marrraiage Register [MAS]", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == (int)DialogResult.OK)
                {
                    Clear_Controls();
                    Controls_Enable("False");
                    Marriage_Get_Id();
                    dgv_marrage.DataSource = null;
                    txt_search.Text = "";
                    btn_save.Enabled = true;
                    btn_edit.Enabled = false;
                    btn_delete.Enabled = false;
                    txt_govt_reg_no.Focus();
                    dgv_marrage.Enabled = false;
                }
                else
                {
                    if (dgv_marrage.DataSource == null)
                    {
                        btn_save.Enabled = true;
                    }
                }
            }
            catch
            {
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int result = (int)MessageBox.Show("Make sure that, Data has to be Saved", "Marrraiage Register[MAS]", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == (int)DialogResult.OK)
                {
                    for (int i = 0; i < gbx_marrage.Controls.Count; i++)
                    {
                        if ((string)gbx_marrage.Controls[i].Tag == "M" && gbx_marrage.Controls[i].Text == "")
                        {
                            MessageBox.Show("Empty text box not allowed!", "Marrraiage Register[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            gbx_marrage.Controls[i].Focus();
                            return;
                        }
                    }
                    for (int i = 0; i < gbx_bg.Controls.Count; i++)
                    {
                        if ((string)gbx_bg.Controls[i].Tag == "M" && gbx_bg.Controls[i].Text == "")
                        {
                            MessageBox.Show("Empty text box not allowed!", "Marrraiage Register[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            gbx_bg.Controls[i].Focus();
                            return;
                        }
                    }

                    Obj_Marriage_Reg = new Cls_Marriage_Registration();


                    Obj_Marriage_Reg.Rgn = int.Parse(txt_reg_no.Text);
                    Obj_Marriage_Reg.Grgn = txt_govt_reg_no.Text;
                    Obj_Marriage_Reg.Cno = txt_certificate_no.Text;
                    Obj_Marriage_Reg.Mdate = dtp_date.Text;
                    Obj_Marriage_Reg.Mplace = txt_place.Text;
                    Obj_Marriage_Reg.Mname = txt_mahallu.Text;
                    Obj_Marriage_Reg.Mahar = txt_mahallu.Text;
                    Obj_Marriage_Reg.Mconductor = txt_mdone.Text;
                    Obj_Marriage_Reg.Crcvd = txt_certrcvd.Text;
                    Obj_Marriage_Reg.Secretarary = txt_secretrary.Text;
                    Obj_Marriage_Reg.President = txt_president.Text;
                    Obj_Marriage_Reg.Bcmntid = txt_b_cmntid.Text;
                    Obj_Marriage_Reg.Bname = txt_b_name.Text;
                    Obj_Marriage_Reg.Bcontact = txt_b_number.Text;
                    Obj_Marriage_Reg.Bdob = txt_b_dob.Text;
                    Obj_Marriage_Reg.Bage = txt_b_age.Text;
                    Obj_Marriage_Reg.Bjob = txt_b_occupation.Text;
                    Obj_Marriage_Reg.Bfather = txt_b_father.Text;
                    Obj_Marriage_Reg.Bmother = txt_b_mother.Text;
                    Obj_Marriage_Reg.Bmahallu = txt_b_mahallu.Text;
                    Obj_Marriage_Reg.Bhouse = txt_b_house.Text;
                    Obj_Marriage_Reg.Bpost = txt_b_po.Text;
                    Obj_Marriage_Reg.Bdistrict = txt_b_district.Text;
                    Obj_Marriage_Reg.Bstate = txt_b_state.Text;
                    Obj_Marriage_Reg.Bcountry = txt_b_country.Text;
                    Obj_Marriage_Reg.Bmcount = txt_b_nomrg.Text;
                    Obj_Marriage_Reg.Bmreason = txt_b_reason.Text;

                    Obj_Marriage_Reg.Bphoto = imageToByteArray(pbx_bride.BackgroundImage);
                    Obj_Marriage_Reg.Bwitness1 = txt_b_witness1.Text;
                    Obj_Marriage_Reg.Bwitness2 = txt_b_witness2.Text;
                    Obj_Marriage_Reg.Gcmntid = txt_g_cmntid.Text;
                    Obj_Marriage_Reg.Gname = txt_g_name.Text;
                    Obj_Marriage_Reg.Gcontact = txt_g_number.Text;
                    Obj_Marriage_Reg.Gdob = txt_g_dob.Text;
                    Obj_Marriage_Reg.Gage = txt_g_age.Text;
                    Obj_Marriage_Reg.Gjob = txt_g_occupation.Text;
                    Obj_Marriage_Reg.Gfather = txt_g_father.Text;
                    Obj_Marriage_Reg.Gmother = txt_g_mother.Text;
                    Obj_Marriage_Reg.Gmahallu = txt_g_mahallu.Text;
                    Obj_Marriage_Reg.Ghouse = txt_g_house.Text;
                    Obj_Marriage_Reg.Gpost = txt_g_po.Text;
                    Obj_Marriage_Reg.Gdistrict = txt_g_district.Text;
                    Obj_Marriage_Reg.Gstate = txt_g_state.Text;
                    Obj_Marriage_Reg.Gcountry = txt_g_country.Text;
                    Obj_Marriage_Reg.Gmcount = txt_g_nomrg.Text;
                    Obj_Marriage_Reg.Gmreason = txt_g_reason.Text;

                    Obj_Marriage_Reg.Gphoto = imageToByteArray(pbx_groom.BackgroundImage);

                    Obj_Marriage_Reg.Gwitness1 = txt_g_witness1.Text;
                    Obj_Marriage_Reg.Gwitness2 = txt_g_witness2.Text;
                    Obj_Marriage_Reg.Narration = txt_narration.Text;
                    Obj_Marriage_Reg.Created = DateTime.Today.ToString();
                    Obj_Marriage_Reg.Modified = "";
                    Obj_Marriage_Reg.Deleted = "";
                    Obj_Marriage_Reg.Userid = "ADMIN";
                    Obj_Marriage_Reg.Status = "GOOd";


                }
                else
                {
                    return;
                }
                if (Obj_Marriage_Reg.Marriage_Register_Insert() > 0)
                {
                    MessageBox.Show("Data Saved!", "Marrraiage Register[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Controls_Enable("True");
                    Marriage_Search_By_key(txt_reg_no.Text);
                    dgv_marrage.Enabled = true;
                                        
                }
                else
                {
                    MessageBox.Show("Process Failed!", "Marrraiage Register[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                int result = (int)MessageBox.Show("Make sure that, Data has to be Saved", "Marrraiage Register[MAS]", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == (int)DialogResult.OK)
                {
                    for (int i = 0; i < gbx_marrage.Controls.Count; i++)
                    {
                        if ((string)gbx_marrage.Controls[i].Tag == "M" && gbx_marrage.Controls[i].Text == "")
                        {
                            MessageBox.Show("Empty text box not allowed!", "Marrraiage Register[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            gbx_marrage.Controls[i].Focus();
                            return;
                        }
                    }
                    for (int i = 0; i < gbx_bg.Controls.Count; i++)
                    {
                        if ((string)gbx_bg.Controls[i].Tag == "M" && gbx_bg.Controls[i].Text == "")
                        {
                            MessageBox.Show("Empty text box not allowed!", "Marrraiage Register[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            gbx_bg.Controls[i].Focus();
                            return;
                        }
                    }

                    Obj_Marriage_Reg = new Cls_Marriage_Registration();


                    Obj_Marriage_Reg.Rgn = int.Parse(txt_reg_no.Text);
                    Obj_Marriage_Reg.Grgn = txt_govt_reg_no.Text;
                    Obj_Marriage_Reg.Cno = txt_certificate_no.Text;
                    Obj_Marriage_Reg.Mdate = dtp_date.Text;
                    Obj_Marriage_Reg.Mplace = txt_place.Text;
                    Obj_Marriage_Reg.Mname = txt_mahallu.Text;
                    Obj_Marriage_Reg.Mahar = txt_mahallu.Text;
                    Obj_Marriage_Reg.Mconductor = txt_mdone.Text;
                    Obj_Marriage_Reg.Crcvd = txt_certrcvd.Text;
                    Obj_Marriage_Reg.Secretarary = txt_secretrary.Text;
                    Obj_Marriage_Reg.President = txt_president.Text;
                    Obj_Marriage_Reg.Bcmntid = txt_b_cmntid.Text;
                    Obj_Marriage_Reg.Bname = txt_b_name.Text;
                    Obj_Marriage_Reg.Bcontact = txt_b_number.Text;
                    Obj_Marriage_Reg.Bdob = txt_b_dob.Text;
                    Obj_Marriage_Reg.Bage = txt_b_age.Text;
                    Obj_Marriage_Reg.Bjob = txt_b_occupation.Text;
                    Obj_Marriage_Reg.Bfather = txt_b_father.Text;
                    Obj_Marriage_Reg.Bmother = txt_b_mother.Text;
                    Obj_Marriage_Reg.Bmahallu = txt_b_mahallu.Text;
                    Obj_Marriage_Reg.Bhouse = txt_b_house.Text;
                    Obj_Marriage_Reg.Bpost = txt_b_po.Text;
                    Obj_Marriage_Reg.Bdistrict = txt_b_district.Text;
                    Obj_Marriage_Reg.Bstate = txt_b_state.Text;
                    Obj_Marriage_Reg.Bcountry = txt_b_country.Text;
                    Obj_Marriage_Reg.Bmcount = txt_b_nomrg.Text;
                    Obj_Marriage_Reg.Bmreason = txt_b_reason.Text;

                    Obj_Marriage_Reg.Bphoto = imageToByteArray(pbx_bride.Image);
                    Obj_Marriage_Reg.Bwitness1 = txt_b_witness1.Text;
                    Obj_Marriage_Reg.Bwitness2 = txt_b_witness2.Text;
                    Obj_Marriage_Reg.Gcmntid = txt_g_cmntid.Text;
                    Obj_Marriage_Reg.Gname = txt_g_name.Text;
                    Obj_Marriage_Reg.Gcontact = txt_g_number.Text;
                    Obj_Marriage_Reg.Gdob = txt_g_dob.Text;
                    Obj_Marriage_Reg.Gage = txt_g_age.Text;
                    Obj_Marriage_Reg.Gjob = txt_g_occupation.Text;
                    Obj_Marriage_Reg.Gfather = txt_g_father.Text;
                    Obj_Marriage_Reg.Gmother = txt_g_mother.Text;
                    Obj_Marriage_Reg.Gmahallu = txt_g_mahallu.Text;
                    Obj_Marriage_Reg.Ghouse = txt_g_house.Text;
                    Obj_Marriage_Reg.Gpost = txt_g_po.Text;
                    Obj_Marriage_Reg.Gdistrict = txt_g_district.Text;
                    Obj_Marriage_Reg.Gstate = txt_g_state.Text;
                    Obj_Marriage_Reg.Gcountry = txt_g_country.Text;
                    Obj_Marriage_Reg.Gmcount = txt_g_nomrg.Text;
                    Obj_Marriage_Reg.Gmreason = txt_g_reason.Text;

                    Obj_Marriage_Reg.Gphoto = imageToByteArray(pbx_groom.Image);

                    Obj_Marriage_Reg.Gwitness1 = txt_g_witness1.Text;
                    Obj_Marriage_Reg.Gwitness2 = txt_g_witness2.Text;
                    Obj_Marriage_Reg.Narration = txt_narration.Text;
                    Obj_Marriage_Reg.Created = DateTime.Today.ToString();
                    Obj_Marriage_Reg.Modified = DateTime.Today.ToString();
                    Obj_Marriage_Reg.Deleted = "";
                    Obj_Marriage_Reg.Userid = "ADMIN";
                    Obj_Marriage_Reg.Status = "GOOd";
                }
                else
                {
                    return;
                }
                if (Obj_Marriage_Reg.Marriage_Register_Update() > 0)
                {
                    MessageBox.Show("File Updated!", "Marrraiage Register[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Controls_Enable("True");
                    Marriage_Search_By_key(txt_reg_no.Text);
                    dgv_marrage.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Process Failed!", "Marrraiage Register[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Can not be deleted ", "Marrraiage Register[MAS]", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgv_marrage_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                btn_save.Enabled = false;
                btn_edit.Enabled = false;
                btn_delete.Enabled = false;
                Controls_Enable("True");
                int rowIndex = dgv_marrage.CurrentCell.RowIndex;
                Marriage_Bind_Controls(dgv_marrage.Rows[rowIndex].Cells[0].FormattedValue.ToString());
            }
            catch
            {
            }
        }

        private void dgv_marrage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int rowIndex = dgv_marrage.CurrentCell.RowIndex;
               Marriage_Bind_Controls(dgv_marrage.Rows[rowIndex].Cells[0].FormattedValue.ToString());
                Marriage_Search_By_key(txt_reg_no.Text);
                Controls_Enable("False");
                btn_edit.Enabled = true;
                btn_delete.Enabled = true;

            }
            catch { }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_marrage.Enabled = true;
                Marriage_Search_By_key(txt_search.Text);
            }
            catch
            {
            }
        }

        private void txt_govt_reg_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_certificate_no.Focus();
            }
        }

        private void txt_certificate_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtp_date.Focus();
            }
        }

        private void dtp_date_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_place.Focus();
            }
        }

        private void txt_place_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_mahallu.Focus();
            }
        }

        private void txt_mahallu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_mahar.Focus();
            }
        }

        private void txt_mahar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_mdone.Focus();
            }
        }

        private void txt_mdone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_certrcvd.Focus();
            }
        }

        private void txt_certrcvd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_secretrary.Focus();
            }
        }

        private void txt_secretrary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_president.Focus();
            }
        }

        private void txt_president_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_narration.Focus();
            }
        }

        private void txt_narration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_b_cmntid.Focus();
            }
        }

        private void txt_b_cmntid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_b_name.Focus();
            }
        }

        private void txt_b_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_b_number.Focus();
            }
        }

        private void txt_b_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_b_dob.Focus();
            }
        }

        private void txt_b_dob_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_b_age.Focus();
            }
        }

        private void txt_b_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_b_occupation.Focus();
            }
        }

        private void txt_g_occupation_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_b_father_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_b_mother.Focus();
            }
        }

        private void txt_b_mother_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_b_mahallu.Focus();
            }
        }

        private void txt_b_mahallu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_b_house.Focus();
            }
        }

        private void txt_b_house_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_b_po.Focus();
            }
        }

        private void txt_b_po_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_b_district.Focus();
            }
        }

        private void txt_b_district_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_b_state.Focus();
            }
        }

        private void txt_b_state_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_b_country.Focus();
            }
        }

        private void txt_b_country_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_b_nomrg.Focus();
            }
        }

        private void txt_b_nomrg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_b_reason.Focus();
            }
        }

        private void txt_b_reason_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_b_witness1.Focus();
            }
        }

        private void txt_b_witness1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_b_witness2.Focus();
            }
        }

        private void txt_b_witness2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_g_cmntid.Focus();
            }
        }

        private void txt_g_cmntid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_g_name.Focus();
            }
        }

        private void txt_g_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_g_number.Focus();
            }
        }

        private void txt_g_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_g_dob.Focus();
            }
        }

        private void txt_g_dob_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_g_age.Focus();
            }
        }

        private void txt_g_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_g_occupation.Focus();
            }
        }

        private void txt_b_occupation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_g_father.Focus();
            }
        }

        private void txt_g_father_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_g_mother.Focus();
            }
        }

        private void txt_g_mother_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_g_mahallu.Focus();
            }
        }

        private void txt_g_mahallu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_g_house.Focus();
            }
        }

        private void txt_g_house_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_g_po.Focus();
            }
        }

        private void txt_g_po_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_g_district.Focus();
            }
        }

        private void txt_g_district_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_g_state.Focus();
            }
        }

        private void txt_g_state_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_g_country.Focus();
            }
        }

        private void txt_g_country_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_g_nomrg.Focus();
            }
        }

        private void txt_g_nomrg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_g_reason.Focus();
            }
        }

        private void txt_g_reason_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_g_witness1.Focus();
            }
        }

        private void txt_g_witness1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_g_witness2.Focus();
            }
        }

        private void txt_b_occupation_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_browseG_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "JPEG Image(*jpeg)|*.jpg|Bitmap(*bmp)|*.bmp";
                open.Multiselect = false;
                if (open.ShowDialog(this) != DialogResult.Cancel)
                {
                    pbx_groom.BackgroundImage = Image.FromFile(open.FileName);
                }
            }
            catch
            {
            }
        }

        private void lbl_browseB_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "JPEG Image(*jpeg)|*.jpg|Bitmap(*bmp)|*.bmp";
                open.Multiselect = false;
                if (open.ShowDialog(this) != DialogResult.Cancel)
                {
                    pbx_bride.BackgroundImage = Image.FromFile(open.FileName);
                }
            }
            catch
            {
            }
        }
        private void lbl_cancelG_Click(object sender, EventArgs e)
        {
            pbx_bride.Image = BackgroundImage;
        }

        private void lbl_cancelB_Click(object sender, EventArgs e)
        {
            pbx_groom.Image = BackgroundImage;
        }     

    }
}
