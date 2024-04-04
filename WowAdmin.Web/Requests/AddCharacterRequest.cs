namespace WowAdmin.Web.Requests
{
    public class AddCharacterRequest
    {
        public required int AccountId { get; set; }

        public required int RealmId { get; set; }

        public required string Name { get; set; }

        public required int Level { get; set; }

        public required int Race { get; set; }

        public required int Class { get; set; }
    }
}
