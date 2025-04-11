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
    public partial class Frm_Food : Form
    {
        Cls_Food_Master obj_cls_food_master;
        //
        public void Clear_Controls()
        {
            try
            {
                txt_description.Text = "";
                txt_resi_id.Text = "";
                txt_search.Text = "";
                cbx_breakfast.Checked = false;
                cbx_dinner.Checked = false;
                cbx_lunch.Checked = false;
                cbx_tea.Checked = false;
                
            }
            catch
            {
            }
        }

        public void Food_Select_All()
        {
            try
            {
                DataTable DT = new DataTable();
                obj_cls_food_master = new Cls_Food_Master();
                DT = obj_cls_food_master.Food_Master_Select_All();
                dgv_food.DataSource = DT;
            }
            catch
            {
            }
        }

        public void Food_Select_By_Resi_Id()
        {
            try
            {
                DataTable DT = new DataTable();
                obj_cls_food_master = new Cls_Food_Master();
                DT = obj_cls_food_master.Food_Master_Select_Resi_Id();
                dgv_food.DataSource = DT;
            }
            catch
            {
            }
        }

        public void Food_Select_By_Keys()
        {
            try
            {
                DataTable DT = new DataTable();
                obj_cls_food_master = new Cls_Food_Master();
                DT = obj_cls_food_master.Food_Master_Select_By_Keys();
                dgv_food.DataSource = DT;
            }
            catch
            {
            }
        }
        //
        public Frm_Food()
        {
            InitializeComponent();
        }       

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                obj_cls_food_master = new Cls_Food_Master();
                obj_cls_food_master.Resi_id = Convert.ToInt32(txt_resi_id.Text);
                obj_cls_food_master.Date = dtp_date.Text;
                if (cbx_breakfast.Checked == true)
                {
                    obj_cls_food_master.Breakfast = "YES";
                }
                else
                {
                    obj_cls_food_master.Breakfast = "NO";
                }

                if (cbx_lunch.Checked == true)
                {
                    obj_cls_food_master.Lunch = "YES";
                }
                else
                {
                    obj_cls_food_master.Lunch = "NO";
                }

                if (cbx_tea.Checked == true)
                {
                    obj_cls_food_master.Tea = "YES";
                }
                else
                {
                    obj_cls_food_master.Tea = "NO";
                }

                if (cbx_dinner.Checked == true)
                {
                    obj_cls_food_master.Supper = "YES";
                }
                else
                {
                    obj_cls_food_master.Supper = "NO";
                }

                obj_cls_food_master.Description = txt_description.Text;
                if (obj_cls_food_master.Food_Master_Insert()>0)
                {
                    MessageBox.Show("Data Saved!", "Food [MAS]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_Controls();
                    //Committee_Dgv_Fill();                   
                    
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
                obj_cls_food_master = new Cls_Food_Master();
                obj_cls_food_master.Resi_id = Convert.ToInt32(txt_resi_id.Text);
                obj_cls_food_master.Date = dtp_date.Text;
                if (cbx_breakfast.Checked == true)
                {
                    obj_cls_food_master.Breakfast = "YES";
                }
                else
                {
                    obj_cls_food_master.Breakfast = "NO";
                }

                if (cbx_lunch.Checked == true)
                {
                    obj_cls_food_master.Lunch = "YES";
                }
                else
                {
                    obj_cls_food_master.Lunch = "NO";
                }

                if (cbx_tea.Checked == true)
                {
                    obj_cls_food_master.Tea = "YES";
                }
                else
                {
                    obj_cls_food_master.Tea = "NO";
                }

                if (cbx_dinner.Checked == true)
                {
                    obj_cls_food_master.Supper = "YES";
                }
                else
                {
                    obj_cls_food_master.Supper = "NO";
                }

                obj_cls_food_master.Description = txt_description.Text;
                if (obj_cls_food_master.Food_Master_Update() > 0)
                {
                }

            }
            catch
            {
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                obj_cls_food_master = new Cls_Food_Master();
                obj_cls_food_master.Resi_id = Convert.ToInt32(txt_resi_id.Text);
                if (obj_cls_food_master.Food_Master_Delete() > 0)
                {
                }             

            }
            catch
            {
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Food_Select_All();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {               
                if (rdb_byresi_id.Checked == true)
                {
                    Food_Select_By_Resi_Id();
                }
                else
                {
                    Food_Select_By_Keys();
                }
            }
            catch
            {
            }
        }

        private void txt_resi_id_TextChanged(object sender, EventArgs e)
        {
            Exception X = new Exception();
            TextBox T = (TextBox)sender;
            try
            {
                if (T.Text != "-")
                {
                    int x = int.Parse(T.Text);
                }
            }
            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
                catch (Exception) { }
            }
        }
    }
}
