namespace Form_Dang_Nhap_voi_SQL_Server
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sbtnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtEUser = new DevExpress.XtraEditors.TextEdit();
            this.chkbtnShowPass = new DevExpress.XtraEditors.CheckButton();
            this.txtPass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtEUser.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(174, 162);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "User:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(175, 212);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 24);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Password:";
            // 
            // sbtnLogin
            // 
            this.sbtnLogin.Location = new System.Drawing.Point(179, 407);
            this.sbtnLogin.Name = "sbtnLogin";
            this.sbtnLogin.Size = new System.Drawing.Size(424, 44);
            this.sbtnLogin.TabIndex = 3;
            this.sbtnLogin.Text = "&LOGIN";
            this.sbtnLogin.Click += new System.EventHandler(this.sbtnLogin_Click);
            // 
            // txtEUser
            // 
            this.txtEUser.Location = new System.Drawing.Point(265, 159);
            this.txtEUser.Name = "txtEUser";
            this.txtEUser.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtEUser.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEUser.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtEUser.Properties.Appearance.Options.UseBackColor = true;
            this.txtEUser.Properties.Appearance.Options.UseFont = true;
            this.txtEUser.Properties.Appearance.Options.UseForeColor = true;
            this.txtEUser.Size = new System.Drawing.Size(337, 34);
            this.txtEUser.TabIndex = 4;
            // 
            // chkbtnShowPass
            // 
            this.chkbtnShowPass.Location = new System.Drawing.Point(179, 324);
            this.chkbtnShowPass.Name = "chkbtnShowPass";
            this.chkbtnShowPass.Size = new System.Drawing.Size(422, 39);
            this.chkbtnShowPass.TabIndex = 5;
            this.chkbtnShowPass.Text = "SHOW PASS";
            this.chkbtnShowPass.CheckedChanged += new System.EventHandler(this.chkbtnShowPass_CheckedChanged);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Red;
            this.txtPass.Location = new System.Drawing.Point(268, 212);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(332, 34);
            this.txtPass.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Form_Dang_Nhap_voi_SQL_Server.Properties.Resources.Minion;
            this.ClientSize = new System.Drawing.Size(712, 473);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.chkbtnShowPass);
            this.Controls.Add(this.txtEUser);
            this.Controls.Add(this.sbtnLogin);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.txtEUser.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton sbtnLogin;
        private DevExpress.XtraEditors.TextEdit txtEUser;
        private DevExpress.XtraEditors.CheckButton chkbtnShowPass;
        private System.Windows.Forms.TextBox txtPass;
    }
}

