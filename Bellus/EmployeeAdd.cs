using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Bellus
{
    public partial class EmployeeAdd : DevExpress.XtraEditors.XtraForm
    {
        int roomID;
        public EmployeeAdd()
        {
            InitializeComponent();
        }
        public EmployeeAdd(int roomID)
        {
            InitializeComponent();
            Fill();
            this.roomID = roomID;
            NewDoc(roomID);
        }

        private void EmployeeAdd_Load(object sender, EventArgs e)
        {

        }
        private void NewDoc(int rommID)
        {
            var row = (MainDataSet.Room_EmployeeRow)((DataRowView)roomEmployeeBindingSource.AddNew()).Row;
            row.Room_ID = rommID;
        }
        private void Fill()
        {
            this.vW_EmployesTableAdapter.Fill(this.mainDataSet.VW_Employes);
            this.room_EmployeeTableAdapter.Fill(this.mainDataSet.Room_Employee);
            this.employesTableAdapter.Fill(this.mainDataSet.Employes);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                roomEmployeeBindingSource.EndEdit();
                room_EmployeeTableAdapter.Update(mainDataSet.Room_Employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}