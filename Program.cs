using System;

namespace songuyento100
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int a = 2;
            while (a < 100)
            {
                bool n = true;

                if (a < 2)
                {
                    n = false;
                }
                else
                {
                    int i = 2;

                    while (i <= Math.Sqrt(a))
                    {
                        if (a % i == 0)
                        {
                            n = false;
                            break;
                        }
                        i = i + 1;
                    }
                }
                if (n)
                    Console.Write("{0} ", a);
                a++;
            }
        }
    }
}
