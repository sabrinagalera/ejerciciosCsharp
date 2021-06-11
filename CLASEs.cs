using System;

namespace CLASEs
{
    class Program
    {
        static void Main(string[] args)
        {

            // ----------- Ejercicio 1 Calcular  área de  un círculo

            Console.WriteLine("Cálculo áreas \n");

            Circulo miCirculo;

            miCirculo = new Circulo();
            Console.WriteLine("Círculo 1: " + miCirculo.CalculoArea(8));

            Circulo miCirculo2 = new Circulo();
            Console.WriteLine("Círculo 2: " + miCirculo2.CalculoArea(10));

            // ---------- Ejercicio 2 Convertir dólar a euro y cambiar la cotización

            Console.WriteLine("\nConversor dólar a euro \n");
            ConversorDolarEuro obj = new ConversorDolarEuro();
            Console.WriteLine("Ayer : " + obj.Convierte(10.0));

            ConversorDolarEuro obj2 = new ConversorDolarEuro();
            obj2.CambiaValorEuro(1.850);
            Console.WriteLine("\nHoy: " + obj2.Convierte(10.0));

        }
    }

    class Circulo
    {
        private const double PI = 3.1416;
        public double CalculoArea(int radio)
        {
            return PI * radio * radio;
        }
    }

    class ConversorDolarEuro
    {
        private double euro = 1.555;

        public double Convierte(double cantidad)
        {
            return cantidad * euro;
        }
        public double CambiaValorEuro(double nuevoValor)
        {
            if (nuevoValor > 0) euro = nuevoValor;
            return euro;
        }

    }
}
