using System;

namespace ConsoleApplication.Models
{
    // keep the client information of Exact Online
    public class ClientInfo
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public Uri CallbackUrl { get; set; }
    }

}
