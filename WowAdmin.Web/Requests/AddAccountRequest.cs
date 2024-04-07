using Microsoft.AspNetCore.Mvc;

namespace WowAdmin.Web.Requests 
{
    public class AddAccountRequest
    {
        [FromQuery]
        public required string AccountName { get; set; }

        [FromQuery]
        public required string Password { get; set; }

        [FromQuery]
        public string? Email { get; set; }

    }
}