using System;

namespace ConsoleApp1
{
    class Program
    {
        public static string Simplify(int a, int b)
        {
            string strTemp = "";
            int i = 0;
            if (b ==0)
                return "can't divide 0";
            if (a==0)
                return "0";
            if (a > b)
            {
                i = b;
                if (a % b == 0)
                    return (a / b).ToString();
            }                
            else
                i = a;
            for (int j =i; j >= 1; j--)
            {
                if (a % j == 0 && b % j == 0)
                {
                    a = a / j;
                    b = b / j;
                    strTemp = a + "/" + b;
                    return strTemp;
                }
            }          
            return strTemp;
        }


        static void Main(string[] args)
        {
            string a = Simplify(4, 6);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
