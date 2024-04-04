using WowAdmin.Persistence.Context;
using WowAdmin.Persistence.Helpers;

namespace WowAdmin.Persistence.Repositories
{
    public class CharacterRepository
    {
        private readonly AccountContext _accountContext;
        private readonly CharacterContext _characterContext;
        private readonly WorldContext _worldContext;

        private readonly Dictionary<int, string> raceToTaxiMask = new()
        {
            {1, "2 0 0 0 0 0 0 0 " },
            {2, "4194304 0 0 0 0 0 0 0 " },
            {3, "32 0 0 0 0 0 0 0 " },
            {4, "100663296 0 0 0 0 0 0 0 " },
            {5, "1024 0 0 0 0 0 0 0 " },
            {6, "2097152 0 0 0 0 0 0 0 " },
            {7, "32 0 0 0 0 0 0 0 " },
            {8, "4194304 0 0 0 0 0 0 0 " },
        };

        private readonly Dictionary<(int, int), string> raceClassToEquipmentMask = new()
        {
            { (1, 1), "0 0 0 0 0 0 38 0 0 0 0 0 39 0 40 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 25 0 2362 0 0 0 0 0 0 0 " },
            { (1, 2), "0 0 0 0 0 0 45 0 0 0 0 0 44 0 43 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 2361 0 0 0 0 0 0 0 0 0 " },
            { (1, 4), "0 0 0 0 0 0 49 0 0 0 0 0 48 0 47 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 2092 0 0 0 2947 0 0 0 0 0 " },
            { (1, 5), "0 0 0 0 0 0 53 0 6098 0 0 0 52 0 51 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 36 0 0 0 0 0 0 0 0 0 " },
            { (1, 8), "0 0 0 0 0 0 6096 0 56 0 0 0 1395 0 55 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 35 0 0 0 0 0 0 0 0 0 " },
            { (1, 9), "0 0 0 0 0 0 6097 0 57 0 0 0 1396 0 59 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 2092 0 0 0 0 0 0 0 0 0 " },
            { (2, 1), "0 0 0 0 0 0 0 0 6129 0 0 0 1396 0 59 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 2092 0 0 0 0 0 0 0 0 0 " },
            { (2, 3), "0 0 0 0 0 0 154 0 0 0 0 0 153 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 36 0 0 0 0 0 0 0 0 0 " },
            { (2, 4), "0 0 0 0 0 0 6125 0 0 0 0 0 139 0 140 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 12282 0 0 0 0 0 0 0 0 0 " },
            { (2, 7), "0 0 0 0 0 0 127 0 0 0 0 0 6126 0 6127 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 37 0 0 0 2504 0 0 0 2101 0 " },
            { (2, 9), "0 0 0 0 0 0 2105 0 0 0 0 0 120 0 121 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 2092 0 0 0 3111 0 0 0 0 0 " },
            { (3, 1), "0 0 0 0 0 0 38 0 0 0 0 0 39 0 40 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 12282 0 0 0 0 0 0 0 0 0 " },
            { (3, 2), "0 0 0 0 0 0 6117 0 0 0 0 0 6118 0 43 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 2361 0 0 0 0 0 0 0 0 0 " },
            { (3, 3), "0 0 0 0 0 0 148 0 0 0 0 0 147 0 129 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 37 0 0 0 2508 0 0 0 2102 0 " },
            { (3, 4), "0 0 0 0 0 0 49 0 0 0 0 0 48 0 47 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 2092 0 0 0 3111 0 0 0 0 0 " },
            { (3, 5), "0 0 0 0 0 0 53 0 6098 0 0 0 52 0 51 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 36 0 0 0 0 0 0 0 0 0 " },
            { (4, 1), "0 0 0 0 0 0 6120 0 0 0 0 0 6121 0 6122 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 25 0 2362 0 0 0 0 0 0 0 " },
            { (4, 3), "0 0 0 0 0 0 148 0 0 0 0 0 147 0 129 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 2092 0 0 0 2504 0 0 0 2101 0 " },
            { (4, 4), "0 0 0 0 0 0 49 0 0 0 0 0 48 0 47 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 2092 0 0 0 2947 0 0 0 0 0 " },
            { (4, 5), "0 0 0 0 0 0 53 0 6119 0 0 0 52 0 51 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 36 0 0 0 0 0 0 0 0 0 " },
            { (4, 11), "0 0 0 0 0 0 0 0 6123 0 0 0 6124 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 3661 0 0 0 0 0 0 0 0 0 " },
            { (5, 1), "0 0 0 0 0 0 6125 0 0 0 0 0 139 0 140 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 25 0 2362 0 0 0 0 0 0 0 " },
            { (5, 4), "0 0 0 0 0 0 2105 0 0 0 0 0 120 0 121 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 2092 0 0 0 2947 0 0 0 0 0 " },
            { (5, 5), "0 0 0 0 0 0 53 0 6144 0 0 0 52 0 51 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 36 0 0 0 0 0 0 0 0 0 " },
            { (5, 8), "0 0 0 0 0 0 6096 0 6140 0 0 0 1395 0 55 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 35 0 0 0 0 0 0 0 0 0 " },
            { (5, 9), "0 0 0 0 0 0 0 0 6129 0 0 0 1396 0 59 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 2092 0 0 0 0 0 0 0 0 0 " },
            { (6, 1), "0 0 0 0 0 0 6125 0 0 0 0 0 139 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 2361 0 0 0 0 0 0 0 0 0 " },
            { (6, 3), "0 0 0 0 0 0 127 0 0 0 0 0 6126 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 37 0 0 0 2508 0 0 0 2102 0 " },
            { (6, 7), "0 0 0 0 0 0 154 0 0 0 0 0 153 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 36 0 0 0 0 0 0 0 0 0 " },
            { (6, 11), "0 0 0 0 0 0 0 0 6139 0 0 0 6124 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 35 0 0 0 0 0 0 0 0 0 " },
            { (7, 1), "0 0 0 0 0 0 38 0 0 0 0 0 39 0 40 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 25 0 2362 0 0 0 0 0 0 0 " },
            { (7, 4), "0 0 0 0 0 0 49 0 0 0 0 0 48 0 47 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 2092 0 0 0 2947 0 0 0 0 0 " },
            { (7, 8), "0 0 0 0 0 0 6096 0 56 0 0 0 1395 0 55 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 35 0 0 0 0 0 0 0 0 0 " },
            { (7, 9), "0 0 0 0 0 0 6097 0 57 0 0 0 1396 0 59 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 2092 0 0 0 0 0 0 0 0 0 " },
            { (8, 1), "0 0 0 0 0 0 6125 0 0 0 0 0 139 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 37 0 2362 0 3111 0 0 0 0 0 " },
            { (8, 3), "0 0 0 0 0 0 127 0 0 0 0 0 6126 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 37 0 0 0 2504 0 0 0 2101 0 " },
            { (8, 4), "0 0 0 0 0 0 6136 0 0 0 0 0 6137 0 6138 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 2092 0 0 0 3111 0 0 0 0 0 " },
            { (8, 5), "0 0 0 0 0 0 53 0 6144 0 0 0 52 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 36 0 0 0 0 0 0 0 0 0 " },
            { (8, 7), "0 0 0 0 0 0 6134 0 0 0 0 0 6135 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 36 0 0 0 0 0 0 0 0 0 " },
            { (8, 8), "0 0 0 0 0 0 6096 0 6140 0 0 0 1395 0 55 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 35 0 0 0 0 0 0 0 0 0 " }
        };


        public CharacterRepository(AccountContext accountContext, CharacterContext characterContext, WorldContext worldContext)
        {
            _accountContext = accountContext;
            _characterContext = characterContext;
            _worldContext = worldContext;
        }

        public async Task<(bool, string)> AddCharacter(int accountId, int realmId, string name, int level, int race, int @class)
        {
            if (_worldContext.ReservedNames.Where(x => x.Name == name).Count() > 0)
            {
                return (false, "Name is reserved");
            }

            if (_characterContext.Characters.Where(x => x.Name == name).Count() > 0)
            {
                return (false, "Name is already in use");
            }

            if (_characterContext.Characters.Where(x => x.Account == accountId).Count() >= 10)
            {
                return (false, "Already 10 characters");
            }

            var playerCreateInfo = _worldContext.Playercreateinfos.FirstOrDefault(x => x.Race == race && x.Class == @class);
            if (playerCreateInfo == null)
            {
                return (false, "No player create info found for race/class combination");
            }

            var playerClassLevelStats = _worldContext.PlayerClasslevelstats.FirstOrDefault(x => x.Class == @class &&  x.Level == level);
            if (playerClassLevelStats == null)
            {
                return (false, "No player class stats found");
            }

            var playerLevelStats = _worldContext.PlayerLevelstats.FirstOrDefault(x => x.Race == race && x.Class == @class && x.Level == level);
            if (playerLevelStats == null)
            {
                return (false, "No player level stats found");
            }

            var playerCreateItems = _worldContext.PlayercreateinfoItems.Where(x => x.Race == race && x.Class == @class).ToList();
            if (playerCreateItems == null)
            {
                return (false, "No player items found");
            }

            var itemString = string.Empty;
            foreach ( var item in playerCreateItems )
            {

            }

            var character = new Character
            {
                Guid = _characterContext.Characters.Max(x => x.Guid) + 1,
                Account = (uint)accountId,
                Name = name,
                Race = (byte)race,
                Class = (byte)@class,
                Gender = 0,
                Skin = 0,
                Face = 0,
                HairStyle = 0,
                HairColor = 0,
                FacialHair = 0,
                Level = (byte)level,
                Map = playerCreateInfo.Map,
                PositionX = playerCreateInfo.PositionX,
                PositionY = playerCreateInfo.PositionY,
                PositionZ = playerCreateInfo.PositionZ,
                Orientation = playerCreateInfo.Orientation,
                KnownTaxiMask = raceToTaxiMask[race],
                CurrentTaxiPath = "",
                Online = 0,
                ExtraFlags = 4,
                AtLoginFlags = 32,
                Health = playerClassLevelStats.Basehp + GameStatsHelper.GetHealthBonusFromStamina(playerLevelStats.Sta),
                Power1 = @class != 1 && @class != 4 ? playerClassLevelStats.Basemana + GameStatsHelper.GetManaBonusFromIntellect(playerLevelStats.Inte) : 0,
                Power2 = 0,
                Power3 = 0,
                Power4 = @class == 4 ? 100u : 0,
                Power5 = 0,
                ExploredZones = string.Concat(Enumerable.Repeat("0 ", 64)),
                EquipmentCache = raceClassToEquipmentMask[(race,@class)],
                AmmoId = @class == 3 ? race == 3 ? 2516u : 2512u : 0,
                WorldPhaseMask = 1,
                CreateTime = 0,
                LogoutTime = 0,
            };

            _characterContext.Characters.Add(character);
            var realmCharacters = _accountContext.Realmcharacters.FirstOrDefault(x => x.Acctid == (ulong)accountId && x.Realmid == realmId);
            if (realmCharacters == null)
            {
                _accountContext.Realmcharacters.Add(new Realmcharacter { Acctid = (ulong)accountId, Realmid = (uint)realmId, Numchars = 1});
            }
            else
            {
                realmCharacters.Numchars += 1;
                _accountContext.Realmcharacters.Update(realmCharacters);
            }


            await _characterContext.SaveChangesAsync();
            await _accountContext.SaveChangesAsync();

            return (true, "");
        }
    }
}
