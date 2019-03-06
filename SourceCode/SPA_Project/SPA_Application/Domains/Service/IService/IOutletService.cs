using SPA_Application.Domains.Entity;
using SPA_Application.Domains.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Domains.Service.IService
{
    public interface IOutletService
    {
        void Open(OutletViewModel outlet);
        void Update(OutletViewModel outlet);
        void Close(long id);
        void ReOpen(long id);

        IEnumerable<OutletViewModel> GetOutlets();
        IEnumerable<OutletViewModel> GetOutletsByStatus(bool status);
        IEnumerable<OutletViewModel> GetOutletsByName(string name);
        OutletViewModel GetOutletsById(long id);

        IEnumerable<OutletSelectViewModel> GetOutletsSelect();
    }
}
