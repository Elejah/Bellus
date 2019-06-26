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
    public partial class RoomsType : DevExpress.XtraEditors.XtraForm
    {
        public RoomsType()
        {
            InitializeComponent();
            Fill();
            NewDoc();
        }
        public RoomsType(int ID)
        {
            InitializeComponent();
            Fill(ID);
        }
        private void Fill()
        {
            this.typesRoomsTableAdapter.Fill(this.mainDataSet.TypesRooms);

        }
        private void Fill(int ID)
        {
            this.typesRoomsTableAdapter.FillBy(this.mainDataSet.TypesRooms,ID);
        }

        private void NewDoc()
        {
            var row = (MainDataSet.TypesRoomsRow)((DataRowView)typesRoomsBindingSource.AddNew()).Row;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                typesRoomsBindingSource.EndEdit();
                typesRoomsTableAdapter.Update(mainDataSet.TypesRooms);
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

        private void RoomsType_Load(object sender, EventArgs e)
        {
        }
    }
}