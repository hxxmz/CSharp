using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Fundamentals
{
    class Program
    {
        public static void NumInput()
        {
            Console.Write("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number is: " + number);
        }

        public static void AddTwoInt()
        {
            int x = 2, y = 3;
            Console.Write(x + y);
        }

        public static void MultiplyFloats()
        {
            float x = 2.0f, y = 3.0f;
            Console.Write(x * y);
        }

        public static void Asciii()
        {
            string value = "h";
            byte[] asci = System.Text.Encoding.ASCII.GetBytes(value);
            foreach (byte a in asci) { Console.Write(a); }
        }

        public static void QuoRem()
        {
            int dividend = 22;
            int divisor = 3;
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("" + quotient);
            Console.WriteLine(remainder);
        }

        public static void SwapNums()
        {
            int a = 2;
            int b = 3;

            Console.WriteLine("A: " + a + " B: " + b);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("A: " + a + " B: " + b);
        }

        public static void OddEven()
        {
            int num = 66;
            if (num % 2 == 1) { Console.Write("Odd"); } else { Console.Write("Even"); }
        }

        public static void VowelConso()
        {
            string l = Char.ToString('a');
            string[] v = { "a", "e", "i", "o", "u" };

            foreach (string i in v)
            {
                if (i == l)
                {
                    Console.Write("Vowel"); break;

                }
                else
                {
                    Console.Write("Consonent"); break;

                }

            }

        }

        public static void ThreeNumComparison()
        {
            int x = 1, y = 3, z = 2;
            if (x > y && x > z) { Console.Write("x"); } else if (y > z) { Console.Write("y"); } else { Console.Write("z"); }
        }

        public static void QuadRoots()
        {
            double a = 1, b = 4, c = 5; double x, y;

            if (a == 0)
            {
                x = -c / b; Console.WriteLine("Linear Roots:" + x);
            }
            else
            {
                double d = (b * b) - (4 * a * c); double den = 2 * a;
                if (d > 0)
                {
                    x = (-b / den) + (Math.Sqrt(d) / den);
                    y = (-b / den) - (Math.Sqrt(d) / den);
                    Console.WriteLine("Real Roots: " + x + " & " + y);
                }
                else if (d == 0)
                {
                    x = -b / den;
                    Console.WriteLine("Single Root: " + x);
                }
                else
                {
                    x = -b / den;
                    y = ((Math.Sqrt((4 * a * c) - (b * b))) / den);
                    Console.WriteLine("First complex root: " + x + "+" + y + "i");
                    Console.WriteLine("Second complex root: " + x + "-" + y + "i");
                }
            }
        }

        public static void LeapYear()
        {
            int year = 2020;
            if ((year % 4) == 0 || ((year % 100) == 0 && (year % 400) == 0)) { Console.Write("Leap Year"); } else { Console.Write("Not Leap Year"); }
        }

        public static void NumCheck()
        {
            int num = -3;
            if (num < 0) { Console.Write("Negative"); } else { Console.Write("Positive"); }
        }

        public static void isAlph()
        {
            string value = "h";
            byte[] asci = System.Text.Encoding.ASCII.GetBytes(value);
            foreach (byte a in asci)
            {
                if ((a >= 65 && a <= 90) || (a >= 97 && a <= 122)) { Console.Write("Alphabet"); } else { Console.Write("Not an Alphabet"); }
            }
        }

        public static void NaturalSum()
        {
            int[] NatNums = { 1, 2, 3, 4, 5 }; int sum = 0;
            for (int i = 0; i < NatNums.Length; i++)
            {
                sum = sum + NatNums[i];
            }
            Console.Write(sum);
        }

        public static void Factorial()
        {
            int f = 5; int res = 1;
            while (f > 0)
            {
                res = res * f;
                f--;
            }
            Console.Write(res);
        }

        public static void MulTable()
        {
            int i = 1; int table = 5;
            while (i < 11)
            {
                int r = table * i;
                Console.WriteLine(table + " * " + i + " = " + r);
                i++;
            }

        }

        public static void FibTwoV()
        {
            int i = 1; int table = 5;
            while (i < 11)
            {
                int r = table * i;
                Console.WriteLine(table + " * " + i + " = " + r);
                i++;
            }

        }

        public static void FibThreeV()
        {
            int f = 0, s = 1, i = 1; Console.Write(f + "," + s + ","); int c = 7;
            while (i <= c)
            {
                int r = f + s; f = s; s = r; i++;
                Console.Write(r + ",");
            }
        }

        public static void GCD()
        {
            int n = 9, m = 15; int r;
            while (m != 0)
            {
                r = n % m;
                n = m;
                m = r;
            }
            Console.Write("GCD: " + n);
        }

        public static void AtoZ()
        {
            int lowSt = 65, lowEnd = 90, capSt = 97, capEnd = 122;
            for (int i = lowSt; i <= lowEnd; i++)
            {
                Console.WriteLine(Convert.ToChar(i));
            }
        }

        public static void NumOfDigits()
        {
            int a = 623, count = 0, s = 0;
            while (a != 0)
            {
                int r = a % 10;
                if (r > 0) { count++; a = a - r; }
                a = a / 10;
            }
            Console.WriteLine(count);
        }

        public static void RevNum()
        {
            int n = 123;
            int rev = 0;
            while (n != 0)
            {
                int r = n % 10;
                rev = rev * 10 + r;
                n = n / 10;
            }
            Console.Write(rev);
        }

        public static void Power()
        {
            int num = 5, pow = 2, i = 0, prod = 1;
            while (i < pow)
            {
                prod = num * prod; i++;
            }
            Console.WriteLine(prod);
        }

        public static void Palindrome()
        {
            string word = "abbcba"; int check = 0;
            char[] w = word.ToCharArray();
            int len = word.Length;
            if (len % 2 == 1)
            {
                for (int i = 0; i < (int)Math.Floor((double)len / 2); i++)
                {
                    if (w[i] == w[len - i - 1])
                    {
                        //Console.WriteLine(w[i]+"="+w[len-i-1]);
                        check = 1;
                    }
                    else { check = 0; break; }
                }
            }
            else
            {
                for (int i = 0; i < len / 2; i++)
                {
                    if (w[i] == w[len - i - 1])
                    {
                        check = 1;
                    }
                    else { check = 0; break; }
                }
            }
            if (check == 1) { Console.Write("Palindrome."); }
            else
            {
                Console.Write("Not a Palindrome.");
            }
        }

        public static void Prime()
        {
            int num = 19, i = 2; bool prime = false;
            while (!prime && i < num)
            {
                if (num % i != 0) { i++; } else { break; }
            }
            if (i == num) { prime = true; }
            Console.Write(prime);
        }

        public static void PrimeInterval()
        {
            int a = 2, b = 12;
            for (int x = a; x <= b; x++)
            {
                int num = x, i = 2; bool prime = false;
                while (!prime && i < num)
                {
                    if (num % i != 0) { i++; } else { break; }
                }
                if (i == num) { prime = true; }
                Console.WriteLine(num + " " + prime.ToString());
            }
        }

        public static void Armstrong()
        {
            int a = 371, s = 0;
            int len = a.ToString().Length;
            while (a != 0)
            {
                int r = a % 10;
                int i = 0, p = 1;
                while (i < len)
                {
                    p = r * p; i++;
                }
                s = s + p;
                a = a / 10;
            }
            Console.WriteLine(s);
        }

        public static void ArmstrongInterval()
        {
            int a = 100, b = 400; // 153 370 371
            for (int i = a; i <= b; i++)
            {
                int s = 0; int num = i;
                int len = num.ToString().Length;
                while (num != 0)
                {
                    int r = num % 10;
                    int j = 0, p = 1;
                    while (j < len)
                    {
                        p = p * r; j++;
                    }
                    s = s + p;
                    num = num / 10;
                }
                if (i == s) { Console.WriteLine(i + "\n"); }
            }
        }


        static void Main(string[] args)
        {
            // NumInput();
            // AddTwoInt();
            // MultiplyFloats();
            // Asciii();
            // QuoRem();
            // SwapNums();
            // OddEven();
            // VowelConso();
            // ThreeNumComparison();
            // QuadRoots();
            // LeapYear();
            // NumCheck();
            // isAlph();
            // NaturalSum();
            // Factorial();
            // MulTable();
            // FibTwoV();
            // FibThreeV();
            // GCD();
            // AtoZ();
            // NumOfDigits();
            // RevNum();
            // Power();
            // Palindrome();
            // Prime();
            // PrimeInterval();
            // Armstrong();
            // ArmstrongInterval();

            Console.ReadLine();
        }
    }
}
