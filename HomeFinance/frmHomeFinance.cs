using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace HomeFinance
{
    public partial class frmPrincipal : Form
    {
        private frmCalculadora fCalculadora;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Fechar a Aplicação?", "Encerrando o HomeFinance...",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "NO"){
                e.Cancel = true;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void calculadoraWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void santanderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sinfo = new ProcessStartInfo("www.santander.com.br");
            Process.Start(sinfo);
        }

        private void toolStripBtnCalcWindows_Click(object sender, EventArgs e)
        {
            calculadoraWindowsToolStripMenuItem_Click(sender, e);
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool formIsOpen = Application.OpenForms.OfType<frmCalculadora>().FirstOrDefault() != null;

            if(formIsOpen == false)
            {
                fCalculadora = new frmCalculadora();
                fCalculadora.Text = "Calculadora";                               
            }
            fCalculadora.MdiParent = this;
            fCalculadora.WindowState = FormWindowState.Maximized;
            fCalculadora.Hide();
            fCalculadora.Show();

        }
    }
}
