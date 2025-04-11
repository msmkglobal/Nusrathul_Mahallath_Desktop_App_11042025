namespace MAS
{
    partial class Frm_Credit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Label();
            this.c_rxenddate = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.c_rxstartdate = new System.Windows.Forms.DateTimePicker();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.c_rxkeyword = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.c_rxtype = new System.Windows.Forms.ComboBox();
            this.c_rxmode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.c_rxdescription = new System.Windows.Forms.TextBox();
            this.c_rxdate = new System.Windows.Forms.DateTimePicker();
            this.c_rxdetails = new System.Windows.Forms.TextBox();
            this.c_rxamount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.c_rxno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_credit = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_credit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.c_rxenddate);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.c_rxstartdate);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.c_rxkeyword);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 136);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(775, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "End date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(775, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Start Date";
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(775, 25);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(53, 17);
            this.Search.TabIndex = 9;
            this.Search.Text = "Search";
            // 
            // c_rxenddate
            // 
            this.c_rxenddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.c_rxenddate.Location = new System.Drawing.Point(904, 98);
            this.c_rxenddate.Name = "c_rxenddate";
            this.c_rxenddate.Size = new System.Drawing.Size(183, 22);
            this.c_rxenddate.TabIndex = 8;
            this.c_rxenddate.ValueChanged += new System.EventHandler(this.c_rxenddate_ValueChanged);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_search.Location = new System.Drawing.Point(607, 44);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(98, 39);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_delete.Location = new System.Drawing.Point(385, 44);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(105, 39);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // c_rxstartdate
            // 
            this.c_rxstartdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.c_rxstartdate.Location = new System.Drawing.Point(904, 60);
            this.c_rxstartdate.Name = "c_rxstartdate";
            this.c_rxstartdate.Size = new System.Drawing.Size(183, 22);
            this.c_rxstartdate.TabIndex = 7;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_cancel.Location = new System.Drawing.Point(496, 43);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(103, 40);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_edit.Location = new System.Drawing.Point(278, 44);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(101, 40);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Update";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // c_rxkeyword
            // 
            this.c_rxkeyword.Location = new System.Drawing.Point(904, 21);
            this.c_rxkeyword.Name = "c_rxkeyword";
            this.c_rxkeyword.Size = new System.Drawing.Size(183, 22);
            this.c_rxkeyword.TabIndex = 6;
            this.c_rxkeyword.TextChanged += new System.EventHandler(this.c_rxkeyword_TextChanged);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_save.Location = new System.Drawing.Point(168, 43);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(104, 40);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_new.Location = new System.Drawing.Point(60, 43);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(97, 39);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.c_rxtype);
            this.panel2.Controls.Add(this.c_rxmode);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.c_rxdescription);
            this.panel2.Controls.Add(this.c_rxdate);
            this.panel2.Controls.Add(this.c_rxdetails);
            this.panel2.Controls.Add(this.c_rxamount);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.c_rxno);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1194, 194);
            this.panel2.TabIndex = 1;
            // 
            // c_rxtype
            // 
            this.c_rxtype.FormattingEnabled = true;
            this.c_rxtype.Items.AddRange(new object[] {
            "USTHAD FEE",
            "MONTHLY FEE",
            "EID",
            "BUCKET COLLECTION",
            "COLLECTIONS",
            "AUCTION",
            "AGRICULTURE",
            "OTHERS"});
            this.c_rxtype.Location = new System.Drawing.Point(190, 125);
            this.c_rxtype.Name = "c_rxtype";
            this.c_rxtype.Size = new System.Drawing.Size(171, 24);
            this.c_rxtype.TabIndex = 17;
            // 
            // c_rxmode
            // 
            this.c_rxmode.FormattingEnabled = true;
            this.c_rxmode.Items.AddRange(new object[] {
            "CHEQUE",
            "CASH",
            "NEFT",
            "DD"});
            this.c_rxmode.Location = new System.Drawing.Point(853, 32);
            this.c_rxmode.Name = "c_rxmode";
            this.c_rxmode.Size = new System.Drawing.Size(186, 24);
            this.c_rxmode.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(725, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(725, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Receipt Mode";
            // 
            // c_rxdescription
            // 
            this.c_rxdescription.Location = new System.Drawing.Point(853, 77);
            this.c_rxdescription.Multiline = true;
            this.c_rxdescription.Name = "c_rxdescription";
            this.c_rxdescription.Size = new System.Drawing.Size(186, 74);
            this.c_rxdescription.TabIndex = 13;
            // 
            // c_rxdate
            // 
            this.c_rxdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.c_rxdate.Location = new System.Drawing.Point(190, 32);
            this.c_rxdate.Name = "c_rxdate";
            this.c_rxdate.Size = new System.Drawing.Size(171, 22);
            this.c_rxdate.TabIndex = 12;
            // 
            // c_rxdetails
            // 
            this.c_rxdetails.Location = new System.Drawing.Point(531, 77);
            this.c_rxdetails.Multiline = true;
            this.c_rxdetails.Name = "c_rxdetails";
            this.c_rxdetails.Size = new System.Drawing.Size(174, 74);
            this.c_rxdetails.TabIndex = 10;
            // 
            // c_rxamount
            // 
            this.c_rxamount.Location = new System.Drawing.Point(531, 32);
            this.c_rxamount.Name = "c_rxamount";
            this.c_rxamount.Size = new System.Drawing.Size(174, 22);
            this.c_rxamount.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Receipt Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amount";
            // 
            // c_rxno
            // 
            this.c_rxno.Location = new System.Drawing.Point(190, 77);
            this.c_rxno.Name = "c_rxno";
            this.c_rxno.Size = new System.Drawing.Size(171, 22);
            this.c_rxno.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Receipt Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Receipt Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // dgv_credit
            // 
            this.dgv_credit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_credit.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_credit.Location = new System.Drawing.Point(0, 330);
            this.dgv_credit.Name = "dgv_credit";
            this.dgv_credit.RowTemplate.Height = 24;
            this.dgv_credit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_credit.Size = new System.Drawing.Size(1194, 150);
            this.dgv_credit.TabIndex = 2;
            this.dgv_credit.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_credit_MouseDoubleClick);
            // 
            // Frm_Credit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 487);
            this.Controls.Add(this.dgv_credit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Credit";
            this.Text = "Credit";
            this.Load += new System.EventHandler(this.Frm_Credit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_credit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker c_rxdate;
        private System.Windows.Forms.TextBox c_rxdetails;
        private System.Windows.Forms.TextBox c_rxamount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox c_rxno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker c_rxenddate;
        private System.Windows.Forms.DateTimePicker c_rxstartdate;
        private System.Windows.Forms.TextBox c_rxkeyword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox c_rxdescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox c_rxtype;
        private System.Windows.Forms.ComboBox c_rxmode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.DataGridView dgv_credit;
    }
}