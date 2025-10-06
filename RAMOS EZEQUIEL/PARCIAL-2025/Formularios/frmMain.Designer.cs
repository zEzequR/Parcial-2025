namespace PARCIAL_2025.Formularios
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainBar = new System.Windows.Forms.MenuStrip();
            this.itemsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.depBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsDepBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.depImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.stockImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.backupBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.mainBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainBar
            // 
            this.mainBar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsBtn,
            this.depBtn,
            this.itemsDepBtn,
            this.reportesBtn,
            this.backupBtn,
            this.SalirBtn});
            this.mainBar.Location = new System.Drawing.Point(0, 0);
            this.mainBar.Name = "mainBar";
            this.mainBar.Size = new System.Drawing.Size(866, 29);
            this.mainBar.TabIndex = 1;
            // 
            // itemsBtn
            // 
            this.itemsBtn.Name = "itemsBtn";
            this.itemsBtn.Size = new System.Drawing.Size(65, 25);
            this.itemsBtn.Text = "Ítems";
            this.itemsBtn.Click += new System.EventHandler(this.itemsBtn_Click);
            // 
            // depBtn
            // 
            this.depBtn.Name = "depBtn";
            this.depBtn.Size = new System.Drawing.Size(97, 25);
            this.depBtn.Text = "Depositos";
            this.depBtn.Click += new System.EventHandler(this.depBtn_Click);
            // 
            // itemsDepBtn
            // 
            this.itemsDepBtn.Name = "itemsDepBtn";
            this.itemsDepBtn.Size = new System.Drawing.Size(143, 25);
            this.itemsDepBtn.Text = "Ítems depositos";
            this.itemsDepBtn.Click += new System.EventHandler(this.itemsDepBtn_Click);
            // 
            // reportesBtn
            // 
            this.reportesBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsImprimir,
            this.depImprimir,
            this.stockImprimir});
            this.reportesBtn.Name = "reportesBtn";
            this.reportesBtn.Size = new System.Drawing.Size(91, 25);
            this.reportesBtn.Text = "Reportes";
            // 
            // itemsImprimir
            // 
            this.itemsImprimir.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsImprimir.Name = "itemsImprimir";
            this.itemsImprimir.Size = new System.Drawing.Size(137, 22);
            this.itemsImprimir.Text = "Ítems";
            this.itemsImprimir.Click += new System.EventHandler(this.itemsImprimir_Click);
            // 
            // depImprimir
            // 
            this.depImprimir.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depImprimir.Name = "depImprimir";
            this.depImprimir.Size = new System.Drawing.Size(137, 22);
            this.depImprimir.Text = "Depósitos";
            this.depImprimir.Click += new System.EventHandler(this.depImprimir_Click);
            // 
            // stockImprimir
            // 
            this.stockImprimir.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockImprimir.Name = "stockImprimir";
            this.stockImprimir.Size = new System.Drawing.Size(137, 22);
            this.stockImprimir.Text = "Stock";
            this.stockImprimir.Click += new System.EventHandler(this.stockImprimir_Click);
            // 
            // backupBtn
            // 
            this.backupBtn.Name = "backupBtn";
            this.backupBtn.Size = new System.Drawing.Size(81, 25);
            this.backupBtn.Text = "Backup";
            this.backupBtn.Click += new System.EventHandler(this.backupBtn_Click);
            // 
            // SalirBtn
            // 
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(52, 25);
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 518);
            this.Controls.Add(this.mainBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainBar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parcial 2025 - Main";
            this.mainBar.ResumeLayout(false);
            this.mainBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainBar;
        private System.Windows.Forms.ToolStripMenuItem itemsBtn;
        private System.Windows.Forms.ToolStripMenuItem depBtn;
        private System.Windows.Forms.ToolStripMenuItem itemsDepBtn;
        private System.Windows.Forms.ToolStripMenuItem reportesBtn;
        private System.Windows.Forms.ToolStripMenuItem backupBtn;
        private System.Windows.Forms.ToolStripMenuItem SalirBtn;
        private System.Windows.Forms.ToolStripMenuItem itemsImprimir;
        private System.Windows.Forms.ToolStripMenuItem depImprimir;
        private System.Windows.Forms.ToolStripMenuItem stockImprimir;
    }
}