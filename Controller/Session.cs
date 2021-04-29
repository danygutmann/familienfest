using familienfest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace familienfest.Controller
{
    public class Session : ViewModelBase
    {
        public static readonly Session Instance = new Session();
        Session()
        {
            CurrentUser = new UserData();
            UserLoggedIn = false;
        }

        public UserData CurrentUser
        {
            get { return Get<UserData>(); }
            set { Set(value); }
        }

        public bool UserLoggedIn
        {
            get { return Get<bool>(); }
            internal set { Set(value); }
        }

        public void TryLogin(Models.Login login)
        {
            int zz = login.Pass.Length;
            UserLoggedIn = true;

            CurrentUser.Vorname = "Daniel";
            CurrentUser.Nachname = "Gutmann";
            CurrentUser.Email = "mail@danielgutmann.de";
            CurrentUser.Type = UserTypes.Admin;

        }

        public void TryLogout()
        {
            UserLoggedIn = false;
            CurrentUser = new UserData();
        }
    }
}
