namespace Bellus
{
    partial class Connect
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEditIP = new DevExpress.XtraEditors.TextEdit();
            this.textEditDB = new DevExpress.XtraEditors.TextEdit();
            this.textEditUser = new DevExpress.XtraEditors.TextEdit();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(124, 159);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(76, 22);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Вход";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textEditIP
            // 
            this.textEditIP.EditValue = "DESKTOP-Q7U9ENT\\MSSQLSERVERDPM";
            this.textEditIP.Location = new System.Drawing.Point(125, 12);
            this.textEditIP.Name = "textEditIP";
            this.textEditIP.Size = new System.Drawing.Size(157, 20);
            this.textEditIP.TabIndex = 1;
            // 
            // textEditDB
            // 
            this.textEditDB.EditValue = "CRM_BELLUS";
            this.textEditDB.Location = new System.Drawing.Point(125, 47);
            this.textEditDB.Name = "textEditDB";
            this.textEditDB.Size = new System.Drawing.Size(157, 20);
            this.textEditDB.TabIndex = 3;
            // 
            // textEditUser
            // 
            this.textEditUser.EditValue = "sa";
            this.textEditUser.Location = new System.Drawing.Point(125, 88);
            this.textEditUser.Name = "textEditUser";
            this.textEditUser.Size = new System.Drawing.Size(157, 20);
            this.textEditUser.TabIndex = 4;
            // 
            // textEditPassword
            // 
            this.textEditPassword.EditValue = "12345678";
            this.textEditPassword.Location = new System.Drawing.Point(125, 123);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Size = new System.Drawing.Size(157, 20);
            this.textEditPassword.TabIndex = 5;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(206, 159);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(76, 22);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Отмена";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(10, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "IP";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Data Base name";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 95);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "User name";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 130);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Password";
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 192);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.textEditPassword);
            this.Controls.Add(this.textEditUser);
            this.Controls.Add(this.textEditDB);
            this.Controls.Add(this.textEditIP);
            this.Controls.Add(this.simpleButton1);
            this.Name = "Connect";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подключение";
            this.Load += new System.EventHandler(this.Connect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditIP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEditIP;
        private DevExpress.XtraEditors.TextEdit textEditDB;
        private DevExpress.XtraEditors.TextEdit textEditUser;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}