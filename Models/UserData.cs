using familienfest.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace familienfest.Models
{
    public class UserData : ViewModelBase
    {
        public UserData()
        {
            Type = UserTypes.Guest;
        }
        [Required]
        public string Vorname
        {
            get { return Get<string>(); }
            set { Set(value); }
        }
        [Required]
        public string Nachname
        {
            get { return Get<string>(); }
            set { Set(value); }
        }
        public string FullName
        {
            get { return $"{Vorname} {Nachname}"; }
        }
        [Required]
        public string Email
        {
            get { return Get<string>(); }
            set { Set(value); }
        }
        [Required]
        public string Password
        {
            get { return Get<string>(); }
            set { Set(value); }
        }
        public UserTypes Type
        {
            get { return Get<UserTypes>(); }
            set { Set(value); }
        }
        public string TypeInfo
        {
            get { return Type.ToString(); }
            set { }
        }
        public void Update()
        {
        }
    }
    public enum UserTypes
    {
        Guest,
        User,
        Admin
    }
}
