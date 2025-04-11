namespace MAS
{
    partial class Frm_Commitee_Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Commitee_Master));
            this.txt_cmty_id = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.txt_strength = new System.Windows.Forms.TextBox();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l7 = new System.Windows.Forms.Label();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.l8 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_cpanel = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dgv_commitee = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_cmty_year = new System.Windows.Forms.MaskedTextBox();
            this.l6 = new System.Windows.Forms.Label();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.txt_dos = new System.Windows.Forms.MaskedTextBox();
            this.txt_doe = new System.Windows.Forms.MaskedTextBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.l21 = new System.Windows.Forms.Label();
            this.rdb_by_id = new System.Windows.Forms.RadioButton();
            this.rdb_by_word = new System.Windows.Forms.RadioButton();
            this.gbx_commitee = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commitee)).BeginInit();
            this.gbx_commitee.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_cmty_id
            // 
            this.txt_cmty_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmty_id.Location = new System.Drawing.Point(133, 16);
            this.txt_cmty_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cmty_id.Name = "txt_cmty_id";
            this.txt_cmty_id.ReadOnly = true;
            this.txt_cmty_id.Size = new System.Drawing.Size(168, 24);
            this.txt_cmty_id.TabIndex = 100;
            this.txt_cmty_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(20, 20);
            this.l1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(99, 18);
            this.l1.TabIndex = 1;
            this.l1.Text = "Committee ID";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(3, 55);
            this.l2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(115, 18);
            this.l2.TabIndex = 2;
            this.l2.Text = "Committee Year";
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5.Location = new System.Drawing.Point(358, 55);
            this.l5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(69, 18);
            this.l5.TabIndex = 4;
            this.l5.Text = "End Date";
            // 
            // txt_strength
            // 
            this.txt_strength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_strength.Location = new System.Drawing.Point(133, 87);
            this.txt_strength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_strength.Name = "txt_strength";
            this.txt_strength.Size = new System.Drawing.Size(168, 24);
            this.txt_strength.TabIndex = 1;
            this.txt_strength.Tag = "M";
            this.Tooltip.SetToolTip(this.txt_strength, "Input numerics only");
            this.txt_strength.TextChanged += new System.EventHandler(this.validateTextInteger);
            this.txt_strength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_strength_KeyPress);
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.Location = new System.Drawing.Point(59, 91);
            this.l3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(63, 18);
            this.l3.TabIndex = 8;
            this.l3.Text = "Strength";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4.Location = new System.Drawing.Point(354, 20);
            this.l4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(74, 18);
            this.l4.TabIndex = 9;
            this.l4.Text = "Start Date";
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l7.Location = new System.Drawing.Point(667, 74);
            this.l7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(69, 18);
            this.l7.TabIndex = 10;
            this.l7.Text = "Message";
            // 
            // txt_message
            // 
            this.txt_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_message.Location = new System.Drawing.Point(744, 20);
            this.txt_message.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(242, 109);
            this.txt_message.TabIndex = 5;
            // 
            // l8
            // 
            this.l8.AutoSize = true;
            this.l8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l8.Location = new System.Drawing.Point(1016, 58);
            this.l8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(40, 18);
            this.l8.TabIndex = 14;
            this.l8.Text = "Note";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(152, 8);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(136, 55);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "SAVE";
            this.Tooltip.SetToolTip(this.btn_save, "Save Committee");
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save.MouseEnter += new System.EventHandler(this.btn_save_MouseEnter);
            this.btn_save.MouseLeave += new System.EventHandler(this.btn_save_MouseLeave);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(296, 8);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(129, 55);
            this.btn_edit.TabIndex = 20;
            this.btn_edit.Text = "EDIT";
            this.Tooltip.SetToolTip(this.btn_edit, "Edit Committee");
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            this.btn_edit.MouseEnter += new System.EventHandler(this.btn_edit_MouseEnter);
            this.btn_edit.MouseLeave += new System.EventHandler(this.btn_edit_MouseLeave);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(433, 11);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(116, 55);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "DELETE";
            this.Tooltip.SetToolTip(this.btn_delete, "Delete Committee");
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            this.btn_delete.MouseEnter += new System.EventHandler(this.btn_delete_MouseEnter);
            this.btn_delete.MouseLeave += new System.EventHandler(this.btn_delete_MouseLeave);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.No;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(557, 9);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(128, 55);
            this.btn_cancel.TabIndex = 23;
            this.btn_cancel.Text = "CANCEL";
            this.Tooltip.SetToolTip(this.btn_cancel, "Cancel All");
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseEnter += new System.EventHandler(this.btn_cancel_MouseEnter);
            this.btn_cancel.MouseLeave += new System.EventHandler(this.btn_cancel_MouseLeave);
            // 
            // btn_cpanel
            // 
            this.btn_cpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cpanel.Location = new System.Drawing.Point(833, 9);
            this.btn_cpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cpanel.Name = "btn_cpanel";
            this.btn_cpanel.Size = new System.Drawing.Size(577, 57);
            this.btn_cpanel.TabIndex = 24;
            this.btn_cpanel.UseVisualStyleBackColor = true;
            this.btn_cpanel.Click += new System.EventHandler(this.btn_cpanel_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(1068, 26);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(167, 22);
            this.txt_search.TabIndex = 25;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // dgv_commitee
            // 
            this.dgv_commitee.AllowUserToAddRows = false;
            this.dgv_commitee.AllowUserToDeleteRows = false;
            this.dgv_commitee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_commitee.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_commitee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_commitee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_commitee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgv_commitee.Location = new System.Drawing.Point(17, 225);
            this.dgv_commitee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_commitee.Name = "dgv_commitee";
            this.dgv_commitee.ReadOnly = true;
            this.dgv_commitee.RowHeadersVisible = false;
            this.dgv_commitee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_commitee.Size = new System.Drawing.Size(1392, 308);
            this.dgv_commitee.TabIndex = 26;
            this.dgv_commitee.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_commitee_MouseClick);
            this.dgv_commitee.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_commitee_MouseDoubleClick);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.No;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(693, 11);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(132, 55);
            this.btn_search.TabIndex = 27;
            this.btn_search.Text = "SEARCH";
            this.Tooltip.SetToolTip(this.btn_search, "Search");
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.MouseEnter += new System.EventHandler(this.btn_search_MouseEnter);
            this.btn_search.MouseLeave += new System.EventHandler(this.btn_search_MouseLeave);
            // 
            // txt_cmty_year
            // 
            this.txt_cmty_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmty_year.Location = new System.Drawing.Point(133, 52);
            this.txt_cmty_year.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cmty_year.Mask = "0000/0000";
            this.txt_cmty_year.Name = "txt_cmty_year";
            this.txt_cmty_year.Size = new System.Drawing.Size(168, 24);
            this.txt_cmty_year.TabIndex = 0;
            this.txt_cmty_year.Tag = "M";
            this.Tooltip.SetToolTip(this.txt_cmty_year, "\"YY/YY\"");
            this.txt_cmty_year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cmty_year_KeyPress);
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l6.Location = new System.Drawing.Point(381, 92);
            this.l6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(50, 18);
            this.l6.TabIndex = 6;
            this.l6.Text = "Status";
            // 
            // txt_note
            // 
            this.txt_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_note.Location = new System.Drawing.Point(1057, 20);
            this.txt_note.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(275, 109);
            this.txt_note.TabIndex = 6;
            // 
            // txt_dos
            // 
            this.txt_dos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dos.Location = new System.Drawing.Point(439, 16);
            this.txt_dos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_dos.Mask = "00/00/0000";
            this.txt_dos.Name = "txt_dos";
            this.txt_dos.Size = new System.Drawing.Size(168, 24);
            this.txt_dos.TabIndex = 2;
            this.txt_dos.Tag = "M";
            this.Tooltip.SetToolTip(this.txt_dos, "\"MM/DD/YY\"");
            this.txt_dos.ValidatingType = typeof(System.DateTime);
            this.txt_dos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Dos_KeyPress);
            // 
            // txt_doe
            // 
            this.txt_doe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doe.Location = new System.Drawing.Point(439, 52);
            this.txt_doe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_doe.Mask = "00/00/0000";
            this.txt_doe.Name = "txt_doe";
            this.txt_doe.Size = new System.Drawing.Size(168, 24);
            this.txt_doe.TabIndex = 3;
            this.txt_doe.Tag = "M";
            this.Tooltip.SetToolTip(this.txt_doe, "\"MM/DD/YY\"");
            this.txt_doe.ValidatingType = typeof(System.DateTime);
            this.txt_doe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_doe_KeyPress);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Location = new System.Drawing.Point(17, 8);
            this.btn_new.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(127, 55);
            this.btn_new.TabIndex = 34;
            this.btn_new.Text = "NEW";
            this.Tooltip.SetToolTip(this.btn_new, "Create New Committee");
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            this.btn_new.MouseEnter += new System.EventHandler(this.btn_new_MouseEnter);
            this.btn_new.MouseLeave += new System.EventHandler(this.btn_new_MouseLeave);
            // 
            // cmb_status
            // 
            this.cmb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "CANCELED",
            "RUNNING",
            "PENDING",
            "FINISHED"});
            this.cmb_status.Location = new System.Drawing.Point(439, 87);
            this.cmb_status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(168, 26);
            this.cmb_status.TabIndex = 4;
            this.cmb_status.Tag = "M";
            this.cmb_status.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_status_KeyPress);
            // 
            // l21
            // 
            this.l21.AutoSize = true;
            this.l21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l21.Location = new System.Drawing.Point(663, 45);
            this.l21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l21.Name = "l21";
            this.l21.Size = new System.Drawing.Size(75, 18);
            this.l21.TabIndex = 102;
            this.l21.Text = "Secretary ";
            // 
            // rdb_by_id
            // 
            this.rdb_by_id.AutoSize = true;
            this.rdb_by_id.Checked = true;
            this.rdb_by_id.Location = new System.Drawing.Point(865, 26);
            this.rdb_by_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb_by_id.Name = "rdb_by_id";
            this.rdb_by_id.Size = new System.Drawing.Size(62, 21);
            this.rdb_by_id.TabIndex = 106;
            this.rdb_by_id.TabStop = true;
            this.rdb_by_id.Text = "By ID";
            this.rdb_by_id.UseVisualStyleBackColor = true;
            this.rdb_by_id.CheckedChanged += new System.EventHandler(this.rdb_by_id_CheckedChanged);
            // 
            // rdb_by_word
            // 
            this.rdb_by_word.AutoSize = true;
            this.rdb_by_word.Location = new System.Drawing.Point(951, 27);
            this.rdb_by_word.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb_by_word.Name = "rdb_by_word";
            this.rdb_by_word.Size = new System.Drawing.Size(79, 21);
            this.rdb_by_word.TabIndex = 107;
            this.rdb_by_word.TabStop = true;
            this.rdb_by_word.Text = "By Year";
            this.rdb_by_word.UseVisualStyleBackColor = true;
            this.rdb_by_word.CheckedChanged += new System.EventHandler(this.rdb_by_word_CheckedChanged);
            // 
            // gbx_commitee
            // 
            this.gbx_commitee.Controls.Add(this.txt_cmty_id);
            this.gbx_commitee.Controls.Add(this.l1);
            this.gbx_commitee.Controls.Add(this.l2);
            this.gbx_commitee.Controls.Add(this.l21);
            this.gbx_commitee.Controls.Add(this.l5);
            this.gbx_commitee.Controls.Add(this.cmb_status);
            this.gbx_commitee.Controls.Add(this.txt_strength);
            this.gbx_commitee.Controls.Add(this.l6);
            this.gbx_commitee.Controls.Add(this.txt_doe);
            this.gbx_commitee.Controls.Add(this.l3);
            this.gbx_commitee.Controls.Add(this.txt_dos);
            this.gbx_commitee.Controls.Add(this.l4);
            this.gbx_commitee.Controls.Add(this.txt_cmty_year);
            this.gbx_commitee.Controls.Add(this.l7);
            this.gbx_commitee.Controls.Add(this.txt_note);
            this.gbx_commitee.Controls.Add(this.txt_message);
            this.gbx_commitee.Controls.Add(this.l8);
            this.gbx_commitee.Location = new System.Drawing.Point(11, 63);
            this.gbx_commitee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_commitee.Name = "gbx_commitee";
            this.gbx_commitee.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_commitee.Size = new System.Drawing.Size(1398, 154);
            this.gbx_commitee.TabIndex = 108;
            this.gbx_commitee.TabStop = false;
            // 
            // Frm_Commitee_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1422, 546);
            this.Controls.Add(this.gbx_commitee);
            this.Controls.Add(this.rdb_by_word);
            this.Controls.Add(this.rdb_by_id);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dgv_commitee);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_cpanel);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Commitee_Master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "M";
            this.Text = "Committee Details [MAS]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Commitee_Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commitee)).EndInit();
            this.gbx_commitee.ResumeLayout(false);
            this.gbx_commitee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cmty_id;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.TextBox txt_strength;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Label l8;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_cpanel;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView dgv_commitee;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.MaskedTextBox txt_cmty_year;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.MaskedTextBox txt_dos;
        private System.Windows.Forms.MaskedTextBox txt_doe;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.ToolTip Tooltip;
        private System.Windows.Forms.Label l21;
        private System.Windows.Forms.RadioButton rdb_by_id;
        private System.Windows.Forms.RadioButton rdb_by_word;
        private System.Windows.Forms.GroupBox gbx_commitee;
    }
}