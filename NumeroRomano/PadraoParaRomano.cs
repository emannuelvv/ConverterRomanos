using System;
using System.Collections.Generic;
using System.Text;

namespace NumeroRomano
{
    class PadraoParaRomano
    {
        public int NumeroPadrao { get; private set; }
        public string NumeroRomano { get; set; }


        private Dictionary<int, string> valoresConversao = new Dictionary<int, string>()
        {
            { 10000, "X̄" },
            { 9000, "ĪX̄" },
            { 8000, "V̄ĪĪĪ" },
            { 7000, "V̄ĪĪ" },
            { 6000, "V̄Ī" },
            { 5000, "V̄" },
            { 4000, "ĪV̄" },
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD"},
            { 100, "C"},
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X"},
            { 9, "IX"},
            { 5, "V"},
            { 4, "IV"},
            { 1, "I"},


    };

        public PadraoParaRomano(int valorPadrao)
        {
            NumeroPadrao = valorPadrao;
            NumeroRomano = Converter(NumeroPadrao);/*converterndo para romano*/
        }
        

        private string Converter(int valorPadrao)
        {

            StringBuilder saida = new StringBuilder();
            int valorParaConversao = valorPadrao;

            foreach (int valor in valoresConversao.Keys)
            {
                while (valorParaConversao >= valor)
                {
                    saida.Append(valoresConversao[valor]);
                    valorParaConversao -= valor;
                }
            }

            return saida.ToString();
        }
    }
}