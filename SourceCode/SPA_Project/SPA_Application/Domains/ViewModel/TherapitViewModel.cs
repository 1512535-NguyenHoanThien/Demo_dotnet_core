using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SPA_Application.Common.EntityHelper;

namespace SPA_Application.Domains.ViewModel
{
    public class TherapitViewModel
    {
        public long Id { set; get; }

        public string FirstName { set; get; }
        public string LastName { set; get; }
        public Gender Gender { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string Phone { set; get; }
        public string IdentifyCard { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public UserRole Role { set; get; }
    }
}
