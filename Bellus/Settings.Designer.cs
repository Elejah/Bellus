namespace Bellus
{
    partial class Settings
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
            this.checkButton1 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton2 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton3 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton4 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton5 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton6 = new DevExpress.XtraEditors.CheckButton();
            this.SuspendLayout();
            // 
            // checkButton1
            // 
            this.checkButton1.Location = new System.Drawing.Point(12, 12);
            this.checkButton1.Name = "checkButton1";
            this.checkButton1.Size = new System.Drawing.Size(356, 23);
            this.checkButton1.TabIndex = 0;
            this.checkButton1.Text = "Office 2013";
            this.checkButton1.CheckedChanged += new System.EventHandler(this.checkButton1_CheckedChanged);
            // 
            // checkButton2
            // 
            this.checkButton2.Location = new System.Drawing.Point(12, 41);
            this.checkButton2.Name = "checkButton2";
            this.checkButton2.Size = new System.Drawing.Size(356, 23);
            this.checkButton2.TabIndex = 1;
            this.checkButton2.Text = "DevExpress Style";
            this.checkButton2.CheckedChanged += new System.EventHandler(this.checkButton2_CheckedChanged);
            // 
            // checkButton3
            // 
            this.checkButton3.Location = new System.Drawing.Point(12, 70);
            this.checkButton3.Name = "checkButton3";
            this.checkButton3.Size = new System.Drawing.Size(356, 23);
            this.checkButton3.TabIndex = 2;
            this.checkButton3.Text = "Office 2016 Dark";
            this.checkButton3.CheckedChanged += new System.EventHandler(this.checkButton3_CheckedChanged);
            // 
            // checkButton4
            // 
            this.checkButton4.Location = new System.Drawing.Point(12, 99);
            this.checkButton4.Name = "checkButton4";
            this.checkButton4.Size = new System.Drawing.Size(356, 23);
            this.checkButton4.TabIndex = 3;
            this.checkButton4.Text = "Office 2016 Black";
            this.checkButton4.CheckedChanged += new System.EventHandler(this.checkButton4_CheckedChanged);
            // 
            // checkButton5
            // 
            this.checkButton5.Location = new System.Drawing.Point(12, 128);
            this.checkButton5.Name = "checkButton5";
            this.checkButton5.Size = new System.Drawing.Size(356, 23);
            this.checkButton5.TabIndex = 4;
            this.checkButton5.Text = "The Bezier";
            this.checkButton5.CheckedChanged += new System.EventHandler(this.checkButton5_CheckedChanged);
            // 
            // checkButton6
            // 
            this.checkButton6.Location = new System.Drawing.Point(12, 157);
            this.checkButton6.Name = "checkButton6";
            this.checkButton6.Size = new System.Drawing.Size(356, 23);
            this.checkButton6.TabIndex = 5;
            this.checkButton6.Text = "Office 2010 Silver";
            this.checkButton6.CheckedChanged += new System.EventHandler(this.checkButton6_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 193);
            this.Controls.Add(this.checkButton6);
            this.Controls.Add(this.checkButton5);
            this.Controls.Add(this.checkButton4);
            this.Controls.Add(this.checkButton3);
            this.Controls.Add(this.checkButton2);
            this.Controls.Add(this.checkButton1);
            this.Name = "Settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckButton checkButton1;
        private DevExpress.XtraEditors.CheckButton checkButton2;
        private DevExpress.XtraEditors.CheckButton checkButton3;
        private DevExpress.XtraEditors.CheckButton checkButton4;
        private DevExpress.XtraEditors.CheckButton checkButton5;
        private DevExpress.XtraEditors.CheckButton checkButton6;
    }
}