﻿using Newtonsoft.Json;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace Assignmnet.StepDefinationFile
{
    [Binding]
    public class UnSucessfullRegestrationSteps
    {
        RestClient client;
        RestRequest request;
        [Given(@"We use client and requests")]
        public void GivenWeUseClientAndRequests()
        {
            client = new RestClient("https://reqres.in/.");
            request = new RestRequest("/api/register", Method.POST);
        }
        
        [Given(@"Add Parameters")]
        public void GivenAddParameters()
        {
            request.AddParameter("email", "sydney@fife");
        }
        
        [When(@"Get the Responsed")]
        public void WhenGetTheResponsed()
        {
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            Console.WriteLine(content);
            Deser deserializedProduct = JsonConvert.DeserializeObject<Deser>(content);
            Console.WriteLine("id : {0}", deserializedProduct.id);
            Console.WriteLine("token : {0}", deserializedProduct.token);
           // Console.ReadLine();
        }
        
        [Then(@"Generate the tokens")]
        public void ThenGenerateTheTokens()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
