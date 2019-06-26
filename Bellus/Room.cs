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
    public partial class Room : DevExpress.XtraEditors.XtraForm
    {
        int RoomID;
        public Room()
        {
            InitializeComponent();
            Fill();
            NewDoc();
        }
        public Room(int ID, int hide =1)
        {
            InitializeComponent();
            RoomID = ID;
            Fill(RoomID);
            HideElements(hide);
        }
        private void HideElements(int hide)
        {
            if (hide == 0)
            {
                textEdit1.Enabled = false;
                textEdit2.Enabled = false;
                textEdit3.Enabled = false;
                simpleButton2.Enabled = false;
                simpleButton1.Enabled = false;

            }
        }

        private void Room_Load(object sender, EventArgs e)
        {

        }
        private void Fill()
        {
            this.roomsTableAdapter.Fill(this.mainDataSet.Rooms);
            this.typesRoomsTableAdapter.Fill(this.mainDataSet.TypesRooms);
            this.employesTableAdapter.Fill(this.mainDataSet.Employes);
            this.typesEmployesTableAdapter.Fill(this.mainDataSet.TypesEmployes);
        }
        private void Fill(int ID)
        {
            this.vW_RoomsEmployesTableAdapter.FillBy(this.mainDataSet.VW_RoomsEmployes,ID);
            this.roomsTableAdapter.FillBy(this.mainDataSet.Rooms,ID);
            this.typesRoomsTableAdapter.Fill(this.mainDataSet.TypesRooms);
            this.employesTableAdapter.Fill(this.mainDataSet.Employes);
            this.typesEmployesTableAdapter.Fill(this.mainDataSet.TypesEmployes);
        }
        private void NewDoc()
        {
            var row = (MainDataSet.RoomsRow)((DataRowView)roomsBindingSource.AddNew()).Row;
            row.Status_ID = 5;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                roomsBindingSource.EndEdit();
                roomsTableAdapter.Update(mainDataSet.Rooms);
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DataRow curentRow = (DataRow)((DataRowView)roomsBindingSource.Current).Row;
            int id = (int)curentRow["ID"];
            using (var adding = new EmployeeAdd(id))
            {
                if (adding.ShowDialog() == DialogResult.OK)
                {
                    Fill(RoomID);
                }
            }
        }
    }
}