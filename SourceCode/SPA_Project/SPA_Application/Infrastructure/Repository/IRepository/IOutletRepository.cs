using SPA_Application.Common.Generic;
using SPA_Application.Domains.Entity;
using SPA_Application.Domains.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Infrastructure.Repository.IRepository
{
    public interface IOutletRepository
    {
        void Add(OutletViewModel outlet);
        void Update(OutletViewModel outlet);
        void InActive(long id);
        void Active(long id);
        
        IEnumerable<OutletViewModel> GetOutlets();
        IEnumerable<OutletViewModel> GetOutletsByStatus(bool status);
        IEnumerable<OutletViewModel> GetOutletsByName(string name);
        OutletViewModel GetOutletsById(long id);
        IEnumerable<OutletSelectViewModel> GetOutletsSelect();
    }
}
