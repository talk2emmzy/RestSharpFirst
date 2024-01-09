using System;
namespace RestSharpProject.Models.Users.Create
{
	public class UsersCreateResponse
	{
        public string name { get; set; }
        public string job { get; set; }
        public string id { get; set; }
        public DateTime createdAt { get; set; }
    }
}

