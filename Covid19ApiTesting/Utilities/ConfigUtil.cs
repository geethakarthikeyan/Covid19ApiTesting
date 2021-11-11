using Covid19ApiTesting.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19ApiTesting.Utilities
{
    public class ConfigUtil
    {
        public static IConfig GetConfigValue(string section,string key = "")
        {
            StreamReader r = new StreamReader(FileUtil.GetFilePath(@"Configuration\config.json"));
            Root configRoot = JsonConvert.DeserializeObject<Root>(r.ReadToEnd());
            switch(section)
            {
                case "EndPoints":
                    return configRoot.Endpoints.SingleOrDefault(endPoint => endPoint.EndPoint.Equals(key));
                case "Authentication":
                        return configRoot.Authentication;
                default:
                    throw new ArgumentException($"InvalidSection{section}");

            }
        }
    }
}
