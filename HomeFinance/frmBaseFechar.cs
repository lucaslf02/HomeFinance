using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFinance
{
    public partial class frmBaseFechar : Form
    {
        public frmBaseFechar()
        {
            InitializeComponent();
        }

        private void toolStripBtnFechar_Click(object sender, EventArgs e)
        {
            this.Sair();
        }

        public virtual bool Sair()
        {
            this.Close();
            return true;
        }
    }
}
