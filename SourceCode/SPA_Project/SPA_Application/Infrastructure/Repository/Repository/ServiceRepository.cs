using Microsoft.EntityFrameworkCore;
using SPA_Application.Common.Generic;
using SPA_Application.Domains.Entity;
using SPA_Application.Domains.ViewModel;
using SPA_Application.Infrastructure.Context;
using SPA_Application.Infrastructure.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Infrastructure.Repository.Repository
{
    public class ServiceRepository : IServiceRepository
    {
        private SPAContext _context;
       
        public ServiceRepository(SPAContext context)
        {
            _context = context;
        }
        public void Add(ServiceViewModel serviceViewModel)
        {
            Service service = new Service
            {
                ServiceName = serviceViewModel.ServiceName,
                Price = serviceViewModel.Price,
                Content = serviceViewModel.Content,
                Time = serviceViewModel.Time,
                ImgUrl = serviceViewModel.ImgUrl,
                ServiceTypeId = serviceViewModel.ServiceTypeId
            };
            service.AddEntity();


            _context.Add(service);
            _context.SaveChanges();
        }

        public IEnumerable<ServiceViewModel> GetAllServices()
        {
            return _context.Services.Select(p => new ServiceViewModel
            {
               Id=p.Id,
               Content=p.Content,
               ImgUrl=p.ImgUrl,
               Price=p.Price,
               ServiceName=p.ServiceName,
               Time=p.Time,
               ServiceTypeId=p.ServiceTypeId
            }).ToList();
        }

        public void Update(ServiceViewModel serviceViewModel)
        {
            var service = _context.Services.FirstOrDefault(p => p.Id == serviceViewModel.Id);

            service.ServiceName = serviceViewModel.ServiceName;
            service.Price = serviceViewModel.Price;
            service.Content = serviceViewModel.Content;
            service.Time = serviceViewModel.Time;
            service.ImgUrl = serviceViewModel.ImgUrl;
            service.ServiceTypeId = serviceViewModel.ServiceTypeId;
            service.UpdatedEntity();

            _context.Services.Update(service);
            _context.SaveChanges();
        }

        public ServicePickedViewModel GetServicePicked(long id)
        {
            return _context.Services.Where(p => p.Id == id).Select(p => new ServicePickedViewModel
            {
                Id=p.Id,
                Price=p.Price,
                ServiceName=p.ServiceName,
                Time=p.Time
            }).FirstOrDefault();
        }
    }
}
