namespace Bellus
{
    partial class LogData
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
            this.components = new System.ComponentModel.Container();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.defaultPath = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.transactionLogGetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet = new Bellus.MainDataSet();
            this.softsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wauth = new System.Windows.Forms.CheckBox();
            this.up = new DevExpress.XtraEditors.TextEdit();
            this.un = new DevExpress.XtraEditors.TextEdit();
            this.bn = new DevExpress.XtraEditors.TextEdit();
            this.ds = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.softsTableAdapter = new Bellus.MainDataSetTableAdapters.SoftsTableAdapter();
            this.transactionLogGetTableAdapter = new Bellus.MainDataSetTableAdapters.TransactionLogGetTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCurrentLSN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionSID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBeginTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.getImagesStatisticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getImagesStatisticTableAdapter = new Bellus.MainDataSetTableAdapters.GetImagesStatisticTableAdapter();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colimgBytes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimgKbRounded = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimgKb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimgMb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.defaultPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionLogGetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.up.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.un.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getImagesStatisticBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(167, 91);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Get Log File";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // defaultPath
            // 
            this.defaultPath.EditValue = "C:/temp/";
            this.defaultPath.Location = new System.Drawing.Point(590, 83);
            this.defaultPath.Name = "defaultPath";
            this.defaultPath.Size = new System.Drawing.Size(214, 20);
            this.defaultPath.TabIndex = 33;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(590, 64);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(93, 13);
            this.labelControl5.TabIndex = 32;
            this.labelControl5.Text = "Default Folder Path";
            // 
            // transactionLogGetBindingSource
            // 
            this.transactionLogGetBindingSource.DataMember = "TransactionLogGet";
            this.transactionLogGetBindingSource.DataSource = this.mainDataSetBindingSource;
            // 
            // mainDataSetBindingSource
            // 
            this.mainDataSetBindingSource.DataSource = this.mainDataSet;
            this.mainDataSetBindingSource.Position = 0;
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "MainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // softsBindingSource
            // 
            this.softsBindingSource.DataMember = "Softs";
            this.softsBindingSource.DataSource = this.mainDataSet;
            // 
            // wauth
            // 
            this.wauth.AutoSize = true;
            this.wauth.Location = new System.Drawing.Point(590, 12);
            this.wauth.Name = "wauth";
            this.wauth.Size = new System.Drawing.Size(146, 17);
            this.wauth.TabIndex = 43;
            this.wauth.Text = "Windows Authentification";
            this.wauth.UseVisualStyleBackColor = true;
            // 
            // up
            // 
            this.up.EditValue = "12345678";
            this.up.Location = new System.Drawing.Point(354, 87);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(214, 20);
            this.up.TabIndex = 42;
            // 
            // un
            // 
            this.un.EditValue = "sa";
            this.un.Location = new System.Drawing.Point(354, 61);
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(214, 20);
            this.un.TabIndex = 41;
            // 
            // bn
            // 
            this.bn.EditValue = "CRM_BELLUS";
            this.bn.Location = new System.Drawing.Point(354, 35);
            this.bn.Name = "bn";
            this.bn.Size = new System.Drawing.Size(214, 20);
            this.bn.TabIndex = 40;
            // 
            // ds
            // 
            this.ds.EditValue = "DESKTOP-Q7U9ENT\\MSSQLSERVERDPM";
            this.ds.Location = new System.Drawing.Point(354, 9);
            this.ds.Name = "ds";
            this.ds.Size = new System.Drawing.Size(214, 20);
            this.ds.TabIndex = 39;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(185, 90);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 13);
            this.labelControl4.TabIndex = 38;
            this.labelControl4.Text = "User password";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(185, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 13);
            this.labelControl3.TabIndex = 37;
            this.labelControl3.Text = "User name";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(185, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 13);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "Data Base name";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(185, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(153, 13);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Data Source(IP or server name)";
            // 
            // softsTableAdapter
            // 
            this.softsTableAdapter.ClearBeforeFill = true;
            // 
            // transactionLogGetTableAdapter
            // 
            this.transactionLogGetTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.transactionLogGetBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 113);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(792, 272);
            this.gridControl1.TabIndex = 45;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCurrentLSN,
            this.colOperation,
            this.colTransactionName,
            this.colTransactionID,
            this.colTransactionSID,
            this.colSPID,
            this.colBeginTime});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colCurrentLSN
            // 
            this.colCurrentLSN.FieldName = "Current LSN";
            this.colCurrentLSN.Name = "colCurrentLSN";
            this.colCurrentLSN.Visible = true;
            this.colCurrentLSN.VisibleIndex = 0;
            // 
            // colOperation
            // 
            this.colOperation.FieldName = "Operation";
            this.colOperation.Name = "colOperation";
            this.colOperation.Visible = true;
            this.colOperation.VisibleIndex = 1;
            // 
            // colTransactionName
            // 
            this.colTransactionName.FieldName = "Transaction Name";
            this.colTransactionName.Name = "colTransactionName";
            this.colTransactionName.Visible = true;
            this.colTransactionName.VisibleIndex = 2;
            // 
            // colTransactionID
            // 
            this.colTransactionID.FieldName = "Transaction ID";
            this.colTransactionID.Name = "colTransactionID";
            this.colTransactionID.Visible = true;
            this.colTransactionID.VisibleIndex = 3;
            // 
            // colTransactionSID
            // 
            this.colTransactionSID.FieldName = "Transaction SID";
            this.colTransactionSID.Name = "colTransactionSID";
            this.colTransactionSID.Visible = true;
            this.colTransactionSID.VisibleIndex = 4;
            // 
            // colSPID
            // 
            this.colSPID.FieldName = "SPID";
            this.colSPID.Name = "colSPID";
            this.colSPID.Visible = true;
            this.colSPID.VisibleIndex = 5;
            // 
            // colBeginTime
            // 
            this.colBeginTime.FieldName = "Begin Time";
            this.colBeginTime.Name = "colBeginTime";
            this.colBeginTime.Visible = true;
            this.colBeginTime.VisibleIndex = 6;
            // 
            // getImagesStatisticBindingSource
            // 
            this.getImagesStatisticBindingSource.DataMember = "GetImagesStatistic";
            this.getImagesStatisticBindingSource.DataSource = this.mainDataSetBindingSource;
            // 
            // getImagesStatisticTableAdapter
            // 
            this.getImagesStatisticTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.getImagesStatisticBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(12, 405);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(789, 249);
            this.gridControl2.TabIndex = 46;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colimgBytes,
            this.colimgKbRounded,
            this.colimgKb,
            this.colimgMb});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colimgBytes
            // 
            this.colimgBytes.FieldName = "imgBytes";
            this.colimgBytes.Name = "colimgBytes";
            this.colimgBytes.Visible = true;
            this.colimgBytes.VisibleIndex = 0;
            // 
            // colimgKbRounded
            // 
            this.colimgKbRounded.FieldName = "imgKbRounded";
            this.colimgKbRounded.Name = "colimgKbRounded";
            this.colimgKbRounded.Visible = true;
            this.colimgKbRounded.VisibleIndex = 1;
            // 
            // colimgKb
            // 
            this.colimgKb.FieldName = "imgKb";
            this.colimgKb.Name = "colimgKb";
            this.colimgKb.Visible = true;
            this.colimgKb.VisibleIndex = 2;
            // 
            // colimgMb
            // 
            this.colimgMb.FieldName = "imgMb";
            this.colimgMb.Name = "colimgMb";
            this.colimgMb.Visible = true;
            this.colimgMb.VisibleIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 391);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(179, 13);
            this.labelControl6.TabIndex = 47;
            this.labelControl6.Text = "Dat Set about size of IMAGES into DB";
            this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // LogData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 666);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.wauth);
            this.Controls.Add(this.up);
            this.Controls.Add(this.un);
            this.Controls.Add(this.bn);
            this.Controls.Add(this.ds);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.defaultPath);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.simpleButton1);
            this.Name = "LogData";
            this.Text = "LogData";
            this.Load += new System.EventHandler(this.LogData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.defaultPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionLogGetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.up.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.un.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getImagesStatisticBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit defaultPath;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.CheckBox wauth;
        private DevExpress.XtraEditors.TextEdit up;
        private DevExpress.XtraEditors.TextEdit un;
        private DevExpress.XtraEditors.TextEdit bn;
        private DevExpress.XtraEditors.TextEdit ds;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private MainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource softsBindingSource;
        private MainDataSetTableAdapters.SoftsTableAdapter softsTableAdapter;
        private System.Windows.Forms.BindingSource mainDataSetBindingSource;
        private System.Windows.Forms.BindingSource transactionLogGetBindingSource;
        private MainDataSetTableAdapters.TransactionLogGetTableAdapter transactionLogGetTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentLSN;
        private DevExpress.XtraGrid.Columns.GridColumn colOperation;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionName;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionID;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionSID;
        private DevExpress.XtraGrid.Columns.GridColumn colSPID;
        private DevExpress.XtraGrid.Columns.GridColumn colBeginTime;
        private System.Windows.Forms.BindingSource getImagesStatisticBindingSource;
        private MainDataSetTableAdapters.GetImagesStatisticTableAdapter getImagesStatisticTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colimgBytes;
        private DevExpress.XtraGrid.Columns.GridColumn colimgKbRounded;
        private DevExpress.XtraGrid.Columns.GridColumn colimgKb;
        private DevExpress.XtraGrid.Columns.GridColumn colimgMb;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}