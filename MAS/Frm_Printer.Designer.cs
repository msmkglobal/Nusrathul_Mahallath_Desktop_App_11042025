namespace MAS
{
    partial class Frm_Printer
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
            this.Crv_Printer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // Crv_Printer
            // 
            this.Crv_Printer.ActiveViewIndex = -1;
            this.Crv_Printer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Crv_Printer.Cursor = System.Windows.Forms.Cursors.Default;
            this.Crv_Printer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Crv_Printer.Location = new System.Drawing.Point(0, 0);
            this.Crv_Printer.Margin = new System.Windows.Forms.Padding(4);
            this.Crv_Printer.Name = "Crv_Printer";
            this.Crv_Printer.SelectionFormula = "";
            this.Crv_Printer.Size = new System.Drawing.Size(1281, 628);
            this.Crv_Printer.TabIndex = 0;
            this.Crv_Printer.ToolPanelWidth = 267;
            this.Crv_Printer.ViewTimeSelectionFormula = "";
            // 
            // Frm_Printer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 628);
            this.Controls.Add(this.Crv_Printer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Printer";
            this.Text = "Frm_Printer";
            this.Load += new System.EventHandler(this.Frm_Printer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Crv_Printer;
    }
}