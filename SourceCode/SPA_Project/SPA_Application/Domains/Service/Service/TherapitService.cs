//using SPA_Application.Domains.Service.IService;
//using SPA_Application.Domains.ViewModel;
//using SPA_Application.Infrastructure.Repository.IRepository;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using static SPA_Application.Common.EntityHelper;

//namespace SPA_Application.Domains.Service.Service
//{
//    public class TherapitService : ITherapitService
//    {
//        private ITherapitRepository _therapitRepository; 

//        public TherapitService(ITherapitRepository therapitRepository)
//        {
//            _therapitRepository = therapitRepository;
//        }

       

//        public void Add(TherapitViewModel therepitViewModel)
//        {
//            _therapitRepository.Add(therepitViewModel);
//        }

//        public IEnumerable<TherapitViewModel> GetTherapitByEmail(string email)
//        {
//            return _therapitRepository.GetTherapitByEmail(email);
//        }

//        public IEnumerable<TherapitViewModel> GetTherapitByFirstName(string firstName)
//        {
//            return _therapitRepository.GetTherapitByFirstName(firstName);
//        }

//        public IEnumerable<TherapitViewModel> GetTherapitByGender(Gender gender)
//        {
//            return _therapitRepository.GetTherapitByGender(gender);
//        }

//        public TherapitViewModel GetTherapitById(long id)
//        {
//            return _therapitRepository.GetTherapitById(id);
//        }

//        public IEnumerable<TherapitViewModel> GetTherapitByLastName(string lastName)
//        {
//            return _therapitRepository.GetTherapitByLastName(lastName);
//        }

//        public IEnumerable<TherapitViewModel> GetTherapitByPhone(string phone)
//        {
//            return _therapitRepository.GetTherapitByPhone(phone);
//        }

       

//        public void OutJob(long id)
//        {
//            _therapitRepository.InActive(id);
//        }

//        public void ReWork(long id)
//        {
//            _therapitRepository.Active(id);
//        }

//        public void Update(TherapitViewModel therapit)
//        {
//            _therapitRepository.Update(therapit);
//        }

//        IEnumerable<TherapitViewModel> ITherapitService.GetTherapits()
//        {
//            return _therapitRepository.GetTherapits();
//        }
//    }
//}
