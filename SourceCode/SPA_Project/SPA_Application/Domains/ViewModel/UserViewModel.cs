using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SPA_Application.Common;
using static SPA_Application.Common.EntityHelper;

namespace SPA_Application.Domains.ViewModel
{
    public class UserViewModel
    {


        public UserViewModel() { }

        public UserViewModel(string id, string phoneNumber, string email, string password, string fullName, Gender gender, DateTime dateOfBirth, string profession, string identifyCard, string role, string address)
        {
            Id = id;
            PhoneNumber = phoneNumber;
            Email = email;
            Password = password;
            FullName = fullName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Profession = profession;
            IdentifyCard = identifyCard;
            Role = role;
            Address = address;
        }
        public string Id { set; get; }
        public string PhoneNumber { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public string FullName { set; get; }
        public Gender Gender { set; get; }
        public DateTime DateOfBirth { set; get; }
        //public int Age { set; get; }
        //public string Profession { set; get; }
        //public string IdentifyCard { set; get; }
        public string Profession { set; get; }
        public string IdentifyCard { set; get; }
        public string Role { set; get; }
        public string Address { set; get; }
    }
}
