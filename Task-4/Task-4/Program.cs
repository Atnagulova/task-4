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
            double e;//точность
            double S=0;//сумма
            e = WriteDouble("Введите точность: ");

            for (int i = 1; i<Int32.MaxValue; i++)
            {
                S = S + (Math.Pow(-1, i) / Enumerable.Range(1, i).Aggregate((p, x) => p * x));
            if (Math.Abs(S) < e)
                {
                    Console.WriteLine("Сумма выражения с заданной точностью {0} равна {1}", e, S);
                    break;
                }                
            }
            Console.ReadKey();
        }
        public static double WriteDouble(string t)
        {
            bool ok; double a;
            do
            {
                Console.WriteLine(t);
                string buf = Console.ReadLine();
                ok = double.TryParse(buf, out a);
                if ((!ok) || (a<0))
                    Console.WriteLine("Ошибка, введите положительное число");
            } while ((!ok) || (a < 0));
            return a;
        }
    }
}
