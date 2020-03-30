using System;

namespace MyprojecsApp
{
    class Program
    {
        static void Main(string[] args)
        {/*
                                                      //Задача 2.1
            int A, B, S = 0;
            Console.Write("A = ");
            A = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            B = int.Parse(Console.ReadLine());

            for (int i = A; i <= B; i++) S += i;
            System.Console.WriteLine($"Sum[{A} до {B}] = {S}");
            Console.ReadKey();
                                                        //Задача 2.2
            int A, B;
            Console.Write("A = ");
            A = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            B = int.Parse(Console.ReadLine());

            for (int i = A; i <= B; i++)
            {
                if (i % 2 == 1) Console.WriteLine(i); ;
            }
            Console.ReadKey();
                                                        //Задача 3
                                         //Прямоугольник
            for(int i=0;i<=8;i++)
            {
                if (i==0 || i==8){
                for(int j=0;j<=17;j++)
                {Console.Write(" *");}
                }
                else {
                Console.Write(" *");
                for(int j=0;j<=16;j++)
                {Console.Write("  ");}
                }
                Console.Write(" *\n");
            }
            Console.ReadKey();

                                         //Прямоугольный треугольник
            Console.Write("  *\n");
            for (int i = 0; i <= 8; i++)
            {
                Console.Write("  *");
                for (int j = 0; j <= i; j++)
                    Console.Write("   ");
                Console.Write("*\n");
                if (i == 8)
                {
                    for (int j = 0; j <= i; j++)
                    { Console.Write("  * "); }
                    Console.Write("\n");
                }
            }
            Console.ReadKey();

                                        //Равносторонний треугольник
            for (int i = 0; i <= 12; i++)
            {
                for (int k = 12 - i; k >= 0; k--)
                {
                    Console.Write("  ");
                }

                if (i >= 2 && i < 12)
                {
                    Console.Write("  *");
                    for (int l = 0; l <= i - 2; l++)
                    {
                        Console.Write("    ");
                    }
                    Console.Write("   *");
                }
                else
                {
                    for (int j = 0; j <= i; j++)
                    { Console.Write("  * "); }
                }
                Console.Write("\n");
            }
            Console.ReadKey();

                                                //Ромб
            for (int i = 0; i <= 12; i++)
            {
                for (int k = 12 - i; k >= 0; k--)
                {
                    Console.Write("  ");
                }

                if (i >= 2 && i <= 12)
                {
                    Console.Write("  *");
                    for (int l = 0; l <= i - 2; l++)
                    {
                        Console.Write("    ");
                    }
                    Console.Write("   *");
                }
                else if (i == 0 || i == 1)
                {
                    for (int j = 0; j <= i; j++)
                    { Console.Write("  * "); }
                }
                Console.Write("\n");
            }

            for (int i = 12; i >= 0; i--)
            {   if(i!=12)
                for (int k = -i + 12; k >= 0; k--)
                {
                    Console.Write("  ");
                }

                if (i >= 2 && i < 12)
                {
                    Console.Write("  *");
                    for (int l = 0; l <= i - 2; l++)
                    {
                        Console.Write("    ");
                    }
                    Console.Write("   *");
                }
                else if (i == 0 || i == 1)
                {
                    for (int j = 0; j <= i; j++)
                    { Console.Write("  * "); }
                }
                if(i!=12)Console.Write("\n");
            }
            Console.ReadKey();

                                                        //Задача 4
            double P, Sum = 1000;int K=0;
            Console.Write("P = ");
            P = double.Parse(Console.ReadLine());

            if (P > 0 && P < 25)
            {
                for(Sum=1000;Sum<=1100;Sum+=((Sum*P)/100))K++;
                Console.WriteLine($"K = {K}");
                Console.WriteLine($"S = {Sum}");
            }
            Console.ReadKey();*/
        }
    }
}
