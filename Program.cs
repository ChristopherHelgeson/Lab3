using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main()
        {
            string cont = "y";

            while (cont == "y" || cont == "Y")
            {
                Console.Clear();
                Console.WriteLine("Learn your squares and cubes!\n");
                Console.Write("Enter an integer: ");
                string getInt = Console.ReadLine();
                int verifiedInt = 0;

                while (!int.TryParse(getInt, out verifiedInt))
                {
                    Console.WriteLine($"Please enter an INTEGER: ");
                    getInt = Console.ReadLine();
                }

                Console.WriteLine("\nNUMBER\t\tSQUARED\t\tCUBED");
                Console.WriteLine("======\t\t=======\t\t=====");

                int count = 1;
                while (count <= verifiedInt)
                {
                    Console.WriteLine(count + "\t\t" + Squared(count) + "\t\t" + Cubed(count));
                    count++;
                }
                
                Console.Write("\nContinue? (Y/N): ");
                cont = Console.ReadLine();
            }
        }

        public static int Squared(int num)
        {
            return num * num;
        }

        public static int Cubed(int num)
        {
            return num * num * num;
        }
    }
}
