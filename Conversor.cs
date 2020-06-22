namespace Aula22Static
{
    public class Conversor
    {
        public static float CotacaoDolar = 5.23f;

        public static float ConverterRealParaDolar(float valor){
            return valor * CotacaoDolar;
        }
    }
}