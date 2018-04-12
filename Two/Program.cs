using System;

namespace Two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value: ");
            string number = Console.ReadLine();
            int two = 2;
            int count = 0;
            do
            {
                if (two * 2 > int.Parse(number) / 2 && two < int.Parse(number) / 2)
                {
                    two += 1;
                    count++;
                }
                // if(int.Parse(number) % (two + 1) == 0)
                else if ((two + 1) == int.Parse(number) / 2 )
                {
                    two += 1;
                    count++;
                }
                //else if (int.Parse(number) / 2 - two <= 2 && int.Parse(number) / 2 - two > 0)
                //{
                //    two += 1;
                //    count++;
                //}
                else if (int.Parse(number) - two == 1)
                {
                    two += 1;
                    count++;
                }
                else
                {
                    two *= 2;
                    count++;
                }
            } while (two != int.Parse(number));
            Console.WriteLine("Count: " + count);

            Console.ReadKey();
        }
    }
}
