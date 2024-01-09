
using System;
using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using RestSharpProject.Models.Users;
using RestSharpProject.Models.Users.Create;

namespace RestSharpProject.Testfile
{
	public class Testcase
	{
		[Test]
		public void GetUsers()
		{
			var endpoint = "https://reqres.in/api/users";

			var client = new RestClient(endpoint);
			var request = new RestRequest();
			request.Method = Method.Get;

			var response = client.Execute(request);
			var responseBody =
				JsonConvert.DeserializeObject<UsersResponse>(response.Content);

			//Fluent Assertion to verify response
			response.StatusCode
				.Should().Be(System.Net.HttpStatusCode.OK);

			responseBody.page.Should().Be(1);

			responseBody.data.Should().NotBeNullOrEmpty();
		}


		[Test]
		public void CreatUser()
		{
            var endpoint = "https://reqres.in/api/users";

            var client = new RestClient(endpoint);
            var request = new RestRequest();
            request.Method = Method.Post;

			var payload = new UsersCreateRequest
			{
				name = "Emmanuel",
				job = "QA",
                id = "42",
				createdAt =  "2024-01-09T00:25:30.787Z"

            };

			request.AddJsonBody(payload);

            var response = client.Execute(request);
            var responseBody =
                JsonConvert.DeserializeObject<UsersCreateResponse>(response.Content);

            //Fluent Assertion to verify response
            response.StatusCode.Should().Be(System.Net.HttpStatusCode.Created);

			responseBody.Should().NotBeNull();

			//
        }
	}
}

