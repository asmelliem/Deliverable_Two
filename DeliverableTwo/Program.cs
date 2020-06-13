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
            string message = "Your encoded message is: ";
            for (int counter = 0; counter < input.Length; counter++)
            {
                int encodedValue = (int)input[counter] - 64;
                message += encodedValue.ToString();
                if (counter < input.Length - 1)
                {
                    message += "-";
                }
                checksum += (int)input[counter];
            }
            Console.WriteLine(message);
            Console.WriteLine("Message checksum value:" + checksum);
        }
    }
}
