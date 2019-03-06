//using SPA_Application.Domains.Entity;
//using SPA_Application.Domains.ViewModel;
//using SPA_Application.Infrastructure.Context;
//using SPA_Application.Infrastructure.Repository.IRepository;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using static SPA_Application.Common.EntityHelper;

//namespace SPA_Application.Infrastructure.Repository.Repository
//{
//    public class TherapitRepository : ITherapitRepository
//    {
//        private SPAContext _context;

//        public TherapitRepository(SPAContext context)
//        {
//            _context = context;
//        }

//        public void Add(TherapitViewModel therapitViewModel)
//        {
//            User therapit = new User
//            {
//                Address = therapitViewModel.Address,
//                DateOfBirth = therapitViewModel.DateOfBirth,
//                Email = therapitViewModel.Email,
//                FirstName = therapitViewModel.FirstName,
//                LastName = therapitViewModel.LastName,
//                Gender = therapitViewModel.Gender,
//                PhoneNumber = therapitViewModel.Phone,
//            };
            
//            _context.Users.Add(therapit);
//            _context.SaveChanges();
//        }

//        public void Active(long id)
//        {
//            var therapit = _context.Users.FirstOrDefault(p => p.Id == id);
//            therapit.UpdatedEntity();

//            _context.Users.Update(therapit);
//            _context.SaveChanges();
//        }

//        public void InActive(long id)
//        {
//            var therapit = _context.Users.FirstOrDefault(p => p.Id == id);
//            therapit.DeleteEntity();

//            _context.Users.Update(therapit);
//            _context.SaveChanges();
//        }

//        public void Update(TherapitViewModel therapitViewModel)
//        {
//            var therapit = _context.Users.FirstOrDefault(p => p.Id == therapitViewModel.Id);
//            therapit.Address = therapitViewModel.Address;
//            therapit.DateOfBirth = therapitViewModel.DateOfBirth;
//            therapit.Email = therapitViewModel.Email;
//            therapit.FirstName = therapitViewModel.FirstName;
//            therapit.LastName = therapitViewModel.LastName;
//            therapit.Gender = therapitViewModel.Gender;
//            therapit.Phone = therapitViewModel.Phone;

//            therapit.UpdatedEntity();

//            _context.Users.Update(therapit);
//            _context.SaveChanges();
//        }

//        public IEnumerable<TherapitViewModel> GetTherapits()
//        {
//            return _context.Users.Where(p => p.Role == UserRole.THERAPIT).Select(p => new TherapitViewModel
//            {
//                Address = p.Address,
//                Email = p.Email,
//                FirstName = p.FirstName,
//                LastName=p.LastName,
//                Gender = p.Gender,
//                Phone = p.Phone,
//                DateOfBirth = p.DateOfBirth
//            }).ToList();
//        }

//        public TherapitViewModel GetTherapitById(long id)
//        {
//            return _context.Users.Where(p => p.Id==id).Select(p => new TherapitViewModel
//            {
//                Address = p.Address,
//                Email = p.Email,
//                FirstName = p.FirstName,
//                LastName=p.LastName,
//                Gender = p.Gender,
//                Phone = p.Phone,
//                DateOfBirth = p.DateOfBirth
//            }).FirstOrDefault();
//        }

//        public IEnumerable<TherapitViewModel> GetTherapitByLastName(string lastName)
//        {
//            return _context.Users.Where(p => p.Role == UserRole.THERAPIT && p.LastName==lastName).Select(p => new TherapitViewModel
//            {
//                Address = p.Address,
//                Email = p.Email,
//                FirstName = p.FirstName,
//                LastName=p.LastName,
//                Gender = p.Gender,
//                Phone = p.Phone,
//                DateOfBirth = p.DateOfBirth
//            }).ToList();
//        }

//        public IEnumerable<TherapitViewModel> GetTherapitByFirstName(string firstName)
//        {
//            return _context.Users.Where(p => p.Role == UserRole.THERAPIT && p.FirstName==firstName).Select(p => new TherapitViewModel
//            {
//                Address = p.Address,
//                Email = p.Email,
//                FirstName = p.FirstName,
//                Gender = p.Gender,
//                Phone = p.Phone,
//                DateOfBirth = p.DateOfBirth
//            }).ToList();
//        }

//        public IEnumerable<TherapitViewModel> GetTherapitByEmail(string email)
//        {
//            return _context.Users.Where(p => p.Role == UserRole.THERAPIT && p.Email==email).Select(p => new TherapitViewModel
//            {
//                Address = p.Address,
//                Email = p.Email,
//                FirstName = p.FirstName,
//                Gender = p.Gender,
//                Phone = p.Phone,
//                DateOfBirth = p.DateOfBirth
//            }).ToList();
//        }

//        public IEnumerable<TherapitViewModel> GetTherapitByPhone(string phone)
//        {
//            return _context.Users.Where(p => p.Role == UserRole.THERAPIT && p.Phone == phone).Select(p => new TherapitViewModel
//            {
//                Address = p.Address,
//                Email = p.Email,
//                FirstName = p.FirstName,
//                Gender = p.Gender,
//                Phone = p.Phone,
//                DateOfBirth = p.DateOfBirth
//            }).ToList();
//        }

//        public IEnumerable<TherapitViewModel> GetTherapitByGender(Gender gender)
//        {
//            return _context.Users.Where(p => p.Role == UserRole.THERAPIT && p.Gender == gender).Select(p => new TherapitViewModel
//            {
//                Address = p.Address,
//                Email = p.Email,
//                FirstName = p.FirstName,
//                Gender = p.Gender,
//                Phone = p.Phone,
//                DateOfBirth = p.DateOfBirth
//            }).ToList();
//        }
//    }
//}
