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

    public class Service : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service called");
        }
    }

    public class Client
    {
        private IService _service;

        public IService Service { set { this._service = value; } }

        public void Start()
        {
            Console.WriteLine("Service started");
            _service.Serve();
        }

    }

}
