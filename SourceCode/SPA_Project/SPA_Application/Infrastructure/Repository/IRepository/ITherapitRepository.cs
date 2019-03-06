//using SPA_Application.Domains.ViewModel;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using static SPA_Application.Common.EntityHelper;

//namespace SPA_Application.Infrastructure.Repository.IRepository
//{
//    public interface ITherapitRepository
//    {
//        void Add(TherapitViewModel TherapitViewModel);
//        IEnumerable<TherapitViewModel> GetTherapits();

//        void Active(long id);

//        void InActive(long id);

//        void Update(TherapitViewModel therapitViewModel);


//        TherapitViewModel GetTherapitById(long id);

//        IEnumerable<TherapitViewModel> GetTherapitByLastName(string lastName);

//        IEnumerable<TherapitViewModel> GetTherapitByFirstName(string firstName);

//        IEnumerable<TherapitViewModel> GetTherapitByEmail(string email);

//        IEnumerable<TherapitViewModel> GetTherapitByPhone(string phone);

//        IEnumerable<TherapitViewModel> GetTherapitByGender(Gender gender);
//    }
//}