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
    public partial class Connect : DevExpress.XtraEditors.XtraForm
    {
        public Connect()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string dataSource = textEditIP.Text;
            string catalog = textEditDB.Text;
            string user = textEditUser.Text;
            string password = textEditPassword.Text;

            string connectingmain = "Data Source=" + dataSource + ";Initial Catalog=" + catalog + ";User Id=" + user + ";Password=" + password + ';';
            Properties.Settings.Default["ARM_MRKConnectionString"] = connectingmain;
            Properties.Settings.Default["ARM_MRKConnectionString2"] = connectingmain;
            Properties.Settings.Default["ARM_MRKConnectionString1"] = connectingmain;
            DialogResult = DialogResult.OK;
            Close();
            //Properties.Settings.Default["ARM_MRKConnectionString"] = "Data Source=" + dataSource + ";Initial Catalog=" + catalog + ";User Id=" + user+ ";Password="+ password+';';
            //"Data Source=" + dataSource + ";Initial Catalog=" + catalog + ";Integrated Security = True";
            //"Data Source=192.168.56.1;Initial Catalog=ARM_MRK;User ID=sa;Password=12345678";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}