using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Domains.ViewModel
{
    public class UserFullViewModel
    {
        public string Id { set; get; }
        public string FullName { set; get; }
        public string Gender { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string Address { set; get; }
        public bool Status { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }

    }
}
