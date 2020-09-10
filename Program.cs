using System;

namespace songuyento100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cac so nguyen to nho hon 100 la: ");
            kq(1, 100);
            Console.ReadKey();
        }
        static int kq(int num, int i)  
        {
            for (num = 1; num <= 100; num++)
            {
                int n = 0;
                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        n++;
                        break;
                    }
                }

                if (n == 0 && num != 1)
                    Console.WriteLine(num);
            }

            return num;
        }   
    }
}
