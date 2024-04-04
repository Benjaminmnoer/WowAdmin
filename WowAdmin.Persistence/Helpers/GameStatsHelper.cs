namespace WowAdmin.Persistence.Helpers
{
    public static class GameStatsHelper
    {
        public static uint GetHealthBonusFromStamina(uint stamina)
        {
            uint baseStam = stamina < 20 ? stamina : 20;
            uint moreStam = stamina - baseStam;

            return baseStam + (moreStam * 10);
        }

        public static uint GetManaBonusFromIntellect(uint intellect)
        {
            uint baseInt = intellect < 20 ? intellect : 20;
            uint moreInt = intellect - baseInt;

            return baseInt + (moreInt * 15);
        }
    }
}
