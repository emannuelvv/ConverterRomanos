using ConverterNumeros;
using System;

namespace NumeroRomano
{
    class Program
    {
        static void Main(string[] args)
        {
            PadraoParaRomano x = new PadraoParaRomano(40);
            Console.WriteLine(x.NumeroRomano);
            RomanoParaPadrao j = new RomanoParaPadrao("XXX");
            Console.WriteLine(j.NumeroPadrao);
        }
    }
}
