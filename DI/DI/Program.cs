
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
            clientProp.Service = new Property.Service1();
            clientProp.Start1();
            Console.ReadKey();

            DI.Method.Client clientMet = new DI.Method.Client();
            clientMet.Start(new Method.Service());
            Console.ReadKey();

        }
    }
}
