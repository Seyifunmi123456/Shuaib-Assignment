using System;
namespace solution
{
    class assignment
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "Poly ilaro ";

            Console.Write("Enter second Integer: ");
            int k_int = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second double: ");
            double k_double = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second string: ");
            string k_str = Console.ReadLine();

            Console.WriteLine(i + k_int);
            Console.WriteLine(d + k_double);
            Console.WriteLine(s + k_str);

        }

    }
}



