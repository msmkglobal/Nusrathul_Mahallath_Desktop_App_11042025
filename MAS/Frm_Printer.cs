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
    public partial class Frm_Printer : Form
    {
        DataTable Dt_Print = new DataTable();
        string Pcode = null;

        public Frm_Printer(DataTable DT,string Print_Code)
        {
            InitializeComponent();
            Dt_Print = DT;
            Pcode = Print_Code;            
        }

        private void Frm_Printer_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Pcode)
                {
                    case "P2P3":
                        {
                            Crv_Passbook_Frontpage_Print Obj_Crv_Passbook_Frontpage_Print = new Crv_Passbook_Frontpage_Print();
                            Crv_Printer.Refresh();
                            Obj_Crv_Passbook_Frontpage_Print.SetDataSource(Dt_Print);
                            Crv_Printer.ReportSource = Obj_Crv_Passbook_Frontpage_Print;                           
                        }
                        break;

                    case "P4P5":
                        {
                            Crv_Passbook_Community_Print Obj_Crv_Pb_Community_Print = new Crv_Passbook_Community_Print();
                            Obj_Crv_Pb_Community_Print.SetDataSource(Dt_Print);
                            Crv_Printer.ReportSource = Obj_Crv_Pb_Community_Print;
                        }
                        break;

                    case "P6P7":
                        {
                            //DataTable DT_RESIDENCE_ACCOUNT_PRINT = new DataTable();for single row print
                            //DT_RESIDENCE_ACCOUNT_PRINT.Columns.Add("RECEIPTNO", typeof(string));
                            //DT_RESIDENCE_ACCOUNT_PRINT.Columns.Add("RECEIPTDATE", typeof(string));
                            //DT_RESIDENCE_ACCOUNT_PRINT.Columns.Add("RECEIPTREFNO", typeof(string));
                            //DT_RESIDENCE_ACCOUNT_PRINT.Columns.Add("RECEIPTRID", typeof(string));
                            //DT_RESIDENCE_ACCOUNT_PRINT.Columns.Add("FINYEAR", typeof(string));
                            //DT_RESIDENCE_ACCOUNT_PRINT.Columns.Add("RECEIPTYEAR", typeof(string));
                            //DT_RESIDENCE_ACCOUNT_PRINT.Columns.Add("RECEIPTMONTH", typeof(string));
                            //DT_RESIDENCE_ACCOUNT_PRINT.Columns.Add("MONTHLYAMNT", typeof(string));
                            //DT_RESIDENCE_ACCOUNT_PRINT.Columns.Add("USTHADAMNT", typeof(string));
                            //DT_RESIDENCE_ACCOUNT_PRINT.Columns.Add("EID1AMNT", typeof(string));
                            //DT_RESIDENCE_ACCOUNT_PRINT.Columns.Add("EID2AMNT", typeof(string));
                            //DT_RESIDENCE_ACCOUNT_PRINT.Columns.Add("FOODAMNT", typeof(string));
                            //DT_RESIDENCE_ACCOUNT_PRINT.Columns.Add("STATUS", typeof(string));
                            //DT_RESIDENCE_ACCOUNT_PRINT.Rows.Add();                          

                            //for (int _rowcount = 0; _rowcount <= Dt_Print.Rows.Count; _rowcount++)
                            //{                                
                            //    DT_RESIDENCE_ACCOUNT_PRINT.Rows[0]["RECEIPTDATE"] = Dt_Print.Rows[_rowcount]["RECEIPTDATE"].ToString();
                            //    DT_RESIDENCE_ACCOUNT_PRINT.Rows[0]["RECEIPTREFNO"] = Dt_Print.Rows[_rowcount]["RECEIPTREFNO"].ToString();
                            //    if (Dt_Print.Rows[_rowcount]["RECEIPTACCOUNT"].ToString() == "MONTHLYFEE")
                            //    {

                            //    }
                            //}
                            Crv_Residence_Account_Transaction_Print Obj_Residence_Account_Print = new Crv_Residence_Account_Transaction_Print();
                            Obj_Residence_Account_Print.SetDataSource(Dt_Print);
                            Crv_Printer.ReportSource = Obj_Residence_Account_Print;                           
                        }
                        break;

                     case "P6P7_Headder":
                        {
                            Crv_Residence_Account_Headding_Print Obj_Pageheadding_P6P7 = new Crv_Residence_Account_Headding_Print();
                            //Obj_Crv_Account_Transaction_Pageheadder.SetDataSource(Dt_Print);
                            Crv_Printer.ReportSource = Obj_Pageheadding_P6P7;                           
                        }
                        break;

                    case "ELECTION_LIST":
                        {
                            Crv_Community_Election_List_Print Obj_Election_List = new Crv_Community_Election_List_Print();
                            Obj_Election_List.SetDataSource(Dt_Print);
                            Crv_Printer.ReportSource = Obj_Election_List; 
                        }
                        break;
                }                               
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
            }
        }
    }
}
