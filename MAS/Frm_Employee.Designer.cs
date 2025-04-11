namespace MAS
{
    partial class Frm_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Employee));
            this.lbl_emp_id = new System.Windows.Forms.Label();
            this.lbl_emp_name = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_pin = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.lbl_designation = new System.Windows.Forms.Label();
            this.lbl_salary = new System.Windows.Forms.Label();
            this.lbl_qualification = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_discription = new System.Windows.Forms.Label();
            this.txt_emp_id = new System.Windows.Forms.TextBox();
            this.txt_emp_name = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_pin = new System.Windows.Forms.TextBox();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.txt_designation = new System.Windows.Forms.TextBox();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.txt_qualification = new System.Windows.Forms.TextBox();
            this.txt_discription = new System.Windows.Forms.TextBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_cpanel = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.pbx_photo = new System.Windows.Forms.PictureBox();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.dgv_employee = new System.Windows.Forms.DataGridView();
            this.rdb_byid = new System.Windows.Forms.RadioButton();
            this.rdb_byword = new System.Windows.Forms.RadioButton();
            this.lbl_clear = new System.Windows.Forms.Label();
            this.lbl_brows = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbx_employee = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).BeginInit();
            this.gbx_employee.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_emp_id
            // 
            this.lbl_emp_id.AutoSize = true;
            this.lbl_emp_id.Location = new System.Drawing.Point(12, 22);
            this.lbl_emp_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_emp_id.Name = "lbl_emp_id";
            this.lbl_emp_id.Size = new System.Drawing.Size(87, 17);
            this.lbl_emp_id.TabIndex = 0;
            this.lbl_emp_id.Text = "Employee ID";
            // 
            // lbl_emp_name
            // 
            this.lbl_emp_name.AutoSize = true;
            this.lbl_emp_name.Location = new System.Drawing.Point(12, 54);
            this.lbl_emp_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_emp_name.Name = "lbl_emp_name";
            this.lbl_emp_name.Size = new System.Drawing.Size(45, 17);
            this.lbl_emp_name.TabIndex = 1;
            this.lbl_emp_name.Text = "Name";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(800, 24);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(60, 17);
            this.lbl_address.TabIndex = 2;
            this.lbl_address.Text = "Address";
            // 
            // lbl_pin
            // 
            this.lbl_pin.AutoSize = true;
            this.lbl_pin.Location = new System.Drawing.Point(801, 95);
            this.lbl_pin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pin.Name = "lbl_pin";
            this.lbl_pin.Size = new System.Drawing.Size(59, 17);
            this.lbl_pin.TabIndex = 3;
            this.lbl_pin.Text = "Pincode";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Location = new System.Drawing.Point(12, 92);
            this.lbl_dob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(38, 17);
            this.lbl_dob.TabIndex = 4;
            this.lbl_dob.Text = "DOB";
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Location = new System.Drawing.Point(277, 22);
            this.lbl_contact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(56, 17);
            this.lbl_contact.TabIndex = 5;
            this.lbl_contact.Text = "Contact";
            // 
            // lbl_designation
            // 
            this.lbl_designation.AutoSize = true;
            this.lbl_designation.Location = new System.Drawing.Point(277, 54);
            this.lbl_designation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_designation.Name = "lbl_designation";
            this.lbl_designation.Size = new System.Drawing.Size(83, 17);
            this.lbl_designation.TabIndex = 7;
            this.lbl_designation.Text = "Designation";
            // 
            // lbl_salary
            // 
            this.lbl_salary.AutoSize = true;
            this.lbl_salary.Location = new System.Drawing.Point(277, 92);
            this.lbl_salary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_salary.Name = "lbl_salary";
            this.lbl_salary.Size = new System.Drawing.Size(48, 17);
            this.lbl_salary.TabIndex = 8;
            this.lbl_salary.Text = "Salary";
            // 
            // lbl_qualification
            // 
            this.lbl_qualification.AutoSize = true;
            this.lbl_qualification.Location = new System.Drawing.Point(547, 20);
            this.lbl_qualification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_qualification.Name = "lbl_qualification";
            this.lbl_qualification.Size = new System.Drawing.Size(86, 17);
            this.lbl_qualification.TabIndex = 9;
            this.lbl_qualification.Text = "Qualification";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(547, 57);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(48, 17);
            this.lbl_status.TabIndex = 10;
            this.lbl_status.Text = "Status";
            // 
            // lbl_discription
            // 
            this.lbl_discription.AutoSize = true;
            this.lbl_discription.Location = new System.Drawing.Point(547, 95);
            this.lbl_discription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_discription.Name = "lbl_discription";
            this.lbl_discription.Size = new System.Drawing.Size(79, 17);
            this.lbl_discription.TabIndex = 11;
            this.lbl_discription.Text = "Description";
            // 
            // txt_emp_id
            // 
            this.txt_emp_id.Location = new System.Drawing.Point(111, 17);
            this.txt_emp_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_emp_id.Name = "txt_emp_id";
            this.txt_emp_id.ReadOnly = true;
            this.txt_emp_id.Size = new System.Drawing.Size(141, 22);
            this.txt_emp_id.TabIndex = 20;
            this.txt_emp_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_emp_id_KeyPress);
            // 
            // txt_emp_name
            // 
            this.txt_emp_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_emp_name.Location = new System.Drawing.Point(111, 52);
            this.txt_emp_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_emp_name.Name = "txt_emp_name";
            this.txt_emp_name.Size = new System.Drawing.Size(141, 22);
            this.txt_emp_name.TabIndex = 21;
            this.txt_emp_name.Tag = "M";
            this.txt_emp_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_emp_name_KeyPress);
            // 
            // txt_address
            // 
            this.txt_address.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_address.Location = new System.Drawing.Point(868, 14);
            this.txt_address.Margin = new System.Windows.Forms.Padding(4);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(183, 67);
            this.txt_address.TabIndex = 22;
            this.txt_address.Tag = "M";
            // 
            // txt_pin
            // 
            this.txt_pin.Location = new System.Drawing.Point(868, 92);
            this.txt_pin.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pin.MaxLength = 8;
            this.txt_pin.Name = "txt_pin";
            this.txt_pin.Size = new System.Drawing.Size(183, 22);
            this.txt_pin.TabIndex = 23;
            this.txt_pin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pin_KeyPress);
            // 
            // txt_contact
            // 
            this.txt_contact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_contact.Location = new System.Drawing.Point(360, 15);
            this.txt_contact.Margin = new System.Windows.Forms.Padding(4);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(147, 22);
            this.txt_contact.TabIndex = 25;
            this.txt_contact.Tag = "M";
            this.txt_contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contact_KeyPress);
            // 
            // txt_designation
            // 
            this.txt_designation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_designation.Location = new System.Drawing.Point(360, 54);
            this.txt_designation.Margin = new System.Windows.Forms.Padding(4);
            this.txt_designation.Name = "txt_designation";
            this.txt_designation.Size = new System.Drawing.Size(147, 22);
            this.txt_designation.TabIndex = 26;
            this.txt_designation.Tag = "M";
            this.txt_designation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_designation_KeyPress);
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(360, 92);
            this.txt_salary.Margin = new System.Windows.Forms.Padding(4);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(147, 22);
            this.txt_salary.TabIndex = 27;
            this.txt_salary.Tag = "M";
            this.txt_salary.TextChanged += new System.EventHandler(this.txt_salary_TextChanged);
            this.txt_salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // txt_qualification
            // 
            this.txt_qualification.Location = new System.Drawing.Point(641, 19);
            this.txt_qualification.Margin = new System.Windows.Forms.Padding(4);
            this.txt_qualification.Name = "txt_qualification";
            this.txt_qualification.Size = new System.Drawing.Size(132, 22);
            this.txt_qualification.TabIndex = 28;
            this.txt_qualification.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qualification_KeyPress);
            // 
            // txt_discription
            // 
            this.txt_discription.Location = new System.Drawing.Point(641, 92);
            this.txt_discription.Margin = new System.Windows.Forms.Padding(4);
            this.txt_discription.Name = "txt_discription";
            this.txt_discription.Size = new System.Drawing.Size(132, 22);
            this.txt_discription.TabIndex = 30;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Location = new System.Drawing.Point(0, 9);
            this.btn_new.Margin = new System.Windows.Forms.Padding(4);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(88, 55);
            this.btn_new.TabIndex = 52;
            this.btn_new.Text = "New";
            this.toolTip.SetToolTip(this.btn_new, "New");
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
            this.btn_search.Location = new System.Drawing.Point(448, 9);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(88, 55);
            this.btn_search.TabIndex = 51;
            this.btn_search.Text = "Search";
            this.toolTip.SetToolTip(this.btn_search, "Search");
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(811, 26);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(183, 22);
            this.txt_search.TabIndex = 50;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // btn_cpanel
            // 
            this.btn_cpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cpanel.Location = new System.Drawing.Point(577, 9);
            this.btn_cpanel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cpanel.Name = "btn_cpanel";
            this.btn_cpanel.Size = new System.Drawing.Size(652, 55);
            this.btn_cpanel.TabIndex = 49;
            this.btn_cpanel.UseVisualStyleBackColor = true;
            this.btn_cpanel.Click += new System.EventHandler(this.btn_cpanel_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.No;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(360, 9);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(88, 55);
            this.btn_cancel.TabIndex = 48;
            this.btn_cancel.Text = "Cancel";
            this.toolTip.SetToolTip(this.btn_cancel, "Cancel All");
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(272, 9);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(88, 55);
            this.btn_delete.TabIndex = 46;
            this.btn_delete.Text = "Delete";
            this.toolTip.SetToolTip(this.btn_delete, "Delete");
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(184, 9);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(88, 55);
            this.btn_edit.TabIndex = 45;
            this.btn_edit.Text = "Edit";
            this.toolTip.SetToolTip(this.btn_edit, "Edit");
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(96, 9);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(88, 55);
            this.btn_save.TabIndex = 44;
            this.btn_save.Text = "Save";
            this.toolTip.SetToolTip(this.btn_save, "Save");
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dtp_dob
            // 
            this.dtp_dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dob.Location = new System.Drawing.Point(113, 90);
            this.dtp_dob.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(139, 22);
            this.dtp_dob.TabIndex = 24;
            this.dtp_dob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtp_dob_KeyPress);
            // 
            // pbx_photo
            // 
            this.pbx_photo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_photo.BackColor = System.Drawing.Color.White;
            this.pbx_photo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx_photo.BackgroundImage")));
            this.pbx_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_photo.ErrorImage = null;
            this.pbx_photo.Location = new System.Drawing.Point(1072, 14);
            this.pbx_photo.Margin = new System.Windows.Forms.Padding(4);
            this.pbx_photo.Name = "pbx_photo";
            this.pbx_photo.Size = new System.Drawing.Size(111, 67);
            this.pbx_photo.TabIndex = 55;
            this.pbx_photo.TabStop = false;
            // 
            // cmb_status
            // 
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "ENABLE",
            "DISABLE"});
            this.cmb_status.Location = new System.Drawing.Point(641, 57);
            this.cmb_status.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(132, 24);
            this.cmb_status.TabIndex = 29;
            this.cmb_status.Tag = "M";
            this.cmb_status.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_status_KeyPress);
            // 
            // dgv_employee
            // 
            this.dgv_employee.AllowUserToAddRows = false;
            this.dgv_employee.AllowUserToDeleteRows = false;
            this.dgv_employee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_employee.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgv_employee.Location = new System.Drawing.Point(0, 236);
            this.dgv_employee.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_employee.Name = "dgv_employee";
            this.dgv_employee.ReadOnly = true;
            this.dgv_employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_employee.Size = new System.Drawing.Size(1224, 325);
            this.dgv_employee.TabIndex = 57;
            this.dgv_employee.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_employee_MouseClick);
            this.dgv_employee.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_employee_MouseDoubleClick);
            // 
            // rdb_byid
            // 
            this.rdb_byid.AutoSize = true;
            this.rdb_byid.Checked = true;
            this.rdb_byid.Location = new System.Drawing.Point(635, 27);
            this.rdb_byid.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_byid.Name = "rdb_byid";
            this.rdb_byid.Size = new System.Drawing.Size(62, 21);
            this.rdb_byid.TabIndex = 58;
            this.rdb_byid.TabStop = true;
            this.rdb_byid.Text = "By ID";
            this.rdb_byid.UseVisualStyleBackColor = true;
            this.rdb_byid.CheckedChanged += new System.EventHandler(this.rdb_byid_CheckedChanged);
            // 
            // rdb_byword
            // 
            this.rdb_byword.AutoSize = true;
            this.rdb_byword.Location = new System.Drawing.Point(712, 27);
            this.rdb_byword.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_byword.Name = "rdb_byword";
            this.rdb_byword.Size = new System.Drawing.Size(83, 21);
            this.rdb_byword.TabIndex = 59;
            this.rdb_byword.Text = "By Word";
            this.rdb_byword.UseVisualStyleBackColor = true;
            // 
            // lbl_clear
            // 
            this.lbl_clear.AutoSize = true;
            this.lbl_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clear.Location = new System.Drawing.Point(104, 475);
            this.lbl_clear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_clear.Name = "lbl_clear";
            this.lbl_clear.Size = new System.Drawing.Size(43, 18);
            this.lbl_clear.TabIndex = 64;
            this.lbl_clear.Text = "Clear";
            this.lbl_clear.Click += new System.EventHandler(this.lbl_clear_Click);
            this.lbl_clear.MouseEnter += new System.EventHandler(this.lbl_clear_MouseEnter);
            this.lbl_clear.MouseLeave += new System.EventHandler(this.lbl_clear_MouseLeave);
            // 
            // lbl_brows
            // 
            this.lbl_brows.AutoSize = true;
            this.lbl_brows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_brows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brows.Location = new System.Drawing.Point(1106, 95);
            this.lbl_brows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_brows.Name = "lbl_brows";
            this.lbl_brows.Size = new System.Drawing.Size(51, 18);
            this.lbl_brows.TabIndex = 63;
            this.lbl_brows.Text = "Brows";
            this.lbl_brows.Click += new System.EventHandler(this.lbl_brows_Click);
            this.lbl_brows.MouseEnter += new System.EventHandler(this.lbl_brows_MouseEnter);
            this.lbl_brows.MouseLeave += new System.EventHandler(this.lbl_brows_MouseLeave);
            // 
            // gbx_employee
            // 
            this.gbx_employee.Controls.Add(this.txt_emp_id);
            this.gbx_employee.Controls.Add(this.lbl_clear);
            this.gbx_employee.Controls.Add(this.lbl_emp_id);
            this.gbx_employee.Controls.Add(this.lbl_brows);
            this.gbx_employee.Controls.Add(this.lbl_emp_name);
            this.gbx_employee.Controls.Add(this.lbl_address);
            this.gbx_employee.Controls.Add(this.lbl_pin);
            this.gbx_employee.Controls.Add(this.lbl_dob);
            this.gbx_employee.Controls.Add(this.cmb_status);
            this.gbx_employee.Controls.Add(this.lbl_contact);
            this.gbx_employee.Controls.Add(this.pbx_photo);
            this.gbx_employee.Controls.Add(this.dtp_dob);
            this.gbx_employee.Controls.Add(this.lbl_designation);
            this.gbx_employee.Controls.Add(this.lbl_salary);
            this.gbx_employee.Controls.Add(this.lbl_qualification);
            this.gbx_employee.Controls.Add(this.lbl_status);
            this.gbx_employee.Controls.Add(this.lbl_discription);
            this.gbx_employee.Controls.Add(this.txt_emp_name);
            this.gbx_employee.Controls.Add(this.txt_address);
            this.gbx_employee.Controls.Add(this.txt_pin);
            this.gbx_employee.Controls.Add(this.txt_contact);
            this.gbx_employee.Controls.Add(this.txt_discription);
            this.gbx_employee.Controls.Add(this.txt_designation);
            this.gbx_employee.Controls.Add(this.txt_qualification);
            this.gbx_employee.Controls.Add(this.txt_salary);
            this.gbx_employee.Location = new System.Drawing.Point(8, 68);
            this.gbx_employee.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_employee.Name = "gbx_employee";
            this.gbx_employee.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_employee.Size = new System.Drawing.Size(1222, 160);
            this.gbx_employee.TabIndex = 65;
            this.gbx_employee.TabStop = false;
            // 
            // Frm_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 586);
            this.Controls.Add(this.gbx_employee);
            this.Controls.Add(this.rdb_byword);
            this.Controls.Add(this.rdb_byid);
            this.Controls.Add(this.dgv_employee);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_cpanel);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).EndInit();
            this.gbx_employee.ResumeLayout(false);
            this.gbx_employee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_emp_id;
        private System.Windows.Forms.Label lbl_emp_name;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_pin;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.Label lbl_designation;
        private System.Windows.Forms.Label lbl_salary;
        private System.Windows.Forms.Label lbl_qualification;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_discription;
        private System.Windows.Forms.TextBox txt_emp_id;
        private System.Windows.Forms.TextBox txt_emp_name;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_pin;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.TextBox txt_designation;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.TextBox txt_qualification;
        private System.Windows.Forms.TextBox txt_discription;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_cpanel;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DateTimePicker dtp_dob;
        private System.Windows.Forms.PictureBox pbx_photo;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.DataGridView dgv_employee;
        private System.Windows.Forms.RadioButton rdb_byid;
        private System.Windows.Forms.RadioButton rdb_byword;
        private System.Windows.Forms.Label lbl_clear;
        private System.Windows.Forms.Label lbl_brows;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox gbx_employee;
    }
}