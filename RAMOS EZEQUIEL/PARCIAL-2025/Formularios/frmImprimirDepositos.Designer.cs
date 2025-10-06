namespace PARCIAL_2025.Formularios
{
    partial class frmImprimirDepositos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImprimirDepositos));
            this.rptViewverDep = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptViewverDep
            // 
            this.rptViewverDep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewverDep.LocalReport.ReportEmbeddedResource = "PARCIAL_2025.Reportes.RptDepositos.rdlc";
            this.rptViewverDep.Location = new System.Drawing.Point(0, 0);
            this.rptViewverDep.Name = "rptViewverDep";
            this.rptViewverDep.ServerReport.BearerToken = null;
            this.rptViewverDep.Size = new System.Drawing.Size(800, 450);
            this.rptViewverDep.TabIndex = 0;
            // 
            // frmImprimirDepositos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptViewverDep);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImprimirDepositos";
            this.Text = "Parcial 2025 - Imprimir Depósitos";
            this.Load += new System.EventHandler(this.frmImprimirDepositos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptViewverDep;
    }
}