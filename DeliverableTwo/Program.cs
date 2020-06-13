using System;
using System.Text;

namespace DeliverableTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your message");
            string input = Console.ReadLine().ToUpper();

            int checksum = 0;
            for (int counter =0; counter < input.Length; counter++)
            {
                Console.WriteLine((int)input[counter]);
                checksum += (int)input[counter];
            }

            Console.WriteLine("Checksum Value:" + checksum);
        }
    }
}
