using System;
namespace RestSharpProject.Models.Users.Create
{
	public class UsersCreateRequest
    {
        public string name { get; set; }
        public string job { get; set; }
        public string id { get; set; }
        public string createdAt { get; set; }
    }
}

