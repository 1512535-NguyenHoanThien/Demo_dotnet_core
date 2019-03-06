using SPA_Application.Domains.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SPA_Application.Common.EntityHelper;

namespace SPA_Application.Infrastructure.Repository.IRepository
{
    public interface IBedRepository
    {
        void Add(Bed bed);
        void Update(Bed bed);
        void InActive(long id);
        void Active(long id);

        IEnumerable<Bed> GetBeds();
        IEnumerable<Bed> GetBedsByStatus(Status status);
        Bed GetBedsById(long id);
    }
}
