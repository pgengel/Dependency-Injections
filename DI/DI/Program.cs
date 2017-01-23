using System;

namespace DI
{
    class Program
    {

        static void Main(string[] args)
        {
            Client client = new Client(new Service());
            client.Start();
            Console.ReadKey();

        }
    }
}
