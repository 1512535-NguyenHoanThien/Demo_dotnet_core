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
    public class OutletService : IOutletService
    {
        private IOutletRepository _outletRepository;

        public OutletService(IOutletRepository outletRepository)
        {
            _outletRepository = outletRepository;
        }


        public void Open(OutletViewModel outlet)
        {
            _outletRepository.Add(outlet);
        }

        public void Close(long id)
        {
            _outletRepository.InActive(id);
        }

        public void Update(OutletViewModel outlet)
        {
            _outletRepository.Update(outlet);
        }

        public void ReOpen(long id)
        {
            _outletRepository.Active(id);
        }

        public IEnumerable<OutletViewModel> GetOutletsByStatus(bool status)
        {
            return _outletRepository.GetOutletsByStatus(status);
        }

        public IEnumerable<OutletViewModel> GetOutletsByName(string name)
        {
            return _outletRepository.GetOutletsByName(name);
        }

        public OutletViewModel GetOutletsById(long id)
        {
            return _outletRepository.GetOutletsById(id);
        }

        public IEnumerable<OutletViewModel> GetOutlets()
        {
            return _outletRepository.GetOutlets();
        }

        public IEnumerable<OutletSelectViewModel> GetOutletsSelect()
        {
            return _outletRepository.GetOutletsSelect();
        }
    }
}
