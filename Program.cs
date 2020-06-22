using System;

namespace Aula22Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversor.CotacaoDolar = 5.23f;
            System.Console.WriteLine( Conversor.ConverterRealParaDolar(200) );
        }
    }
}
