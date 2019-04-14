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

        private void InserirTextoVisor(string valor)
        {
            string valoratual;
            valoratual = (txtVisor.Text != null ? txtVisor.Text : "");
            valoratual += valor;
            txtVisor.Text = valoratual;

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            InserirTextoVisor("0");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
            txtVisor.Font = new Font("Arial", 31);
        }

        private void btnSeparador_Click(object sender, EventArgs e)
        {
            InserirTextoVisor(",");
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            InserirTextoVisor(" + ");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            InserirTextoVisor("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            InserirTextoVisor("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            InserirTextoVisor("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            InserirTextoVisor("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            InserirTextoVisor("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            InserirTextoVisor("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            InserirTextoVisor("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            InserirTextoVisor("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            InserirTextoVisor("9");
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            InserirTextoVisor(" - ");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            InserirTextoVisor(" * ");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            InserirTextoVisor(" / ");
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

        private void txtVisor_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void txtVisor_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Fonte: " + txtVisor.Font.Size);
            if (txtVisor.Text.Length > 11)
            {
                txtVisor.Font = new Font("Arial",txtVisor.Font.Size - 1);
            }
        }
    }
}
