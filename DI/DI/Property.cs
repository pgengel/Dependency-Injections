using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("Service1 called");
        }
    }
    public class Service2 : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service2 called");
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
