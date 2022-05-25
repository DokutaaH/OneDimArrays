using System;

namespace One_dim_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 1

            int[] demoArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            for (int i = 0; i < demoArray.Length; i++)
            {
                Console.Write(demoArray[i] + "; ");
            }
            
            Console.WriteLine();
            Console.WriteLine("=============================================================");
            Console.WriteLine();

            // Задача 2

            Random random = new Random();

            int[] demoArray2 = new int[15];

            for (int i = 0; i < demoArray2.Length; i++)
            {
                demoArray2[i] = random.Next(-9999, 9999);
                Console.Write(demoArray2[i] + "; ");
            }
            
            Console.WriteLine();
            Console.WriteLine("=============================================================");
            Console.WriteLine();

            // Задача 3

            int[] demoArray3 = new int[10];

            for (int i = 0; i < demoArray3.Length; i++)
            {
                Console.WriteLine("Please enter number " + (i + 1));
                bool isParsed = false;

                do
                {
                    string input = Console.ReadLine();
                    isParsed = int.TryParse(input, out int parsedResult);

                    if (isParsed)
                    {
                        demoArray3[i] = parsedResult;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a correct number.");
                    }
                } while (isParsed == false);
            }

            Console.WriteLine();
            Console.WriteLine("The array you entered is as follows:");
            for (int j = 0; j < demoArray3.Length; j++)
            {
                Console.WriteLine(demoArray3[j]);
            }

            Console.WriteLine();
            Console.WriteLine("=============================================================");
            Console.WriteLine();

            // Задача 4

            int[] demoArray4 = new int[10];
            int numOfPositives = 0;

            for (int i = 0; i < demoArray4.Length; i++)
            {
                Console.WriteLine("Please enter number " + (i + 1));
                bool isParsed = false;

                do
                {
                    string input = Console.ReadLine();
                    isParsed = int.TryParse(input, out int parsedResult);

                    if (isParsed)
                    {
                        demoArray4[i] = parsedResult;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a correct number.");
                    }
                } while (isParsed == false);

                if (demoArray4[i] >0)
                {
                    numOfPositives += 1;
                }
            }

            for (int j = 0; j < demoArray4.Length; j++)
            {
                Console.Write(demoArray4[j] + "; ");
            }

            Console.WriteLine();
            Console.WriteLine("The number of positive digits you entered is " + numOfPositives);
        }
    }
}
