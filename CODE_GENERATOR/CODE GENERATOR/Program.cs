using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CODE_GENERATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] arr = new string[2, 2];


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine("[{0}{1}]-Enter course name :",i,j);
                    }
                    if (j == 1)
                    {
                        Console.WriteLine("[{0}{1}]-Enter book name :",i,j);
                    }
                    arr[i, j] = Console.ReadLine();
                }
            }

            Console.WriteLine("-----------------------");

            int isbn = -1;
            for (int i = 0; i < 2; i++)
            {
                string ccode = split(arr[i, 0]), bcode = split(arr[i, 1]);
                if (i == 0)
                {

                    isbn = random0();
                    Console.Write(isbn + " ");
                }
                else if (i == 1)
                {

                    isbn = random1();
                    Console.Write(isbn + " ");
                }

                for (int j = 0; j < 2; j++)
                {
                    Console.Write(arr[i, j] + " ");

                }
                Console.Write(codegenerator(isbn, ccode, bcode));
                Console.WriteLine();
            }
        }

        public static string codegenerator(int isbn, string coursecode, string bookcode)
        {
            string ans = isbn + "" + coursecode + bookcode;
            return ans;
        }

        public static int random0()
        {
            Random rand = new Random();
            int a = rand.Next(1000, 4000);
            return a;
        }
        public static int random1()
        {
            Random rand = new Random();
            int a = rand.Next(1200, 6000);
            return a;
        }


        public static string split(string a)
        {
            char x = ' ';
            string[] sp = a.Split(x);
            string emp = "";
            for (int i = 0; i < sp.Length; i++)
            {
                emp += sp[i][0];
            }
            return emp.ToUpper();
        }

    }
}
