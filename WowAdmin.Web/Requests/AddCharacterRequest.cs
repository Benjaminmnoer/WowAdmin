using Microsoft.AspNetCore.Mvc;

namespace WowAdmin.Web.Requests
{
    public class AddCharacterRequest
    {
        [FromQuery]
        public required int AccountId { get; set; }

        [FromQuery]
        public required int RealmId { get; set; }

        [FromQuery]
        public required string Name { get; set; }

        [FromQuery]
        public required int Level { get; set; }

        [FromQuery]
        public required int Race { get; set; }

        [FromQuery]
        public required int Class { get; set; }

        [FromQuery]
        public required bool AutoEquip { get; set; }
    }
}
