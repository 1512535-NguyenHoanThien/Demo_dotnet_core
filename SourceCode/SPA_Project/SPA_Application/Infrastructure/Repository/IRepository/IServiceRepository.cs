using SPA_Application.Common.Generic;
using SPA_Application.Domains.Entity;
using SPA_Application.Domains.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Infrastructure.Repository.IRepository
{
    public interface IServiceRepository
    {
        void Add(ServiceViewModel serviceViewModel);
        void Update(ServiceViewModel serviceViewModel);

        IEnumerable<ServiceViewModel> GetAllServices();
        ServicePickedViewModel GetServicePicked(long id); 
    }

}
