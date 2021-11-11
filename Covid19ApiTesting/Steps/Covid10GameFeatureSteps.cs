using Covid19ApiTesting.Configuration;
using Covid19ApiTesting.Context;
using Covid19ApiTesting.Utilities;
using FluentAssertions;
using RestSharp;
using System;
using System.Configuration;
using System.Linq;
using TechTalk.SpecFlow;

namespace Covid19ApiTesting.Steps
{
    [Binding]
    public class Covid10GameFeatureSteps
    {
        Settings _context;
        string Token;
        public Covid10GameFeatureSteps(Settings settings)
        {
            _context = settings;
        }
        [Given(@"Get Token for Covid Game")]
        public void GivenGetTokenForCovidGame()
        {
           Token = AuthUtil.GetToken();
           
        }
        
        [When(@"Verify The Token")]
        public void WhenVerifyTheToken()
        {
            string url = ConfigurationManager.AppSettings.Get("CovidGameURL");
            var endpoint = (url+ ConfigUtil.GetConfigValue("EndPoints","VerifyToken").As<Endpoint>().URL);
            _context.RestClient.BaseUrl = new Uri(endpoint);
            _context.Request = new RestRequest(Method.GET);
            _context.Request.AddHeader("Token", Token.ToString());
            _context.Response = _context.RestClient.Execute(_context.Request);
        }
        
        [Then(@"Get The list of users for the game")]
        public void ThenGetTheListOfUsersForTheGame(Table table)
        {
            var status = table.Rows.First(row => row["attribute"] == "Status")["Value"];
            _context.Response.StatusCode.ToString().Should().Be(status);
        }
    }
}
