
using System;

namespace DI
{
    class Program
    {

        static void Main(string[] args)
        {
            Constructor.Client clientCon = new Constructor.Client(new Constructor.Service());
            clientCon.Start();
            Console.ReadKey();

            Property.Client clientProp = new Property.Client();
            clientProp.Service = new Property.Service();

        }
    }
}
