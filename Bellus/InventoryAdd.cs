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
    public partial class InventoryAdd : DevExpress.XtraEditors.XtraForm
    {
        public InventoryAdd()
        {
            InitializeComponent();
            Fill();
            NewDoc();
        }
        public InventoryAdd(int ID)
        {
            InitializeComponent();
            Fill(ID);
        }

        private void InventoryAdd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.TypesInventory". При необходимости она может быть перемещена или удалена.
        }
        private void Fill()
        {
            this.typesInventoryTableAdapter.Fill(this.mainDataSet.TypesInventory);

        }
        private void Fill(int ID)
        {
            this.typesInventoryTableAdapter.FillBy(this.mainDataSet.TypesInventory, ID);
        }

        private void NewDoc()
        {
            var row = (MainDataSet.TypesInventoryRow)((DataRowView)typesInventoryBindingSource.AddNew()).Row;
        }


        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                typesInventoryBindingSource.EndEdit();
                typesInventoryTableAdapter.Update(mainDataSet.TypesInventory);
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

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}