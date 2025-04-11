namespace MAS
{
    partial class Frm_Resi_lookup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Resi_lookup));
            this.dgv_resi_llookup = new System.Windows.Forms.DataGridView();
            this.btn_select = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_resi_id = new System.Windows.Forms.TextBox();
            this.txt_residance_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_owner_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_bldg_num = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_place = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resi_llookup)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_resi_llookup
            // 
            this.dgv_resi_llookup.AllowUserToAddRows = false;
            this.dgv_resi_llookup.AllowUserToDeleteRows = false;
            this.dgv_resi_llookup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resi_llookup.Location = new System.Drawing.Point(268, 12);
            this.dgv_resi_llookup.Name = "dgv_resi_llookup";
            this.dgv_resi_llookup.ReadOnly = true;
            this.dgv_resi_llookup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_resi_llookup.Size = new System.Drawing.Size(465, 263);
            this.dgv_resi_llookup.TabIndex = 31;
            this.dgv_resi_llookup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_resi_llookup_MouseClick);
            // 
            // btn_select
            // 
            this.btn_select.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_select.BackgroundImage")));
            this.btn_select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_select.Location = new System.Drawing.Point(197, 230);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(65, 45);
            this.btn_select.TabIndex = 32;
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 45);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Search";
            // 
            // txt_search
            // 
            this.txt_search.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(114, 14);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(104, 21);
            this.txt_search.TabIndex = 31;
            this.txt_search.Tag = "M";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_resi_id);
            this.groupBox2.Controls.Add(this.txt_residance_name);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_owner_name);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_bldg_num);
            this.groupBox2.Controls.Add(this.txt_phone);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_place);
            this.groupBox2.Location = new System.Drawing.Point(12, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 163);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(73, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "JNO";
            // 
            // txt_resi_id
            // 
            this.txt_resi_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_resi_id.Enabled = false;
            this.txt_resi_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resi_id.Location = new System.Drawing.Point(114, 11);
            this.txt_resi_id.Name = "txt_resi_id";
            this.txt_resi_id.Size = new System.Drawing.Size(104, 21);
            this.txt_resi_id.TabIndex = 45;
            this.txt_resi_id.Tag = "M";
            this.txt_resi_id.TextChanged += new System.EventHandler(this.txt_resi_id_TextChanged);
            // 
            // txt_residance_name
            // 
            this.txt_residance_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_residance_name.Enabled = false;
            this.txt_residance_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_residance_name.Location = new System.Drawing.Point(114, 59);
            this.txt_residance_name.Name = "txt_residance_name";
            this.txt_residance_name.Size = new System.Drawing.Size(104, 21);
            this.txt_residance_name.TabIndex = 40;
            this.txt_residance_name.Tag = "M";
            this.txt_residance_name.TextChanged += new System.EventHandler(this.txt_residance_name_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "Building Number";
            // 
            // txt_owner_name
            // 
            this.txt_owner_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_owner_name.Enabled = false;
            this.txt_owner_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_owner_name.Location = new System.Drawing.Point(114, 83);
            this.txt_owner_name.Name = "txt_owner_name";
            this.txt_owner_name.Size = new System.Drawing.Size(104, 21);
            this.txt_owner_name.TabIndex = 41;
            this.txt_owner_name.Tag = "M";
            this.txt_owner_name.TextChanged += new System.EventHandler(this.txt_owner_name_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 37;
            this.label7.Text = "Owner Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 15);
            this.label8.TabIndex = 38;
            this.label8.Text = "Residence Name";
            // 
            // txt_bldg_num
            // 
            this.txt_bldg_num.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_bldg_num.Enabled = false;
            this.txt_bldg_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bldg_num.Location = new System.Drawing.Point(114, 35);
            this.txt_bldg_num.Name = "txt_bldg_num";
            this.txt_bldg_num.Size = new System.Drawing.Size(104, 21);
            this.txt_bldg_num.TabIndex = 36;
            this.txt_bldg_num.Tag = "M";
            this.txt_bldg_num.TextChanged += new System.EventHandler(this.txt_bldg_num_TextChanged_1);
            // 
            // txt_phone
            // 
            this.txt_phone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_phone.Enabled = false;
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(114, 131);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(104, 21);
            this.txt_phone.TabIndex = 44;
            this.txt_phone.TextChanged += new System.EventHandler(this.txt_phone_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(66, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 15);
            this.label15.TabIndex = 43;
            this.label15.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(77, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "Area";
            // 
            // txt_place
            // 
            this.txt_place.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_place.Enabled = false;
            this.txt_place.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_place.Location = new System.Drawing.Point(114, 107);
            this.txt_place.Name = "txt_place";
            this.txt_place.Size = new System.Drawing.Size(104, 21);
            this.txt_place.TabIndex = 42;
            this.txt_place.Tag = "M";
            this.txt_place.TextChanged += new System.EventHandler(this.txt_place_TextChanged);
            // 
            // Frm_Resi_lookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(741, 283);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.dgv_resi_llookup);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Frm_Resi_lookup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_Resi_lookup";
            this.Load += new System.EventHandler(this.Frm_Resi_lookup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resi_llookup)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_resi_llookup;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_resi_id;
        private System.Windows.Forms.TextBox txt_residance_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_owner_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_bldg_num;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_place;
    }
}