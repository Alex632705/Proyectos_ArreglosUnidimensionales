namespace Inversión_de_arreglo
{
    internal class Program
    {
        /*Crea un programa que almacene 6 números en un arreglo y luego imprima el arreglo en orden inverso.*/
        static void Main(string[] args)
        {
            byte[] numeros = new byte[6];

            for (int i = 0; i < numeros.Length; i++) 
            {
                Console.WriteLine($"Ingrese el {i + 1} número de su arreglo:");
                try
                {
                    numeros[i] = byte.Parse(Console.ReadLine()!);
                }
                catch(Exception e) { 
                    Console.WriteLine(e.Message);
                    Console.WriteLine($"Ingrese el {i + 1} número de su arreglo:");
                    numeros[i] = byte.Parse(Console.ReadLine()!);
                }
            }

            Console.WriteLine("Arreglo invertido; Desde el último hasta el primero");
            for (int i = numeros.Length - 1 ; i >= 0 ; i--) 
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
