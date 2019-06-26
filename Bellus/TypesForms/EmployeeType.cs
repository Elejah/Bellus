using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Bellus.TypesForms
{
    public partial class EmployeeType : DevExpress.XtraEditors.XtraForm
    {
        public EmployeeType()
        {
            InitializeComponent();
            Fill();
            NewDoc();
        }

        public EmployeeType(int ID)
        {
            InitializeComponent();
            Fill(ID);
        }

        private void Fill()
        {
            this.typesEmployesTableAdapter.Fill(this.mainDataSet.TypesEmployes);
        
        }
        private void Fill(int ID)
        {
            this.typesEmployesTableAdapter.FillBy(this.mainDataSet.TypesEmployes, ID);
        }

        private void NewDoc()
        {
            var row = (MainDataSet.TypesEmployesRow)((DataRowView)typesEmployesBindingSource.AddNew()).Row;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                typesEmployesBindingSource.EndEdit();
                typesEmployesTableAdapter.Update(mainDataSet.TypesEmployes);
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

        private void EmployeeType_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.TypesEmployes". При необходимости она может быть перемещена или удалена.
            //this.typesEmployesTableAdapter.Fill(this.mainDataSet.TypesEmployes);

        }
    }
}