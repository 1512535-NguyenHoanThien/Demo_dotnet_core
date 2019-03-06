using Microsoft.AspNetCore.Identity;
using SPA_Application.Domains.Entity;
using SPA_Application.Domains.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Infrastructure.Repository.IRepository
{
    public interface IAccountRepository
    {
        IdentityResult Register(RegisterViewModel registerViewModel);
        User Login(LoginViewModel loginViewModel);
        Task<bool> UpdateUserAsync(UserViewModel userViewModel);
        UserViewModel GetUserByPhoneNumber(String phoneNumber);
        Task<bool> ChangePassword(String phoneNumber, String curPass, String newPass);
        string GetFirstRole(string id);

        IEnumerable<UserViewModel> GetAllUser();
        UserFullViewModel GetUserFullViewById(string id);
        IEnumerable<ItemSelectViewModel<string>> GetTherapist();

    }
}

