namespace MAS
{
    partial class Frm_Education
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
            this.components = new System.ComponentModel.Container();
            this.dgv_education = new System.Windows.Forms.DataGridView();
            this.lbl_Cmtnt_Id = new System.Windows.Forms.Label();
            this.lbl_Cmnt_Id = new System.Windows.Forms.Label();
            this.lbl_subjet = new System.Windows.Forms.Label();
            this.lbl_stream = new System.Windows.Forms.Label();
            this.txt_Reg_No = new System.Windows.Forms.TextBox();
            this.lbl_Issuing_authority = new System.Windows.Forms.Label();
            this.txt_Passing_Year = new System.Windows.Forms.TextBox();
            this.lbl_Percentage = new System.Windows.Forms.Label();
            this.txt_Grade = new System.Windows.Forms.TextBox();
            this.lbl_Grade = new System.Windows.Forms.Label();
            this.txt_Percentage = new System.Windows.Forms.TextBox();
            this.lbl_passing_year = new System.Windows.Forms.Label();
            this.txt_Issuing_Authority = new System.Windows.Forms.TextBox();
            this.lbl_Reg_No = new System.Windows.Forms.Label();
            this.txt_Stream = new System.Windows.Forms.TextBox();
            this.lbl_Remarks = new System.Windows.Forms.Label();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.txt_Cmnt_Id = new System.Windows.Forms.TextBox();
            this.gpbx_education = new System.Windows.Forms.GroupBox();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Remarks = new System.Windows.Forms.TextBox();
            this.txt_Qualification = new System.Windows.Forms.ComboBox();
            this.btn_pick = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_cpanel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_education)).BeginInit();
            this.gpbx_education.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_education
            // 
            this.dgv_education.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_education.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_education.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_education.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_education.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgv_education.Location = new System.Drawing.Point(0, 208);
            this.dgv_education.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_education.Name = "dgv_education";
            this.dgv_education.RowHeadersVisible = false;
            this.dgv_education.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_education.Size = new System.Drawing.Size(1336, 430);
            this.dgv_education.TabIndex = 0;
            this.dgv_education.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_education_MouseClick);
            this.dgv_education.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_education_MouseDoubleClick);
            // 
            // lbl_Cmtnt_Id
            // 
            this.lbl_Cmtnt_Id.AutoSize = true;
            this.lbl_Cmtnt_Id.Location = new System.Drawing.Point(10, 22);
            this.lbl_Cmtnt_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Cmtnt_Id.Name = "lbl_Cmtnt_Id";
            this.lbl_Cmtnt_Id.Size = new System.Drawing.Size(94, 17);
            this.lbl_Cmtnt_Id.TabIndex = 136;
            this.lbl_Cmtnt_Id.Text = "Community ID";
            // 
            // lbl_Cmnt_Id
            // 
            this.lbl_Cmnt_Id.AutoSize = true;
            this.lbl_Cmnt_Id.Location = new System.Drawing.Point(10, 59);
            this.lbl_Cmnt_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Cmnt_Id.Name = "lbl_Cmnt_Id";
            this.lbl_Cmnt_Id.Size = new System.Drawing.Size(89, 17);
            this.lbl_Cmnt_Id.TabIndex = 137;
            this.lbl_Cmnt_Id.Text = "Quallification";
            // 
            // lbl_subjet
            // 
            this.lbl_subjet.AutoSize = true;
            this.lbl_subjet.Location = new System.Drawing.Point(10, 99);
            this.lbl_subjet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_subjet.Name = "lbl_subjet";
            this.lbl_subjet.Size = new System.Drawing.Size(55, 17);
            this.lbl_subjet.TabIndex = 138;
            this.lbl_subjet.Text = "Subject";
            // 
            // lbl_stream
            // 
            this.lbl_stream.AutoSize = true;
            this.lbl_stream.Location = new System.Drawing.Point(318, 22);
            this.lbl_stream.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_stream.Name = "lbl_stream";
            this.lbl_stream.Size = new System.Drawing.Size(53, 17);
            this.lbl_stream.TabIndex = 139;
            this.lbl_stream.Text = "Stream";
            // 
            // txt_Reg_No
            // 
            this.txt_Reg_No.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Reg_No.Location = new System.Drawing.Point(791, 96);
            this.txt_Reg_No.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Reg_No.Name = "txt_Reg_No";
            this.txt_Reg_No.Size = new System.Drawing.Size(152, 22);
            this.txt_Reg_No.TabIndex = 8;
            this.txt_Reg_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Reg_No_KeyPress);
            // 
            // lbl_Issuing_authority
            // 
            this.lbl_Issuing_authority.AutoSize = true;
            this.lbl_Issuing_authority.Location = new System.Drawing.Point(318, 59);
            this.lbl_Issuing_authority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Issuing_authority.Name = "lbl_Issuing_authority";
            this.lbl_Issuing_authority.Size = new System.Drawing.Size(112, 17);
            this.lbl_Issuing_authority.TabIndex = 140;
            this.lbl_Issuing_authority.Text = "Issuing Authority";
            // 
            // txt_Passing_Year
            // 
            this.txt_Passing_Year.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Passing_Year.Location = new System.Drawing.Point(791, 56);
            this.txt_Passing_Year.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Passing_Year.Name = "txt_Passing_Year";
            this.txt_Passing_Year.Size = new System.Drawing.Size(152, 22);
            this.txt_Passing_Year.TabIndex = 7;
            this.txt_Passing_Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Passing_Year_KeyPress);
            // 
            // lbl_Percentage
            // 
            this.lbl_Percentage.AutoSize = true;
            this.lbl_Percentage.Location = new System.Drawing.Point(318, 99);
            this.lbl_Percentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Percentage.Name = "lbl_Percentage";
            this.lbl_Percentage.Size = new System.Drawing.Size(81, 17);
            this.lbl_Percentage.TabIndex = 141;
            this.lbl_Percentage.Text = "Percentage";
            // 
            // txt_Grade
            // 
            this.txt_Grade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Grade.Location = new System.Drawing.Point(791, 19);
            this.txt_Grade.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Grade.Name = "txt_Grade";
            this.txt_Grade.Size = new System.Drawing.Size(152, 22);
            this.txt_Grade.TabIndex = 6;
            this.txt_Grade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Grade_KeyPress);
            // 
            // lbl_Grade
            // 
            this.lbl_Grade.AutoSize = true;
            this.lbl_Grade.Location = new System.Drawing.Point(687, 22);
            this.lbl_Grade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Grade.Name = "lbl_Grade";
            this.lbl_Grade.Size = new System.Drawing.Size(48, 17);
            this.lbl_Grade.TabIndex = 142;
            this.lbl_Grade.Text = "Grade";
            // 
            // txt_Percentage
            // 
            this.txt_Percentage.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Percentage.Location = new System.Drawing.Point(461, 96);
            this.txt_Percentage.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Percentage.Name = "txt_Percentage";
            this.txt_Percentage.Size = new System.Drawing.Size(152, 22);
            this.txt_Percentage.TabIndex = 5;
            this.txt_Percentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Percentage_KeyPress);
            // 
            // lbl_passing_year
            // 
            this.lbl_passing_year.AutoSize = true;
            this.lbl_passing_year.Location = new System.Drawing.Point(687, 59);
            this.lbl_passing_year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_passing_year.Name = "lbl_passing_year";
            this.lbl_passing_year.Size = new System.Drawing.Size(92, 17);
            this.lbl_passing_year.TabIndex = 143;
            this.lbl_passing_year.Text = "Passing Year";
            // 
            // txt_Issuing_Authority
            // 
            this.txt_Issuing_Authority.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Issuing_Authority.Location = new System.Drawing.Point(461, 56);
            this.txt_Issuing_Authority.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Issuing_Authority.Name = "txt_Issuing_Authority";
            this.txt_Issuing_Authority.Size = new System.Drawing.Size(152, 22);
            this.txt_Issuing_Authority.TabIndex = 4;
            this.txt_Issuing_Authority.Tag = "M";
            this.txt_Issuing_Authority.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Issuing_Authority_KeyPress);
            // 
            // lbl_Reg_No
            // 
            this.lbl_Reg_No.AutoSize = true;
            this.lbl_Reg_No.Location = new System.Drawing.Point(687, 99);
            this.lbl_Reg_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Reg_No.Name = "lbl_Reg_No";
            this.lbl_Reg_No.Size = new System.Drawing.Size(86, 17);
            this.lbl_Reg_No.TabIndex = 144;
            this.lbl_Reg_No.Text = "Reg number";
            // 
            // txt_Stream
            // 
            this.txt_Stream.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Stream.Location = new System.Drawing.Point(461, 19);
            this.txt_Stream.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Stream.Name = "txt_Stream";
            this.txt_Stream.Size = new System.Drawing.Size(152, 22);
            this.txt_Stream.TabIndex = 3;
            this.txt_Stream.Tag = "";
            this.txt_Stream.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Stream_KeyPress);
            // 
            // lbl_Remarks
            // 
            this.lbl_Remarks.AutoSize = true;
            this.lbl_Remarks.Location = new System.Drawing.Point(980, 73);
            this.lbl_Remarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Remarks.Name = "lbl_Remarks";
            this.lbl_Remarks.Size = new System.Drawing.Size(64, 17);
            this.lbl_Remarks.TabIndex = 145;
            this.lbl_Remarks.Text = "Remarks";
            // 
            // txt_Subject
            // 
            this.txt_Subject.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Subject.Location = new System.Drawing.Point(128, 96);
            this.txt_Subject.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(152, 22);
            this.txt_Subject.TabIndex = 2;
            this.txt_Subject.Tag = "M";
            this.txt_Subject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Subject_KeyPress);
            // 
            // txt_Cmnt_Id
            // 
            this.txt_Cmnt_Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Cmnt_Id.Enabled = false;
            this.txt_Cmnt_Id.Location = new System.Drawing.Point(128, 19);
            this.txt_Cmnt_Id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Cmnt_Id.Name = "txt_Cmnt_Id";
            this.txt_Cmnt_Id.Size = new System.Drawing.Size(96, 22);
            this.txt_Cmnt_Id.TabIndex = 0;
            this.txt_Cmnt_Id.Tag = "M";
            // 
            // gpbx_education
            // 
            this.gpbx_education.Controls.Add(this.cmb_status);
            this.gpbx_education.Controls.Add(this.label1);
            this.gpbx_education.Controls.Add(this.txt_Remarks);
            this.gpbx_education.Controls.Add(this.txt_Qualification);
            this.gpbx_education.Controls.Add(this.btn_pick);
            this.gpbx_education.Controls.Add(this.txt_Cmnt_Id);
            this.gpbx_education.Controls.Add(this.txt_Subject);
            this.gpbx_education.Controls.Add(this.lbl_Remarks);
            this.gpbx_education.Controls.Add(this.txt_Stream);
            this.gpbx_education.Controls.Add(this.lbl_Cmtnt_Id);
            this.gpbx_education.Controls.Add(this.lbl_Reg_No);
            this.gpbx_education.Controls.Add(this.lbl_Cmnt_Id);
            this.gpbx_education.Controls.Add(this.txt_Issuing_Authority);
            this.gpbx_education.Controls.Add(this.lbl_subjet);
            this.gpbx_education.Controls.Add(this.lbl_passing_year);
            this.gpbx_education.Controls.Add(this.lbl_stream);
            this.gpbx_education.Controls.Add(this.txt_Percentage);
            this.gpbx_education.Controls.Add(this.txt_Reg_No);
            this.gpbx_education.Controls.Add(this.lbl_Grade);
            this.gpbx_education.Controls.Add(this.lbl_Issuing_authority);
            this.gpbx_education.Controls.Add(this.txt_Grade);
            this.gpbx_education.Controls.Add(this.txt_Passing_Year);
            this.gpbx_education.Controls.Add(this.lbl_Percentage);
            this.gpbx_education.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbx_education.Location = new System.Drawing.Point(0, 73);
            this.gpbx_education.Margin = new System.Windows.Forms.Padding(4);
            this.gpbx_education.Name = "gpbx_education";
            this.gpbx_education.Padding = new System.Windows.Forms.Padding(4);
            this.gpbx_education.Size = new System.Drawing.Size(1336, 135);
            this.gpbx_education.TabIndex = 0;
            this.gpbx_education.TabStop = false;
            // 
            // cmb_status
            // 
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "DOING",
            "CERTIFIED",
            "QUALLIFIED"});
            this.cmb_status.Location = new System.Drawing.Point(1057, 18);
            this.cmb_status.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(152, 24);
            this.cmb_status.TabIndex = 10;
            this.cmb_status.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_status_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(980, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 163;
            this.label1.Text = "Status";
            // 
            // txt_Remarks
            // 
            this.txt_Remarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Remarks.Location = new System.Drawing.Point(1057, 55);
            this.txt_Remarks.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Remarks.Multiline = true;
            this.txt_Remarks.Name = "txt_Remarks";
            this.txt_Remarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Remarks.Size = new System.Drawing.Size(215, 63);
            this.txt_Remarks.TabIndex = 9;
            // 
            // txt_Qualification
            // 
            this.txt_Qualification.FormattingEnabled = true;
            this.txt_Qualification.Items.AddRange(new object[] {
            "PRE PRIMARY",
            "PRIMARY",
            "UPS",
            "HS",
            "HSS",
            "GRADUATED",
            "POST GRADUATED",
            "DOCTORATE"});
            this.txt_Qualification.Location = new System.Drawing.Point(128, 55);
            this.txt_Qualification.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Qualification.Name = "txt_Qualification";
            this.txt_Qualification.Size = new System.Drawing.Size(152, 24);
            this.txt_Qualification.TabIndex = 1;
            this.txt_Qualification.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Qualification_KeyPress_1);
            // 
            // btn_pick
            // 
            this.btn_pick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pick.Location = new System.Drawing.Point(227, 17);
            this.btn_pick.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pick.Name = "btn_pick";
            this.btn_pick.Size = new System.Drawing.Size(53, 26);
            this.btn_pick.TabIndex = 160;
            this.btn_pick.Text = "Pick";
            this.btn_pick.UseVisualStyleBackColor = true;
            this.btn_pick.Click += new System.EventHandler(this.btn_pick_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.No;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(404, 2);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 57);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Location = new System.Drawing.Point(4, 2);
            this.btn_new.Margin = new System.Windows.Forms.Padding(4);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(100, 57);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "New";
            this.toolTip1.SetToolTip(this.btn_new, "New");
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.No;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(504, 2);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 57);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(304, 2);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 57);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.toolTip1.SetToolTip(this.btn_delete, "Delete");
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(204, 2);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(100, 57);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit";
            this.toolTip1.SetToolTip(this.btn_edit, "Edit");
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_save.Location = new System.Drawing.Point(104, 2);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 57);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.toolTip1.SetToolTip(this.btn_save, "Save");
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.Red;
            this.txt_search.Location = new System.Drawing.Point(751, 18);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(335, 26);
            this.txt_search.TabIndex = 6;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_cpanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1336, 73);
            this.panel1.TabIndex = 134;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1094, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 75;
            this.label6.Text = "Search";
            // 
            // btn_cpanel
            // 
            this.btn_cpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cpanel.Location = new System.Drawing.Point(706, 4);
            this.btn_cpanel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cpanel.Name = "btn_cpanel";
            this.btn_cpanel.Size = new System.Drawing.Size(621, 55);
            this.btn_cpanel.TabIndex = 74;
            this.btn_cpanel.UseVisualStyleBackColor = true;
            // 
            // Frm_Education
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1336, 638);
            this.Controls.Add(this.dgv_education);
            this.Controls.Add(this.gpbx_education);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Frm_Education";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAS[Education]";
            this.Load += new System.EventHandler(this.Frm_Education_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_education)).EndInit();
            this.gpbx_education.ResumeLayout(false);
            this.gpbx_education.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_education;
        private System.Windows.Forms.Label lbl_Cmtnt_Id;
        private System.Windows.Forms.Label lbl_Cmnt_Id;
        private System.Windows.Forms.Label lbl_subjet;
        private System.Windows.Forms.Label lbl_stream;
        private System.Windows.Forms.TextBox txt_Reg_No;
        private System.Windows.Forms.Label lbl_Issuing_authority;
        private System.Windows.Forms.TextBox txt_Passing_Year;
        private System.Windows.Forms.Label lbl_Percentage;
        private System.Windows.Forms.TextBox txt_Grade;
        private System.Windows.Forms.Label lbl_Grade;
        private System.Windows.Forms.TextBox txt_Percentage;
        private System.Windows.Forms.Label lbl_passing_year;
        private System.Windows.Forms.TextBox txt_Issuing_Authority;
        private System.Windows.Forms.Label lbl_Reg_No;
        private System.Windows.Forms.TextBox txt_Stream;
        private System.Windows.Forms.Label lbl_Remarks;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.TextBox txt_Cmnt_Id;
        private System.Windows.Forms.GroupBox gpbx_education;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cpanel;
        private System.Windows.Forms.Button btn_pick;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox txt_Qualification;
        private System.Windows.Forms.TextBox txt_Remarks;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Label label1;
    }
}