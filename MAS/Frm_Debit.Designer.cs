namespace MAS
{
    partial class Frm_Debit
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
            this.label8 = new System.Windows.Forms.Label();
            this.c_pxkeyword = new System.Windows.Forms.TextBox();
            this.c_pxstartdate = new System.Windows.Forms.DateTimePicker();
            this.c_pxenddate = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.c_pxmode = new System.Windows.Forms.ComboBox();
            this.c_pxtype = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.c_pxdescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.c_pxdetails = new System.Windows.Forms.TextBox();
            this.c_pxamount = new System.Windows.Forms.TextBox();
            this.c_pxno = new System.Windows.Forms.TextBox();
            this.c_pxdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_debit = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_debit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.c_pxkeyword);
            this.panel1.Controls.Add(this.c_pxstartdate);
            this.panel1.Controls.Add(this.c_pxenddate);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 133);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(777, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "end Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(777, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Start  Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(777, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Search";
            // 
            // c_pxkeyword
            // 
            this.c_pxkeyword.Location = new System.Drawing.Point(878, 30);
            this.c_pxkeyword.Name = "c_pxkeyword";
            this.c_pxkeyword.Size = new System.Drawing.Size(156, 22);
            this.c_pxkeyword.TabIndex = 8;
            this.c_pxkeyword.TextChanged += new System.EventHandler(this.c_pxkeyword_TextChanged);
            // 
            // c_pxstartdate
            // 
            this.c_pxstartdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.c_pxstartdate.Location = new System.Drawing.Point(878, 58);
            this.c_pxstartdate.Name = "c_pxstartdate";
            this.c_pxstartdate.Size = new System.Drawing.Size(156, 22);
            this.c_pxstartdate.TabIndex = 7;
            // 
            // c_pxenddate
            // 
            this.c_pxenddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.c_pxenddate.Location = new System.Drawing.Point(878, 96);
            this.c_pxenddate.Name = "c_pxenddate";
            this.c_pxenddate.Size = new System.Drawing.Size(156, 22);
            this.c_pxenddate.TabIndex = 6;
            this.c_pxenddate.ValueChanged += new System.EventHandler(this.c_pxenddate_ValueChanged);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_search.Location = new System.Drawing.Point(602, 40);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(102, 38);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancel.Location = new System.Drawing.Point(484, 40);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(112, 40);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_delete.Location = new System.Drawing.Point(382, 40);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(96, 39);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_edit.Location = new System.Drawing.Point(275, 40);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(101, 40);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Update";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_save.Location = new System.Drawing.Point(163, 40);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(106, 39);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_new.Location = new System.Drawing.Point(47, 40);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(110, 39);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.c_pxmode);
            this.panel2.Controls.Add(this.c_pxtype);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.c_pxdescription);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.c_pxdetails);
            this.panel2.Controls.Add(this.c_pxamount);
            this.panel2.Controls.Add(this.c_pxno);
            this.panel2.Controls.Add(this.c_pxdate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1113, 171);
            this.panel2.TabIndex = 1;
            // 
            // c_pxmode
            // 
            this.c_pxmode.FormattingEnabled = true;
            this.c_pxmode.Items.AddRange(new object[] {
            "CHEQUE",
            "CASH",
            "NEFT",
            "DD"});
            this.c_pxmode.Location = new System.Drawing.Point(805, 28);
            this.c_pxmode.Name = "c_pxmode";
            this.c_pxmode.Size = new System.Drawing.Size(161, 24);
            this.c_pxmode.TabIndex = 15;
            // 
            // c_pxtype
            // 
            this.c_pxtype.FormattingEnabled = true;
            this.c_pxtype.Items.AddRange(new object[] {
            "SALARY",
            "ELECTRICITY CHARGE",
            "TEL-PHONE CHARGE",
            "CONSTRUCTION",
            "WAKF BOARD",
            "OTHERS"});
            this.c_pxtype.Location = new System.Drawing.Point(163, 121);
            this.c_pxtype.Name = "c_pxtype";
            this.c_pxtype.Size = new System.Drawing.Size(158, 24);
            this.c_pxtype.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(667, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Payment Mode";
            // 
            // c_pxdescription
            // 
            this.c_pxdescription.Location = new System.Drawing.Point(805, 82);
            this.c_pxdescription.Multiline = true;
            this.c_pxdescription.Name = "c_pxdescription";
            this.c_pxdescription.Size = new System.Drawing.Size(161, 65);
            this.c_pxdescription.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(667, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Description";
            // 
            // c_pxdetails
            // 
            this.c_pxdetails.Location = new System.Drawing.Point(484, 76);
            this.c_pxdetails.Multiline = true;
            this.c_pxdetails.Name = "c_pxdetails";
            this.c_pxdetails.Size = new System.Drawing.Size(155, 71);
            this.c_pxdetails.TabIndex = 9;
            // 
            // c_pxamount
            // 
            this.c_pxamount.Location = new System.Drawing.Point(484, 23);
            this.c_pxamount.Name = "c_pxamount";
            this.c_pxamount.Size = new System.Drawing.Size(155, 22);
            this.c_pxamount.TabIndex = 8;
            // 
            // c_pxno
            // 
            this.c_pxno.Location = new System.Drawing.Point(163, 79);
            this.c_pxno.Name = "c_pxno";
            this.c_pxno.Size = new System.Drawing.Size(158, 22);
            this.c_pxno.TabIndex = 6;
            // 
            // c_pxdate
            // 
            this.c_pxdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.c_pxdate.Location = new System.Drawing.Point(163, 23);
            this.c_pxdate.Name = "c_pxdate";
            this.c_pxdate.Size = new System.Drawing.Size(158, 22);
            this.c_pxdate.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Payment Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Payment Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payment Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Date";
            // 
            // dgv_debit
            // 
            this.dgv_debit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_debit.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_debit.Location = new System.Drawing.Point(0, 304);
            this.dgv_debit.Name = "dgv_debit";
            this.dgv_debit.RowTemplate.Height = 24;
            this.dgv_debit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_debit.Size = new System.Drawing.Size(1113, 186);
            this.dgv_debit.TabIndex = 2;
            this.dgv_debit.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_debit_MouseDoubleClick);
            // 
            // Frm_Debit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 489);
            this.Controls.Add(this.dgv_debit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Debit";
            this.Text = "Debit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_debit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox c_pxkeyword;
        private System.Windows.Forms.DateTimePicker c_pxstartdate;
        private System.Windows.Forms.DateTimePicker c_pxenddate;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox c_pxdetails;
        private System.Windows.Forms.TextBox c_pxamount;
        private System.Windows.Forms.TextBox c_pxno;
        private System.Windows.Forms.DateTimePicker c_pxdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox c_pxdescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox c_pxmode;
        private System.Windows.Forms.ComboBox c_pxtype;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_debit;
    }
}