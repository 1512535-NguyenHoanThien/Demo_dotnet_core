using SPA_Application.Domains.Entity;
using SPA_Application.Infrastructure.Context;
using SPA_Application.Infrastructure.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SPA_Application.Common.EntityHelper;

namespace SPA_Application.Infrastructure.Repository.Repository
{
    public class BedRepository : IBedRepository
    {
        private SPAContext _context;
        public BedRepository(SPAContext context)
        {
            _context = context;
        }

        public void Active(long id)
        {
            var bed = _context.Beds.FirstOrDefault(p => p.Id == id);
            bed.UpdatedEntity();

            _context.Beds.Update(bed);
            _context.SaveChanges();
        }

        public void Add(Bed bed)
        {
            bed.AddEntity();

            _context.Add(bed);
            _context.SaveChanges();
        }

        public void InActive(long id)
        {
            var bed = _context.Beds.FirstOrDefault(p => p.Id == id);
            bed.DeleteEntity();

            _context.Beds.Update(bed);
            _context.SaveChanges();
        }

        public void Update(Bed bed)
        {
            var _bed = _context.Beds.FirstOrDefault(p => p.Id == bed.Id);

            _bed.UpdatedEntity();

            _context.Beds.Update(_bed);
            _context.SaveChanges();
        }

        public IEnumerable<Bed> GetBedsByStatus(Status status)
        {
            return _context.Beds.Where(t => t.Status == status).ToList();
        }

        public Bed GetBedsById(long id)
        {
            return _context.Beds.Where(t => t.Id == id).FirstOrDefault();
        }

        public IEnumerable<Bed> GetBeds()
        {
            return _context.Beds.ToList();
        }
    }
}
