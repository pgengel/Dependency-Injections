using System;

namespace DI.Property
{
    public interface IService
    {
        void Serve();
    }

    public class Service1 : IService
    {
        public void Serve()
        {
            Console.WriteLine("Property Service1 called");
        }
    }
    public class Service2 : IService
    {
        public void Serve()
        {
            Console.WriteLine("Property Service2 called");
        }
    }

    public class Client
    {
        private IService _service;

        public IService Service { set { this._service = value; } }

        public void Start1()
        {
            Console.WriteLine("Service started");
            _service.Serve();
        }
        public void Start2()
        {
            Console.WriteLine("Service started");
            _service.Serve();
        }

    }

}
