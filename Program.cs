using System;

namespace Lesson3_ContinueConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("----------HomeWork_2----------");
            Console.Write("Price without discount = "); var price = Convert.ToInt32(Console.ReadLine());
            if (price >= 500 && price < 1000)
            {
                price = price - (price*3)/100;
                System.Console.WriteLine($"Price with discount: {price}");
            }else if(price >=1000)
            {
                price = price - (price*5)/100;
                System.Console.WriteLine($"Price with discount: {price}");
            }else
            {
                Console.WriteLine($"There are no discounts for this price");                
            }
            
            System.Console.WriteLine("----------HomeWork_3----------");
            int a, b, c, d;
            Console.Write("a = ");a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");c = Convert.ToInt32(Console.ReadLine());
            Console.Write("d = ");d = Convert.ToInt32(Console.ReadLine());
            if (a==b && b==c && c==d)
            {
                var h= a*b*c*d;
                System.Console.WriteLine("h="+h);                
            }else if (!(a<b && b < c && c < d))
            {
                var h=min(min(a, b), min(c, d));
                Console.WriteLine($"Min: {h}");
            }else
            {
                System.Console.WriteLine("Числа расположены по возрастанию");
            }
            System.Console.WriteLine("----------HomeWork_4----------");
            int A,B,C;
            System.Console.WriteLine("Введите 3 цифры:");
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            C = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Sort:");
            if (A==B && B==C)
            {
                System.Console.WriteLine("Все числа равны");
            }else if (A>=B && A>=C && B>=C)
            {
                System.Console.WriteLine(A+" "+B+" "+C);
            }else if (A>=B && A>=C && C>=B)
            {
                System.Console.WriteLine(A+" "+C+" "+B);                
            }else if (B>=A && B>=C && A>=C)
            {
                System.Console.WriteLine(B+" "+A+" "+C);
            }else if (B>=A && B>=C && C>=A)
            {
                System.Console.WriteLine(B+" "+C+" "+A);                
            }else if (C>=A && C>=B && A>=B)
            {
                System.Console.WriteLine(C+" "+A+" "+B);                
            }else if (C>=A && C>=B && B>=A)
            {
                System.Console.WriteLine(C+" "+B+" "+A);                
            }
        }
        public static int min(int a, int b){
            return a < b ? a : b;
        }
    }
}
