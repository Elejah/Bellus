namespace Bellus
{
    partial class EmployeeAdd
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit3 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.roomEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet = new Bellus.MainDataSet();
            this.vWEmployesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vWRoomsEmployesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employesTableAdapter = new Bellus.MainDataSetTableAdapters.EmployesTableAdapter();
            this.vW_RoomsEmployesTableAdapter = new Bellus.MainDataSetTableAdapters.VW_RoomsEmployesTableAdapter();
            this.room_EmployeeTableAdapter = new Bellus.MainDataSetTableAdapters.Room_EmployeeTableAdapter();
            this.vW_EmployesTableAdapter = new Bellus.MainDataSetTableAdapters.VW_EmployesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWEmployesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWRoomsEmployesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(135, 13);
            this.labelControl4.TabIndex = 111;
            this.labelControl4.Text = "Введите ключевые слова:";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(249, 45);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(92, 21);
            this.simpleButton3.TabIndex = 110;
            this.simpleButton3.Text = "Отмена";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(142, 45);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(92, 21);
            this.simpleButton1.TabIndex = 109;
            this.simpleButton1.Text = "Добавить";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textEdit3
            // 
            this.textEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.roomEmployeeBindingSource, "Employee_ID", true));
            this.textEdit3.Location = new System.Drawing.Point(160, 9);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit3.Properties.DataSource = this.vWEmployesBindingSource;
            this.textEdit3.Properties.DisplayMember = "Surname";
            this.textEdit3.Properties.NullText = "";
            this.textEdit3.Properties.PopupView = this.searchLookUpEdit1View;
            this.textEdit3.Properties.ValueMember = "ID";
            this.textEdit3.Size = new System.Drawing.Size(181, 20);
            this.textEdit3.TabIndex = 112;
            // 
            // roomEmployeeBindingSource
            // 
            this.roomEmployeeBindingSource.DataMember = "Room_Employee";
            this.roomEmployeeBindingSource.DataSource = this.mainDataSet;
            this.roomEmployeeBindingSource.Filter = "";
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "MainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vWEmployesBindingSource
            // 
            this.vWEmployesBindingSource.DataMember = "VW_Employes";
            this.vWEmployesBindingSource.DataSource = this.mainDataSet;
            this.vWEmployesBindingSource.Filter = "Status_ID=1";
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colID,
            this.colSurname});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 1;
            // 
            // colSurname
            // 
            this.colSurname.FieldName = "Surname";
            this.colSurname.Name = "colSurname";
            this.colSurname.Visible = true;
            this.colSurname.VisibleIndex = 2;
            // 
            // employesBindingSource
            // 
            this.employesBindingSource.DataMember = "Employes";
            this.employesBindingSource.DataSource = this.mainDataSet;
            // 
            // vWRoomsEmployesBindingSource
            // 
            this.vWRoomsEmployesBindingSource.DataMember = "VW_RoomsEmployes";
            this.vWRoomsEmployesBindingSource.DataSource = this.mainDataSet;
            // 
            // employesTableAdapter
            // 
            this.employesTableAdapter.ClearBeforeFill = true;
            // 
            // vW_RoomsEmployesTableAdapter
            // 
            this.vW_RoomsEmployesTableAdapter.ClearBeforeFill = true;
            // 
            // room_EmployeeTableAdapter
            // 
            this.room_EmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // vW_EmployesTableAdapter
            // 
            this.vW_EmployesTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 94);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit3);
            this.Name = "EmployeeAdd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление пользователя";
            this.Load += new System.EventHandler(this.EmployeeAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWEmployesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWRoomsEmployesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SearchLookUpEdit textEdit3;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private MainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource employesBindingSource;
        private MainDataSetTableAdapters.EmployesTableAdapter employesTableAdapter;
        private System.Windows.Forms.BindingSource vWRoomsEmployesBindingSource;
        private MainDataSetTableAdapters.VW_RoomsEmployesTableAdapter vW_RoomsEmployesTableAdapter;
        private System.Windows.Forms.BindingSource roomEmployeeBindingSource;
        private MainDataSetTableAdapters.Room_EmployeeTableAdapter room_EmployeeTableAdapter;
        private System.Windows.Forms.BindingSource vWEmployesBindingSource;
        private MainDataSetTableAdapters.VW_EmployesTableAdapter vW_EmployesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
    }
}