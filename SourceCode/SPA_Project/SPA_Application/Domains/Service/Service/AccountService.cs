using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using SPA_Application.Domains.Entity;
using SPA_Application.Domains.Service.IService;
using SPA_Application.Domains.ViewModel;
using SPA_Application.Infrastructure.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SPA_Application.Domains.Service.Service
{
    public class AccountService : IAccountService
    {
        private IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public List<string> Register(RegisterViewModel userRegister)
        {
            List<string> message = new List<string>();
            IdentityResult result = _accountRepository.Register(userRegister);
            if (result.Succeeded)
            {
                message.Add("Succeeded");
                return message;
            }
            else
            {
                return message;
            }
        }

        public async Task<bool> UpdateUser(UserViewModel userViewModel)
        {
            return await _accountRepository.UpdateUserAsync(userViewModel);
        }


        public string Login(LoginViewModel loginViewModel)
        {
            User user = _accountRepository.Login(loginViewModel);
            if (user == null)
                return "Login Failed";
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("1C6E85CA81978C378F57CBC856713Z7212425BZ");
            string roleName = _accountRepository.GetFirstRole(user.Id);
            //if (user.PhoneNumber.ToString() == "0981540295")
            //{
            //    roleName = "Admin";
            //}
            //else
            //    roleName = "Customer";
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("Id",user.Id.ToString()),
                    new Claim("PhoneNumber", user.PhoneNumber.ToString()),
                    new Claim("FullName", user.FullName.ToString()),
                    new Claim("Gender",user.Gender.ToString()),
                    //new Claim("DateOfBirth",user.DateOfBirth.ToString()),
                    //new Claim("Age",user.Age.ToString()),
                    //new Claim("Profession",user.Profession.ToString()),
                    //new Claim("IdentifyCard",user.IdentifyCard.ToString()),
                    //new Claim("Address",user.Address.ToString()),
                    new Claim("Role",roleName)
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            string tokenResult = tokenHandler.WriteToken(token);
            return tokenResult;
        }

        public UserViewModel GetUserByPhoneNumber(string phoneNumber)
        {
            return _accountRepository.GetUserByPhoneNumber(phoneNumber);
        }

        public Task<bool> ChangePassword(String phoneNumber, String curPass, String newPass)
        {
            Task<bool> test = _accountRepository.ChangePassword(phoneNumber, curPass, newPass);
            return _accountRepository.ChangePassword(phoneNumber, curPass, newPass);
        }
        public IEnumerable<UserViewModel> GetAllUser()
        {
            return _accountRepository.GetAllUser();
        }

        public UserFullViewModel GetUserFullViewById(string id)
        {
            return _accountRepository.GetUserFullViewById(id);
        }

        public IEnumerable<ItemSelectViewModel<string>> GetTherapist()
        {
            return _accountRepository.GetTherapist();
        }

    }
}
