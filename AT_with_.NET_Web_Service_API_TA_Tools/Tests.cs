using NUnit.Framework;
using RestSharp;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using Core;
using System.Net;


namespace TestLayer
{
    public class Tests
    {
        private ApiClient _apiClient;

        [SetUp]
        public void Setup()
        {
            ConfigurationManager _configManager = new ConfigurationManager();

            _apiClient = new ApiClient();
        }

        [Test]
        [Category("API")]
        public void Test_ListOfUsersCanBeReceivedSuccessfully()
        {
            RestResponse response = _apiClient.Get();

            Assert.That(response, Is.Not.Null, "Response is null");
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK), "Unexpected status code");
        }

    }
}