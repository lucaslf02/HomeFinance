using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFinance
{
    class TCalculadora
    {
        private string expressao = "";
        private bool error = false;
        private ArrayList calculo = new ArrayList();

        public TCalculadora(String expressao)
        {
            this.expressao = expressao;
            
            for (int i = 0; i < expressao.Length; i++)
            {
                calculo.Add(expressao[i]);
            }
            Calcular();
        }
        
        private string Calcular()
        {
            double val1 = 0;
            double val2 = 0;
            String operador = "";                    
            while(calculo.Count > 1) {
                int i = 0;

            }
            return "";
        }

        private String soma(double val1, double val2)
        {
            double result = val1 + val2;
            return result.ToString();
        }
        private String subtracao(double val1, double val2)
        {
            double result = val1 - val2;
            return result.ToString();
        }
        private String divisao(double val1, double val2)
        {
            if(val2 == 0)
            {
                error = true;
                return "Impossível Divir Por Zero";
            }
            double result = val1 / val2;
            return result.ToString();
        }
        private String multiplicacao(double val1, double val2)
        {
            double result = val2 * val2;
            return result.ToString();
        }
    }
}
