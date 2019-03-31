using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HomeFinance
{
    public partial class Logon : HomeFinance.frmBaseFechar
    {
        public bool bSenhaOK = false;
        public bool VerificaString(string str)
        {
            char[] c = str.ToCharArray();
            char le = ' ';
            for(int i = 0; i < c.Length; i++)
            {
                le = c[i];
                if (char.IsLetter(le) || char.IsPunctuation(le))
                    return true;                
            }
            return false;
        }
        public bool VerificaNumero(string str)
        {
            char[] c = str.ToCharArray();
            char le = ' ';
            for(int i = 0; i < c.Length; i++)
            {
                le = c[i];
                if (char.IsNumber(le))
                    return true;
            }
            return false;
        }
        public Logon()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtSenha.Text = "";
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Atenção, o login é um campo obrigatório", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Atenção, a senha é um campo obrigatório", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(!VerificaNumero(txtSenha.Text) || !VerificaString(txtSenha.Text))
            {
                MessageBox.Show("Atenção, senha inválida (deve conter letras e numeros)","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            if(txtLogin.Text == "admin" && txtSenha.Text == "admin123")
            {
                bSenhaOK = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
