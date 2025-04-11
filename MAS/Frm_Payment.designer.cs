namespace MAS
{
    partial class Frm_Payment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Payment));
            this.c_panel_left = new System.Windows.Forms.Panel();
            this.c_foryear = new System.Windows.Forms.ComboBox();
            this.c_formonth = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.c_px_reference = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.c_account = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.c_invmonth_to = new System.Windows.Forms.ComboBox();
            this.c_invmonth_from = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.c_search_option = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.c_search_value = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.c_pxnumber = new System.Windows.Forms.TextBox();
            this.c_pxmode = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.c_paidto = new System.Windows.Forms.TextBox();
            this.c_pxdate = new System.Windows.Forms.DateTimePicker();
            this.c_pxamount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.c_towards = new System.Windows.Forms.TextBox();
            this.lbl_refranceno = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.c_pxdetails = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_send_mail = new System.Windows.Forms.Button();
            this.c_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.c_panel_top = new System.Windows.Forms.Panel();
            this.c_datagrid_view = new System.Windows.Forms.DataGridView();
            this.c_panel_left.SuspendLayout();
            this.panel2.SuspendLayout();
            this.c_panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_datagrid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // c_panel_left
            // 
            this.c_panel_left.BackColor = System.Drawing.Color.White;
            this.c_panel_left.Controls.Add(this.c_foryear);
            this.c_panel_left.Controls.Add(this.c_formonth);
            this.c_panel_left.Controls.Add(this.label5);
            this.c_panel_left.Controls.Add(this.c_px_reference);
            this.c_panel_left.Controls.Add(this.label2);
            this.c_panel_left.Controls.Add(this.c_account);
            this.c_panel_left.Controls.Add(this.panel2);
            this.c_panel_left.Controls.Add(this.label1);
            this.c_panel_left.Controls.Add(this.label7);
            this.c_panel_left.Controls.Add(this.c_pxnumber);
            this.c_panel_left.Controls.Add(this.c_pxmode);
            this.c_panel_left.Controls.Add(this.label15);
            this.c_panel_left.Controls.Add(this.label14);
            this.c_panel_left.Controls.Add(this.c_paidto);
            this.c_panel_left.Controls.Add(this.c_pxdate);
            this.c_panel_left.Controls.Add(this.c_pxamount);
            this.c_panel_left.Controls.Add(this.label10);
            this.c_panel_left.Controls.Add(this.c_towards);
            this.c_panel_left.Controls.Add(this.lbl_refranceno);
            this.c_panel_left.Controls.Add(this.lbl_date);
            this.c_panel_left.Controls.Add(this.label3);
            this.c_panel_left.Controls.Add(this.label4);
            this.c_panel_left.Controls.Add(this.c_pxdetails);
            this.c_panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.c_panel_left.Location = new System.Drawing.Point(0, 66);
            this.c_panel_left.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_panel_left.Name = "c_panel_left";
            this.c_panel_left.Size = new System.Drawing.Size(424, 663);
            this.c_panel_left.TabIndex = 19;
            this.c_panel_left.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // c_foryear
            // 
            this.c_foryear.FormattingEnabled = true;
            this.c_foryear.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019"});
            this.c_foryear.Location = new System.Drawing.Point(151, 625);
            this.c_foryear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_foryear.Name = "c_foryear";
            this.c_foryear.Size = new System.Drawing.Size(260, 24);
            this.c_foryear.TabIndex = 40;
            this.c_foryear.Tag = "M";
            // 
            // c_formonth
            // 
            this.c_formonth.FormattingEnabled = true;
            this.c_formonth.Items.AddRange(new object[] {
            "JANUARY",
            "FEBRUARY",
            "MARCH",
            "APRIL",
            "MAY",
            "JUNE",
            "JULY",
            "AUGUST",
            "SEPTEMBER",
            "OCTOBER",
            "NOVEMBER",
            "DECEMBER"});
            this.c_formonth.Location = new System.Drawing.Point(151, 592);
            this.c_formonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_formonth.Name = "c_formonth";
            this.c_formonth.Size = new System.Drawing.Size(260, 24);
            this.c_formonth.TabIndex = 39;
            this.c_formonth.Tag = "M";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(52, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "Reference#";
            this.label5.Visible = false;
            // 
            // c_px_reference
            // 
            this.c_px_reference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c_px_reference.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c_px_reference.Enabled = false;
            this.c_px_reference.Location = new System.Drawing.Point(151, 255);
            this.c_px_reference.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_px_reference.Name = "c_px_reference";
            this.c_px_reference.Size = new System.Drawing.Size(262, 22);
            this.c_px_reference.TabIndex = 37;
            this.c_px_reference.Tag = "M";
            this.c_px_reference.Text = "NA";
            this.c_px_reference.Visible = false;
            this.c_px_reference.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(56, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "Account";
            // 
            // c_account
            // 
            this.c_account.FormattingEnabled = true;
            this.c_account.Items.AddRange(new object[] {
            "TATA",
            "TDS",
            "BSNL",
            "AIRTEL",
            "SALLARY",
            "SWEEPER",
            "SERVICE TAX",
            "RR INFOCOM",
            "TECHNOPOWER",
            "TECHNOPARK RENT",
            "BONUS/COMMISSIONS",
            "OFFICE MAINTENANCE",
            "OFFICE EXPENCE/STATIONARY",
            "DNC TECHNO SOLUTIONS PVT LTD",
            "OFFICE EXPENCE/TEA/FOOD/WATER"});
            this.c_account.Location = new System.Drawing.Point(151, 222);
            this.c_account.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_account.Name = "c_account";
            this.c_account.Size = new System.Drawing.Size(260, 24);
            this.c_account.TabIndex = 35;
            this.c_account.Tag = "M";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.c_invmonth_to);
            this.panel2.Controls.Add(this.c_invmonth_from);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.c_search_option);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.c_search_value);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 145);
            this.panel2.TabIndex = 34;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 78);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 17);
            this.label19.TabIndex = 8;
            this.label19.Text = "2014-2015";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(116, 111);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 17);
            this.label18.TabIndex = 7;
            this.label18.Text = "Month To";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(103, 78);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 17);
            this.label17.TabIndex = 6;
            this.label17.Text = "Month From";
            // 
            // c_invmonth_to
            // 
            this.c_invmonth_to.FormattingEnabled = true;
            this.c_invmonth_to.Items.AddRange(new object[] {
            "2014-2015 FINYEAR ONLY",
            "JANUARY",
            "FEBRUARY",
            "MARCH",
            "APRIL",
            "MAY",
            "JUNE",
            "JULY",
            "AUGUST",
            "SEPTEMBER",
            "OCTOBER",
            "NOVEMBER",
            "DECEMBER"});
            this.c_invmonth_to.Location = new System.Drawing.Point(209, 106);
            this.c_invmonth_to.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_invmonth_to.Name = "c_invmonth_to";
            this.c_invmonth_to.Size = new System.Drawing.Size(164, 24);
            this.c_invmonth_to.TabIndex = 5;
            // 
            // c_invmonth_from
            // 
            this.c_invmonth_from.FormattingEnabled = true;
            this.c_invmonth_from.Items.AddRange(new object[] {
            "2014-2015 FINYEAR ONLY",
            "JANUARY",
            "FEBRUARY",
            "MARCH",
            "APRIL",
            "MAY",
            "JUNE",
            "JULY",
            "AUGUST",
            "SEPTEMBER",
            "OCTOBER",
            "NOVEMBER",
            "DECEMBER"});
            this.c_invmonth_from.Location = new System.Drawing.Point(209, 73);
            this.c_invmonth_from.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_invmonth_from.Name = "c_invmonth_from";
            this.c_invmonth_from.Size = new System.Drawing.Size(164, 24);
            this.c_invmonth_from.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 12);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 17);
            this.label16.TabIndex = 3;
            this.label16.Text = "Choose Search By";
            // 
            // c_search_option
            // 
            this.c_search_option.FormattingEnabled = true;
            this.c_search_option.Items.AddRange(new object[] {
            "TRANSACTIONS BY MONTHS",
            "INVOICE BY INVOICENO",
            "INVOICE BY MONTHS",
            "CUSTOMER BY NAME",
            "INVOICE BY ILL ID",
            "CUSTOMER BY ID"});
            this.c_search_option.Location = new System.Drawing.Point(133, 7);
            this.c_search_option.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_search_option.Name = "c_search_option";
            this.c_search_option.Size = new System.Drawing.Size(240, 24);
            this.c_search_option.TabIndex = 2;
            this.c_search_option.SelectedIndexChanged += new System.EventHandler(this.c_search_option_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "CMRID/ILL ID/Invoice No";
            // 
            // c_search_value
            // 
            this.c_search_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c_search_value.Location = new System.Drawing.Point(209, 41);
            this.c_search_value.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_search_value.Name = "c_search_value";
            this.c_search_value.Size = new System.Drawing.Size(165, 22);
            this.c_search_value.TabIndex = 0;
            this.c_search_value.Tag = "M";
            this.c_search_value.TextChanged += new System.EventHandler(this.c_search_value_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Payment Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(35, 412);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Payment Type";
            // 
            // c_pxnumber
            // 
            this.c_pxnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c_pxnumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c_pxnumber.Enabled = false;
            this.c_pxnumber.Location = new System.Drawing.Point(151, 155);
            this.c_pxnumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_pxnumber.Name = "c_pxnumber";
            this.c_pxnumber.Size = new System.Drawing.Size(262, 22);
            this.c_pxnumber.TabIndex = 27;
            this.c_pxnumber.Tag = "M";
            // 
            // c_pxmode
            // 
            this.c_pxmode.FormattingEnabled = true;
            this.c_pxmode.Items.AddRange(new object[] {
            "CHEQUE",
            "CASH",
            "NEFT",
            "DD"});
            this.c_pxmode.Location = new System.Drawing.Point(151, 409);
            this.c_pxmode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_pxmode.Name = "c_pxmode";
            this.c_pxmode.Size = new System.Drawing.Size(260, 24);
            this.c_pxmode.TabIndex = 6;
            this.c_pxmode.Tag = "M";
            this.c_pxmode.Text = "CHEQUE";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(81, 380);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 18);
            this.label15.TabIndex = 22;
            this.label15.Text = "Amount";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(49, 629);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 18);
            this.label14.TabIndex = 20;
            this.label14.Text = "For the Year";
            // 
            // c_paidto
            // 
            this.c_paidto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c_paidto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c_paidto.Location = new System.Drawing.Point(151, 287);
            this.c_paidto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_paidto.Multiline = true;
            this.c_paidto.Name = "c_paidto";
            this.c_paidto.Size = new System.Drawing.Size(261, 73);
            this.c_paidto.TabIndex = 3;
            this.c_paidto.Tag = "M";
            // 
            // c_pxdate
            // 
            this.c_pxdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.c_pxdate.Location = new System.Drawing.Point(151, 187);
            this.c_pxdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_pxdate.Name = "c_pxdate";
            this.c_pxdate.Size = new System.Drawing.Size(261, 22);
            this.c_pxdate.TabIndex = 1;
            this.c_pxdate.Tag = "M";
            // 
            // c_pxamount
            // 
            this.c_pxamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c_pxamount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c_pxamount.Location = new System.Drawing.Point(151, 377);
            this.c_pxamount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_pxamount.Name = "c_pxamount";
            this.c_pxamount.Size = new System.Drawing.Size(261, 22);
            this.c_pxamount.TabIndex = 4;
            this.c_pxamount.Tag = "M";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(72, 314);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Paid To";
            // 
            // c_towards
            // 
            this.c_towards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c_towards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_towards.ForeColor = System.Drawing.Color.Red;
            this.c_towards.Location = new System.Drawing.Point(151, 519);
            this.c_towards.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_towards.Multiline = true;
            this.c_towards.Name = "c_towards";
            this.c_towards.Size = new System.Drawing.Size(259, 65);
            this.c_towards.TabIndex = 5;
            this.c_towards.Tag = "M";
            this.c_towards.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_refranceno
            // 
            this.lbl_refranceno.AutoSize = true;
            this.lbl_refranceno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_refranceno.ForeColor = System.Drawing.Color.Black;
            this.lbl_refranceno.Location = new System.Drawing.Point(29, 594);
            this.lbl_refranceno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_refranceno.Name = "lbl_refranceno";
            this.lbl_refranceno.Size = new System.Drawing.Size(113, 20);
            this.lbl_refranceno.TabIndex = 1;
            this.lbl_refranceno.Text = "For the Month";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.Black;
            this.lbl_date.Location = new System.Drawing.Point(23, 190);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(115, 20);
            this.lbl_date.TabIndex = 2;
            this.lbl_date.Text = "Payment Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(65, 519);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Towards";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 444);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Payment Details";
            // 
            // c_pxdetails
            // 
            this.c_pxdetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c_pxdetails.Location = new System.Drawing.Point(151, 442);
            this.c_pxdetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_pxdetails.Multiline = true;
            this.c_pxdetails.Name = "c_pxdetails";
            this.c_pxdetails.Size = new System.Drawing.Size(259, 70);
            this.c_pxdetails.TabIndex = 7;
            this.c_pxdetails.Tag = "M";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Enabled = false;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(424, 14);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(104, 44);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "&Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Visible = false;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.Enabled = false;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(632, 14);
            this.btn_print.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(104, 44);
            this.btn_print.TabIndex = 3;
            this.btn_print.Text = "&Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Visible = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(320, 14);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(104, 44);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "&Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_send_mail
            // 
            this.btn_send_mail.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_send_mail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_send_mail.Enabled = false;
            this.btn_send_mail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send_mail.ForeColor = System.Drawing.Color.White;
            this.btn_send_mail.Location = new System.Drawing.Point(528, 14);
            this.btn_send_mail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_send_mail.Name = "btn_send_mail";
            this.btn_send_mail.Size = new System.Drawing.Size(104, 44);
            this.btn_send_mail.TabIndex = 33;
            this.btn_send_mail.Text = "Send Mail";
            this.btn_send_mail.UseVisualStyleBackColor = false;
            this.btn_send_mail.Visible = false;
            // 
            // c_save
            // 
            this.c_save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.c_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_save.ForeColor = System.Drawing.Color.White;
            this.c_save.Location = new System.Drawing.Point(112, 14);
            this.c_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_save.Name = "c_save";
            this.c_save.Size = new System.Drawing.Size(104, 44);
            this.c_save.TabIndex = 0;
            this.c_save.Text = "&Save";
            this.c_save.UseVisualStyleBackColor = false;
            this.c_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(216, 14);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(104, 44);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "&Update";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Location = new System.Drawing.Point(8, 14);
            this.btn_new.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(104, 44);
            this.btn_new.TabIndex = 5;
            this.btn_new.Text = "&New";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // c_panel_top
            // 
            this.c_panel_top.BackColor = System.Drawing.Color.White;
            this.c_panel_top.Controls.Add(this.btn_print);
            this.c_panel_top.Controls.Add(this.btn_cancel);
            this.c_panel_top.Controls.Add(this.btn_new);
            this.c_panel_top.Controls.Add(this.btn_send_mail);
            this.c_panel_top.Controls.Add(this.c_save);
            this.c_panel_top.Controls.Add(this.btn_delete);
            this.c_panel_top.Controls.Add(this.btn_update);
            this.c_panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.c_panel_top.Location = new System.Drawing.Point(0, 0);
            this.c_panel_top.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_panel_top.Name = "c_panel_top";
            this.c_panel_top.Size = new System.Drawing.Size(1584, 66);
            this.c_panel_top.TabIndex = 20;
            // 
            // c_datagrid_view
            // 
            this.c_datagrid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.c_datagrid_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_datagrid_view.Location = new System.Drawing.Point(424, 66);
            this.c_datagrid_view.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_datagrid_view.Name = "c_datagrid_view";
            this.c_datagrid_view.Size = new System.Drawing.Size(1160, 663);
            this.c_datagrid_view.TabIndex = 21;
            // 
            // Frm_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 729);
            this.Controls.Add(this.c_datagrid_view);
            this.Controls.Add(this.c_panel_left);
            this.Controls.Add(this.c_panel_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.Frm_Payment_Load);
            this.c_panel_left.ResumeLayout(false);
            this.c_panel_left.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.c_panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c_datagrid_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel c_panel_left;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox c_invmonth_to;
        private System.Windows.Forms.ComboBox c_invmonth_from;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox c_search_option;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox c_search_value;
        private System.Windows.Forms.Button btn_send_mail;
        private System.Windows.Forms.Button c_save;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox c_pxnumber;
        private System.Windows.Forms.ComboBox c_pxmode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox c_paidto;
        private System.Windows.Forms.DateTimePicker c_pxdate;
        private System.Windows.Forms.TextBox c_pxamount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox c_towards;
        private System.Windows.Forms.Label lbl_refranceno;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox c_pxdetails;
        private System.Windows.Forms.Panel c_panel_top;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox c_px_reference;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox c_account;
        private System.Windows.Forms.ComboBox c_formonth;
        private System.Windows.Forms.ComboBox c_foryear;
        private System.Windows.Forms.DataGridView c_datagrid_view;
    }
}