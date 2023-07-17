using System;


namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*  Scrieti o functie recursiva care va calcula al n-lea element din sirul lui Fibonacci, n fiind citit de la tastatura, apelati-o si afisati-I rezultatul.*/


            Console.Write("Numarul n = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Numar " + n + " " + "sir Fibonacci" +" "+ "este: " + " " + NrFibonacci(n));
        }



        static int NrFibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
          
               return NrFibonacci(n - 1) + NrFibonacci(n - 2);
            
  
        }
    }
}
