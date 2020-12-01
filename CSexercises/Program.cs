using System;
using System.Collections.Generic;

namespace CSexercises
{
    class exercises
    {
        public bool isDivisor(int x, int y)
        {
            if (y % x == 0) { return true; }
            else { return false; }
        }

        public bool isPerfectNr(int x)
        {
            int a = 0;


            for (int i = 1; i < x / 2 + 1; i++) { if (isDivisor(i, x)) { a = a + i; } }

            if (a == x) { return true; }
            else { return false; }
        }

        public void PerfectNumbers()
        {
            List<int> perfectNrs = new List<int>();

            Console.Write("Input the start of the interval: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the end of the interval: ");
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                if (isPerfectNr(i))
                {
                    perfectNrs.Add(i);
                }
            }

            Console.Write("{0} {1}{2}{3} {4}{5}{6}", "Here are the perfect number(s) within the range", '"', a, " -", b, '"', ":");
            Console.Write(" ");

            for (int i = 0; i < perfectNrs.Count; i++)
            {
                Console.Write(perfectNrs[i]);
                Console.Write(", ");
            }

            Console.Write("\n");
        }

        public void Exercise1()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Henrik");
        }

        public void Exercise2(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        public void Exercise3(int x, int y)
        {
            Console.WriteLine(x / y);
        }

        public void Exercise4()
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 - 4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 - 7 % 2);
        }

        public void Exercise5(int x, int y)
        {
            int z = x;
            x = y;
            y = z;
            Console.WriteLine(string.Format("{0} {1}", x, y));
        }

        public void Exercise6()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(x * y * z);

        }

        public void Exercise7()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(x + y);
            Console.WriteLine(x / y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
        }

        public void Exercise8()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(x * (i + 1));
            }

        }

        public void Exercise9()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine((a + b + c + d) / 4);
        }

        public void Exercise10()
        {
            int x, y, z;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((x + y) * z);
            Console.WriteLine(x * y + y * z);
        }

        public void Exercise13()
        {
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0}{0}{0}", x);
        }

        public void Exercise15()
        {
            String s = Console.ReadLine();
            int index = Convert.ToInt32(Console.ReadLine());
        }

    }

    class ReverseTheString
    {
        public string reverseString(string s)
        {
            string tempString = String.Empty;
            for (int i = s.Length - 1; i > -1; i--)
            {
                tempString += s[i];
            }

            return tempString;
        }

        public string specialReverse(string s)
        {
            string sReverse = reverseString(s);
            
            string tempString = String.Empty;
            string tempString2 = String.Empty;
            string tempString3 = String.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                if (sReverse[i] != ' ')
                {
                    tempString += sReverse[i];
                }
            }

            int a = 0;
            int j = 0;
            while (j < s.Length - 1)
            {
                if (s[j] == ' ')
                {
                    tempString2 += ' ';
                    j += 1;
                }

                tempString2 += tempString[a];

                a += 1;
                j += 1;
            }
            tempString2 += s[0];
            
            tempString2 = tempString2.ToLower();        
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].ToString() == s.Substring(i, 1).ToUpper())
                {
                    tempString3 += tempString2.Substring(i, 1).ToUpper();
                }
                else { tempString3 += tempString2[i]; }
            }

            return tempString3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var e = new exercises();
            var s = new ReverseTheString();
            Console.WriteLine(s.specialReverse("aB cde1 FgH"));
        }
    }


    //   string input34 = "aDSfg asdg3 ";
    //   string structure = "";
    //   foreach (char character in input34)
    //{
    //       if (character.IsUpper())
    //{
    //       structure = structure + "U";
    //}
    //   else if
    //   { 

    //   }

    //	}
}
