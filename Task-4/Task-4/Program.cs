using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double e=0;//точность 
            double S = 0;//сумма
            int i;
            double Ts = 0;//текущая сумма           

            while (e <= 0)
            {
                e = WriteDouble("Введите точность: ");
                e = Math.Round(e, 9);
                Console.WriteLine(e);
                if (e != 0)
                {
                    S = 0;
                    i = 1;
                    Ts = (Math.Pow(-1, i) / Enumerable.Range(1, i).Aggregate((p, x) => p * x));
                    while (Math.Abs(Ts) > e)
                    {
                        S += Ts;
                        i++;
                        Ts = (Math.Pow(-1, i) / Enumerable.Range(1, i).Aggregate((p, x) => p * x));
                    }
                    Console.WriteLine("Сумма выражения с заданной точностью {0} = {1}", e, S);
                }
                else
                {
                    Console.WriteLine("Введите e больше нуля!");
                }

            }
            Console.ReadKey();
        }
        public static double WriteDouble(string t)
        {
            bool ok; double a;
            do
            {
                Console.Write(t);
                string buf = Console.ReadLine();
                ok = double.TryParse(buf, out a);
                if ((!ok) || (a<=0))
                    Console.WriteLine("Ошибка, введите положительное число");
            } while ((!ok) || (a <= 0));
            return a;
        }
    }
}
