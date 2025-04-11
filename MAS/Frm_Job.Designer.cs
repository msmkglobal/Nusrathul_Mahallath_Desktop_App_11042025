namespace MAS
{
    partial class Frm_Job
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Job));
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_cpanel = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txt_emp_state = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_emp_district = new System.Windows.Forms.TextBox();
            this.cmb_job_type = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_employment = new System.Windows.Forms.DataGridView();
            this.txt_remarks_employment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_join_date = new System.Windows.Forms.TextBox();
            this.txt_contact_number = new System.Windows.Forms.TextBox();
            this.txt_country = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_employer = new System.Windows.Forms.TextBox();
            this.txt_emp_cmnt_id = new System.Windows.Forms.TextBox();
            this.txt_designation = new System.Windows.Forms.TextBox();
            this.gbx_job = new System.Windows.Forms.GroupBox();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_pick = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employment)).BeginInit();
            this.gbx_job.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_new
            // 
            this.btn_new.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_new.BackgroundImage")));
            this.btn_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Location = new System.Drawing.Point(3, 3);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 46);
            this.btn_new.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btn_new, "New");
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.No;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(378, 3);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 46);
            this.btn_search.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_search, "Search");
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(610, 16);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(163, 20);
            this.txt_search.TabIndex = 50;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_cpanel
            // 
            this.btn_cpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cpanel.Location = new System.Drawing.Point(453, 3);
            this.btn_cpanel.Name = "btn_cpanel";
            this.btn_cpanel.Size = new System.Drawing.Size(461, 46);
            this.btn_cpanel.TabIndex = 49;
            this.btn_cpanel.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancel.BackgroundImage")));
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.No;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(303, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 46);
            this.btn_cancel.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_cancel, "Cancel All");
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(228, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 46);
            this.btn_delete.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_delete, "Delete");
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_edit.BackgroundImage")));
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(153, 3);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 46);
            this.btn_edit.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btn_edit, "Edit");
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save.BackgroundImage")));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(78, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 46);
            this.btn_save.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btn_save, "Save");
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "State";
            // 
            // txt_emp_state
            // 
            this.txt_emp_state.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_emp_state.Location = new System.Drawing.Point(89, 206);
            this.txt_emp_state.Name = "txt_emp_state";
            this.txt_emp_state.Size = new System.Drawing.Size(109, 20);
            this.txt_emp_state.TabIndex = 6;
            this.txt_emp_state.TextChanged += new System.EventHandler(this.txt_emp_state_TextChanged);
            this.txt_emp_state.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_emp_state_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "District";
            // 
            // txt_emp_district
            // 
            this.txt_emp_district.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_emp_district.Location = new System.Drawing.Point(89, 180);
            this.txt_emp_district.Name = "txt_emp_district";
            this.txt_emp_district.Size = new System.Drawing.Size(109, 20);
            this.txt_emp_district.TabIndex = 5;
            this.txt_emp_district.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_emp_district_KeyPress);
            // 
            // cmb_job_type
            // 
            this.cmb_job_type.FormattingEnabled = true;
            this.cmb_job_type.Items.AddRange(new object[] {
            "COOLIE",
            "PRIVATE",
            "ABROAD",
            "STUDENT",
            "PENSIONER",
            "GOVERNMENT",
            "SELF EMPLOYED",
            "PROFFESSIONAL"});
            this.cmb_job_type.Location = new System.Drawing.Point(89, 46);
            this.cmb_job_type.Name = "cmb_job_type";
            this.cmb_job_type.Size = new System.Drawing.Size(109, 21);
            this.cmb_job_type.TabIndex = 1;
            this.cmb_job_type.Tag = "M";
            this.cmb_job_type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_job_type_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Job Type";
            // 
            // dgv_employment
            // 
            this.dgv_employment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_employment.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_employment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employment.GridColor = System.Drawing.Color.Plum;
            this.dgv_employment.Location = new System.Drawing.Point(219, 59);
            this.dgv_employment.Name = "dgv_employment";
            this.dgv_employment.RowHeadersVisible = false;
            this.dgv_employment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_employment.Size = new System.Drawing.Size(695, 406);
            this.dgv_employment.TabIndex = 73;
            this.dgv_employment.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_employment_MouseClick);
            this.dgv_employment.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_employment_MouseDoubleClick);
            // 
            // txt_remarks_employment
            // 
            this.txt_remarks_employment.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_remarks_employment.Location = new System.Drawing.Point(89, 308);
            this.txt_remarks_employment.Name = "txt_remarks_employment";
            this.txt_remarks_employment.Size = new System.Drawing.Size(109, 20);
            this.txt_remarks_employment.TabIndex = 10;
            this.txt_remarks_employment.TextChanged += new System.EventHandler(this.txt_remarks_employment_TextChanged);
            this.txt_remarks_employment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_remarks_employment_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Community ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Designattion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Employer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Address";
            // 
            // txt_join_date
            // 
            this.txt_join_date.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_join_date.Location = new System.Drawing.Point(89, 283);
            this.txt_join_date.Name = "txt_join_date";
            this.txt_join_date.Size = new System.Drawing.Size(109, 20);
            this.txt_join_date.TabIndex = 9;
            this.txt_join_date.TextChanged += new System.EventHandler(this.txt_join_date_TextChanged);
            this.txt_join_date.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_join_date_KeyPress);
            // 
            // txt_contact_number
            // 
            this.txt_contact_number.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_contact_number.Location = new System.Drawing.Point(89, 258);
            this.txt_contact_number.Name = "txt_contact_number";
            this.txt_contact_number.Size = new System.Drawing.Size(109, 20);
            this.txt_contact_number.TabIndex = 8;
            this.txt_contact_number.TextChanged += new System.EventHandler(this.txt_contact_number_TextChanged);
            this.txt_contact_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contact_number_KeyPress);
            // 
            // txt_country
            // 
            this.txt_country.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_country.Location = new System.Drawing.Point(89, 233);
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(109, 20);
            this.txt_country.TabIndex = 7;
            this.txt_country.TextChanged += new System.EventHandler(this.txt_country_TextChanged);
            this.txt_country.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_country_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "Country";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "Contact Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 71;
            this.label10.Text = "Joining year";
            // 
            // txt_address
            // 
            this.txt_address.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_address.Location = new System.Drawing.Point(89, 123);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(109, 51);
            this.txt_address.TabIndex = 4;
            this.txt_address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_address_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 72;
            this.label11.Text = "Remarks";
            // 
            // txt_employer
            // 
            this.txt_employer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_employer.Location = new System.Drawing.Point(89, 98);
            this.txt_employer.Name = "txt_employer";
            this.txt_employer.Size = new System.Drawing.Size(109, 20);
            this.txt_employer.TabIndex = 3;
            this.txt_employer.Tag = "M";
            this.txt_employer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_employer_KeyPress);
            // 
            // txt_emp_cmnt_id
            // 
            this.txt_emp_cmnt_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_emp_cmnt_id.Enabled = false;
            this.txt_emp_cmnt_id.Location = new System.Drawing.Point(89, 19);
            this.txt_emp_cmnt_id.Name = "txt_emp_cmnt_id";
            this.txt_emp_cmnt_id.Size = new System.Drawing.Size(68, 20);
            this.txt_emp_cmnt_id.TabIndex = 0;
            this.txt_emp_cmnt_id.Tag = "M";
            this.txt_emp_cmnt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_emp_cmnt_id_KeyPress);
            // 
            // txt_designation
            // 
            this.txt_designation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_designation.Location = new System.Drawing.Point(89, 73);
            this.txt_designation.Name = "txt_designation";
            this.txt_designation.Size = new System.Drawing.Size(109, 20);
            this.txt_designation.TabIndex = 2;
            this.txt_designation.Tag = "M";
            this.txt_designation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_designation_KeyPress);
            // 
            // gbx_job
            // 
            this.gbx_job.Controls.Add(this.cmb_status);
            this.gbx_job.Controls.Add(this.label12);
            this.gbx_job.Controls.Add(this.lbl_pick);
            this.gbx_job.Controls.Add(this.label7);
            this.gbx_job.Controls.Add(this.txt_designation);
            this.gbx_job.Controls.Add(this.txt_emp_state);
            this.gbx_job.Controls.Add(this.label1);
            this.gbx_job.Controls.Add(this.txt_employer);
            this.gbx_job.Controls.Add(this.txt_emp_district);
            this.gbx_job.Controls.Add(this.label11);
            this.gbx_job.Controls.Add(this.cmb_job_type);
            this.gbx_job.Controls.Add(this.txt_address);
            this.gbx_job.Controls.Add(this.label6);
            this.gbx_job.Controls.Add(this.label10);
            this.gbx_job.Controls.Add(this.label9);
            this.gbx_job.Controls.Add(this.label8);
            this.gbx_job.Controls.Add(this.txt_country);
            this.gbx_job.Controls.Add(this.txt_contact_number);
            this.gbx_job.Controls.Add(this.txt_remarks_employment);
            this.gbx_job.Controls.Add(this.txt_join_date);
            this.gbx_job.Controls.Add(this.label2);
            this.gbx_job.Controls.Add(this.label5);
            this.gbx_job.Controls.Add(this.label3);
            this.gbx_job.Controls.Add(this.label4);
            this.gbx_job.Controls.Add(this.txt_emp_cmnt_id);
            this.gbx_job.Location = new System.Drawing.Point(5, 51);
            this.gbx_job.Name = "gbx_job";
            this.gbx_job.Size = new System.Drawing.Size(208, 367);
            this.gbx_job.TabIndex = 7;
            this.gbx_job.TabStop = false;
            // 
            // cmb_status
            // 
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "WORKING",
            "RESIGNED"});
            this.cmb_status.Location = new System.Drawing.Point(89, 333);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(109, 21);
            this.cmb_status.TabIndex = 11;
            this.cmb_status.Tag = "M";
            this.cmb_status.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_status_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 337);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 151;
            this.label12.Text = "Status";
            // 
            // lbl_pick
            // 
            this.lbl_pick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_pick.Location = new System.Drawing.Point(158, 18);
            this.lbl_pick.Name = "lbl_pick";
            this.lbl_pick.Size = new System.Drawing.Size(40, 21);
            this.lbl_pick.TabIndex = 150;
            this.lbl_pick.Text = "Pick";
            this.lbl_pick.UseVisualStyleBackColor = true;
            this.lbl_pick.Click += new System.EventHandler(this.lbl_pick_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(558, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 15);
            this.label13.TabIndex = 76;
            this.label13.Text = "Search";
            // 
            // Frm_Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(922, 477);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.gbx_job);
            this.Controls.Add(this.dgv_employment);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_cpanel);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Job";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job[MAS]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Job_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employment)).EndInit();
            this.gbx_job.ResumeLayout(false);
            this.gbx_job.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_cpanel;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_emp_state;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_emp_district;
        private System.Windows.Forms.ComboBox cmb_job_type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_employment;
        private System.Windows.Forms.TextBox txt_remarks_employment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_join_date;
        private System.Windows.Forms.TextBox txt_contact_number;
        private System.Windows.Forms.TextBox txt_country;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_employer;
        private System.Windows.Forms.TextBox txt_emp_cmnt_id;
        private System.Windows.Forms.TextBox txt_designation;
        private System.Windows.Forms.GroupBox gbx_job;
        private System.Windows.Forms.Button lbl_pick;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}