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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStaff f = new fStaff();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void họcViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fManagement f = new fManagement();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void côngNợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDebt f = new fDebt();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đẳngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStaffManagement f = new fStaffManagement();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
