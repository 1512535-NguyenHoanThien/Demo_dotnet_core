using SPA_Application.Domains.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Domains.Service.IService
{
    public interface IAccountService
    {
        List<string> Register(RegisterViewModel userRegister);
        string Login(LoginViewModel loginViewModel);
        Task<bool> UpdateUser(UserViewModel userViewModel);
        UserViewModel GetUserByPhoneNumber(String phoneNumber);
        Task<bool> ChangePassword(String phoneNumber, String curPass, String newPass);
        IEnumerable<UserViewModel> GetAllUser();
        UserFullViewModel GetUserFullViewById(string id);
        IEnumerable<ItemSelectViewModel<string>> GetTherapist();

    }
}
