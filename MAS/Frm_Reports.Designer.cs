namespace MAS
{
    partial class Frm_Reports
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
            this.c_print = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.c_search_text = new System.Windows.Forms.TextBox();
            this.c_gridview = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.c_print.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // c_print
            // 
            this.c_print.Controls.Add(this.button1);
            this.c_print.Controls.Add(this.c_search_text);
            this.c_print.Controls.Add(this.label1);
            this.c_print.Dock = System.Windows.Forms.DockStyle.Top;
            this.c_print.Location = new System.Drawing.Point(0, 0);
            this.c_print.Name = "c_print";
            this.c_print.Size = new System.Drawing.Size(1078, 100);
            this.c_print.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // c_search_text
            // 
            this.c_search_text.Location = new System.Drawing.Point(258, 37);
            this.c_search_text.Name = "c_search_text";
            this.c_search_text.Size = new System.Drawing.Size(212, 22);
            this.c_search_text.TabIndex = 1;
            this.c_search_text.TextChanged += new System.EventHandler(this.c_Search_TextChanged);
            // 
            // c_gridview
            // 
            this.c_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.c_gridview.Dock = System.Windows.Forms.DockStyle.Top;
            this.c_gridview.Location = new System.Drawing.Point(0, 100);
            this.c_gridview.Name = "c_gridview";
            this.c_gridview.RowTemplate.Height = 24;
            this.c_gridview.Size = new System.Drawing.Size(1078, 300);
            this.c_gridview.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 394);
            this.Controls.Add(this.c_gridview);
            this.Controls.Add(this.c_print);
            this.Name = "Frm_Reports";
            this.Text = "Frm_Reports";
            this.Load += new System.EventHandler(this.Frm_Reports_Load);
            this.c_print.ResumeLayout(false);
            this.c_print.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel c_print;
        private System.Windows.Forms.TextBox c_search_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView c_gridview;
        private System.Windows.Forms.Button button1;
    }
}