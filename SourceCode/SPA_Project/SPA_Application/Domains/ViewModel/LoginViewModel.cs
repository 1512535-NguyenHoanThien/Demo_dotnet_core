using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Domains.ViewModel
{
    public class LoginViewModel
    {
        public string PhoneNumber { set; get; }
        public string Password { set; get; }
        public bool RememberMe { set; get; }
    }
}
