using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HomeFinance
{
    public partial class frmCalculadora : HomeFinance.frmBaseFechar
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            string valoratual = "";
            valoratual = (txtVisor.Text != null? txtVisor.Text: "");
            valoratual = "0" + valoratual;
            txtVisor.Text = valoratual;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
        }

        private void btnSeparador_Click(object sender, EventArgs e)
        {
            string valoratual = "";
            valoratual = (txtVisor.Text != null ? txtVisor.Text : "");
            valoratual = "," + valoratual;
            txtVisor.Text = valoratual;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            string valoratual = "";
            valoratual = (txtVisor.Text != null ? txtVisor.Text : "");
            valoratual = " + " + valoratual;
            txtVisor.Text = valoratual;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string valoratual = "";
            valoratual = (txtVisor.Text != null ? txtVisor.Text : "");
            MessageBox.Show(valoratual);
            valoratual = "1" + valoratual;
            txtVisor.Text = valoratual;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string valoratual = "";
            valoratual = (txtVisor.Text != null ? txtVisor.Text : "");
            valoratual = "2" + valoratual;
            txtVisor.Text = valoratual;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string valoratual = "";
            valoratual = (txtVisor.Text != null ? txtVisor.Text : "");
            valoratual = "3" + valoratual;
            txtVisor.Text = valoratual;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string valoratual = "";
            valoratual = (txtVisor.Text != null ? txtVisor.Text : "");
            valoratual = "4" + valoratual;
            txtVisor.Text = valoratual;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string valoratual = "";
            valoratual = (txtVisor.Text != null ? txtVisor.Text : "");
            valoratual = "5" + valoratual;
            txtVisor.Text = valoratual;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string valoratual = "";
            valoratual = (txtVisor.Text != null ? txtVisor.Text : "");
            valoratual = "6" + valoratual;
            txtVisor.Text = valoratual;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string valoratual = "";
            valoratual = (txtVisor.Text != null ? txtVisor.Text : "");
            valoratual = "7" + valoratual;
            txtVisor.Text = valoratual;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string valoratual = "";
            valoratual = (txtVisor.Text != null ? txtVisor.Text : "");
            valoratual = "8" + valoratual;
            txtVisor.Text = valoratual;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string valoratual = "";
            valoratual = (txtVisor.Text != null ? txtVisor.Text : "");
            valoratual = "9" + valoratual;
            txtVisor.Text = valoratual;
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            string valoratual = "";
            valoratual = (txtVisor.Text != null ? txtVisor.Text : "");
            valoratual = " - " + valoratual;
            txtVisor.Text = valoratual;
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            string valoratual = "";
            valoratual = (txtVisor.Text != null ? txtVisor.Text : "");
            valoratual = " * " + valoratual;
            txtVisor.Text = valoratual;
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            string valoratual = "";
            valoratual = (txtVisor.Text != null ? txtVisor.Text : "");
            valoratual = " / " + valoratual;
            txtVisor.Text = valoratual;
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            string valoratual = "";
            if(txtVisor.Text != null && txtVisor.Text != "")
            {
                valoratual = txtVisor.Text;
                valoratual = valoratual.Remove(valoratual.Length - 1);
                txtVisor.Text = valoratual;
            }          
        }

        private void btnNegativo_Click(object sender, EventArgs e)
        {
            string valoratual = "";
            if (txtVisor.Text != null && txtVisor.Text != "")
            {
                valoratual = txtVisor.Text;
                valoratual = valoratual.Substring(valoratual.Length - 2);
                valoratual = (valoratual.Equals("-" + valoratual[valoratual.Length - 1])?""+valoratual[valoratual.Length - 1] : "-" + valoratual[valoratual.Length - 1]);
                valoratual += txtVisor.Text;
                txtVisor.Text = valoratual;
            }
        }
    }
}
