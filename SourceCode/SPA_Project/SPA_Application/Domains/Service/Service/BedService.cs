using SPA_Application.Domains.Entity;
using SPA_Application.Domains.Service.IService;
using SPA_Application.Infrastructure.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SPA_Application.Common.EntityHelper;

namespace SPA_Application.Domains.Service.Service
{
    public class BedService : IBedService
    {

        private IBedRepository _bedRepository;

        public BedService(IBedRepository bedRepository)
        {
            _bedRepository = bedRepository;
        }

        public void Add(Bed bed)
        {
            _bedRepository.Add(bed);
        }

        public void Close(long id)
        {
            _bedRepository.InActive(id);
        }

        public IEnumerable<Bed> GetBeds()
        {
            return _bedRepository.GetBeds();
        }

        public Bed GetBedsById(long id)
        {
            return _bedRepository.GetBedsById(id);
        }

        public IEnumerable<Bed> GetBedsByStatus(Status status)
        {
            return _bedRepository.GetBedsByStatus(status);
        }



        public void ReOpen(long id)
        {
            _bedRepository.Active(id);
        }

        public void Update(Bed bed)
        {
            _bedRepository.Update(bed);
        }
    }
}
