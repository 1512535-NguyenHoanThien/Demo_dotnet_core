using SPA_Application.Domains.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Domains.Service.IService
{
    public interface IServiceService
    {
        void Add(ServiceViewModel service);
        void Update(ServiceViewModel service);
        IEnumerable<ServiceViewModel> GetServices();
        ServicePickedViewModel GetServicePicked(long id);

    }
}
