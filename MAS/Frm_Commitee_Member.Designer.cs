namespace MAS
{
    partial class Frm_Commitee_Member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Commitee_Member));
            this.lbl_cmty_id = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_year = new System.Windows.Forms.Label();
            this.txt_cmnt_id = new System.Windows.Forms.TextBox();
            this.lbl_cmnty_id = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_photo = new System.Windows.Forms.Label();
            this.lbl_designation = new System.Windows.Forms.Label();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.txt_cmty_year = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_cpanel = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_signature = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.pbx_sign = new System.Windows.Forms.PictureBox();
            this.pbx_photo = new System.Windows.Forms.PictureBox();
            this.dgv_cmty_member = new System.Windows.Forms.DataGridView();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.txt_mem_id = new System.Windows.Forms.TextBox();
            this.lbl_mem_id = new System.Windows.Forms.Label();
            this.txt_cmty_id = new System.Windows.Forms.TextBox();
            this.cmb_designation = new System.Windows.Forms.ComboBox();
            this.lbl_photo_open = new System.Windows.Forms.Label();
            this.lbl_sign_open = new System.Windows.Forms.Label();
            this.lbl_sign_cancel = new System.Windows.Forms.Label();
            this.lbl_photo_cancel = new System.Windows.Forms.Label();
            this.rdb_by_id = new System.Windows.Forms.RadioButton();
            this.rdb_by_word = new System.Windows.Forms.RadioButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_brows = new System.Windows.Forms.Button();
            this.lbl_browscmnty_id = new System.Windows.Forms.Button();
            this.gbx_commitee_member = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_sign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cmty_member)).BeginInit();
            this.gbx_commitee_member.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_cmty_id
            // 
            this.lbl_cmty_id.AutoSize = true;
            this.lbl_cmty_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cmty_id.Location = new System.Drawing.Point(32, 59);
            this.lbl_cmty_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cmty_id.Name = "lbl_cmty_id";
            this.lbl_cmty_id.Size = new System.Drawing.Size(99, 18);
            this.lbl_cmty_id.TabIndex = 0;
            this.lbl_cmty_id.Text = "Committee ID";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.White;
            this.txt_name.Enabled = false;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(478, 20);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(163, 24);
            this.txt_name.TabIndex = 1004;
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_year.Location = new System.Drawing.Point(32, 94);
            this.lbl_year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(107, 18);
            this.lbl_year.TabIndex = 2;
            this.lbl_year.Text = "Committe Year";
            // 
            // txt_cmnt_id
            // 
            this.txt_cmnt_id.BackColor = System.Drawing.Color.White;
            this.txt_cmnt_id.Enabled = false;
            this.txt_cmnt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmnt_id.Location = new System.Drawing.Point(151, 126);
            this.txt_cmnt_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cmnt_id.Name = "txt_cmnt_id";
            this.txt_cmnt_id.ReadOnly = true;
            this.txt_cmnt_id.Size = new System.Drawing.Size(105, 24);
            this.txt_cmnt_id.TabIndex = 1003;
            // 
            // lbl_cmnty_id
            // 
            this.lbl_cmnty_id.AutoSize = true;
            this.lbl_cmnty_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cmnty_id.Location = new System.Drawing.Point(32, 132);
            this.lbl_cmnty_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cmnty_id.Name = "lbl_cmnty_id";
            this.lbl_cmnty_id.Size = new System.Drawing.Size(102, 18);
            this.lbl_cmnty_id.TabIndex = 4;
            this.lbl_cmnty_id.Text = "Community ID";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(352, 25);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(48, 18);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "Name";
            // 
            // lbl_photo
            // 
            this.lbl_photo.AutoSize = true;
            this.lbl_photo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_photo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_photo.Location = new System.Drawing.Point(930, 37);
            this.lbl_photo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_photo.Name = "lbl_photo";
            this.lbl_photo.Size = new System.Drawing.Size(48, 18);
            this.lbl_photo.TabIndex = 5;
            this.lbl_photo.Text = "Photo";
            this.lbl_photo.Click += new System.EventHandler(this.lbl_photo_Click);
            // 
            // lbl_designation
            // 
            this.lbl_designation.AutoSize = true;
            this.lbl_designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_designation.Location = new System.Drawing.Point(352, 99);
            this.lbl_designation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_designation.Name = "lbl_designation";
            this.lbl_designation.Size = new System.Drawing.Size(86, 18);
            this.lbl_designation.TabIndex = 7;
            this.lbl_designation.Text = "Designation";
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contact.Location = new System.Drawing.Point(352, 62);
            this.lbl_contact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(117, 18);
            this.lbl_contact.TabIndex = 8;
            this.lbl_contact.Text = "Contact Number";
            // 
            // txt_cmty_year
            // 
            this.txt_cmty_year.BackColor = System.Drawing.Color.White;
            this.txt_cmty_year.Enabled = false;
            this.txt_cmty_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmty_year.Location = new System.Drawing.Point(151, 91);
            this.txt_cmty_year.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cmty_year.Name = "txt_cmty_year";
            this.txt_cmty_year.ReadOnly = true;
            this.txt_cmty_year.Size = new System.Drawing.Size(163, 24);
            this.txt_cmty_year.TabIndex = 1002;
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.Location = new System.Drawing.Point(687, 59);
            this.txt_description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(215, 100);
            this.txt_description.TabIndex = 4;
            // 
            // txt_contact
            // 
            this.txt_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.Location = new System.Drawing.Point(478, 59);
            this.txt_contact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(163, 24);
            this.txt_contact.TabIndex = 1005;
            this.txt_contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contact_KeyPress);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Location = new System.Drawing.Point(16, 13);
            this.btn_new.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(125, 55);
            this.btn_new.TabIndex = 43;
            this.btn_new.Text = "NEW";
            this.toolTip.SetToolTip(this.btn_new, "New");
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(662, 13);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(123, 55);
            this.btn_search.TabIndex = 42;
            this.btn_search.Text = "SEARCH";
            this.toolTip.SetToolTip(this.btn_search, "Search");
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(1014, 30);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(201, 22);
            this.txt_search.TabIndex = 41;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_cpanel
            // 
            this.btn_cpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cpanel.Location = new System.Drawing.Point(793, 13);
            this.btn_cpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cpanel.Name = "btn_cpanel";
            this.btn_cpanel.Size = new System.Drawing.Size(646, 57);
            this.btn_cpanel.TabIndex = 40;
            this.btn_cpanel.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(543, 13);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(111, 55);
            this.btn_cancel.TabIndex = 39;
            this.btn_cancel.Text = "CANCEL";
            this.toolTip.SetToolTip(this.btn_cancel, "Cancel");
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(406, 13);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(129, 55);
            this.btn_delete.TabIndex = 37;
            this.btn_delete.Text = "DELETE";
            this.toolTip.SetToolTip(this.btn_delete, "Delete");
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
            this.btn_edit.Location = new System.Drawing.Point(285, 13);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(113, 55);
            this.btn_edit.TabIndex = 36;
            this.btn_edit.Text = "UPDATE";
            this.toolTip.SetToolTip(this.btn_edit, "Update");
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(153, 13);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(124, 55);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "SAVE";
            this.toolTip.SetToolTip(this.btn_save, "Save");
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_signature
            // 
            this.lbl_signature.AutoSize = true;
            this.lbl_signature.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_signature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signature.Location = new System.Drawing.Point(1184, 37);
            this.lbl_signature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_signature.Name = "lbl_signature";
            this.lbl_signature.Size = new System.Drawing.Size(70, 18);
            this.lbl_signature.TabIndex = 9;
            this.lbl_signature.Text = "Signature";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(352, 136);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(50, 18);
            this.lbl_status.TabIndex = 46;
            this.lbl_status.Text = "Status";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.Location = new System.Drawing.Point(687, 30);
            this.lbl_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(83, 18);
            this.lbl_description.TabIndex = 47;
            this.lbl_description.Text = "Description";
            // 
            // pbx_sign
            // 
            this.pbx_sign.BackColor = System.Drawing.Color.White;
            this.pbx_sign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbx_sign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_sign.ErrorImage = null;
            this.pbx_sign.Location = new System.Drawing.Point(1262, 30);
            this.pbx_sign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbx_sign.Name = "pbx_sign";
            this.pbx_sign.Size = new System.Drawing.Size(151, 129);
            this.pbx_sign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_sign.TabIndex = 48;
            this.pbx_sign.TabStop = false;
            // 
            // pbx_photo
            // 
            this.pbx_photo.BackColor = System.Drawing.Color.White;
            this.pbx_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbx_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_photo.ErrorImage = null;
            this.pbx_photo.Location = new System.Drawing.Point(998, 30);
            this.pbx_photo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbx_photo.Name = "pbx_photo";
            this.pbx_photo.Size = new System.Drawing.Size(159, 129);
            this.pbx_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_photo.TabIndex = 49;
            this.pbx_photo.TabStop = false;
            // 
            // dgv_cmty_member
            // 
            this.dgv_cmty_member.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_cmty_member.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_cmty_member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cmty_member.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgv_cmty_member.Location = new System.Drawing.Point(16, 307);
            this.dgv_cmty_member.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_cmty_member.Name = "dgv_cmty_member";
            this.dgv_cmty_member.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cmty_member.Size = new System.Drawing.Size(1396, 161);
            this.dgv_cmty_member.TabIndex = 50;
            this.dgv_cmty_member.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_cmty_member_MouseClick);
            this.dgv_cmty_member.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_cmty_member_MouseDoubleClick);
            // 
            // cmb_status
            // 
            this.cmb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "ACTIVE",
            "INACTIVE"});
            this.cmb_status.Location = new System.Drawing.Point(478, 133);
            this.cmb_status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(163, 26);
            this.cmb_status.TabIndex = 3;
            this.cmb_status.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_status_KeyPress);
            // 
            // txt_mem_id
            // 
            this.txt_mem_id.BackColor = System.Drawing.Color.White;
            this.txt_mem_id.Enabled = false;
            this.txt_mem_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mem_id.Location = new System.Drawing.Point(151, 18);
            this.txt_mem_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_mem_id.Name = "txt_mem_id";
            this.txt_mem_id.ReadOnly = true;
            this.txt_mem_id.Size = new System.Drawing.Size(163, 26);
            this.txt_mem_id.TabIndex = 1000;
            // 
            // lbl_mem_id
            // 
            this.lbl_mem_id.AutoSize = true;
            this.lbl_mem_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mem_id.Location = new System.Drawing.Point(32, 23);
            this.lbl_mem_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mem_id.Name = "lbl_mem_id";
            this.lbl_mem_id.Size = new System.Drawing.Size(81, 18);
            this.lbl_mem_id.TabIndex = 53;
            this.lbl_mem_id.Text = "Member ID";
            // 
            // txt_cmty_id
            // 
            this.txt_cmty_id.BackColor = System.Drawing.Color.White;
            this.txt_cmty_id.Enabled = false;
            this.txt_cmty_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmty_id.Location = new System.Drawing.Point(151, 59);
            this.txt_cmty_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cmty_id.Name = "txt_cmty_id";
            this.txt_cmty_id.ReadOnly = true;
            this.txt_cmty_id.Size = new System.Drawing.Size(105, 24);
            this.txt_cmty_id.TabIndex = 1001;
            // 
            // cmb_designation
            // 
            this.cmb_designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_designation.FormattingEnabled = true;
            this.cmb_designation.Items.AddRange(new object[] {
            "PRESIDENT",
            "SECRETARY",
            "MEMBER",
            "CASHIER"});
            this.cmb_designation.Location = new System.Drawing.Point(478, 96);
            this.cmb_designation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_designation.Name = "cmb_designation";
            this.cmb_designation.Size = new System.Drawing.Size(163, 26);
            this.cmb_designation.TabIndex = 2;
            this.cmb_designation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_designation_KeyPress);
            // 
            // lbl_photo_open
            // 
            this.lbl_photo_open.AutoSize = true;
            this.lbl_photo_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_photo_open.Location = new System.Drawing.Point(930, 91);
            this.lbl_photo_open.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_photo_open.Name = "lbl_photo_open";
            this.lbl_photo_open.Size = new System.Drawing.Size(43, 17);
            this.lbl_photo_open.TabIndex = 8;
            this.lbl_photo_open.Text = "Open";
            this.lbl_photo_open.Click += new System.EventHandler(this.lbl_photo_open_Click);
            this.lbl_photo_open.MouseEnter += new System.EventHandler(this.lbl_photo_open_MouseEnter);
            this.lbl_photo_open.MouseLeave += new System.EventHandler(this.lbl_photo_open_MouseLeave);
            // 
            // lbl_sign_open
            // 
            this.lbl_sign_open.AutoSize = true;
            this.lbl_sign_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_sign_open.Location = new System.Drawing.Point(1184, 83);
            this.lbl_sign_open.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sign_open.Name = "lbl_sign_open";
            this.lbl_sign_open.Size = new System.Drawing.Size(43, 17);
            this.lbl_sign_open.TabIndex = 10;
            this.lbl_sign_open.Text = "Open";
            this.lbl_sign_open.Click += new System.EventHandler(this.lbl_sign_open_Click);
            this.lbl_sign_open.MouseEnter += new System.EventHandler(this.lbl_sign_open_MouseEnter);
            this.lbl_sign_open.MouseLeave += new System.EventHandler(this.lbl_sign_open_MouseLeave);
            // 
            // lbl_sign_cancel
            // 
            this.lbl_sign_cancel.AutoSize = true;
            this.lbl_sign_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_sign_cancel.Location = new System.Drawing.Point(1184, 129);
            this.lbl_sign_cancel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sign_cancel.Name = "lbl_sign_cancel";
            this.lbl_sign_cancel.Size = new System.Drawing.Size(51, 17);
            this.lbl_sign_cancel.TabIndex = 64;
            this.lbl_sign_cancel.Text = "Cancel";
            this.lbl_sign_cancel.Click += new System.EventHandler(this.lbl_sign_cancel_Click);
            this.lbl_sign_cancel.MouseEnter += new System.EventHandler(this.lbl_sign_cancel_MouseEnter);
            this.lbl_sign_cancel.MouseLeave += new System.EventHandler(this.lbl_sign_cancel_MouseLeave);
            // 
            // lbl_photo_cancel
            // 
            this.lbl_photo_cancel.AutoSize = true;
            this.lbl_photo_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_photo_cancel.Location = new System.Drawing.Point(930, 136);
            this.lbl_photo_cancel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_photo_cancel.Name = "lbl_photo_cancel";
            this.lbl_photo_cancel.Size = new System.Drawing.Size(51, 17);
            this.lbl_photo_cancel.TabIndex = 65;
            this.lbl_photo_cancel.Text = "Cancel";
            this.lbl_photo_cancel.Click += new System.EventHandler(this.lbl_photo_cancel_Click);
            this.lbl_photo_cancel.MouseEnter += new System.EventHandler(this.lbl_photo_cancel_MouseEnter);
            this.lbl_photo_cancel.MouseLeave += new System.EventHandler(this.lbl_photo_cancel_MouseLeave);
            // 
            // rdb_by_id
            // 
            this.rdb_by_id.AutoSize = true;
            this.rdb_by_id.Checked = true;
            this.rdb_by_id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_by_id.Location = new System.Drawing.Point(812, 31);
            this.rdb_by_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb_by_id.Name = "rdb_by_id";
            this.rdb_by_id.Size = new System.Drawing.Size(62, 21);
            this.rdb_by_id.TabIndex = 66;
            this.rdb_by_id.TabStop = true;
            this.rdb_by_id.Text = "By ID";
            this.rdb_by_id.UseVisualStyleBackColor = true;
            // 
            // rdb_by_word
            // 
            this.rdb_by_word.AutoSize = true;
            this.rdb_by_word.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_by_word.Location = new System.Drawing.Point(906, 31);
            this.rdb_by_word.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb_by_word.Name = "rdb_by_word";
            this.rdb_by_word.Size = new System.Drawing.Size(83, 21);
            this.rdb_by_word.TabIndex = 67;
            this.rdb_by_word.TabStop = true;
            this.rdb_by_word.Text = "By Word";
            this.rdb_by_word.UseVisualStyleBackColor = true;
            // 
            // lbl_brows
            // 
            this.lbl_brows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_brows.Location = new System.Drawing.Point(264, 59);
            this.lbl_brows.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_brows.Name = "lbl_brows";
            this.lbl_brows.Size = new System.Drawing.Size(53, 26);
            this.lbl_brows.TabIndex = 0;
            this.lbl_brows.Text = "Pick";
            this.lbl_brows.UseVisualStyleBackColor = true;
            this.lbl_brows.Click += new System.EventHandler(this.lbl_brows_Click_1);
            // 
            // lbl_browscmnty_id
            // 
            this.lbl_browscmnty_id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_browscmnty_id.Location = new System.Drawing.Point(261, 124);
            this.lbl_browscmnty_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_browscmnty_id.Name = "lbl_browscmnty_id";
            this.lbl_browscmnty_id.Size = new System.Drawing.Size(53, 26);
            this.lbl_browscmnty_id.TabIndex = 1;
            this.lbl_browscmnty_id.Text = "Pick";
            this.lbl_browscmnty_id.UseVisualStyleBackColor = true;
            this.lbl_browscmnty_id.Click += new System.EventHandler(this.lbl_browscmnty_id_Click);
            // 
            // gbx_commitee_member
            // 
            this.gbx_commitee_member.Controls.Add(this.txt_mem_id);
            this.gbx_commitee_member.Controls.Add(this.lbl_browscmnty_id);
            this.gbx_commitee_member.Controls.Add(this.lbl_cmty_id);
            this.gbx_commitee_member.Controls.Add(this.lbl_brows);
            this.gbx_commitee_member.Controls.Add(this.txt_name);
            this.gbx_commitee_member.Controls.Add(this.lbl_year);
            this.gbx_commitee_member.Controls.Add(this.txt_cmnt_id);
            this.gbx_commitee_member.Controls.Add(this.lbl_photo_cancel);
            this.gbx_commitee_member.Controls.Add(this.lbl_cmnty_id);
            this.gbx_commitee_member.Controls.Add(this.lbl_sign_cancel);
            this.gbx_commitee_member.Controls.Add(this.lbl_name);
            this.gbx_commitee_member.Controls.Add(this.lbl_sign_open);
            this.gbx_commitee_member.Controls.Add(this.lbl_photo);
            this.gbx_commitee_member.Controls.Add(this.lbl_photo_open);
            this.gbx_commitee_member.Controls.Add(this.lbl_contact);
            this.gbx_commitee_member.Controls.Add(this.txt_cmty_year);
            this.gbx_commitee_member.Controls.Add(this.cmb_designation);
            this.gbx_commitee_member.Controls.Add(this.txt_description);
            this.gbx_commitee_member.Controls.Add(this.lbl_designation);
            this.gbx_commitee_member.Controls.Add(this.txt_contact);
            this.gbx_commitee_member.Controls.Add(this.txt_cmty_id);
            this.gbx_commitee_member.Controls.Add(this.lbl_signature);
            this.gbx_commitee_member.Controls.Add(this.lbl_status);
            this.gbx_commitee_member.Controls.Add(this.lbl_mem_id);
            this.gbx_commitee_member.Controls.Add(this.lbl_description);
            this.gbx_commitee_member.Controls.Add(this.cmb_status);
            this.gbx_commitee_member.Controls.Add(this.pbx_sign);
            this.gbx_commitee_member.Controls.Add(this.pbx_photo);
            this.gbx_commitee_member.Location = new System.Drawing.Point(16, 69);
            this.gbx_commitee_member.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_commitee_member.Name = "gbx_commitee_member";
            this.gbx_commitee_member.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_commitee_member.Size = new System.Drawing.Size(1423, 211);
            this.gbx_commitee_member.TabIndex = 1;
            this.gbx_commitee_member.TabStop = false;
            this.gbx_commitee_member.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Frm_Commitee_Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 638);
            this.Controls.Add(this.gbx_commitee_member);
            this.Controls.Add(this.rdb_by_word);
            this.Controls.Add(this.rdb_by_id);
            this.Controls.Add(this.dgv_cmty_member);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Commitee_Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Commitee_Member";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Commitee_Member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_sign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cmty_member)).EndInit();
            this.gbx_commitee_member.ResumeLayout(false);
            this.gbx_commitee_member.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cmty_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.TextBox txt_cmnt_id;
        private System.Windows.Forms.Label lbl_cmnty_id;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_photo;
        private System.Windows.Forms.Label lbl_designation;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.TextBox txt_cmty_year;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_cpanel;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_signature;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.PictureBox pbx_sign;
        private System.Windows.Forms.PictureBox pbx_photo;
        private System.Windows.Forms.DataGridView dgv_cmty_member;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.TextBox txt_mem_id;
        private System.Windows.Forms.Label lbl_mem_id;
        private System.Windows.Forms.ComboBox cmb_designation;
        private System.Windows.Forms.Label lbl_photo_open;
        private System.Windows.Forms.Label lbl_sign_open;
        private System.Windows.Forms.Label lbl_sign_cancel;
        private System.Windows.Forms.Label lbl_photo_cancel;
        private System.Windows.Forms.RadioButton rdb_by_id;
        private System.Windows.Forms.RadioButton rdb_by_word;
        private System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.TextBox txt_cmty_id;
        private System.Windows.Forms.Button lbl_brows;
        private System.Windows.Forms.Button lbl_browscmnty_id;
        private System.Windows.Forms.GroupBox gbx_commitee_member;
    }
}