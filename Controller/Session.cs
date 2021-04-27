using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace familienfest.Controller
{
    public class Session : ViewModelBase
    {
        public static readonly Session Instance = new Session();
        //public NavigationManager MyNavigationManager { get; set; }

        Session()
        {
            UserName = "Anonym";
            UserLoggedIn = false;
        }

        public T GetUriParam<T>(string name)
        {
            var result = default(T);
            //MyNavigationManager.TryGetQueryString<T>(name, out result);
            return result;
        }
        public string UserName
        {
            get { return Get<string>(); }
            set { Set(value); }
            //get
            //{
            //    return GetUriParam<string>("name");
            //}
        }
        public string UserImage
        {
            get { return Get<string>(); }
            set { Set(value); }
        }
        public string UserEmail
        {
            get { return Get<string>(); }
            set { Set(value); }
        }
        public bool UserLoggedIn
        {
            get { return Get<bool>(); }
            set { Set(value); }
        }


        public void TryLogin()
        {
            TryLogin(GetUriParam<string>("email"));
        }
        public void TryLogin(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                if (email == "mail@danielgutmann.de")
                {
                    UserName = "Dany";
                    UserLoggedIn = true;
                }
            }
        }
        public string Uri
        {
            get
            {
                try
                {
                    return null; // MyNavigationManager.Uri.ToString();
                }
                catch (Exception)
                {
                    return "";
                }
            }
        }

    }
}
