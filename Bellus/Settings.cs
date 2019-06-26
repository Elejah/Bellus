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
    public partial class Settings : DevExpress.XtraEditors.XtraForm
    {
        DevExpress.LookAndFeel.DefaultLookAndFeel maindesign;

        public Settings()
        {
            InitializeComponent();
        }
        public Settings(DevExpress.LookAndFeel.DefaultLookAndFeel maindesign)
        {
            this.maindesign = maindesign;
            InitializeComponent();
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            maindesign.LookAndFeel.SkinName = "Office 2013";
        }

        private void checkButton2_CheckedChanged(object sender, EventArgs e)
        {
            maindesign.LookAndFeel.SkinName = "DevExpress Style";
        }

        private void checkButton3_CheckedChanged(object sender, EventArgs e)
        {
            maindesign.LookAndFeel.SkinName = "Office 2016 Dark";
        }

        private void checkButton4_CheckedChanged(object sender, EventArgs e)
        {
            maindesign.LookAndFeel.SkinName = "Office 2016 Black";
        }

        private void checkButton5_CheckedChanged(object sender, EventArgs e)
        {
            maindesign.LookAndFeel.SkinName = "The Bezier";
        }

        private void checkButton6_CheckedChanged(object sender, EventArgs e)
        {
            maindesign.LookAndFeel.SkinName = "Office 2010 Silver";
        }
    }
}