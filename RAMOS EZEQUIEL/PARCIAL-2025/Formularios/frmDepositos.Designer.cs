namespace PARCIAL_2025.Formularios
{
    partial class frmDepositos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepositos));
            this.gridDepositos = new System.Windows.Forms.TableLayoutPanel();
            this.addBtn = new System.Windows.Forms.PictureBox();
            this.deleteBtn = new System.Windows.Forms.PictureBox();
            this.nameDepTxt = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.Label();
            this.nomDepInp = new System.Windows.Forms.TextBox();
            this.numDepInp = new System.Windows.Forms.TextBox();
            this.tableDepositos = new System.Windows.Forms.DataGridView();
            this.sumbitBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.PictureBox();
            this.gridDepositos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDepositos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDepositos
            // 
            this.gridDepositos.ColumnCount = 6;
            this.gridDepositos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.23256F));
            this.gridDepositos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.48367F));
            this.gridDepositos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.4168F));
            this.gridDepositos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.78404F));
            this.gridDepositos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.gridDepositos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.gridDepositos.Controls.Add(this.addBtn, 4, 1);
            this.gridDepositos.Controls.Add(this.deleteBtn, 4, 2);
            this.gridDepositos.Controls.Add(this.nameDepTxt, 1, 5);
            this.gridDepositos.Controls.Add(this.idTxt, 1, 4);
            this.gridDepositos.Controls.Add(this.nomDepInp, 2, 5);
            this.gridDepositos.Controls.Add(this.numDepInp, 2, 4);
            this.gridDepositos.Controls.Add(this.tableDepositos, 1, 1);
            this.gridDepositos.Controls.Add(this.sumbitBtn, 1, 6);
            this.gridDepositos.Controls.Add(this.updateBtn, 4, 3);
            this.gridDepositos.Location = new System.Drawing.Point(0, 0);
            this.gridDepositos.Name = "gridDepositos";
            this.gridDepositos.RowCount = 8;
            this.gridDepositos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.26316F));
            this.gridDepositos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.65693F));
            this.gridDepositos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.83212F));
            this.gridDepositos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.29197F));
            this.gridDepositos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.gridDepositos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.gridDepositos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.gridDepositos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gridDepositos.Size = new System.Drawing.Size(800, 450);
            this.gridDepositos.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
            this.addBtn.Location = new System.Drawing.Point(629, 31);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(82, 78);
            this.addBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addBtn.TabIndex = 1;
            this.addBtn.TabStop = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.Location = new System.Drawing.Point(629, 115);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(82, 73);
            this.deleteBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.TabStop = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // nameDepTxt
            // 
            this.nameDepTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameDepTxt.AutoSize = true;
            this.nameDepTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDepTxt.Location = new System.Drawing.Point(67, 340);
            this.nameDepTxt.Name = "nameDepTxt";
            this.nameDepTxt.Size = new System.Drawing.Size(82, 34);
            this.nameDepTxt.TabIndex = 5;
            this.nameDepTxt.Text = "Nombre de depósito";
            this.nameDepTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idTxt
            // 
            this.idTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idTxt.AutoSize = true;
            this.idTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxt.Location = new System.Drawing.Point(95, 286);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(85, 34);
            this.idTxt.TabIndex = 4;
            this.idTxt.Text = "Número de depósito";
            this.idTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nomDepInp
            // 
            this.nomDepInp.AcceptsTab = true;
            this.nomDepInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomDepInp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomDepInp.Location = new System.Drawing.Point(215, 346);
            this.nomDepInp.Name = "nomDepInp";
            this.nomDepInp.Size = new System.Drawing.Size(144, 21);
            this.nomDepInp.TabIndex = 8;
            // 
            // numDepInp
            // 
            this.numDepInp.AcceptsTab = true;
            this.numDepInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numDepInp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDepInp.Location = new System.Drawing.Point(215, 293);
            this.numDepInp.Name = "numDepInp";
            this.numDepInp.ReadOnly = true;
            this.numDepInp.Size = new System.Drawing.Size(144, 21);
            this.numDepInp.TabIndex = 7;
            // 
            // tableDepositos
            // 
            this.tableDepositos.AllowUserToAddRows = false;
            this.tableDepositos.AllowUserToDeleteRows = false;
            this.tableDepositos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableDepositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDepositos.SetColumnSpan(this.tableDepositos, 3);
            this.tableDepositos.Location = new System.Drawing.Point(67, 31);
            this.tableDepositos.Name = "tableDepositos";
            this.tableDepositos.ReadOnly = true;
            this.gridDepositos.SetRowSpan(this.tableDepositos, 3);
            this.tableDepositos.Size = new System.Drawing.Size(556, 240);
            this.tableDepositos.TabIndex = 0;
            this.tableDepositos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDepositos_CellClick);
            // 
            // sumbitBtn
            // 
            this.sumbitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridDepositos.SetColumnSpan(this.sumbitBtn, 2);
            this.sumbitBtn.Location = new System.Drawing.Point(159, 391);
            this.sumbitBtn.Name = "sumbitBtn";
            this.sumbitBtn.Size = new System.Drawing.Size(110, 27);
            this.sumbitBtn.TabIndex = 6;
            this.sumbitBtn.Text = "-";
            this.sumbitBtn.UseVisualStyleBackColor = true;
            this.sumbitBtn.Click += new System.EventHandler(this.sumbitBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Image = ((System.Drawing.Image)(resources.GetObject("updateBtn.Image")));
            this.updateBtn.Location = new System.Drawing.Point(629, 194);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(82, 77);
            this.updateBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.updateBtn.TabIndex = 3;
            this.updateBtn.TabStop = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // frmDepositos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridDepositos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDepositos";
            this.Text = "Parcial 2025 - Depósitos";
            this.gridDepositos.ResumeLayout(false);
            this.gridDepositos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDepositos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel gridDepositos;
        private System.Windows.Forms.DataGridView tableDepositos;
        private System.Windows.Forms.PictureBox addBtn;
        private System.Windows.Forms.PictureBox deleteBtn;
        private System.Windows.Forms.PictureBox updateBtn;
        private System.Windows.Forms.Label idTxt;
        private System.Windows.Forms.Label nameDepTxt;
        private System.Windows.Forms.Button sumbitBtn;
        private System.Windows.Forms.TextBox numDepInp;
        private System.Windows.Forms.TextBox nomDepInp;
    }
}