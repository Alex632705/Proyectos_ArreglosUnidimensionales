namespace Ventas_diarias
{
    /*
             Se requiere crear un programa que registre las ventas de una tienda durante 7 días y determina:

                1. El total vendido en la semana

                2. El promedio diario

                3. El día con la venta máxima
      */
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] ventas = new double[7];
            double mayor;
            mayor = 0;
            double total = 0;
            double promedio = 0;
            byte dia = 0;
            for (byte i = 0; i < ventas.Length; i++)
            {
                Console.WriteLine($"Ingrese las ventas del día {i + 1}:");
                try
                {
                    ventas[i] = double.Parse(Console.ReadLine()!);
                }
                catch(Exception e) 
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine($"Ingrese las ventas del día {i + 1}:");
                    ventas[i] = double.Parse(Console.ReadLine()!);

                }
                if (ventas[i] > mayor)
                {
                    mayor = ventas[i];
                    dia = i;
                }
                //Total de ventas
                total += ventas[i];
            }
            promedio = total / ventas.Length;
            Console.WriteLine($"El total vendido en la semana es ${total}");
            Console.WriteLine($"El promedio diario es {promedio}");
            Console.WriteLine($"El día que más se vendió fue el día #{dia + 1}");
            
        }
    }
}
