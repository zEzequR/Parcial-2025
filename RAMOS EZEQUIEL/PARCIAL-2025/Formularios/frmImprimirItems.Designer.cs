namespace PARCIAL_2025.Formularios
{
    partial class frmImprimirItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImprimirItems));
            this.rptViewverItems = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptViewverItems
            // 
            this.rptViewverItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewverItems.LocalReport.ReportEmbeddedResource = "PARCIAL_2025.Reportes.RptItems.rdlc";
            this.rptViewverItems.Location = new System.Drawing.Point(0, 0);
            this.rptViewverItems.Name = "rptViewverItems";
            this.rptViewverItems.ServerReport.BearerToken = null;
            this.rptViewverItems.Size = new System.Drawing.Size(875, 526);
            this.rptViewverItems.TabIndex = 0;
            // 
            // frmImprimirItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 526);
            this.Controls.Add(this.rptViewverItems);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImprimirItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parcial 2025 - Imprimir Ítems";
            this.Load += new System.EventHandler(this.frmImprimirItems_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptViewverItems;
    }
}