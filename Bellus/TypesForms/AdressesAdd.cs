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
    public partial class AdressesAdd : DevExpress.XtraEditors.XtraForm
    {
        public AdressesAdd()
        {
            InitializeComponent();
            Fill();
            NewDoc();
        }

        public AdressesAdd(int ID)
        {
            InitializeComponent();
            Fill(ID);
        }

        private void Fill()
        {
            this.addressesTableAdapter.Fill(this.mainDataSet.Addresses);
        }
        private void Fill(int ID)
        {
            this.addressesTableAdapter.FillBy(this.mainDataSet.Addresses, ID);
        }

        private void NewDoc()
        {
            var row = (MainDataSet.AddressesRow)((DataRowView)addressesBindingSource.AddNew()).Row;
        }

        private void AdressesAdd_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                addressesBindingSource.EndEdit();
                addressesTableAdapter.Update(mainDataSet.Addresses);
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