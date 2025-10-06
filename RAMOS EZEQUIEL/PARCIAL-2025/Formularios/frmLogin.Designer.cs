namespace PARCIAL_2025
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.loginGrid = new System.Windows.Forms.TableLayoutPanel();
            this.userDiv = new System.Windows.Forms.TableLayoutPanel();
            this.userInp = new System.Windows.Forms.TextBox();
            this.inpUserTxt = new System.Windows.Forms.Label();
            this.userImg = new System.Windows.Forms.PictureBox();
            this.passwrdImg = new System.Windows.Forms.PictureBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.psswrdDiv = new System.Windows.Forms.TableLayoutPanel();
            this.passwrdInpTxt = new System.Windows.Forms.Label();
            this.passwrdInp = new System.Windows.Forms.TextBox();
            this.seePswDiv = new System.Windows.Forms.TableLayoutPanel();
            this.seePswBtn = new System.Windows.Forms.PictureBox();
            this.loginGrid.SuspendLayout();
            this.userDiv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwrdImg)).BeginInit();
            this.psswrdDiv.SuspendLayout();
            this.seePswDiv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seePswBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // loginGrid
            // 
            this.loginGrid.ColumnCount = 5;
            this.loginGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.095454F));
            this.loginGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.98916F));
            this.loginGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.47453F));
            this.loginGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.115281F));
            this.loginGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.093247F));
            this.loginGrid.Controls.Add(this.userDiv, 2, 1);
            this.loginGrid.Controls.Add(this.userImg, 1, 1);
            this.loginGrid.Controls.Add(this.passwrdImg, 1, 2);
            this.loginGrid.Controls.Add(this.loginBtn, 1, 3);
            this.loginGrid.Controls.Add(this.psswrdDiv, 2, 2);
            this.loginGrid.Controls.Add(this.seePswDiv, 3, 2);
            this.loginGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginGrid.Location = new System.Drawing.Point(0, 0);
            this.loginGrid.Name = "loginGrid";
            this.loginGrid.RowCount = 4;
            this.loginGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.loginGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.loginGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.loginGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.loginGrid.Size = new System.Drawing.Size(373, 489);
            this.loginGrid.TabIndex = 0;
            // 
            // userDiv
            // 
            this.userDiv.ColumnCount = 1;
            this.userDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userDiv.Controls.Add(this.userInp, 0, 1);
            this.userDiv.Controls.Add(this.inpUserTxt, 0, 0);
            this.userDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDiv.Location = new System.Drawing.Point(122, 149);
            this.userDiv.Name = "userDiv";
            this.userDiv.RowCount = 2;
            this.userDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.userDiv.Size = new System.Drawing.Size(186, 91);
            this.userDiv.TabIndex = 7;
            // 
            // userInp
            // 
            this.userInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userInp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userInp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInp.Location = new System.Drawing.Point(21, 57);
            this.userInp.Name = "userInp";
            this.userInp.Size = new System.Drawing.Size(143, 21);
            this.userInp.TabIndex = 0;
            // 
            // inpUserTxt
            // 
            this.inpUserTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inpUserTxt.AutoSize = true;
            this.inpUserTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpUserTxt.Location = new System.Drawing.Point(33, 14);
            this.inpUserTxt.Name = "inpUserTxt";
            this.inpUserTxt.Size = new System.Drawing.Size(120, 17);
            this.inpUserTxt.TabIndex = 1;
            this.inpUserTxt.Text = "Ingrese su usuario";
            // 
            // userImg
            // 
            this.userImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userImg.Image = ((System.Drawing.Image)(resources.GetObject("userImg.Image")));
            this.userImg.Location = new System.Drawing.Point(29, 149);
            this.userImg.Name = "userImg";
            this.userImg.Size = new System.Drawing.Size(87, 91);
            this.userImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImg.TabIndex = 2;
            this.userImg.TabStop = false;
            // 
            // passwrdImg
            // 
            this.passwrdImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwrdImg.Image = ((System.Drawing.Image)(resources.GetObject("passwrdImg.Image")));
            this.passwrdImg.Location = new System.Drawing.Point(29, 246);
            this.passwrdImg.Name = "passwrdImg";
            this.passwrdImg.Size = new System.Drawing.Size(87, 91);
            this.passwrdImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwrdImg.TabIndex = 3;
            this.passwrdImg.TabStop = false;
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginGrid.SetColumnSpan(this.loginBtn, 2);
            this.loginBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(108, 400);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(120, 28);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Iniciar sesión";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // psswrdDiv
            // 
            this.psswrdDiv.ColumnCount = 1;
            this.psswrdDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.psswrdDiv.Controls.Add(this.passwrdInpTxt, 0, 0);
            this.psswrdDiv.Controls.Add(this.passwrdInp, 0, 1);
            this.psswrdDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.psswrdDiv.Location = new System.Drawing.Point(122, 246);
            this.psswrdDiv.Name = "psswrdDiv";
            this.psswrdDiv.RowCount = 2;
            this.psswrdDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.psswrdDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.psswrdDiv.Size = new System.Drawing.Size(186, 91);
            this.psswrdDiv.TabIndex = 6;
            // 
            // passwrdInpTxt
            // 
            this.passwrdInpTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwrdInpTxt.AutoSize = true;
            this.passwrdInpTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwrdInpTxt.Location = new System.Drawing.Point(19, 14);
            this.passwrdInpTxt.Name = "passwrdInpTxt";
            this.passwrdInpTxt.Size = new System.Drawing.Size(147, 17);
            this.passwrdInpTxt.TabIndex = 2;
            this.passwrdInpTxt.Text = "Ingrese su contraseña";
            // 
            // passwrdInp
            // 
            this.passwrdInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwrdInp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwrdInp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwrdInp.Location = new System.Drawing.Point(21, 57);
            this.passwrdInp.Name = "passwrdInp";
            this.passwrdInp.Size = new System.Drawing.Size(143, 21);
            this.passwrdInp.TabIndex = 1;
            this.passwrdInp.UseSystemPasswordChar = true;
            // 
            // seePswDiv
            // 
            this.seePswDiv.ColumnCount = 1;
            this.seePswDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.seePswDiv.Controls.Add(this.seePswBtn, 0, 1);
            this.seePswDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seePswDiv.Location = new System.Drawing.Point(314, 246);
            this.seePswDiv.Name = "seePswDiv";
            this.seePswDiv.RowCount = 2;
            this.seePswDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.seePswDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.seePswDiv.Size = new System.Drawing.Size(28, 91);
            this.seePswDiv.TabIndex = 9;
            // 
            // seePswBtn
            // 
            this.seePswBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.seePswBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seePswBtn.Image = ((System.Drawing.Image)(resources.GetObject("seePswBtn.Image")));
            this.seePswBtn.Location = new System.Drawing.Point(3, 56);
            this.seePswBtn.Name = "seePswBtn";
            this.seePswBtn.Size = new System.Drawing.Size(22, 23);
            this.seePswBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seePswBtn.TabIndex = 8;
            this.seePswBtn.TabStop = false;
            this.seePswBtn.Click += new System.EventHandler(this.seePswBtn_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 489);
            this.Controls.Add(this.loginGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parcial 2025 - Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.loginGrid.ResumeLayout(false);
            this.userDiv.ResumeLayout(false);
            this.userDiv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwrdImg)).EndInit();
            this.psswrdDiv.ResumeLayout(false);
            this.psswrdDiv.PerformLayout();
            this.seePswDiv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seePswBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel loginGrid;
        private System.Windows.Forms.TextBox userInp;
        private System.Windows.Forms.TextBox passwrdInp;
        private System.Windows.Forms.PictureBox userImg;
        private System.Windows.Forms.PictureBox passwrdImg;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TableLayoutPanel userDiv;
        private System.Windows.Forms.TableLayoutPanel psswrdDiv;
        private System.Windows.Forms.Label inpUserTxt;
        private System.Windows.Forms.Label passwrdInpTxt;
        private System.Windows.Forms.PictureBox seePswBtn;
        private System.Windows.Forms.TableLayoutPanel seePswDiv;
    }
}