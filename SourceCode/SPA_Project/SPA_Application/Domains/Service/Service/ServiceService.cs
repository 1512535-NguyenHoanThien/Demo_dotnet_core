using SPA_Application.Domains.Entity;
using SPA_Application.Domains.Service.IService;
using SPA_Application.Domains.ViewModel;
using SPA_Application.Infrastructure.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Domains.Service.Service
{
    public class ServiceService : IServiceService
    {
        private IServiceRepository _serviceRepository;

        public ServiceService(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }


        public void Add(ServiceViewModel service)
        {
            _serviceRepository.Add(service);
        }

        public void Update(ServiceViewModel service)
        {
            _serviceRepository.Update(service);
        }

        public ServicePickedViewModel GetServicePicked(long id)
        {
            return _serviceRepository.GetServicePicked(id);
        }

        public IEnumerable<ServiceViewModel> GetServices()
        {
            return _serviceRepository.GetAllServices();
        }
    }
}
