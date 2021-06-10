using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterNumeros
{
    class RomanoParaPadrao
    {
        public int NumeroPadrao { get; private set; }
        public string NumeroRomano { get; set; }

        private Dictionary<string, int> dicionarioConversao = new Dictionary<string, int>()
        {
            { "X̄", 10000 },
            { "V̄", 5000 },
            { "M", 1000 },
            { "D", 500 },
            { "C", 100 },
            { "L", 50 },
            { "X", 10},
            { "V", 5},
            { "I", 1},
        };

        private List<string> valorMenor = new List<string>()
        {
            "I",
            "X",
            "C"
        };

        public RomanoParaPadrao(string valorRomano)

        {

            NumeroRomano = valorRomano;
            NumeroPadrao = Converter(valorRomano);

        }
        private int Converter(string valorPadrao)

        {
            char[] valoresParaConversao = valorPadrao.ToCharArray();

            int saida = 0;

            for (int i = 0; i < valoresParaConversao.Length; i++)

            {
                string valor = valoresParaConversao[i].ToString();
                int valorParaAdicionar = 0;

                if (PulaUmCaracter(valoresParaConversao, i))

                {
                    string proximoValor = valoresParaConversao[i + 1].ToString();

                    if (valorMenor.Contains(valor) && ValorMaior(valor, proximoValor))
                    {
                        valorParaAdicionar = dicionarioConversao[proximoValor] - dicionarioConversao[valor];
                        i++;
                    }

                }

                if (valorParaAdicionar == 0)

                {

                    valorParaAdicionar = dicionarioConversao[valor];

                }

                saida += valorParaAdicionar;
            }

            return saida;
        }

        private bool ValorMaior(string valor, string proximoValor)
        {
            return dicionarioConversao[proximoValor] > dicionarioConversao[valor];
        }

        private static bool PulaUmCaracter(char[] valoresParaConversao, int i)
        {
            return i + 1 < valoresParaConversao.Length;
        }
    }
}
