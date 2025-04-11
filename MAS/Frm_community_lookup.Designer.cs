namespace MAS
{
    partial class Frm_community_lookup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_community_lookup));
            this.dgv_cmnty_lookup = new System.Windows.Forms.DataGridView();
            this.btn_Select = new System.Windows.Forms.Button();
            this.l7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_search_cmnty = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.pbx_image = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.txt_mob = new System.Windows.Forms.TextBox();
            this.txt_dob = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_cmntid = new System.Windows.Forms.TextBox();
            this.l3 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cmnty_lookup)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_image)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_cmnty_lookup
            // 
            this.dgv_cmnty_lookup.AllowUserToAddRows = false;
            this.dgv_cmnty_lookup.AllowUserToDeleteRows = false;
            this.dgv_cmnty_lookup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cmnty_lookup.Location = new System.Drawing.Point(14, 232);
            this.dgv_cmnty_lookup.Name = "dgv_cmnty_lookup";
            this.dgv_cmnty_lookup.ReadOnly = true;
            this.dgv_cmnty_lookup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cmnty_lookup.Size = new System.Drawing.Size(391, 181);
            this.dgv_cmnty_lookup.TabIndex = 69;
            this.dgv_cmnty_lookup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_cmnty_lookup_MouseClick);
            // 
            // btn_Select
            // 
            this.btn_Select.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Select.BackgroundImage")));
            this.btn_Select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Select.ForeColor = System.Drawing.Color.White;
            this.btn_Select.Location = new System.Drawing.Point(330, 12);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(75, 47);
            this.btn_Select.TabIndex = 67;
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.Location = new System.Drawing.Point(36, 134);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(38, 13);
            this.l7.TabIndex = 61;
            this.l7.Text = "Mobile";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_search_cmnty);
            this.groupBox1.Controls.Add(this.lbl_search);
            this.groupBox1.Location = new System.Drawing.Point(10, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 53);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_search_cmnty
            // 
            this.txt_search_cmnty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_search_cmnty.Location = new System.Drawing.Point(13, 27);
            this.txt_search_cmnty.Name = "txt_search_cmnty";
            this.txt_search_cmnty.Size = new System.Drawing.Size(295, 20);
            this.txt_search_cmnty.TabIndex = 51;
            this.txt_search_cmnty.TextChanged += new System.EventHandler(this.txt_search_cmnty_TextChanged);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(6, 11);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(213, 13);
            this.lbl_search.TabIndex = 50;
            this.lbl_search.Text = "Type Name, House Name, or Community ID";
            // 
            // pbx_image
            // 
            this.pbx_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_image.ErrorImage = null;
            this.pbx_image.ImageLocation = "s";
            this.pbx_image.Location = new System.Drawing.Point(275, 77);
            this.pbx_image.Name = "pbx_image";
            this.pbx_image.Size = new System.Drawing.Size(127, 142);
            this.pbx_image.TabIndex = 71;
            this.pbx_image.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_adress);
            this.groupBox2.Controls.Add(this.txt_mob);
            this.groupBox2.Controls.Add(this.txt_dob);
            this.groupBox2.Controls.Add(this.txt_name);
            this.groupBox2.Controls.Add(this.l7);
            this.groupBox2.Controls.Add(this.txt_cmntid);
            this.groupBox2.Controls.Add(this.l3);
            this.groupBox2.Controls.Add(this.l6);
            this.groupBox2.Controls.Add(this.l4);
            this.groupBox2.Controls.Add(this.l5);
            this.groupBox2.Location = new System.Drawing.Point(11, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 161);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            // 
            // txt_adress
            // 
            this.txt_adress.Enabled = false;
            this.txt_adress.Location = new System.Drawing.Point(88, 104);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.ReadOnly = true;
            this.txt_adress.Size = new System.Drawing.Size(156, 20);
            this.txt_adress.TabIndex = 79;
            // 
            // txt_mob
            // 
            this.txt_mob.Enabled = false;
            this.txt_mob.Location = new System.Drawing.Point(88, 130);
            this.txt_mob.Name = "txt_mob";
            this.txt_mob.ReadOnly = true;
            this.txt_mob.Size = new System.Drawing.Size(156, 20);
            this.txt_mob.TabIndex = 78;
            // 
            // txt_dob
            // 
            this.txt_dob.Enabled = false;
            this.txt_dob.Location = new System.Drawing.Point(88, 78);
            this.txt_dob.Name = "txt_dob";
            this.txt_dob.ReadOnly = true;
            this.txt_dob.Size = new System.Drawing.Size(156, 20);
            this.txt_dob.TabIndex = 77;
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.Location = new System.Drawing.Point(88, 49);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(156, 20);
            this.txt_name.TabIndex = 76;
            // 
            // txt_cmntid
            // 
            this.txt_cmntid.Enabled = false;
            this.txt_cmntid.Location = new System.Drawing.Point(88, 19);
            this.txt_cmntid.Name = "txt_cmntid";
            this.txt_cmntid.ReadOnly = true;
            this.txt_cmntid.Size = new System.Drawing.Size(156, 20);
            this.txt_cmntid.TabIndex = 75;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(9, 26);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(72, 13);
            this.l3.TabIndex = 71;
            this.l3.Text = "Community ID";
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Location = new System.Drawing.Point(36, 108);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(45, 13);
            this.l6.TabIndex = 74;
            this.l6.Text = "Address";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(46, 56);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(35, 13);
            this.l4.TabIndex = 72;
            this.l4.Text = "Name";
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Location = new System.Drawing.Point(51, 85);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(30, 13);
            this.l5.TabIndex = 73;
            this.l5.Text = "DOB";
            // 
            // Frm_community_lookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(417, 425);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pbx_image);
            this.Controls.Add(this.dgv_cmnty_lookup);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Frm_community_lookup";
            this.Text = "Frm_community_lookup";
            this.Load += new System.EventHandler(this.Frm_community_lookup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cmnty_lookup)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_image)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cmnty_lookup;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_search_cmnty;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.PictureBox pbx_image;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.TextBox txt_mob;
        private System.Windows.Forms.TextBox txt_dob;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_cmntid;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l5;
    }
}