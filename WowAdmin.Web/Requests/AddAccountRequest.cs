namespace WowAdmin.Web.Requests 
{
    public class AddAccountRequest
    {
        public required string AccountName { get; set; }

        public required string Password { get; set; }

        public string? Email { get; set; }

    }
}