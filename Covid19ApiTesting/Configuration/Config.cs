using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19ApiTesting.Configuration
{
   public class Endpoint : IConfig
    {
        public string EndPoint { get; set; }
        public string URL { get; set; }

    }
    public class Authentication : IConfig
    {
        public string User { get; set; }
    }
    public class Root
    {
        public List<Endpoint> Endpoints { get; set; }
        public Authentication Authentication { get; set; }
    }
}
