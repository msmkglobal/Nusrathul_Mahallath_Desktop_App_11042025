namespace MAS
{
    partial class Frm_Food
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Food));
            this.lbl_resi_id = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.txt_resi_id = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_cpanel = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.dgv_food = new System.Windows.Forms.DataGridView();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.cbx_dinner = new System.Windows.Forms.CheckBox();
            this.cbx_lunch = new System.Windows.Forms.CheckBox();
            this.cbx_tea = new System.Windows.Forms.CheckBox();
            this.cbx_breakfast = new System.Windows.Forms.CheckBox();
            this.rdb_by_word = new System.Windows.Forms.RadioButton();
            this.rdb_byresi_id = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_food)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_resi_id
            // 
            this.lbl_resi_id.AutoSize = true;
            this.lbl_resi_id.Location = new System.Drawing.Point(9, 28);
            this.lbl_resi_id.Name = "lbl_resi_id";
            this.lbl_resi_id.Size = new System.Drawing.Size(72, 13);
            this.lbl_resi_id.TabIndex = 0;
            this.lbl_resi_id.Text = "Residence ID";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(51, 56);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(30, 13);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "Date";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(345, 32);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(54, 13);
            this.lbl_description.TabIndex = 6;
            this.lbl_description.Text = "Desription";
            // 
            // txt_resi_id
            // 
            this.txt_resi_id.Location = new System.Drawing.Point(94, 24);
            this.txt_resi_id.Name = "txt_resi_id";
            this.txt_resi_id.Size = new System.Drawing.Size(83, 20);
            this.txt_resi_id.TabIndex = 7;
            this.txt_resi_id.TextChanged += new System.EventHandler(this.txt_resi_id_TextChanged);
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(428, 25);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(196, 44);
            this.txt_description.TabIndex = 13;
            // 
            // btn_new
            // 
            this.btn_new.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_new.BackgroundImage")));
            this.btn_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Location = new System.Drawing.Point(0, -1);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(66, 45);
            this.btn_new.TabIndex = 52;
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(390, -1);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(66, 45);
            this.btn_search.TabIndex = 51;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(634, 14);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(87, 20);
            this.txt_search.TabIndex = 50;
            // 
            // btn_cpanel
            // 
            this.btn_cpanel.Location = new System.Drawing.Point(455, -1);
            this.btn_cpanel.Name = "btn_cpanel";
            this.btn_cpanel.Size = new System.Drawing.Size(314, 46);
            this.btn_cpanel.TabIndex = 49;
            this.btn_cpanel.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancel.BackgroundImage")));
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(325, -1);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(66, 45);
            this.btn_cancel.TabIndex = 48;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_update.BackgroundImage")));
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(195, -1);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(66, 45);
            this.btn_update.TabIndex = 47;
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(260, -1);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(66, 45);
            this.btn_delete.TabIndex = 46;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_edit.BackgroundImage")));
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(130, -1);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(66, 45);
            this.btn_edit.TabIndex = 45;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save.BackgroundImage")));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(65, -1);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(66, 45);
            this.btn_save.TabIndex = 44;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 359);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(766, 22);
            this.statusStrip1.TabIndex = 53;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dtp_date
            // 
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(94, 50);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(83, 20);
            this.dtp_date.TabIndex = 54;
            // 
            // dgv_food
            // 
            this.dgv_food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_food.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgv_food.Location = new System.Drawing.Point(14, 198);
            this.dgv_food.Name = "dgv_food";
            this.dgv_food.Size = new System.Drawing.Size(707, 131);
            this.dgv_food.TabIndex = 55;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.txt_description);
            this.groupBox.Controls.Add(this.lbl_description);
            this.groupBox.Controls.Add(this.dtp_date);
            this.groupBox.Controls.Add(this.cbx_dinner);
            this.groupBox.Controls.Add(this.cbx_lunch);
            this.groupBox.Controls.Add(this.cbx_tea);
            this.groupBox.Controls.Add(this.cbx_breakfast);
            this.groupBox.Controls.Add(this.txt_resi_id);
            this.groupBox.Controls.Add(this.lbl_resi_id);
            this.groupBox.Controls.Add(this.lbl_date);
            this.groupBox.Location = new System.Drawing.Point(29, 67);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(692, 112);
            this.groupBox.TabIndex = 56;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Food Details";
            // 
            // cbx_dinner
            // 
            this.cbx_dinner.AutoSize = true;
            this.cbx_dinner.Location = new System.Drawing.Point(274, 50);
            this.cbx_dinner.Name = "cbx_dinner";
            this.cbx_dinner.Size = new System.Drawing.Size(57, 17);
            this.cbx_dinner.TabIndex = 3;
            this.cbx_dinner.Text = "Dinner";
            this.cbx_dinner.UseVisualStyleBackColor = true;
            // 
            // cbx_lunch
            // 
            this.cbx_lunch.AutoSize = true;
            this.cbx_lunch.Location = new System.Drawing.Point(188, 53);
            this.cbx_lunch.Name = "cbx_lunch";
            this.cbx_lunch.Size = new System.Drawing.Size(56, 17);
            this.cbx_lunch.TabIndex = 2;
            this.cbx_lunch.Text = "Lunch";
            this.cbx_lunch.UseVisualStyleBackColor = true;
            // 
            // cbx_tea
            // 
            this.cbx_tea.AutoSize = true;
            this.cbx_tea.Location = new System.Drawing.Point(274, 24);
            this.cbx_tea.Name = "cbx_tea";
            this.cbx_tea.Size = new System.Drawing.Size(45, 17);
            this.cbx_tea.TabIndex = 1;
            this.cbx_tea.Text = "Tea";
            this.cbx_tea.UseVisualStyleBackColor = true;
            // 
            // cbx_breakfast
            // 
            this.cbx_breakfast.AutoSize = true;
            this.cbx_breakfast.Location = new System.Drawing.Point(188, 24);
            this.cbx_breakfast.Name = "cbx_breakfast";
            this.cbx_breakfast.Size = new System.Drawing.Size(71, 17);
            this.cbx_breakfast.TabIndex = 0;
            this.cbx_breakfast.Text = "Breakfast";
            this.cbx_breakfast.UseVisualStyleBackColor = true;
            // 
            // rdb_by_word
            // 
            this.rdb_by_word.AutoSize = true;
            this.rdb_by_word.Location = new System.Drawing.Point(566, 16);
            this.rdb_by_word.Name = "rdb_by_word";
            this.rdb_by_word.Size = new System.Drawing.Size(51, 17);
            this.rdb_by_word.TabIndex = 55;
            this.rdb_by_word.TabStop = true;
            this.rdb_by_word.Text = "Word";
            this.rdb_by_word.UseVisualStyleBackColor = true;
            // 
            // rdb_byresi_id
            // 
            this.rdb_byresi_id.AutoSize = true;
            this.rdb_byresi_id.Checked = true;
            this.rdb_byresi_id.Location = new System.Drawing.Point(492, 16);
            this.rdb_byresi_id.Name = "rdb_byresi_id";
            this.rdb_byresi_id.Size = new System.Drawing.Size(60, 17);
            this.rdb_byresi_id.TabIndex = 56;
            this.rdb_byresi_id.TabStop = true;
            this.rdb_byresi_id.Text = "Resi ID";
            this.rdb_byresi_id.UseVisualStyleBackColor = true;
            // 
            // Frm_Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 381);
            this.Controls.Add(this.rdb_by_word);
            this.Controls.Add(this.rdb_byresi_id);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.dgv_food);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_cpanel);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Food";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Food";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_food)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_resi_id;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TextBox txt_resi_id;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_cpanel;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.DataGridView dgv_food;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.CheckBox cbx_dinner;
        private System.Windows.Forms.CheckBox cbx_lunch;
        private System.Windows.Forms.CheckBox cbx_tea;
        private System.Windows.Forms.CheckBox cbx_breakfast;
        private System.Windows.Forms.RadioButton rdb_by_word;
        private System.Windows.Forms.RadioButton rdb_byresi_id;
    }
}