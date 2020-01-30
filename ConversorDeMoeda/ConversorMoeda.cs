namespace ConversorDeMoeda
{
    class ConversorMoeda
    {

        public static double IOF = 0.06;

        public static double DolarReais(double cotacaoDolar, double valorCompra)
        {
            return (valorCompra + (valorCompra * IOF)) * cotacaoDolar;
        }

    }
}
