using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Message[] msg = new Message[4];
            msg[0] = new Message("First Project");
            msg[1] = new Message("in github");
            msg[2] = new Message("i have made changes");
            msg[3] = new Message("I am on my way");

            
            string input = Console.ReadLine().ToLower();
            if (input == "ben")
            {
                msg[0].Print();
            }
            else if(input == "timothy")
                {
                msg[1].Print();
            }
            else if(input == "alex")
            {
                msg[2].Print();
            }
            else
            {
                msg[3].Print();
            }
        }
    }
}
