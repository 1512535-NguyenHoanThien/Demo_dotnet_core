using Microsoft.AspNetCore.Identity;
using SPA_Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SPA_Application.Common.EntityHelper;


namespace SPA_Application.Domains.Entity
{
    public class User : IdentityUser
    {
        public string FullName { set; get; }
        public Gender Gender { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string Profession { set; get; }
        public string IdentifyCard { set; get; }
        public string Address { set; get; }
        //public bool EntityStatus { set; get; }

        // public TargetType TargetType { set; get; }

        public ICollection<TherapistAbility> TherapistAbilities { set; get; }
        public ICollection<Appointment> Appointments { set; get; }
        public ICollection<BufferTime> BufferTimes { set; get; }
    }
}
