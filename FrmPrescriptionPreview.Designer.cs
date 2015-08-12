namespace WindowsAutoPrint
{
    partial class FrmPrescriptionPreview
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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.prg_Print = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // prg_Print
            // 
            this.prg_Print.Location = new System.Drawing.Point(2, 1);
            this.prg_Print.Name = "prg_Print";
            this.prg_Print.Size = new System.Drawing.Size(744, 98);
            this.prg_Print.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prg_Print.TabIndex = 2;
            // 
            // FrmPrescriptionPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 102);
            this.Controls.Add(this.prg_Print);
            this.Name = "FrmPrescriptionPreview";
            this.Text = "FrmPrescriptionPreview";
            this.Load += new System.EventHandler(this.FrmPrescriptionPreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ProgressBar prg_Print;
    }
}