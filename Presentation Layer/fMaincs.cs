using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class fMaincs : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public fMaincs()
        {
            InitializeComponent();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            fThemKhoaHoc objfthemkhoahoc = new fThemKhoaHoc();
            objfthemkhoahoc.Show();
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            fSuaKhoaHoc objSua = new fSuaKhoaHoc();
            objSua.Show();
        }

        private void buttonItem19_Click(object sender, EventArgs e)
        {
            fThemLopHoc them = new fThemLopHoc();
            them.Show();
        }

        private void buttonItem20_Click(object sender, EventArgs e)
        {
            fSuaLopHoc slop = new fSuaLopHoc();
            slop.Show();
        }
    }
}