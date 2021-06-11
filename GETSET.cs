using System;

namespace GETSET
{
    class Program
    {
        static void Main(string[] args)
        {
            Heladera miHeladera1 = new Heladera();
            Console.WriteLine("Heladera 1: " + miHeladera1.getInfoHeladera());

            Heladera miHeladera2 = new Heladera("Philco", 0.75);
            miHeladera2.setInfoHeladera("Beige", 1.80);
            Console.WriteLine("Heladera 2: " + miHeladera2.getInfoHeladera());

            Heladera miHeladera3 = new Heladera("Gama", 0.80);
            miHeladera3.setInfoHeladera("Blanca", 2.00);
            Console.WriteLine("Heladera 3: " + miHeladera3.getInfoHeladera());



        }
    }

    partial class Heladera
    {
        public Heladera()
        {
            marca = "Mabel";
            grados = -15;
            profundidad = 0.60;
            freezer = true;
            color = "Blanco";
            alto = 1.90;
        }

        public Heladera(string marcaHela, double profHela)
        {
            marca = marcaHela;
            grados = -15;
            profundidad = profHela;
            freezer = true;
        }
    }

    partial class Heladera
    {
        public string getInfoHeladera()
        {
            return "Info Heladera:\n" + " Marca: " + marca + " \n Freezer: " + freezer + "\n Grados: " + grados + "\n Profundidad: " + profundidad + "\n Alto: " + alto + "\n Color: " + color;
        }

        public void setInfoHeladera(string color, double alto)
        {
            this.color = color;
            this.alto = alto;
        }

        string marca;
        int grados;
        double profundidad;
        string color;
        double alto;
        bool freezer;
    }
}

