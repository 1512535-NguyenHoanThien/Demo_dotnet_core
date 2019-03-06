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
    public class OutletRepository : IOutletRepository
    {
        private SPAContext _context;
        public OutletRepository(SPAContext context)
        {
            _context = context;
        }

        public void Active(long id)
        {
            var outlet = _context.Outlets.FirstOrDefault(p => p.Id == id);
            outlet.UpdatedEntity();

            _context.Outlets.Update(outlet);
            _context.SaveChanges();
        }

        public void Add(OutletViewModel outletVM)
        {
            Outlet outlet = new Outlet
            {
                Address = outletVM.Address,
                Name = outletVM.Name,
                Phone = outletVM.Phone,
                Longitude = outletVM.Longitude,
                Latitude = outletVM.Latitude

            };
            outlet.AddEntity();

            _context.Add(outlet);
            _context.SaveChanges();
        }

        public void InActive(long id)
        {
            var outlet = _context.Outlets.FirstOrDefault(p => p.Id == id);
            outlet.DeleteEntity();

            _context.Outlets.Update(outlet);
            _context.SaveChanges();
        }

        public void Update(OutletViewModel outletVM)
        {
            var outlet = _context.Outlets.FirstOrDefault(p => p.Id == outletVM.Id);

            outlet.Name = outletVM.Name;
            outlet.Phone = outletVM.Phone;
            outlet.Address = outletVM.Address;
            outlet.Latitude = outletVM.Latitude;
            outlet.Longitude = outletVM.Longitude;
            outlet.UpdatedEntity();

            _context.Outlets.Update(outlet);
            _context.SaveChanges();
        }

        public IEnumerable<OutletViewModel> GetOutletsByStatus(bool status)
        {
            return _context.Outlets.Where(t=>t.EntityStatus == status).Select(p => new OutletViewModel
            {
                Address = p.Address,
                Id = p.Id,
                Name = p.Name,
                Phone = p.Phone,
                Status = p.EntityStatus
            }).ToList();
        }
        public IEnumerable<OutletViewModel> GetOutletsByName(string name)
        {
            return _context.Outlets.Where(t => t.Name == name).Select(p => new OutletViewModel
            {
                Address = p.Address,
                Id = p.Id,
                Name = p.Name,
                Phone = p.Phone,
                Status = p.EntityStatus
            }).ToList();
        }
        public OutletViewModel GetOutletsById(long id)
        {
            return _context.Outlets.Where(t => t.Id == id).Select(p => new OutletViewModel
            {
                Address = p.Address,
                Id = p.Id,
                Name = p.Name,
                Phone = p.Phone,
                Status = p.EntityStatus,
                Latitude = p.Latitude,
                Longitude = p.Longitude
            }).FirstOrDefault();
        }

        public IEnumerable<OutletViewModel> GetOutlets()
        {
            return _context.Outlets.Select(p => new OutletViewModel
            {
                Address = p.Address,
                Id = p.Id,
                Name = p.Name,
                Phone = p.Phone,
                Status = p.EntityStatus,
                Latitude=p.Latitude,
                Longitude=p.Longitude
            }).ToList();
        }

        public IEnumerable<OutletSelectViewModel> GetOutletsSelect()
        {
            return _context.Outlets.Select(p => new OutletSelectViewModel
            {
                Id = p.Id,
                Name = p.Name,
            }).ToList();
        }
    }
}
