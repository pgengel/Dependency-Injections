using System;

namespace DI.Method
{
    public interface IService
    {
        void Serve();
    }

    public class Service : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service Method Called");

        }
    }

    public class Client
    {
        private IService _service;
        public void Start(IService service)
        {
            this._service = service;
            this._service.Serve();
        }
    }

}
