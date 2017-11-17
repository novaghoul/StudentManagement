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
    public partial class fManagement : Form
    {
        public fManagement()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddStudent f = new fAddStudent();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            fAddSubject f = new fAddSubject();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            fAddClass f = new fAddClass();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
