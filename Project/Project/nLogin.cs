using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class nLogin : Form
    {
        public nLogin()
        {
            InitializeComponent();
        }

        #region Event

        #region Click

        // Click button Login ( nhấn nút Đẳng nhập )
        private void btnLogin_Click(object sender, EventArgs e)
        {
            nMain t = new nMain();
            this.Hide();
            t.ShowDialog();
            this.Show();
        }

        // Click button Exit ( nhấn nút Thoát )
        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        // Click button Minimize on toolbox ( nhấn vào nút thu nhỏ trên thanh )
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Click button Exit on toolbox ( nhấn vào nút thoát trên thanh )
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        #endregion

        #endregion


        #region Method

        //

        #endregion

    }
}
