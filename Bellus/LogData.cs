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
    public partial class LogData : Form
    {
        bool IsWinAuth = false;
        string dataSource = "";
        string dataBaseName = "";
        string userName = "";
        string userPassword = "";
        string defaultFolderPath = "";

        public LogData()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // read connectionstring from config file
                string connectionString = "";
                string dataToVriteToLogFile = "";
                //dataSource


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

                using (SqlConnection conn = new SqlConnection(sqlConStrBuilder.ConnectionString))
                {
                    conn.Open();

                    // 1.  create a command object identifying the stored procedure
                    SqlCommand cmd = new SqlCommand("TransactionLogGet", conn);

                    // 2. set the command object so it knows to execute a stored procedure
                    cmd.CommandType = CommandType.StoredProcedure;

                    // execute the command
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            var operation = rdr["Operation"].ToString();
                            var currentLSN = rdr["Current LSN"].ToString();
                            var transactionName = rdr["Transaction Name"].ToString();
                            var transactionID = rdr["Transaction ID"].ToString();
                            var transactionSID = rdr["Transaction SID"].ToString();
                            var beginTime = rdr["Begin Time"].ToString();

                            var data = $"Operation_{operation}_Transaction ID_{currentLSN}_Transaction Name_{transactionName}_Transaction ID_{transactionID}_" +
                                $"Transaction SID_{transactionSID}_beginTime_{beginTime}\r\n";

                            dataToVriteToLogFile += data;
                        }
                    }
                }

                var backupFileName = String.Format("{0}{1}-{2}_log_data.txt",
                    backupFolder, sqlConStrBuilder.InitialCatalog,
                    DateTime.Now.ToString("dd-MMMM-yyyy hh-mm-ss"));

                File.WriteAllText(backupFileName, dataToVriteToLogFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MessageBox.Show("Log File was pulled successfully in the destination folder with .txt extension");
            }
        }

        private void LogData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.GetImagesStatistic' table. You can move, or remove it, as needed.
            this.getImagesStatisticTableAdapter.Fill(this.mainDataSet.GetImagesStatistic);
            // TODO: This line of code loads data into the 'mainDataSet.TransactionLogGet' table. You can move, or remove it, as needed.
            this.transactionLogGetTableAdapter.Fill(this.mainDataSet.TransactionLogGet);
            // TODO: This line of code loads data into the 'mainDataSet.Softs' table. You can move, or remove it, as needed.
            this.softsTableAdapter.Fill(this.mainDataSet.Softs);

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }
    }
}
