using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air_ine
{
    internal class Program
    {

        static void Ps() 
        {
        
        for(int i = 1; i<=30;i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Ps();
            Console.WriteLine("How Many Passengers ? \n");
            int P = Convert.ToInt32(Console.ReadLine());
            do
            {
                Ps();
                Console.WriteLine("|Hello Passenger In Saudi Arab Line| \n");
                Ps();
                Console.WriteLine("Please Entre your Degree :\n");
                Console.WriteLine("1-A \n2-B \n3-C\n");
                int d = Convert.ToInt32(Console.ReadLine());
                Ps();

                switch (d)
                {
                    case 1:
                        Console.WriteLine("Entre Your Weight \n");
                        double w = Convert.ToDouble(Console.ReadLine());

                        if (w <= 30) { Console.WriteLine("Thanks You Are Pass\n"); }
                        else
                        {
                            Console.WriteLine("Each one kg = 10 SAR\n");
                            Console.Write("Total Cost = ");
                            Console.WriteLine((w - 30) * 10 + "SAR\n");

                        }

                        break;

                    case 2:
                        Console.WriteLine("Entre Your Weight \n");

                        w = Convert.ToDouble(Console.ReadLine());

                        if (w <= 20) { Console.WriteLine("Thanks You Are Pass\n"); }
                        else
                        {
                            Console.WriteLine("Each one kg = 10 SAR\n");
                            Console.Write("Total Cost = ");
                            Console.WriteLine((w - 20) * 10 + "SAR\n");

                        }
                        break;
                    case 3:
                        Console.WriteLine("Entre Your Weight \n");

                        w = Convert.ToDouble(Console.ReadLine());

                        if (w <= 10) { Console.WriteLine("Thanks You Are Pass\n"); }
                        else
                        {
                            Console.WriteLine("Each one kg = 10 SAR\n");
                            Console.Write("Total Cost = ");
                            Console.WriteLine((w - 10) * 10 + "SAR\n");

                        }
                        break;



                }
                P--;
            } while (P != 0);
            Console.WriteLine("Thank You For Use Our APP\n");



        }
    }
}
