namespace MAS
{
    partial class Frm_Passbook_Print
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
            this.c_panel_menu = new System.Windows.Forms.Panel();
            this.c_transaction_header = new System.Windows.Forms.Button();
            this.c_p6p7 = new System.Windows.Forms.Button();
            this.c_print_pb_fpage = new System.Windows.Forms.Button();
            this.c_p4p5 = new System.Windows.Forms.Button();
            this.c_panel_controls = new System.Windows.Forms.Panel();
            this.c_subscription_list = new System.Windows.Forms.RadioButton();
            this.c_cmnty_list = new System.Windows.Forms.RadioButton();
            this.c_panel_residence = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.c_receipt_refno = new System.Windows.Forms.TextBox();
            this.c_print_settings = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.c_cmnty_print_order = new System.Windows.Forms.TextBox();
            this.c_no = new System.Windows.Forms.RadioButton();
            this.c_printed = new System.Windows.Forms.Label();
            this.c_yes = new System.Windows.Forms.RadioButton();
            this.c_search_text = new System.Windows.Forms.Label();
            this.c_mobile = new System.Windows.Forms.Label();
            this.c_search_by_rid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.c_rname = new System.Windows.Forms.Label();
            this.c_rowner = new System.Windows.Forms.Label();
            this.c_rid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.c_dgv_pb_print = new System.Windows.Forms.DataGridView();
            this.c_panel_menu.SuspendLayout();
            this.c_panel_controls.SuspendLayout();
            this.c_panel_residence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_dgv_pb_print)).BeginInit();
            this.SuspendLayout();
            // 
            // c_panel_menu
            // 
            this.c_panel_menu.BackColor = System.Drawing.Color.White;
            this.c_panel_menu.Controls.Add(this.c_transaction_header);
            this.c_panel_menu.Controls.Add(this.c_p6p7);
            this.c_panel_menu.Controls.Add(this.c_print_pb_fpage);
            this.c_panel_menu.Controls.Add(this.c_p4p5);
            this.c_panel_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_panel_menu.Location = new System.Drawing.Point(0, 0);
            this.c_panel_menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_panel_menu.Name = "c_panel_menu";
            this.c_panel_menu.Size = new System.Drawing.Size(1499, 74);
            this.c_panel_menu.TabIndex = 0;
            // 
            // c_transaction_header
            // 
            this.c_transaction_header.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.c_transaction_header.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c_transaction_header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_transaction_header.ForeColor = System.Drawing.Color.White;
            this.c_transaction_header.Location = new System.Drawing.Point(464, 14);
            this.c_transaction_header.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_transaction_header.Name = "c_transaction_header";
            this.c_transaction_header.Size = new System.Drawing.Size(172, 39);
            this.c_transaction_header.TabIndex = 3;
            this.c_transaction_header.Text = "Print Page 6,7 Headder";
            this.c_transaction_header.UseVisualStyleBackColor = false;
            this.c_transaction_header.Click += new System.EventHandler(this.c_transaction_header_Click);
            // 
            // c_p6p7
            // 
            this.c_p6p7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.c_p6p7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c_p6p7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_p6p7.ForeColor = System.Drawing.Color.White;
            this.c_p6p7.Location = new System.Drawing.Point(316, 14);
            this.c_p6p7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_p6p7.Name = "c_p6p7";
            this.c_p6p7.Size = new System.Drawing.Size(140, 39);
            this.c_p6p7.TabIndex = 2;
            this.c_p6p7.Text = "Print Page 6,7";
            this.c_p6p7.UseVisualStyleBackColor = false;
            this.c_p6p7.Click += new System.EventHandler(this.c_p6p7_Click);
            // 
            // c_print_pb_fpage
            // 
            this.c_print_pb_fpage.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.c_print_pb_fpage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c_print_pb_fpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_print_pb_fpage.ForeColor = System.Drawing.Color.White;
            this.c_print_pb_fpage.Location = new System.Drawing.Point(17, 14);
            this.c_print_pb_fpage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_print_pb_fpage.Name = "c_print_pb_fpage";
            this.c_print_pb_fpage.Size = new System.Drawing.Size(140, 39);
            this.c_print_pb_fpage.TabIndex = 0;
            this.c_print_pb_fpage.Text = "Print Page 2,3";
            this.c_print_pb_fpage.UseVisualStyleBackColor = false;
            this.c_print_pb_fpage.Click += new System.EventHandler(this.c_print_pb_fpage_Click);
            // 
            // c_p4p5
            // 
            this.c_p4p5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.c_p4p5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c_p4p5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_p4p5.ForeColor = System.Drawing.Color.White;
            this.c_p4p5.Location = new System.Drawing.Point(168, 14);
            this.c_p4p5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_p4p5.Name = "c_p4p5";
            this.c_p4p5.Size = new System.Drawing.Size(140, 39);
            this.c_p4p5.TabIndex = 1;
            this.c_p4p5.Text = "Print Page 4,5";
            this.c_p4p5.UseVisualStyleBackColor = false;
            this.c_p4p5.Click += new System.EventHandler(this.c_p4p5_Click);
            // 
            // c_panel_controls
            // 
            this.c_panel_controls.BackColor = System.Drawing.Color.White;
            this.c_panel_controls.Controls.Add(this.c_subscription_list);
            this.c_panel_controls.Controls.Add(this.c_cmnty_list);
            this.c_panel_controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.c_panel_controls.Location = new System.Drawing.Point(0, 288);
            this.c_panel_controls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_panel_controls.Name = "c_panel_controls";
            this.c_panel_controls.Size = new System.Drawing.Size(1499, 73);
            this.c_panel_controls.TabIndex = 1;
            // 
            // c_subscription_list
            // 
            this.c_subscription_list.AutoSize = true;
            this.c_subscription_list.Location = new System.Drawing.Point(171, 25);
            this.c_subscription_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_subscription_list.Name = "c_subscription_list";
            this.c_subscription_list.Size = new System.Drawing.Size(102, 20);
            this.c_subscription_list.TabIndex = 17;
            this.c_subscription_list.Text = "Subscription";
            this.c_subscription_list.UseVisualStyleBackColor = true;
            this.c_subscription_list.CheckedChanged += new System.EventHandler(this.c_subscription_list_CheckedChanged);
            // 
            // c_cmnty_list
            // 
            this.c_cmnty_list.AutoSize = true;
            this.c_cmnty_list.Checked = true;
            this.c_cmnty_list.Location = new System.Drawing.Point(23, 25);
            this.c_cmnty_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_cmnty_list.Name = "c_cmnty_list";
            this.c_cmnty_list.Size = new System.Drawing.Size(128, 20);
            this.c_cmnty_list.TabIndex = 16;
            this.c_cmnty_list.TabStop = true;
            this.c_cmnty_list.Text = "Family Members";
            this.c_cmnty_list.UseVisualStyleBackColor = true;
            this.c_cmnty_list.CheckedChanged += new System.EventHandler(this.c_cmnty_list_CheckedChanged);
            // 
            // c_panel_residence
            // 
            this.c_panel_residence.Controls.Add(this.label6);
            this.c_panel_residence.Controls.Add(this.c_receipt_refno);
            this.c_panel_residence.Controls.Add(this.c_print_settings);
            this.c_panel_residence.Controls.Add(this.label4);
            this.c_panel_residence.Controls.Add(this.c_cmnty_print_order);
            this.c_panel_residence.Controls.Add(this.c_no);
            this.c_panel_residence.Controls.Add(this.c_printed);
            this.c_panel_residence.Controls.Add(this.c_yes);
            this.c_panel_residence.Controls.Add(this.c_search_text);
            this.c_panel_residence.Controls.Add(this.c_mobile);
            this.c_panel_residence.Controls.Add(this.c_search_by_rid);
            this.c_panel_residence.Controls.Add(this.label5);
            this.c_panel_residence.Controls.Add(this.c_rname);
            this.c_panel_residence.Controls.Add(this.c_rowner);
            this.c_panel_residence.Controls.Add(this.c_rid);
            this.c_panel_residence.Controls.Add(this.label3);
            this.c_panel_residence.Controls.Add(this.label2);
            this.c_panel_residence.Controls.Add(this.label1);
            this.c_panel_residence.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.c_panel_residence.Location = new System.Drawing.Point(0, 74);
            this.c_panel_residence.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_panel_residence.Name = "c_panel_residence";
            this.c_panel_residence.Size = new System.Drawing.Size(1499, 214);
            this.c_panel_residence.TabIndex = 1;
            this.c_panel_residence.Paint += new System.Windows.Forms.PaintEventHandler(this.c_panel_residence_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1171, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Receipt REFNO";
            // 
            // c_receipt_refno
            // 
            this.c_receipt_refno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c_receipt_refno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c_receipt_refno.Enabled = false;
            this.c_receipt_refno.Location = new System.Drawing.Point(1295, 76);
            this.c_receipt_refno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_receipt_refno.Name = "c_receipt_refno";
            this.c_receipt_refno.Size = new System.Drawing.Size(187, 22);
            this.c_receipt_refno.TabIndex = 17;
            this.c_receipt_refno.TextChanged += new System.EventHandler(this.c_receipt_refno_TextChanged);
            // 
            // c_print_settings
            // 
            this.c_print_settings.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.c_print_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c_print_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_print_settings.ForeColor = System.Drawing.Color.White;
            this.c_print_settings.Location = new System.Drawing.Point(1295, 142);
            this.c_print_settings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_print_settings.Name = "c_print_settings";
            this.c_print_settings.Size = new System.Drawing.Size(188, 44);
            this.c_print_settings.TabIndex = 16;
            this.c_print_settings.Text = "Apply Print Settings";
            this.c_print_settings.UseVisualStyleBackColor = false;
            this.c_print_settings.Click += new System.EventHandler(this.c_print_settings_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1164, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Family Print Order";
            // 
            // c_cmnty_print_order
            // 
            this.c_cmnty_print_order.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c_cmnty_print_order.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c_cmnty_print_order.Location = new System.Drawing.Point(1295, 41);
            this.c_cmnty_print_order.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_cmnty_print_order.Name = "c_cmnty_print_order";
            this.c_cmnty_print_order.Size = new System.Drawing.Size(187, 22);
            this.c_cmnty_print_order.TabIndex = 14;
            this.c_cmnty_print_order.TextChanged += new System.EventHandler(this.c_cmnty_print_order_TextChanged);
            // 
            // c_no
            // 
            this.c_no.AutoSize = true;
            this.c_no.Location = new System.Drawing.Point(1373, 113);
            this.c_no.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_no.Name = "c_no";
            this.c_no.Size = new System.Drawing.Size(48, 20);
            this.c_no.TabIndex = 13;
            this.c_no.TabStop = true;
            this.c_no.Text = "NO";
            this.c_no.UseVisualStyleBackColor = true;
            // 
            // c_printed
            // 
            this.c_printed.AutoSize = true;
            this.c_printed.Location = new System.Drawing.Point(1157, 116);
            this.c_printed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.c_printed.Name = "c_printed";
            this.c_printed.Size = new System.Drawing.Size(117, 16);
            this.c_printed.TabIndex = 12;
            this.c_printed.Text = "Update Printed To";
            // 
            // c_yes
            // 
            this.c_yes.AutoSize = true;
            this.c_yes.Location = new System.Drawing.Point(1295, 113);
            this.c_yes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_yes.Name = "c_yes";
            this.c_yes.Size = new System.Drawing.Size(55, 20);
            this.c_yes.TabIndex = 11;
            this.c_yes.TabStop = true;
            this.c_yes.Text = "YES";
            this.c_yes.UseVisualStyleBackColor = true;
            this.c_yes.CheckedChanged += new System.EventHandler(this.c_yes_CheckedChanged);
            this.c_yes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.c_yes_MouseClick);
            // 
            // c_search_text
            // 
            this.c_search_text.AutoSize = true;
            this.c_search_text.Location = new System.Drawing.Point(1164, 14);
            this.c_search_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.c_search_text.Name = "c_search_text";
            this.c_search_text.Size = new System.Drawing.Size(107, 16);
            this.c_search_text.TabIndex = 10;
            this.c_search_text.Text = "Search RID/JNO";
            // 
            // c_mobile
            // 
            this.c_mobile.AutoSize = true;
            this.c_mobile.Location = new System.Drawing.Point(113, 85);
            this.c_mobile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.c_mobile.Name = "c_mobile";
            this.c_mobile.Size = new System.Drawing.Size(44, 16);
            this.c_mobile.TabIndex = 9;
            this.c_mobile.Text = "label6";
            // 
            // c_search_by_rid
            // 
            this.c_search_by_rid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c_search_by_rid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c_search_by_rid.Location = new System.Drawing.Point(1295, 9);
            this.c_search_by_rid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_search_by_rid.Name = "c_search_by_rid";
            this.c_search_by_rid.Size = new System.Drawing.Size(187, 22);
            this.c_search_by_rid.TabIndex = 0;
            this.c_search_by_rid.TextChanged += new System.EventHandler(this.c_search_by_key_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mobile:";
            // 
            // c_rname
            // 
            this.c_rname.AutoSize = true;
            this.c_rname.Location = new System.Drawing.Point(113, 34);
            this.c_rname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.c_rname.Name = "c_rname";
            this.c_rname.Size = new System.Drawing.Size(44, 16);
            this.c_rname.TabIndex = 6;
            this.c_rname.Text = "label7";
            // 
            // c_rowner
            // 
            this.c_rowner.AutoSize = true;
            this.c_rowner.Location = new System.Drawing.Point(113, 60);
            this.c_rowner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.c_rowner.Name = "c_rowner";
            this.c_rowner.Size = new System.Drawing.Size(44, 16);
            this.c_rowner.TabIndex = 5;
            this.c_rowner.Text = "label6";
            // 
            // c_rid
            // 
            this.c_rid.AutoSize = true;
            this.c_rid.Location = new System.Drawing.Point(113, 9);
            this.c_rid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.c_rid.Name = "c_rid";
            this.c_rid.Size = new System.Drawing.Size(44, 16);
            this.c_rid.TabIndex = 4;
            this.c_rid.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "House Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guardian:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "RID/JNO :";
            // 
            // c_dgv_pb_print
            // 
            this.c_dgv_pb_print.AllowDrop = true;
            this.c_dgv_pb_print.AllowUserToAddRows = false;
            this.c_dgv_pb_print.AllowUserToDeleteRows = false;
            this.c_dgv_pb_print.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.c_dgv_pb_print.BackgroundColor = System.Drawing.Color.White;
            this.c_dgv_pb_print.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.c_dgv_pb_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c_dgv_pb_print.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.c_dgv_pb_print.Location = new System.Drawing.Point(0, 361);
            this.c_dgv_pb_print.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_dgv_pb_print.Name = "c_dgv_pb_print";
            this.c_dgv_pb_print.ReadOnly = true;
            this.c_dgv_pb_print.RowHeadersWidth = 51;
            this.c_dgv_pb_print.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.c_dgv_pb_print.Size = new System.Drawing.Size(1499, 361);
            this.c_dgv_pb_print.TabIndex = 2;
            this.c_dgv_pb_print.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.c_dgv_pb_print_CellClick);
            this.c_dgv_pb_print.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.c_dgv_pb_print_CellContentClick);
            // 
            // Frm_Passbook_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 722);
            this.Controls.Add(this.c_panel_menu);
            this.Controls.Add(this.c_panel_residence);
            this.Controls.Add(this.c_panel_controls);
            this.Controls.Add(this.c_dgv_pb_print);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Frm_Passbook_Print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passbook Print Console";
            this.Load += new System.EventHandler(this.Frm_Passbook_Print_Load);
            this.c_panel_menu.ResumeLayout(false);
            this.c_panel_controls.ResumeLayout(false);
            this.c_panel_controls.PerformLayout();
            this.c_panel_residence.ResumeLayout(false);
            this.c_panel_residence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_dgv_pb_print)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel c_panel_menu;
        private System.Windows.Forms.Panel c_panel_controls;
        private System.Windows.Forms.DataGridView c_dgv_pb_print;
        private System.Windows.Forms.Button c_print_pb_fpage;
        private System.Windows.Forms.TextBox c_search_by_rid;
        private System.Windows.Forms.Button c_p4p5;
        private System.Windows.Forms.Panel c_panel_residence;
        private System.Windows.Forms.Label c_rowner;
        private System.Windows.Forms.Label c_rid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label c_rname;
        private System.Windows.Forms.Label c_mobile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button c_p6p7;
        private System.Windows.Forms.Button c_transaction_header;
        private System.Windows.Forms.Label c_search_text;
        private System.Windows.Forms.RadioButton c_no;
        private System.Windows.Forms.Label c_printed;
        private System.Windows.Forms.RadioButton c_yes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox c_cmnty_print_order;
        private System.Windows.Forms.Button c_print_settings;
        private System.Windows.Forms.RadioButton c_subscription_list;
        private System.Windows.Forms.RadioButton c_cmnty_list;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox c_receipt_refno;
    }
}