using Covid19ApiTesting.Configuration;
using Covid19ApiTesting.Context;
using FluentAssertions;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19ApiTesting.Utilities
{
    public class AuthUtil
    {
        public static string GetToken()
        {
            Settings _settings = new Settings();
            string url = ConfigurationManager.AppSettings.Get("URL");
            string endpoint = url + ConfigUtil.GetConfigValue("EndPoints", "GenerateToken").As<Endpoint>().URL;
            string Authendpoint = url + "auth/gentoken";
            // _settings.RestClient.BaseUrl = new Uri(endpoint);                        
             _settings.RestClient.BaseUrl = new Uri(Authendpoint);                    
            _settings.Request = new RestRequest(Method.POST);
            _settings.Request.AddHeader("Content-Type", "application/json");
            StreamReader r = new StreamReader(FileUtil.GetFilePath(@"Data\Application\AuthData.json"));
            _settings.Request.AddJsonBody(r.ReadToEnd());
            _settings.Response = _settings.RestClient.Execute(_settings.Request);
            string Token = _settings.Response.Content;
            return Token;


        }
    }
}
