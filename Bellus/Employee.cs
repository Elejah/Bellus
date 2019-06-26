using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Drawing.Drawing2D;

namespace Bellus
{
    public partial class Employee : DevExpress.XtraEditors.XtraForm
    {

        public Employee()
        {
            InitializeComponent();
            Fill();
            NewDoc();
        }
        public Employee(int ID ,int hide = 1)
        {
            InitializeComponent();
            Fill(ID);
            HideElements(hide);
        }
        private void HideElements(int hide) {
            if (hide == 0) {
                textEdit1.Enabled = false;
                textEdit2.Enabled = false;
                textEdit3.Enabled = false;
                textEdit4.Enabled = false;
                textEdit5.Enabled = false;
                textEdit6.Enabled = false;
                textEdit7.Enabled = false;
                dateEdit1.Enabled = false;
                memoEdit1.Enabled = false;
                simpleButtonAddPhoto.Enabled = false;
                simpleButton1.Enabled = false;
                simpleButton2.Enabled = false;
                
            }
        }
        private void Fill() {
            this.typesEmployesTableAdapter.Fill(this.mainDataSet.TypesEmployes);
            this.employesTableAdapter.Fill(this.mainDataSet.Employes);
            this.addressesTableAdapter.Fill(this.mainDataSet.Addresses);
        }
        private void Fill(int ID)
        {
            this.typesEmployesTableAdapter.Fill(this.mainDataSet.TypesEmployes);
            this.employesTableAdapter.FillBy(this.mainDataSet.Employes, ID);
            this.addressesTableAdapter.Fill(this.mainDataSet.Addresses);
        }

        private void NewDoc() {
            var row = (MainDataSet.EmployesRow)((DataRowView)employesBindingSource.AddNew()).Row;
            row.Status_ID = 1;
        }




        private void Employee_Load(object sender, EventArgs e)
        {

        }


        private void simpleButtonAddPhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image photo = Image.FromFile(openFileDialogImage.FileName);
                    Bitmap bmpImage = new Bitmap(photo);
                    bmpImage = ResizeImage(bmpImage, pictureEditPhoto.Width, pictureEditPhoto.Height);
                    pictureEditPhoto.Image =bmpImage;
                }
                catch (Exception ex)
                {

                }
            }
        }

        private Bitmap ResizeImage(Bitmap bmp, float width, float height, InterpolationMode mode = InterpolationMode.Bilinear)
        {
            var w = (int)(width);
            var h = (int)(height);
        
            var res = new Bitmap(w, h);
            using (var gr = Graphics.FromImage(res))
            {
                gr.InterpolationMode = mode;
                gr.DrawImage(bmp, 0, 0, w, h);
            }
        
            return res;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                employesBindingSource.EndEdit();
                employesTableAdapter.Update(mainDataSet.Employes);
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            pictureEditPhoto.EditValue = DBNull.Value;
        }
    }
}