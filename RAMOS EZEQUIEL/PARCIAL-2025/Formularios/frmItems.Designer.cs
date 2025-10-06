namespace PARCIAL_2025.Formularios
{
    partial class frmItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItems));
            this.gridItem = new System.Windows.Forms.TableLayoutPanel();
            this.descItemTxt = new System.Windows.Forms.Label();
            this.codItemTxt = new System.Windows.Forms.Label();
            this.descItemInp = new System.Windows.Forms.TextBox();
            this.codItemInp = new System.Windows.Forms.TextBox();
            this.tableItems = new System.Windows.Forms.DataGridView();
            this.precioTxt = new System.Windows.Forms.Label();
            this.fechaVtoTxt = new System.Windows.Forms.Label();
            this.sumbitBtn = new System.Windows.Forms.Button();
            this.precioInp = new System.Windows.Forms.TextBox();
            this.fechaVtoInp = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.PictureBox();
            this.deleteBtn = new System.Windows.Forms.PictureBox();
            this.updateBtn = new System.Windows.Forms.PictureBox();
            this.gridItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // gridItem
            // 
            this.gridItem.ColumnCount = 6;
            this.gridItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.23256F));
            this.gridItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.48367F));
            this.gridItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.4168F));
            this.gridItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.78404F));
            this.gridItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.gridItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.gridItem.Controls.Add(this.descItemTxt, 1, 5);
            this.gridItem.Controls.Add(this.codItemTxt, 1, 4);
            this.gridItem.Controls.Add(this.descItemInp, 2, 5);
            this.gridItem.Controls.Add(this.codItemInp, 2, 4);
            this.gridItem.Controls.Add(this.tableItems, 1, 1);
            this.gridItem.Controls.Add(this.precioTxt, 1, 6);
            this.gridItem.Controls.Add(this.fechaVtoTxt, 1, 7);
            this.gridItem.Controls.Add(this.sumbitBtn, 1, 8);
            this.gridItem.Controls.Add(this.precioInp, 2, 6);
            this.gridItem.Controls.Add(this.fechaVtoInp, 2, 7);
            this.gridItem.Controls.Add(this.addBtn, 4, 1);
            this.gridItem.Controls.Add(this.deleteBtn, 4, 2);
            this.gridItem.Controls.Add(this.updateBtn, 4, 3);
            this.gridItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridItem.Location = new System.Drawing.Point(0, 0);
            this.gridItem.Name = "gridItem";
            this.gridItem.RowCount = 10;
            this.gridItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.109489F));
            this.gridItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.5F));
            this.gridItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.08333F));
            this.gridItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.29197F));
            this.gridItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.gridItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.gridItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.gridItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.gridItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.gridItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.gridItem.Size = new System.Drawing.Size(800, 450);
            this.gridItem.TabIndex = 1;
            // 
            // descItemTxt
            // 
            this.descItemTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.descItemTxt.AutoSize = true;
            this.descItemTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descItemTxt.Location = new System.Drawing.Point(67, 284);
            this.descItemTxt.Name = "descItemTxt";
            this.descItemTxt.Size = new System.Drawing.Size(137, 17);
            this.descItemTxt.TabIndex = 5;
            this.descItemTxt.Text = "Descripción de item";
            this.descItemTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // codItemTxt
            // 
            this.codItemTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codItemTxt.AutoSize = true;
            this.codItemTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codItemTxt.Location = new System.Drawing.Point(81, 253);
            this.codItemTxt.Name = "codItemTxt";
            this.codItemTxt.Size = new System.Drawing.Size(112, 17);
            this.codItemTxt.TabIndex = 4;
            this.codItemTxt.Text = "Código de ítem";
            this.codItemTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descItemInp
            // 
            this.descItemInp.AcceptsTab = true;
            this.descItemInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descItemInp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descItemInp.Location = new System.Drawing.Point(215, 282);
            this.descItemInp.Name = "descItemInp";
            this.descItemInp.Size = new System.Drawing.Size(144, 21);
            this.descItemInp.TabIndex = 8;
            // 
            // codItemInp
            // 
            this.codItemInp.AcceptsTab = true;
            this.codItemInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codItemInp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codItemInp.Location = new System.Drawing.Point(215, 251);
            this.codItemInp.Name = "codItemInp";
            this.codItemInp.ReadOnly = true;
            this.codItemInp.Size = new System.Drawing.Size(144, 21);
            this.codItemInp.TabIndex = 7;
            // 
            // tableItems
            // 
            this.tableItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItem.SetColumnSpan(this.tableItems, 3);
            this.tableItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableItems.Location = new System.Drawing.Point(67, 15);
            this.tableItems.Name = "tableItems";
            this.gridItem.SetRowSpan(this.tableItems, 3);
            this.tableItems.Size = new System.Drawing.Size(556, 228);
            this.tableItems.TabIndex = 0;
            this.tableItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableItems_CellContentClick);
            // 
            // precioTxt
            // 
            this.precioTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.precioTxt.AutoSize = true;
            this.precioTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTxt.Location = new System.Drawing.Point(113, 317);
            this.precioTxt.Name = "precioTxt";
            this.precioTxt.Size = new System.Drawing.Size(48, 17);
            this.precioTxt.TabIndex = 9;
            this.precioTxt.Text = "Precio";
            this.precioTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fechaVtoTxt
            // 
            this.fechaVtoTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fechaVtoTxt.AutoSize = true;
            this.fechaVtoTxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaVtoTxt.Location = new System.Drawing.Point(95, 347);
            this.fechaVtoTxt.Name = "fechaVtoTxt";
            this.fechaVtoTxt.Size = new System.Drawing.Size(84, 34);
            this.fechaVtoTxt.TabIndex = 10;
            this.fechaVtoTxt.Text = "Fecha de vencimiento";
            this.fechaVtoTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sumbitBtn
            // 
            this.sumbitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridItem.SetColumnSpan(this.sumbitBtn, 2);
            this.sumbitBtn.Location = new System.Drawing.Point(159, 390);
            this.sumbitBtn.Name = "sumbitBtn";
            this.sumbitBtn.Size = new System.Drawing.Size(110, 27);
            this.sumbitBtn.TabIndex = 6;
            this.sumbitBtn.Text = "-";
            this.sumbitBtn.UseVisualStyleBackColor = true;
            this.sumbitBtn.Click += new System.EventHandler(this.sumbitBtn_Click);
            // 
            // precioInp
            // 
            this.precioInp.AcceptsTab = true;
            this.precioInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.precioInp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioInp.Location = new System.Drawing.Point(215, 315);
            this.precioInp.Name = "precioInp";
            this.precioInp.Size = new System.Drawing.Size(144, 21);
            this.precioInp.TabIndex = 11;
            // 
            // fechaVtoInp
            // 
            this.fechaVtoInp.AcceptsTab = true;
            this.fechaVtoInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fechaVtoInp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaVtoInp.Location = new System.Drawing.Point(215, 353);
            this.fechaVtoInp.Name = "fechaVtoInp";
            this.fechaVtoInp.Size = new System.Drawing.Size(144, 21);
            this.fechaVtoInp.TabIndex = 12;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
            this.addBtn.Location = new System.Drawing.Point(629, 15);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(79, 74);
            this.addBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addBtn.TabIndex = 13;
            this.addBtn.TabStop = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.Location = new System.Drawing.Point(629, 95);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(79, 73);
            this.deleteBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.TabStop = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Image = ((System.Drawing.Image)(resources.GetObject("updateBtn.Image")));
            this.updateBtn.Location = new System.Drawing.Point(629, 174);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(79, 69);
            this.updateBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.updateBtn.TabIndex = 15;
            this.updateBtn.TabStop = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmItems";
            this.Text = "Parcial 2025 - Items";
            this.gridItem.ResumeLayout(false);
            this.gridItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel gridItem;
        private System.Windows.Forms.Label descItemTxt;
        private System.Windows.Forms.Label codItemTxt;
        private System.Windows.Forms.TextBox descItemInp;
        private System.Windows.Forms.TextBox codItemInp;
        private System.Windows.Forms.DataGridView tableItems;
        private System.Windows.Forms.Button sumbitBtn;
        private System.Windows.Forms.Label precioTxt;
        private System.Windows.Forms.Label fechaVtoTxt;
        private System.Windows.Forms.TextBox precioInp;
        private System.Windows.Forms.TextBox fechaVtoInp;
        private System.Windows.Forms.PictureBox addBtn;
        private System.Windows.Forms.PictureBox deleteBtn;
        private System.Windows.Forms.PictureBox updateBtn;
    }
}