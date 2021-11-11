using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19ApiTesting.Context
{
    public class Settings
    {
        public Uri BaseUrl { get; set; }
        public IRestResponse Response { get; set; }
        public IRestRequest Request { get; set; }
        public IRestClient RestClient { get; set; }

    }
}
