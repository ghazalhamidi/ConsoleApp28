using System;

namespace TimeConverter
{
    class Program
    {
        static void Main(string[]args)
        {
            int a;
            Console.WriteLine("enter the a:");
            a =
                Convert.ToInt32(Console.ReadLine());
            int b;
            Console.WriteLine("enter the b:");
            b =
                Convert.ToInt32(Console.ReadLine());
            int c;
            Console.WriteLine("enter the c");
            c =
                Convert.ToInt32(Console.ReadLine());
            int ha = hajm(a, b, c);
            Console.WriteLine("hajm jabe:"+ha);


        } 
        static int hajm(int a,int b,int c)
        {
            int h = a * b * c;
            return h;
        }
    }
}