namespace MAS
{
    partial class Frm_Committee_Lokkup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Committee_Lokkup));
            this.l6 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.txt_cmty_id = new System.Windows.Forms.TextBox();
            this.cmb_select = new System.Windows.Forms.ComboBox();
            this.lbl_choose = new System.Windows.Forms.Label();
            this.txt_cmty_year = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l6.Location = new System.Drawing.Point(61, 96);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(41, 15);
            this.l6.TabIndex = 105;
            this.l6.Text = "Status";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(7, 70);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(95, 15);
            this.l2.TabIndex = 103;
            this.l2.Text = "Committee Year";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(20, 44);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(82, 15);
            this.l1.TabIndex = 102;
            this.l1.Text = "Committee ID";
            // 
            // txt_cmty_id
            // 
            this.txt_cmty_id.Location = new System.Drawing.Point(110, 41);
            this.txt_cmty_id.Name = "txt_cmty_id";
            this.txt_cmty_id.Size = new System.Drawing.Size(112, 20);
            this.txt_cmty_id.TabIndex = 106;
            // 
            // cmb_select
            // 
            this.cmb_select.FormattingEnabled = true;
            this.cmb_select.Location = new System.Drawing.Point(110, 12);
            this.cmb_select.Name = "cmb_select";
            this.cmb_select.Size = new System.Drawing.Size(112, 21);
            this.cmb_select.TabIndex = 107;
            this.cmb_select.SelectedIndexChanged += new System.EventHandler(this.cmb_select_SelectedIndexChanged);
            // 
            // lbl_choose
            // 
            this.lbl_choose.AutoSize = true;
            this.lbl_choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choose.Location = new System.Drawing.Point(61, 15);
            this.lbl_choose.Name = "lbl_choose";
            this.lbl_choose.Size = new System.Drawing.Size(41, 15);
            this.lbl_choose.TabIndex = 108;
            this.lbl_choose.Text = "Select";
            // 
            // txt_cmty_year
            // 
            this.txt_cmty_year.Location = new System.Drawing.Point(110, 67);
            this.txt_cmty_year.Name = "txt_cmty_year";
            this.txt_cmty_year.Size = new System.Drawing.Size(112, 20);
            this.txt_cmty_year.TabIndex = 109;
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(110, 93);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(112, 20);
            this.txt_status.TabIndex = 110;
            // 
            // btn_select
            // 
            this.btn_select.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_select.BackgroundImage")));
            this.btn_select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_select.Location = new System.Drawing.Point(110, 119);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(66, 37);
            this.btn_select.TabIndex = 112;
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // Frm_Committee_Lokkup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(239, 169);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_cmty_year);
            this.Controls.Add(this.lbl_choose);
            this.Controls.Add(this.cmb_select);
            this.Controls.Add(this.txt_cmty_id);
            this.Controls.Add(this.l6);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Committee_Lokkup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Committee Lookup";
            this.Load += new System.EventHandler(this.Frm_Committee_Lokkup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.TextBox txt_cmty_id;
        private System.Windows.Forms.ComboBox cmb_select;
        private System.Windows.Forms.Label lbl_choose;
        private System.Windows.Forms.TextBox txt_cmty_year;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Button btn_select;
    }
}