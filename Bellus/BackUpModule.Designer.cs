namespace Bellus
{
    partial class BackUpModule
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ds = new DevExpress.XtraEditors.TextEdit();
            this.bn = new DevExpress.XtraEditors.TextEdit();
            this.un = new DevExpress.XtraEditors.TextEdit();
            this.up = new DevExpress.XtraEditors.TextEdit();
            this.wauth = new System.Windows.Forms.CheckBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.defaultPath = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ds.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.un.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.up.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultPath.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(156, 96);
            this.simpleButton1.TabIndex = 20;
            this.simpleButton1.Text = "Back Up a Curren Data Base";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(174, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(153, 13);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Data Source(IP or server name)";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(174, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 13);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Data Base name";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(174, 65);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 13);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "User name";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(174, 91);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "User password";
            // 
            // ds
            // 
            this.ds.EditValue = "DESKTOP-Q7U9ENT\\MSSQLSERVERDPM";
            this.ds.Location = new System.Drawing.Point(343, 10);
            this.ds.Name = "ds";
            this.ds.Size = new System.Drawing.Size(214, 20);
            this.ds.TabIndex = 25;
            this.ds.EditValueChanged += new System.EventHandler(this.ds_EditValueChanged);
            // 
            // bn
            // 
            this.bn.EditValue = "CRM_BELLUS";
            this.bn.Location = new System.Drawing.Point(343, 36);
            this.bn.Name = "bn";
            this.bn.Size = new System.Drawing.Size(214, 20);
            this.bn.TabIndex = 26;
            // 
            // un
            // 
            this.un.EditValue = "sa";
            this.un.Location = new System.Drawing.Point(343, 62);
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(214, 20);
            this.un.TabIndex = 27;
            // 
            // up
            // 
            this.up.EditValue = "12345678";
            this.up.Location = new System.Drawing.Point(343, 88);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(214, 20);
            this.up.TabIndex = 28;
            // 
            // wauth
            // 
            this.wauth.AutoSize = true;
            this.wauth.Location = new System.Drawing.Point(579, 13);
            this.wauth.Name = "wauth";
            this.wauth.Size = new System.Drawing.Size(148, 17);
            this.wauth.TabIndex = 29;
            this.wauth.Text = "Windows Authentification";
            this.wauth.UseVisualStyleBackColor = true;
            this.wauth.CheckedChanged += new System.EventHandler(this.wauth_CheckedChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(579, 65);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(93, 13);
            this.labelControl5.TabIndex = 30;
            this.labelControl5.Text = "Default Folder Path";
            // 
            // defaultPath
            // 
            this.defaultPath.EditValue = "C:/temp/";
            this.defaultPath.Location = new System.Drawing.Point(579, 84);
            this.defaultPath.Name = "defaultPath";
            this.defaultPath.Size = new System.Drawing.Size(214, 20);
            this.defaultPath.TabIndex = 31;
            // 
            // BackUpModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 127);
            this.Controls.Add(this.defaultPath);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.wauth);
            this.Controls.Add(this.up);
            this.Controls.Add(this.un);
            this.Controls.Add(this.bn);
            this.Controls.Add(this.ds);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Name = "BackUpModule";
            this.Text = "BackUpModule";
            this.Load += new System.EventHandler(this.BackUpModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.un.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.up.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultPath.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit ds;
        private DevExpress.XtraEditors.TextEdit bn;
        private DevExpress.XtraEditors.TextEdit un;
        private DevExpress.XtraEditors.TextEdit up;
        private System.Windows.Forms.CheckBox wauth;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit defaultPath;
    }
}