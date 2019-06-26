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
    public partial class Soft : DevExpress.XtraEditors.XtraForm
    {
        public Soft()
        {
            InitializeComponent();
            Fill();
            NewDoc();
        }
        public Soft(int ID, int hide=1)
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
                memoEdit1.Enabled = false;
                dateEdit1.Enabled = false;
                simpleButton1.Enabled = false;

            }
        }
        private void NewDoc()
        {
            var row = (MainDataSet.SoftsRow)((DataRowView)softsBindingSource.AddNew()).Row;
            row.Status_ID = 7;
        }
        private void Fill()
        {
            this.softsTableAdapter.Fill(this.mainDataSet.Softs);
            this.employesTableAdapter.Fill(this.mainDataSet.Employes);
        }
        private void Fill(int ID)
        {
            this.softsTableAdapter.FillBy(this.mainDataSet.Softs,ID);
            this.employesTableAdapter.Fill(this.mainDataSet.Employes);
        }

        private void Soft_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.TypesEmployes". При необходимости она может быть перемещена или удалена.
            this.typesEmployesTableAdapter.Fill(this.mainDataSet.TypesEmployes);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                softsBindingSource.EndEdit();
                softsTableAdapter.Update(mainDataSet.Softs);
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