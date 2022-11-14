using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bellus
{
    public partial class BackUpModule : DevExpress.XtraEditors.XtraForm
    {
        bool IsWinAuth = false;
        string dataSource = "";
        string dataBaseName = "";
        string userName = "";
        string userPassword = "";
        string defaultFolderPath= "";

        public BackUpModule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BackUpModule_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Использование данного модуля должно выполняться ТОЛЬКО лицами представляющими технически-административную часть организации");
        }

        private void wauth_CheckedChanged(object sender, EventArgs e)
        {
            if (wauth.Checked)
            {
                un.Enabled = false;
                up.Enabled = false;

                IsWinAuth = true;
            }
            else
            {
                un.Enabled = true;
                up.Enabled = true;

                IsWinAuth = false;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // read connectionstring from config file
                string connectionString = "";

                dataSource = ds.Text;
                dataBaseName = bn.Text;
                userName = un.Text;
                userPassword = up.Text;
                defaultFolderPath = defaultPath.Text;

                //Integrated Security=True
                if (IsWinAuth)
                {
                    connectionString = "Data Source =" + dataSource + ";" + "Initial Catalog=" + dataBaseName + ";" + "Integrated Security=True";
                }
                else
                {
                    connectionString = "Data Source =" + dataSource + ";" + "Initial Catalog=" + dataBaseName + ";" + "User Id=" + userName + ";" + "Password=" + userPassword;
                }


                var backupFolder = defaultFolderPath;
                if (!Directory.Exists(backupFolder))
                {
                    Directory.CreateDirectory(backupFolder);
                }

                var sqlConStrBuilder = new SqlConnectionStringBuilder(connectionString);

                // set backupfilename (you will get something like: "C:/temp/MyDatabase-2013-12-07.bak")
                var backupFileName = String.Format("{0}{1}-{2}.bak",
                    backupFolder, sqlConStrBuilder.InitialCatalog,
                    DateTime.Now.ToString("dd-MMMM-yyyy hh-mm-ss"));

                using (var connection = new SqlConnection(sqlConStrBuilder.ConnectionString))
                {
                    var query = String.Format("BACKUP DATABASE {0} TO DISK='{1}'",
                        sqlConStrBuilder.InitialCatalog, backupFileName);

                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MessageBox.Show("Back up was created successfully in the destination folder with .bak extension");
            }
        }

        private void ds_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
