using System;

namespace excepciones2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = 0;
            bool intentar = false;
            Console.WriteLine("¿Qué número es mayor?");


            while (!intentar) 
            {  
                Console.WriteLine("Ingrese el primer número");
                try
                {
                    num1 = Int32.Parse(Console.ReadLine());
                    intentar = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("\nHas ingresado texto y ha ocurrido un error");
                    Console.WriteLine("Esta vez asegurese de ingresar un numero\n");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("\nHas ingresado un numero muy grande");
                    Console.WriteLine("Esta vez intente ingresar una cantidad correcta\n");
                }

            }

            
            Console.WriteLine("Ingrese el segundo número");
            int num2 = Int32.Parse(Console.ReadLine());
            
            if(num1 > num2)
            {
                Console.WriteLine($"{num1} es mayor que {num2}");
            }
            else if (num1 == num2)
            {
                Console.WriteLine($"{num1} es igual a {num2}");
            }
            else
            {
                Console.WriteLine($"{num2} es mayor a {num1}");
            }

            Console.ReadKey();
        }
    }
}
