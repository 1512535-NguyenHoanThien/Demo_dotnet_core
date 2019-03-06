using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SPA_Application.Domains.Service.IService;
using SPA_Application.Domains.ViewModel;
using Microsoft.AspNetCore.Identity;
using SPA_Application.Domains.Entity;
using SPA_Application.Infrastructure.Repository.IRepository;

namespace SPA_Application.Controllers.AuthenticateControllers
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private IAccountService _authenticateService;

        public AccountController(IAccountService authenticateService)
        {
            _authenticateService = authenticateService;
        }

        [Route("update")]
        [HttpPut]
        public async Task<IActionResult> UpdateUserAsync([FromBody] UserViewModel userViewModel)
        {
            if (userViewModel == null)
            {
                throw new ArgumentNullException(nameof(userViewModel));
            }

            if (ModelState.IsValid)
            {
                if(await _authenticateService.UpdateUser(userViewModel))
                {
                    return Ok("Successfull");
                }
            }
            return BadRequest("Unknow error.");
        }

        [Route("changepass")]
        [HttpPost]
        public async Task<IActionResult> ChangePassword(String phoneNumber,[FromBody] ChangePasswordViewModel changePasswordViewModel)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException("User không tồn tại.");
            }

            if (ModelState.IsValid)
            {
                if (await _authenticateService.ChangePassword(phoneNumber, changePasswordViewModel.curPass, changePasswordViewModel.newPass))
                {
                    return Ok("Successfull");
                }
            }
            return BadRequest("Unknow error.");
        }

        [Route("register")]
        [HttpPost]
        public IActionResult Register([FromBody] RegisterViewModel registerViewModel)
        {
            _authenticateService.Register(registerViewModel);
            return Ok();
        }
        [Route("login")]
        [HttpPost]
        public IActionResult Login([FromBody]LoginViewModel loginViewModel)
        {
            string token = _authenticateService.Login(loginViewModel);
            if (token != "Login Failed")
                return Json(token);
            return BadRequest(token.ToString());
        }

        [Route("picked")]
        [HttpGet]
        public IActionResult GetUserByPhoneNumber(String phoneNumber)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException("Phone number is null.");
            }
            UserViewModel user = _authenticateService.GetUserByPhoneNumber(phoneNumber);
            if (user != null)
            {
                return Json(user);
            }
            return BadRequest("User is not exist.");

        }

        [Route("all")]
        [HttpGet]
        public IActionResult GetAllUser()
        {
            IEnumerable<UserViewModel> userViewModels = _authenticateService.GetAllUser(); ;
            if (userViewModels == null)
            {
                return NotFound();
            }
            else return Ok(userViewModels);
        }
        [Route("createUser")]
        [HttpPost]
        public IActionResult CreateUser([FromBody] RegisterViewModel registerViewModel)
        {
            registerViewModel.Password = "123456@Ab";
            _authenticateService.Register(registerViewModel);
            return Ok();
        }
        [Route("")]
        [HttpGet]
        public IActionResult GetUserFullView(string id)
        {
            UserFullViewModel userFullViewModel = _authenticateService.GetUserFullViewById(id); ;
            if (userFullViewModel == null)
            {
                return NotFound();
            }
            else return Ok(userFullViewModel);
        }
        [Route("therapit")]
        [HttpGet]
        public IActionResult GetTherapit()
        {
            IEnumerable<ItemSelectViewModel<string>> item = _authenticateService.GetTherapist(); ;
            if (item == null)
            {
                return NotFound();
            }
            else return Ok(item);
        }

    }
}