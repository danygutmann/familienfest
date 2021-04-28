using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;


namespace familienfest.Controller
{
    public class Data
    {
        public static readonly Data _instance = new Data();

        Data()
        {
        }

        public object HttpClinet { get; private set; }

        public void GetData()
        {
            using (System.Net.Http.HttpClient client = new HttpClient())
            {

            }

        }
    }
}
