using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_1
{
    class Program1
    {
        static void Main(string[] args)
        {
            
            int a = 1;
            int b = 2;
            int c = 3;

            
            //21.1
            // Bigger of a,b,c in (if else)
            if (a>b && a>c)
            {
                Console.WriteLine("Bigger value: " + a);
            }
            else if (b>a && b>c)
            {
                Console.WriteLine("Bigger value: " + b);
            }
            else
            {
                Console.WriteLine("Bigger value: " + c);
            }
           
            //22/1
            // Smaller of a,b,c (if else)
            if (a < b && a < c)
            {
                Console.WriteLine("Smaller value: " + a);
            }
            else if (b < a && b < c)
            {
                Console.WriteLine("Smaller value: " + b);
            }
            else
            {
                Console.WriteLine("Smaller value: " + c);
            }
            

            //21/2
            switch (Math.Max(a, Math.Max(b, c)))

            {
                case 1:
                    Console.WriteLine(a);
                    break;
                case 2:
                    Console.WriteLine(b);
                    break;
                case 3:
                    Console.WriteLine(c);
                    break;
                default:
                    Console.WriteLine("I dont found max number");
                            break;
            }
            //22/2
            switch (Math.Min(a, Math.Min(b, c)))

            {
                case 1:
                    Console.WriteLine(a);
                    break;
                case 2:
                    Console.WriteLine(b);
                    break;
                case 3:
                    Console.WriteLine(c);
                    break;
                default:
                    Console.WriteLine("I dont found min number");
                    break;
            }

            //23 / 1

            if (a == 1 || b == 1 || c == 1)
            {
                Console.WriteLine(true);
            }

            //int chi toxum booliani het ashxati
            ////////switch (a == 1  || b == 1 || c == 1)
            ////////{
            ////////    case 1:
            ////////        Console.WriteLine(a);
            ////////        break;
            ////////    default:
            ////////        Console.WriteLine("false");
            ////////        break;
            ////////}

            //24/1
            if (a==2&&b==2 || a==2&&c==2||b==2&&c==2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            //25/1 erankyuni
            if ((a+b)>c&&(a+c)>b&&(c+b)>a)
            {
                Console.WriteLine("y=1");
            }
            else
            {
                Console.WriteLine("y=2");
            }
            //26/1
            if (a % 2 == 0 || b % 2 == 0 || c % 2 == 0)
            {
                Console.WriteLine(1);
            }
            else { Console.WriteLine(2); }

            //27/1 Թվաբանական պրոգրեսիա
            Console.Write("Tvabanakan progresia: ");
            if (b-a==c-b)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            //28/1 Երկրաչափական պրոգրեսիա
            Console.Write("Erkrachapakan progresia: ");
            if (b / a == c / b)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            //29/1
            if (a < b && a < c)
            {
                if (b < c)
                {
                    Console.WriteLine($"{a} {b} {c}");
                }
                else
                {
                    Console.WriteLine($"{a} {c} {b}");
                }
            }
            else if (b < a && b < c)
            {
                if (a < c)
                {
                    Console.WriteLine($"{b} {a} {c}");
                }
                else
                {
                    Console.WriteLine($"{b} {c} {a}");
                }
            }
            else if (c < a && c < b)
            {
                if (a < b)
                {
                    Console.WriteLine($"{c} {a} {b}");
                }
                else
                {
                    Console.WriteLine($"{c} {b} {a}");
                }
            }
            //30/1
            if (a>b&&a>c)
            {
                if (b>c)
                {
                    Console.WriteLine($"{a} {b} {c}");
                }
                else 
                {
                    Console.WriteLine($"{a} {c} {b}");
                }
            }
            else if (b > a && b > c)
            {
                if (a>c)
                {
                    Console.WriteLine($"{b} {a} {c}");
                }
                else
                {
                    Console.WriteLine($"{b} {c} {a}");
                }
            }
            else if (c>a&&c>b)
            {
                if (a>b)
                {
                    Console.WriteLine($"{c} {a} {b}");
                }
                else
                {
                    Console.WriteLine($"{c} {b} {a}");
                }
            }
        }
    }
}
