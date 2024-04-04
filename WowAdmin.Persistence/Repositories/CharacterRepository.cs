using WowAdmin.Persistence.Context;

namespace WowAdmin.Persistence.Repositories
{
    public class CharacterRepository
    {
        private readonly CharacterContext _characterContext;
        private readonly WorldContext _worldContext;

        public CharacterRepository(CharacterContext characterContext, WorldContext worldContext)
        {
            _characterContext = characterContext;
            _worldContext = worldContext;
        }

        public Task<(bool, string)> AddCharacter(int accountId, int realmdId, string name, int level, int race, int @class)
        {
            return Task.FromResult((false, "Db connection not implemented, character NOT created"));
        }
    }
}
