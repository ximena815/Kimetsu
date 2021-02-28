using System;

namespace kimetsu2for
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Nezuko", "Tanjiro", "Zenitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
            double[] estatura = { 153, 165, 164.5, 164, 180, 156, 176 };
            Console.WriteLine("Kimetsu estaruras");
            //-----------------------------------------------------
            double total = 0;
            for (int i = 0; i < estatura.Length; i++)
            {
                total += estatura[i];
            }
            Console.WriteLine("Total: " + total);
            double promedio = total / estatura.Length;
            Console.WriteLine("promedio: " + promedio);
            //-----------------------------------------------------|X| = sqrt(x^2)
            double[] distancias = new double[estatura.Length];
            double min = 200;
            int indice = 0;
            //encontrar el nombre de la persona con estatura más parecida al promedio(menor distancia)
            for (int i = 0; i < distancias.Length; i++)
            {
                distancias[i] =Math.Abs(estatura[i] - promedio);
                if (distancias[i] < min)
                {
                    min = distancias[i];
                    indice = i;
                }
            }
            Console.WriteLine("Nombre de la persona aja: " + nombres[indice]);
            //-----------------------------------------------------
        }
    }
}
