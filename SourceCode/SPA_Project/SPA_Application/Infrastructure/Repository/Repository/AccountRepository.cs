using Microsoft.AspNetCore.Identity;
using SPA_Application.Domains.Entity;
using SPA_Application.Domains.ViewModel;
using SPA_Application.Infrastructure.Context;
using SPA_Application.Infrastructure.Repository.IRepository;
using System;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SPA_Application.Common.EntityHelper;
using Microsoft.AspNetCore.Http;

namespace SPA_Application.Infrastructure.Repository.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private SPAContext _context;
        private UserManager<User> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private SignInManager<User> _signinManager;

        public AccountRepository(
            SPAContext context
            , UserManager<User> userManager
            , RoleManager<IdentityRole> roleManager
            , SignInManager<User> signinManager
            )
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _signinManager = signinManager;
        }

        public AccountRepository()
        {
        }

        public async Task<bool> UpdateUserAsync(UserViewModel userViewModel)
        {
            User user = _userManager.FindByNameAsync(userViewModel.PhoneNumber).Result;

            if (user == null)
            {
                return false;
            }

            user.Email = userViewModel.Email;
            user.PhoneNumber = userViewModel.PhoneNumber;
            user.FullName = userViewModel.FullName;
            user.Gender = userViewModel.Gender;
            user.DateOfBirth = userViewModel.DateOfBirth;
            user.Profession = userViewModel.Profession;
            user.IdentifyCard = userViewModel.IdentifyCard;
            user.Address = userViewModel.Address;

            IdentityResult result = await _userManager.UpdateAsync(user);

            User test = _userManager.FindByNameAsync(userViewModel.PhoneNumber).Result;
            return true;
        }

        public IdentityResult Register(RegisterViewModel registerViewModel)
        {
            var user = new User
            {
                PhoneNumber = registerViewModel.PhoneNumber,
                Email = registerViewModel.Email,
                UserName = registerViewModel.PhoneNumber,
                FullName = registerViewModel.FullName
            };

            //Admin only
            //Please comment after run
            //registerViewModel.Role = "ADMIN";
            //registerViewModel.Password = "123456@Ab";
            //var user = new User
            //{
            //    PhoneNumber = "0912010200",
            //    Email = "admin@admins.com",
            //    UserName = "0912010200",
            //    FullName = "Adminstators"
            //};
            var registerResult = _userManager.CreateAsync(user, registerViewModel.Password).Result;

            if (registerResult.Succeeded)
            {
                bool checkRole = _roleManager.RoleExistsAsync(registerViewModel.Role.ToUpper()).Result;
                if (!checkRole)
                {
                    var result = _roleManager.CreateAsync(new IdentityRole(registerViewModel.Role.ToUpper())).Result;
                }
                var roleResult = _userManager.AddToRoleAsync(user, registerViewModel.Role.ToUpper()).Result;
                return registerResult;
            }

            return registerResult;
        }

        public User Login(LoginViewModel loginViewModel)
        {

            var loginResult = _signinManager.PasswordSignInAsync(
                loginViewModel.PhoneNumber, 
                loginViewModel.Password, 
                loginViewModel.RememberMe,
                false).Result;

            if (loginResult.Succeeded)
            {
                return _userManager.FindByNameAsync(loginViewModel.PhoneNumber).Result;
            }
            return null;
        }

        public UserViewModel GetUserByPhoneNumber(String phoneNumber)
        {
            User user = _userManager.FindByNameAsync(phoneNumber).Result;

            UserViewModel userViewModel = new UserViewModel(user.Id,user.PhoneNumber,user.Email,user.PasswordHash,user.FullName,user.Gender,user.DateOfBirth,user.Profession,user.IdentifyCard, "",user.Address);

            string roleId = _context.UserRoles.Where(p => p.UserId == user.Id).Select(p => p.RoleId).FirstOrDefault();
            userViewModel.Role = _context.Roles.Where(p => p.Id == roleId).Select(p => p.Name).FirstOrDefault().ToString();

            return userViewModel;
        }

        public async Task<bool> ChangePassword(String phoneNumber, String curPass, String newPass)
        {
            User user = _userManager.FindByNameAsync(phoneNumber).Result;

            if (curPass == null || newPass == null)
            {
                return false;
            }
            try
            {
                IdentityResult result = await _userManager.ChangePasswordAsync(user, curPass, newPass);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: '{0}'", e);
            }
            return false;
        }

        public string GetFirstRole(string id)
        {

            var query = (
               from uRole in _context.UserRoles
               from user in _userManager.Users
               from role in _context.Roles
               where uRole.UserId == user.Id && uRole.RoleId == role.Id && user.Id == id
               select role.Name
           );
            return query.FirstOrDefault();

        }

        public IEnumerable<UserViewModel> GetAllUser()
        {
            IEnumerable<UserViewModel> userViewModels = new List<UserViewModel>();
            userViewModels = _userManager.Users.Select(p => new UserViewModel
            {
                Email = p.Email,
                FullName = p.FullName,
                Id = p.Id,
                PhoneNumber = p.PhoneNumber
            }).ToList();

            foreach (var user in userViewModels)
            {
                string roleId = _context.UserRoles.Where(p => p.UserId == user.Id).Select(p => p.RoleId).FirstOrDefault();
                user.Role = _context.Roles.Where(p => p.Id == roleId).Select(p => p.Name).FirstOrDefault().ToString();
            }

            return userViewModels;

        }

        public UserFullViewModel GetUserFullViewById(string id)
        {
            User user = _userManager.FindByIdAsync(id).Result;
            return new UserFullViewModel()
            {
                Address = user.Address,
                DateOfBirth = user.DateOfBirth.Date,
                Gender = user.Gender.ToString(),
                FullName = user.FullName,
                Id = user.Id,
                //Status = user.EntityStatus,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };

        }

        public IEnumerable<ItemSelectViewModel<string>> GetTherapist()
        {
            var query = (
                 from uRole in _context.UserRoles
                 from user in _userManager.Users
                 from role in _context.Roles
                 where uRole.UserId == user.Id && uRole.RoleId == role.Id && role.Name == "THERAPIT"
                 select new ItemSelectViewModel<string>
                 {
                     Id = user.Id,
                     Name = user.FullName
                 }
             );
            return query.ToList();

        }
    }
}
