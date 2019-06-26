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
    public partial class Inventory : DevExpress.XtraEditors.XtraForm
    {
        public Inventory()
        {
            InitializeComponent();
            Fill();
            NewDoc();
        }
        public Inventory(int ID, int hide =1)
        {
            InitializeComponent();
            Fill(ID);
            HideElements(hide);
        }
        private void HideElements(int hide)
        {
            if (hide == 0)
            {
                textEdit1.Enabled = false;
                textEdit2.Enabled = false;
                textEdit3.Enabled = false;
                textEdit4.Enabled = false;
                textEdit7.Enabled = false;
                memoEdit1.Enabled = false;
                simpleButton1.Enabled = false;

            }
        }
        private void NewDoc()
        {
            var row = (MainDataSet.InventoryRow)((DataRowView)inventoryBindingSource.AddNew()).Row;
            row.Status_ID = 3;
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.TypesEmployes". При необходимости она может быть перемещена или удалена.
            this.typesEmployesTableAdapter.Fill(this.mainDataSet.TypesEmployes);
        }
        private void Fill()
        {
            this.inventoryTableAdapter.Fill(this.mainDataSet.Inventory);
            this.employesTableAdapter.Fill(this.mainDataSet.Employes);
            this.typesInventoryTableAdapter.Fill(this.mainDataSet.TypesInventory);
        }
        private void Fill(int ID)
        {
            this.inventoryTableAdapter.FillBy(this.mainDataSet.Inventory,ID);
            this.employesTableAdapter.Fill(this.mainDataSet.Employes);
            this.typesInventoryTableAdapter.Fill(this.mainDataSet.TypesInventory);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                inventoryBindingSource.EndEdit();
                inventoryTableAdapter.Update(mainDataSet.Inventory);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникло сиситемное исключение, возможно у вас не достаточно прав для этого действия");
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