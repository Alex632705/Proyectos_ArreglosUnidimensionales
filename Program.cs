using System;

namespace Temperaturas
{
    /*
     Se requiere craear un programa que almacene en un arreglo las temperaturas de una ciudad durante 10 días y determina:

        1. Temperatura más alta y más baja

        2. Promedio de temperaturas

        3. Cuántos días estuvieron por encima de 30°C
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturas = new double[10];
            double mayor;
            double menor = 56.7;
            mayor = 0;
            double total = 0;
            double promedio = 0;
            byte dia = 0;
            byte dias = 0;
            byte dia_menor = 0;

            for (byte i = 0; i < temperaturas.Length; i++)
            {
                Console.Write($"Ingrese la temperatura del día {i + 1}:");
                try
                {
                    temperaturas[i] = double.Parse(Console.ReadLine()!);
                }
                catch(Exception e) {
                    Console.WriteLine(e.Message);
                    Console.WriteLine($"Ingrese la temperatura del día {i + 1}:");
                    temperaturas[i] = double.Parse(Console.ReadLine()!);
                }
                if (temperaturas[i] > mayor)
                {
                    mayor = temperaturas[i];
                    dia = i;
                }
                if (temperaturas[i] < menor) 
                {
                    menor = temperaturas[i];
                    dia_menor = i;
                }

                if (temperaturas[i] > 30) 
                {
                    dias++;
                }
               
                total += temperaturas[i];
            }
            promedio = total / temperaturas.Length;
            Console.WriteLine($"La temperatura más alta fue {mayor}°C y la más baja fue {menor}°C");
            Console.WriteLine($"El promedio de temperatura es: {promedio}°C");
            Console.WriteLine($"Los días que la temperatura estuvo por encima de 30°C fueron: {dias}");
        }
    }
}
