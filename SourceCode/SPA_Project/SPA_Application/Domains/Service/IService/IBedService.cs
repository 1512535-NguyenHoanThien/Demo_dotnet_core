using SPA_Application.Domains.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SPA_Application.Common.EntityHelper;

namespace SPA_Application.Domains.Service.IService
{
    public interface IBedService
    {
        void Add(Bed bed);
        void Update(Bed bed);
        void Close(long id);
        void ReOpen(long id);

        IEnumerable<Bed> GetBeds();
        IEnumerable<Bed> GetBedsByStatus(Status status);
        Bed GetBedsById(long id);
    }
}
