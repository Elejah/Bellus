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
    public partial class SearchingOnTab : DevExpress.XtraEditors.XtraForm
    {
        public SearchingOnTab()
        {
            InitializeComponent();
        }

        private void SearchingOnTab_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.Employes". При необходимости она может быть перемещена или удалена.
            this.employesTableAdapter.Fill(this.mainDataSet.Employes);

        }
    }
}