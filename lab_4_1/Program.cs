using System;

namespace lab_4_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] mas = new int[8];
            int rows = mas.GetUpperBound(0) + 1;
            Random rnd = new Random();
            for (int i = 0; i < 8; i++)
            {
                mas[i] = rnd.Next(-10, 0);
            }
            for (int i = 0; i < 8 - 1; i++)
            {
                for (int j = 0; j < 8 - 1; j++)
                {
                    if (mas[j] > mas[j + 1])
                    {
                        int tmp = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = tmp;
                    }
                }


            }
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"{mas[i]} \t");
            }

            int[] mas2 = new int[8];
            int rows2 = mas.GetUpperBound(0) + 1;
            Random rnd2 = new Random();
            for (int i = 0; i < 8; i++)
            {
                mas2[i] = rnd2.Next(0, 10);
            }
            for (int i = 0; i < 8 - 1; i++)
            {
                for (int j = 0; j < 8 - 1; j++)
                {
                    if (mas2[j] < mas2[j + 1])
                    {
                        int tmp = mas2[j];
                        mas2[j] = mas2[j + 1];
                        mas2[j + 1] = tmp;
                    }
                }


            }
            for (int i = 0; i < rows2; i++)
            {
                Console.Write($"{mas2[i]} \t");
            }


        }
    
    }
}
