using System;
namespace RestSharpProject.Models.Users
{

        public class UsersResponse
        {
            public int page { get; set; }
            public int per_page { get; set; }
            public int total { get; set; }
            public int total_pages { get; set; }
            public required List<Datum> data { get; set; }
            public required Support support { get; set; }
        }


        public class Datum
        {
            public int id { get; set; }
            public required string email { get; set; }
            public required string first_name { get; set; }
            public required string last_name { get; set; }
            public required string avatar { get; set; }
        }

        public class Support
        {
            public required string url { get; set; }
            public required string text { get; set; }
        }
    
}

