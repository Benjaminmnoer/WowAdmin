namespace WowAdmin.Web.Responses
{
    public class AddAccountResponse
    {
        public required int AccountId { get; set; }

        public required string AccountName { get; set; }

        public required bool Success { get; set; }

        public string? Error { get; set; }
    }
}