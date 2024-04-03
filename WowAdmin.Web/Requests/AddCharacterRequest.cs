namespace WowAdmin.Web.Requests
{
    public class AddCharacterRequest
    {
        public required string Name { get; set; }

        public required int Level { get; set; }

        public required int Race { get; set; }

        public required int Class { get; set; }
    }
}
