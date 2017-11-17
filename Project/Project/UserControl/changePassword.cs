using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class changePassword : UserControl
    {
        public changePassword()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            passOld.Text = "";
            passNew.Text = "";
            checkpassNew.Text = "";
        }
    }
}
