using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WowAdmin.Persistence.Context;

public partial class WorldContext : DbContext
{
    public WorldContext()
    {
    }

    public WorldContext(DbContextOptions<WorldContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AreaTemplate> AreaTemplates { get; set; }

    public virtual DbSet<AreatriggerBgEntrance> AreatriggerBgEntrances { get; set; }

    public virtual DbSet<AreatriggerInvolvedrelation> AreatriggerInvolvedrelations { get; set; }

    public virtual DbSet<AreatriggerTavern> AreatriggerTaverns { get; set; }

    public virtual DbSet<AreatriggerTeleport> AreatriggerTeleports { get; set; }

    public virtual DbSet<AreatriggerTemplate> AreatriggerTemplates { get; set; }

    public virtual DbSet<Auctionhousebot> Auctionhousebots { get; set; }

    public virtual DbSet<Autobroadcast> Autobroadcasts { get; set; }

    public virtual DbSet<BattlegroundEvent> BattlegroundEvents { get; set; }

    public virtual DbSet<BattlegroundTemplate> BattlegroundTemplates { get; set; }

    public virtual DbSet<BattlemasterEntry> BattlemasterEntries { get; set; }

    public virtual DbSet<BroadcastText> BroadcastTexts { get; set; }

    public virtual DbSet<CinematicWaypoint> CinematicWaypoints { get; set; }

    public virtual DbSet<Command> Commands { get; set; }

    public virtual DbSet<Condition> Conditions { get; set; }

    public virtual DbSet<Creature> Creatures { get; set; }

    public virtual DbSet<CreatureAddon> CreatureAddons { get; set; }

    public virtual DbSet<CreatureAiEvent> CreatureAiEvents { get; set; }

    public virtual DbSet<CreatureAiScript> CreatureAiScripts { get; set; }

    public virtual DbSet<CreatureBattleground> CreatureBattlegrounds { get; set; }

    public virtual DbSet<CreatureClasslevelstat> CreatureClasslevelstats { get; set; }

    public virtual DbSet<CreatureDisplayInfoAddon> CreatureDisplayInfoAddons { get; set; }

    public virtual DbSet<CreatureEquipTemplate> CreatureEquipTemplates { get; set; }

    public virtual DbSet<CreatureGroup> CreatureGroups { get; set; }

    public virtual DbSet<CreatureGroupsEntryLimit> CreatureGroupsEntryLimits { get; set; }

    public virtual DbSet<CreatureInvolvedrelation> CreatureInvolvedrelations { get; set; }

    public virtual DbSet<CreatureLinking> CreatureLinkings { get; set; }

    public virtual DbSet<CreatureLinkingTemplate> CreatureLinkingTemplates { get; set; }

    public virtual DbSet<CreatureLootTemplate> CreatureLootTemplates { get; set; }

    public virtual DbSet<CreatureMovement> CreatureMovements { get; set; }

    public virtual DbSet<CreatureMovementScript> CreatureMovementScripts { get; set; }

    public virtual DbSet<CreatureMovementSpecial> CreatureMovementSpecials { get; set; }

    public virtual DbSet<CreatureMovementTemplate> CreatureMovementTemplates { get; set; }

    public virtual DbSet<CreatureOnkillReputation> CreatureOnkillReputations { get; set; }

    public virtual DbSet<CreatureQuestrelation> CreatureQuestrelations { get; set; }

    public virtual DbSet<CreatureSpell> CreatureSpells { get; set; }

    public virtual DbSet<CreatureSpellsScript> CreatureSpellsScripts { get; set; }

    public virtual DbSet<CreatureTemplate> CreatureTemplates { get; set; }

    public virtual DbSet<CustomText> CustomTexts { get; set; }

    public virtual DbSet<DisenchantLootTemplate> DisenchantLootTemplates { get; set; }

    public virtual DbSet<EventScript> EventScripts { get; set; }

    public virtual DbSet<ExplorationBasexp> ExplorationBasexps { get; set; }

    public virtual DbSet<Faction> Factions { get; set; }

    public virtual DbSet<FactionTemplate> FactionTemplates { get; set; }

    public virtual DbSet<FishingLootTemplate> FishingLootTemplates { get; set; }

    public virtual DbSet<ForbiddenItem> ForbiddenItems { get; set; }

    public virtual DbSet<GameEvent> GameEvents { get; set; }

    public virtual DbSet<GameEventCreature> GameEventCreatures { get; set; }

    public virtual DbSet<GameEventCreatureDatum> GameEventCreatureData { get; set; }

    public virtual DbSet<GameEventGameobject> GameEventGameobjects { get; set; }

    public virtual DbSet<GameEventMail> GameEventMails { get; set; }

    public virtual DbSet<GameEventQuest> GameEventQuests { get; set; }

    public virtual DbSet<GameGraveyardZone> GameGraveyardZones { get; set; }

    public virtual DbSet<GameTele> GameTeles { get; set; }

    public virtual DbSet<GameWeather> GameWeathers { get; set; }

    public virtual DbSet<Gameobject> Gameobjects { get; set; }

    public virtual DbSet<GameobjectBattleground> GameobjectBattlegrounds { get; set; }

    public virtual DbSet<GameobjectDisplayInfoAddon> GameobjectDisplayInfoAddons { get; set; }

    public virtual DbSet<GameobjectInvolvedrelation> GameobjectInvolvedrelations { get; set; }

    public virtual DbSet<GameobjectLootTemplate> GameobjectLootTemplates { get; set; }

    public virtual DbSet<GameobjectQuestrelation> GameobjectQuestrelations { get; set; }

    public virtual DbSet<GameobjectRequirement> GameobjectRequirements { get; set; }

    public virtual DbSet<GameobjectScript> GameobjectScripts { get; set; }

    public virtual DbSet<GameobjectTemplate> GameobjectTemplates { get; set; }

    public virtual DbSet<GenericScript> GenericScripts { get; set; }

    public virtual DbSet<GossipMenu> GossipMenus { get; set; }

    public virtual DbSet<GossipMenuOption> GossipMenuOptions { get; set; }

    public virtual DbSet<GossipScript> GossipScripts { get; set; }

    public virtual DbSet<InstanceBuffRemoval> InstanceBuffRemovals { get; set; }

    public virtual DbSet<ItemDisplayInfo> ItemDisplayInfos { get; set; }

    public virtual DbSet<ItemEnchantmentTemplate> ItemEnchantmentTemplates { get; set; }

    public virtual DbSet<ItemLootTemplate> ItemLootTemplates { get; set; }

    public virtual DbSet<ItemRequiredTarget> ItemRequiredTargets { get; set; }

    public virtual DbSet<ItemTemplate> ItemTemplates { get; set; }

    public virtual DbSet<LocalesArea> LocalesAreas { get; set; }

    public virtual DbSet<LocalesAreatrigger> LocalesAreatriggers { get; set; }

    public virtual DbSet<LocalesBroadcastText> LocalesBroadcastTexts { get; set; }

    public virtual DbSet<LocalesCreature> LocalesCreatures { get; set; }

    public virtual DbSet<LocalesFaction> LocalesFactions { get; set; }

    public virtual DbSet<LocalesGameobject> LocalesGameobjects { get; set; }

    public virtual DbSet<LocalesGossipMenuOption> LocalesGossipMenuOptions { get; set; }

    public virtual DbSet<LocalesItem> LocalesItems { get; set; }

    public virtual DbSet<LocalesPageText> LocalesPageTexts { get; set; }

    public virtual DbSet<LocalesPointsOfInterest> LocalesPointsOfInterests { get; set; }

    public virtual DbSet<LocalesQuest> LocalesQuests { get; set; }

    public virtual DbSet<LocalesSpell> LocalesSpells { get; set; }

    public virtual DbSet<LocalesTaxiNode> LocalesTaxiNodes { get; set; }

    public virtual DbSet<MailLootTemplate> MailLootTemplates { get; set; }

    public virtual DbSet<MailTextTemplate> MailTextTemplates { get; set; }

    public virtual DbSet<MangosString> MangosStrings { get; set; }

    public virtual DbSet<MapLootDisabled> MapLootDisableds { get; set; }

    public virtual DbSet<MapTemplate> MapTemplates { get; set; }

    public virtual DbSet<Migration> Migrations { get; set; }

    public virtual DbSet<NpcGossip> NpcGossips { get; set; }

    public virtual DbSet<NpcText> NpcTexts { get; set; }

    public virtual DbSet<NpcTrainer> NpcTrainers { get; set; }

    public virtual DbSet<NpcTrainerGreeting> NpcTrainerGreetings { get; set; }

    public virtual DbSet<NpcTrainerTemplate> NpcTrainerTemplates { get; set; }

    public virtual DbSet<NpcVendor> NpcVendors { get; set; }

    public virtual DbSet<NpcVendorTemplate> NpcVendorTemplates { get; set; }

    public virtual DbSet<PageText> PageTexts { get; set; }

    public virtual DbSet<PetLevelstat> PetLevelstats { get; set; }

    public virtual DbSet<PetNameGeneration> PetNameGenerations { get; set; }

    public virtual DbSet<PetSpellDatum> PetSpellData { get; set; }

    public virtual DbSet<PetcreateinfoSpell> PetcreateinfoSpells { get; set; }

    public virtual DbSet<PickpocketingLootTemplate> PickpocketingLootTemplates { get; set; }

    public virtual DbSet<PlayerClasslevelstat> PlayerClasslevelstats { get; set; }

    public virtual DbSet<PlayerFactionchangeItem> PlayerFactionchangeItems { get; set; }

    public virtual DbSet<PlayerFactionchangeMount> PlayerFactionchangeMounts { get; set; }

    public virtual DbSet<PlayerFactionchangeQuest> PlayerFactionchangeQuests { get; set; }

    public virtual DbSet<PlayerFactionchangeReputation> PlayerFactionchangeReputations { get; set; }

    public virtual DbSet<PlayerFactionchangeSpell> PlayerFactionchangeSpells { get; set; }

    public virtual DbSet<PlayerLevelstat> PlayerLevelstats { get; set; }

    public virtual DbSet<PlayerPremadeItem> PlayerPremadeItems { get; set; }

    public virtual DbSet<PlayerPremadeItemTemplate> PlayerPremadeItemTemplates { get; set; }

    public virtual DbSet<PlayerPremadeSpell> PlayerPremadeSpells { get; set; }

    public virtual DbSet<PlayerPremadeSpellTemplate> PlayerPremadeSpellTemplates { get; set; }

    public virtual DbSet<PlayerXpForLevel> PlayerXpForLevels { get; set; }

    public virtual DbSet<Playercreateinfo> Playercreateinfos { get; set; }

    public virtual DbSet<PlayercreateinfoAction> PlayercreateinfoActions { get; set; }

    public virtual DbSet<PlayercreateinfoItem> PlayercreateinfoItems { get; set; }

    public virtual DbSet<PlayercreateinfoSpell> PlayercreateinfoSpells { get; set; }

    public virtual DbSet<PointsOfInterest> PointsOfInterests { get; set; }

    public virtual DbSet<PoolCreature> PoolCreatures { get; set; }

    public virtual DbSet<PoolCreatureTemplate> PoolCreatureTemplates { get; set; }

    public virtual DbSet<PoolGameobject> PoolGameobjects { get; set; }

    public virtual DbSet<PoolGameobjectTemplate> PoolGameobjectTemplates { get; set; }

    public virtual DbSet<PoolPool> PoolPools { get; set; }

    public virtual DbSet<PoolTemplate> PoolTemplates { get; set; }

    public virtual DbSet<QuestEndScript> QuestEndScripts { get; set; }

    public virtual DbSet<QuestGreeting> QuestGreetings { get; set; }

    public virtual DbSet<QuestStartScript> QuestStartScripts { get; set; }

    public virtual DbSet<QuestTemplate> QuestTemplates { get; set; }

    public virtual DbSet<ReferenceLootTemplate> ReferenceLootTemplates { get; set; }

    public virtual DbSet<ReputationRewardRate> ReputationRewardRates { get; set; }

    public virtual DbSet<ReputationSpilloverTemplate> ReputationSpilloverTemplates { get; set; }

    public virtual DbSet<ReservedName> ReservedNames { get; set; }

    public virtual DbSet<ScriptEscortDatum> ScriptEscortData { get; set; }

    public virtual DbSet<ScriptText> ScriptTexts { get; set; }

    public virtual DbSet<ScriptWaypoint> ScriptWaypoints { get; set; }

    public virtual DbSet<ScriptedAreatrigger> ScriptedAreatriggers { get; set; }

    public virtual DbSet<ScriptedEventId> ScriptedEventIds { get; set; }

    public virtual DbSet<SkillFishingBaseLevel> SkillFishingBaseLevels { get; set; }

    public virtual DbSet<SkillLineAbility> SkillLineAbilities { get; set; }

    public virtual DbSet<SkinningLootTemplate> SkinningLootTemplates { get; set; }

    public virtual DbSet<SoundEntry> SoundEntries { get; set; }

    public virtual DbSet<SpellAffect> SpellAffects { get; set; }

    public virtual DbSet<SpellArea> SpellAreas { get; set; }

    public virtual DbSet<SpellChain> SpellChains { get; set; }

    public virtual DbSet<SpellCheck> SpellChecks { get; set; }

    public virtual DbSet<SpellDisabled> SpellDisableds { get; set; }

    public virtual DbSet<SpellEffectMod> SpellEffectMods { get; set; }

    public virtual DbSet<SpellElixir> SpellElixirs { get; set; }

    public virtual DbSet<SpellEnchantCharge> SpellEnchantCharges { get; set; }

    public virtual DbSet<SpellGroup> SpellGroups { get; set; }

    public virtual DbSet<SpellGroupStackRule> SpellGroupStackRules { get; set; }

    public virtual DbSet<SpellLearnSpell> SpellLearnSpells { get; set; }

    public virtual DbSet<SpellMod> SpellMods { get; set; }

    public virtual DbSet<SpellPetAura> SpellPetAuras { get; set; }

    public virtual DbSet<SpellProcEvent> SpellProcEvents { get; set; }

    public virtual DbSet<SpellProcItemEnchant> SpellProcItemEnchants { get; set; }

    public virtual DbSet<SpellScript> SpellScripts { get; set; }

    public virtual DbSet<SpellScriptTarget> SpellScriptTargets { get; set; }

    public virtual DbSet<SpellTargetPosition> SpellTargetPositions { get; set; }

    public virtual DbSet<SpellTemplate> SpellTemplates { get; set; }

    public virtual DbSet<SpellThreat> SpellThreats { get; set; }

    public virtual DbSet<TaxiNode> TaxiNodes { get; set; }

    public virtual DbSet<TaxiPathTransition> TaxiPathTransitions { get; set; }

    public virtual DbSet<Transport> Transports { get; set; }

    public virtual DbSet<Variable> Variables { get; set; }

    public virtual DbSet<WardenScan> WardenScans { get; set; }

    public virtual DbSet<WorldSafeLocsFacing> WorldSafeLocsFacings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AreaTemplate>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("area_template");

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.AreaLevel)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("area_level");
            entity.Property(e => e.ExploreFlag)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("explore_flag");
            entity.Property(e => e.Flags)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("flags");
            entity.Property(e => e.LiquidType).HasColumnName("liquid_type");
            entity.Property(e => e.MapId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("map_id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Team).HasColumnName("team");
            entity.Property(e => e.ZoneId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("zone_id");
        });

        modelBuilder.Entity<AreatriggerBgEntrance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("areatrigger_bg_entrance");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("'0'")
                .HasComment("Identifier")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("id");
            entity.Property(e => e.BgTemplate)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("bg_template");
            entity.Property(e => e.ExitMap).HasColumnName("exit_map");
            entity.Property(e => e.ExitOrientation).HasColumnName("exit_orientation");
            entity.Property(e => e.ExitPositionX).HasColumnName("exit_position_x");
            entity.Property(e => e.ExitPositionY).HasColumnName("exit_position_y");
            entity.Property(e => e.ExitPositionZ).HasColumnName("exit_position_z");
            entity.Property(e => e.Name)
                .HasColumnType("text")
                .HasColumnName("name");
            entity.Property(e => e.Team)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("team");
        });

        modelBuilder.Entity<AreatriggerInvolvedrelation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("areatrigger_involvedrelation", tb => tb.HasComment("Trigger System"));

            entity.Property(e => e.Id)
                .HasDefaultValueSql("'0'")
                .HasComment("Identifier")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Quest)
                .HasDefaultValueSql("'0'")
                .HasComment("Quest Identifier")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("quest");
        });

        modelBuilder.Entity<AreatriggerTavern>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("areatrigger_tavern", tb => tb.HasComment("Trigger System"));

            entity.Property(e => e.Id)
                .HasDefaultValueSql("'0'")
                .HasComment("Identifier")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("text")
                .HasColumnName("name");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
        });

        modelBuilder.Entity<AreatriggerTeleport>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Patch }).HasName("PRIMARY");

            entity.ToTable("areatrigger_teleport", tb => tb.HasComment("Trigger System"));

            entity.Property(e => e.Id)
                .HasDefaultValueSql("'0'")
                .HasComment("Identifier")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Patch)
                .HasComment("Content patch in which this exact version of the entry was added")
                .HasColumnName("patch");
            entity.Property(e => e.Message)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("message");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.RequiredCondition)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("required_condition");
            entity.Property(e => e.RequiredLevel).HasColumnName("required_level");
            entity.Property(e => e.TargetMap).HasColumnName("target_map");
            entity.Property(e => e.TargetOrientation).HasColumnName("target_orientation");
            entity.Property(e => e.TargetPositionX).HasColumnName("target_position_x");
            entity.Property(e => e.TargetPositionY).HasColumnName("target_position_y");
            entity.Property(e => e.TargetPositionZ).HasColumnName("target_position_z");
        });

        modelBuilder.Entity<AreatriggerTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Build }).HasName("PRIMARY");

            entity.ToTable("areatrigger_template");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Build)
                .HasComment("Game client build for which to load this entry")
                .HasColumnName("build");
            entity.Property(e => e.BoxOrientation).HasColumnName("box_orientation");
            entity.Property(e => e.BoxX).HasColumnName("box_x");
            entity.Property(e => e.BoxY).HasColumnName("box_y");
            entity.Property(e => e.BoxZ).HasColumnName("box_z");
            entity.Property(e => e.MapId).HasColumnName("map_id");
            entity.Property(e => e.Radius).HasColumnName("radius");
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
            entity.Property(e => e.Z).HasColumnName("z");
        });

        modelBuilder.Entity<Auctionhousebot>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("auctionhousebot");

            entity.Property(e => e.Bid)
                .HasDefaultValueSql("'1'")
                .HasComment("Bid Price")
                .HasColumnName("bid");
            entity.Property(e => e.Buyout)
                .HasDefaultValueSql("'1'")
                .HasComment("Buyout Price")
                .HasColumnName("buyout");
            entity.Property(e => e.Item)
                .HasComment("Item Id")
                .HasColumnName("item");
            entity.Property(e => e.Stack)
                .HasDefaultValueSql("'1'")
                .HasComment("Stack Size")
                .HasColumnName("stack");
        });

        modelBuilder.Entity<Autobroadcast>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("autobroadcast");

            entity.Property(e => e.StringId).HasColumnName("string_id");
        });

        modelBuilder.Entity<BattlegroundEvent>(entity =>
        {
            entity.HasKey(e => new { e.Map, e.Event1, e.Event2 }).HasName("PRIMARY");

            entity.ToTable("battleground_events");

            entity.Property(e => e.Map).HasColumnName("map");
            entity.Property(e => e.Event1).HasColumnName("event1");
            entity.Property(e => e.Event2).HasColumnName("event2");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
        });

        modelBuilder.Entity<BattlegroundTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Patch }).HasName("PRIMARY");

            entity.ToTable("battleground_template");

            entity.Property(e => e.Id)
                .HasColumnType("mediumint unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Patch)
                .HasComment("Content patch in which this exact version of the entry was added")
                .HasColumnName("patch");
            entity.Property(e => e.AllianceLoseSpell).HasColumnName("alliance_lose_spell");
            entity.Property(e => e.AllianceStartLocation)
                .HasDefaultValueSql("'0'")
                .HasComment("WorldSafeLocs.dbc")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("alliance_start_location");
            entity.Property(e => e.AllianceWinSpell).HasColumnName("alliance_win_spell");
            entity.Property(e => e.HordeLoseSpell).HasColumnName("horde_lose_spell");
            entity.Property(e => e.HordeStartLocation)
                .HasDefaultValueSql("'0'")
                .HasComment("WorldSafeLocs.dbc")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("horde_start_location");
            entity.Property(e => e.HordeWinSpell).HasColumnName("horde_win_spell");
            entity.Property(e => e.MaxLevel).HasColumnName("max_level");
            entity.Property(e => e.MaxPlayersPerTeam).HasColumnName("max_players_per_team");
            entity.Property(e => e.MinLevel).HasColumnName("min_level");
            entity.Property(e => e.MinPlayersPerTeam).HasColumnName("min_players_per_team");
            entity.Property(e => e.PlayerLootId)
                .HasDefaultValueSql("'0'")
                .HasComment("entry from reference_loot_template")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("player_loot_id");
        });

        modelBuilder.Entity<BattlemasterEntry>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("battlemaster_entry");

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasComment("Entry of a creature")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.BgTemplate)
                .HasDefaultValueSql("'0'")
                .HasComment("Battleground template id")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("bg_template");
        });

        modelBuilder.Entity<BroadcastText>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("broadcast_text");

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.ChatType).HasColumnName("chat_type");
            entity.Property(e => e.EmoteDelay1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("emote_delay1");
            entity.Property(e => e.EmoteDelay2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("emote_delay2");
            entity.Property(e => e.EmoteDelay3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("emote_delay3");
            entity.Property(e => e.EmoteId1).HasColumnName("emote_id1");
            entity.Property(e => e.EmoteId2).HasColumnName("emote_id2");
            entity.Property(e => e.EmoteId3).HasColumnName("emote_id3");
            entity.Property(e => e.FemaleText).HasColumnName("female_text");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MaleText).HasColumnName("male_text");
            entity.Property(e => e.SoundId).HasColumnName("sound_id");
        });

        modelBuilder.Entity<CinematicWaypoint>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cinematic_waypoints");

            entity.Property(e => e.Cinematic)
                .HasDefaultValueSql("'0'")
                .HasColumnName("cinematic");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasColumnName("comment");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
            entity.Property(e => e.Timer)
                .HasDefaultValueSql("'0'")
                .HasColumnName("timer");
        });

        modelBuilder.Entity<Command>(entity =>
        {
            entity.HasKey(e => e.Name).HasName("PRIMARY");

            entity.ToTable("command", tb => tb.HasComment("Chat System"));

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Flags).HasColumnName("flags");
            entity.Property(e => e.Help).HasColumnName("help");
            entity.Property(e => e.Security).HasColumnName("security");
        });

        modelBuilder.Entity<Condition>(entity =>
        {
            entity.HasKey(e => e.ConditionEntry).HasName("PRIMARY");

            entity.ToTable("conditions", tb => tb.HasComment("Condition System"));

            entity.HasIndex(e => new { e.Type, e.Value1, e.Value2, e.Flags, e.Value3, e.Value4 }, "unique_conditions").IsUnique();

            entity.Property(e => e.ConditionEntry)
                .HasComment("Identifier")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_entry");
            entity.Property(e => e.Flags)
                .HasComment("general condition flags")
                .HasColumnName("flags");
            entity.Property(e => e.Type)
                .HasComment("Type of the condition")
                .HasColumnName("type");
            entity.Property(e => e.Value1)
                .HasComment("data field one for the condition")
                .HasColumnName("value1");
            entity.Property(e => e.Value2)
                .HasComment("data field two for the condition")
                .HasColumnName("value2");
            entity.Property(e => e.Value3)
                .HasComment("data field three for the condition")
                .HasColumnName("value3");
            entity.Property(e => e.Value4)
                .HasComment("data field four for the condition")
                .HasColumnName("value4");
        });

        modelBuilder.Entity<Creature>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("creature", tb => tb.HasComment("Creature System"));

            entity.HasIndex(e => e.Id, "idx_id");

            entity.HasIndex(e => e.Map, "idx_map");

            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.HealthPercent)
                .HasDefaultValueSql("'100'")
                .HasColumnName("health_percent");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("'0'")
                .HasComment("Creature Template Id")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Id2)
                .HasDefaultValueSql("'0'")
                .HasComment("Creature Template Id")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("id2");
            entity.Property(e => e.Id3)
                .HasDefaultValueSql("'0'")
                .HasComment("Creature Template Id")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("id3");
            entity.Property(e => e.Id4)
                .HasDefaultValueSql("'0'")
                .HasComment("Creature Template Id")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("id4");
            entity.Property(e => e.Id5)
                .HasDefaultValueSql("'0'")
                .HasComment("Creature Template Id")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("id5");
            entity.Property(e => e.Map)
                .HasComment("Map Identifier")
                .HasColumnName("map");
            entity.Property(e => e.MovementType).HasColumnName("movement_type");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to load this entry")
                .HasColumnName("patch_max");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
            entity.Property(e => e.SpawnFlags).HasColumnName("spawn_flags");
            entity.Property(e => e.Spawntimesecsmax)
                .HasDefaultValueSql("'120'")
                .HasColumnName("spawntimesecsmax");
            entity.Property(e => e.Spawntimesecsmin)
                .HasDefaultValueSql("'120'")
                .HasColumnName("spawntimesecsmin");
            entity.Property(e => e.VisibilityMod)
                .HasDefaultValueSql("'0'")
                .HasColumnName("visibility_mod");
            entity.Property(e => e.WanderDistance)
                .HasDefaultValueSql("'5'")
                .HasColumnName("wander_distance");
        });

        modelBuilder.Entity<CreatureAddon>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Patch }).HasName("PRIMARY");

            entity.ToTable("creature_addon", tb => tb.HasComment("Extra data for creature spawn."));

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Patch)
                .HasComment("Content patch in which this exact version of the entry was added")
                .HasColumnName("patch");
            entity.Property(e => e.Auras)
                .HasColumnType("text")
                .HasColumnName("auras");
            entity.Property(e => e.DisplayId).HasColumnName("display_id");
            entity.Property(e => e.EmoteState).HasColumnName("emote_state");
            entity.Property(e => e.EquipmentId)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("equipment_id");
            entity.Property(e => e.MountDisplayId)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("mount_display_id");
            entity.Property(e => e.SheathState)
                .HasDefaultValueSql("'1'")
                .HasColumnName("sheath_state");
            entity.Property(e => e.StandState).HasColumnName("stand_state");
        });

        modelBuilder.Entity<CreatureAiEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("creature_ai_events", tb => tb.HasComment("EventAI Scripts"));

            entity.Property(e => e.Id)
                .HasComment("Identifier")
                .HasColumnName("id");
            entity.Property(e => e.Action1Script).HasColumnName("action1_script");
            entity.Property(e => e.Action2Script).HasColumnName("action2_script");
            entity.Property(e => e.Action3Script).HasColumnName("action3_script");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasComment("Event Comment")
                .HasColumnName("comment");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasComment("Condition id from conditions table")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_id");
            entity.Property(e => e.CreatureId)
                .HasComment("Creature Template Identifier")
                .HasColumnName("creature_id");
            entity.Property(e => e.EventChance)
                .HasDefaultValueSql("'100'")
                .HasColumnName("event_chance");
            entity.Property(e => e.EventFlags).HasColumnName("event_flags");
            entity.Property(e => e.EventInversePhaseMask)
                .HasComment("Mask which phases this event will not trigger in")
                .HasColumnName("event_inverse_phase_mask");
            entity.Property(e => e.EventParam1).HasColumnName("event_param1");
            entity.Property(e => e.EventParam2).HasColumnName("event_param2");
            entity.Property(e => e.EventParam3).HasColumnName("event_param3");
            entity.Property(e => e.EventParam4).HasColumnName("event_param4");
            entity.Property(e => e.EventType)
                .HasComment("Event Type")
                .HasColumnName("event_type");
        });

        modelBuilder.Entity<CreatureAiScript>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creature_ai_scripts");

            entity.Property(e => e.Command).HasColumnName("command");
            entity.Property(e => e.Comments)
                .HasMaxLength(255)
                .HasColumnName("comments");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_id");
            entity.Property(e => e.DataFlags).HasColumnName("data_flags");
            entity.Property(e => e.Dataint).HasColumnName("dataint");
            entity.Property(e => e.Dataint2).HasColumnName("dataint2");
            entity.Property(e => e.Dataint3).HasColumnName("dataint3");
            entity.Property(e => e.Dataint4).HasColumnName("dataint4");
            entity.Property(e => e.Datalong).HasColumnName("datalong");
            entity.Property(e => e.Datalong2).HasColumnName("datalong2");
            entity.Property(e => e.Datalong3).HasColumnName("datalong3");
            entity.Property(e => e.Datalong4).HasColumnName("datalong4");
            entity.Property(e => e.Delay).HasColumnName("delay");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.O).HasColumnName("o");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.TargetParam1).HasColumnName("target_param1");
            entity.Property(e => e.TargetParam2).HasColumnName("target_param2");
            entity.Property(e => e.TargetType).HasColumnName("target_type");
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
            entity.Property(e => e.Z).HasColumnName("z");
        });

        modelBuilder.Entity<CreatureBattleground>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Event1 }).HasName("PRIMARY");

            entity.ToTable("creature_battleground", tb => tb.HasComment("Creature battleground indexing system"));

            entity.Property(e => e.Guid)
                .HasComment("Creature's GUID")
                .HasColumnName("guid");
            entity.Property(e => e.Event1)
                .HasComment("main event")
                .HasColumnName("event1");
            entity.Property(e => e.Event2)
                .HasComment("sub event")
                .HasColumnName("event2");
        });

        modelBuilder.Entity<CreatureClasslevelstat>(entity =>
        {
            entity.HasKey(e => new { e.Class, e.Level }).HasName("PRIMARY");

            entity.ToTable("creature_classlevelstats", tb => tb.HasComment("Base stats for creatures per class and level."));

            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Agility).HasColumnName("agility");
            entity.Property(e => e.Armor).HasColumnName("armor");
            entity.Property(e => e.AttackPower).HasColumnName("attack_power");
            entity.Property(e => e.BaseHealth).HasColumnName("base_health");
            entity.Property(e => e.BaseMana).HasColumnName("base_mana");
            entity.Property(e => e.Health)
                .HasComment("value used with multipliers to get total health")
                .HasColumnName("health");
            entity.Property(e => e.Intellect).HasColumnName("intellect");
            entity.Property(e => e.Mana)
                .HasComment("value used with multipliers to get total mana")
                .HasColumnName("mana");
            entity.Property(e => e.MeleeDamage).HasColumnName("melee_damage");
            entity.Property(e => e.RangedAttackPower).HasColumnName("ranged_attack_power");
            entity.Property(e => e.RangedDamage).HasColumnName("ranged_damage");
            entity.Property(e => e.Spirit).HasColumnName("spirit");
            entity.Property(e => e.Stamina).HasColumnName("stamina");
            entity.Property(e => e.Strength).HasColumnName("strength");
        });

        modelBuilder.Entity<CreatureDisplayInfoAddon>(entity =>
        {
            entity.HasKey(e => new { e.DisplayId, e.Build }).HasName("PRIMARY");

            entity.ToTable("creature_display_info_addon", tb => tb.HasComment("Creature System (display id related info)"));

            entity.Property(e => e.DisplayId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("display_id");
            entity.Property(e => e.Build)
                .HasComment("Game client build in which this exact version was added")
                .HasColumnName("build");
            entity.Property(e => e.BoundingRadius).HasColumnName("bounding_radius");
            entity.Property(e => e.CombatReach).HasColumnName("combat_reach");
            entity.Property(e => e.DisplayIdOtherGender)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("display_id_other_gender");
            entity.Property(e => e.Gender)
                .HasDefaultValueSql("'2'")
                .HasColumnName("gender");
            entity.Property(e => e.SpeedRun)
                .HasDefaultValueSql("'1.14286'")
                .HasColumnName("speed_run");
            entity.Property(e => e.SpeedWalk)
                .HasDefaultValueSql("'1'")
                .HasColumnName("speed_walk");
        });

        modelBuilder.Entity<CreatureEquipTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item1, e.Item2, e.Item3 }).HasName("PRIMARY");

            entity.ToTable("creature_equip_template", tb => tb.HasComment("Creature System (Equipment)"));

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasComment("Unique entry")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Item1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("item1");
            entity.Property(e => e.Item2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("item2");
            entity.Property(e => e.Item3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("item3");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to load this entry")
                .HasColumnName("patch_max");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
            entity.Property(e => e.Probability)
                .HasDefaultValueSql("'1'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("probability");
        });

        modelBuilder.Entity<CreatureGroup>(entity =>
        {
            entity.HasKey(e => e.MemberGuid).HasName("PRIMARY");

            entity.ToTable("creature_groups");

            entity.Property(e => e.MemberGuid).HasColumnName("member_guid");
            entity.Property(e => e.Flags).HasColumnName("flags");
            entity.Property(e => e.LeaderGuid).HasColumnName("leader_guid");
        });

        modelBuilder.Entity<CreatureGroupsEntryLimit>(entity =>
        {
            entity.HasKey(e => new { e.LeaderGuid, e.CreatureId }).HasName("PRIMARY");

            entity.ToTable("creature_groups_entry_limit");

            entity.Property(e => e.LeaderGuid).HasColumnName("leader_guid");
            entity.Property(e => e.CreatureId).HasColumnName("creature_id");
            entity.Property(e => e.MaxCount)
                .HasDefaultValueSql("'1'")
                .HasColumnName("max_count");
            entity.Property(e => e.MinCount).HasColumnName("min_count");
        });

        modelBuilder.Entity<CreatureInvolvedrelation>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Quest }).HasName("PRIMARY");

            entity.ToTable("creature_involvedrelation", tb => tb.HasComment("Creature System"));

            entity.Property(e => e.Id)
                .HasDefaultValueSql("'0'")
                .HasComment("Identifier")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Quest)
                .HasDefaultValueSql("'0'")
                .HasComment("Quest Identifier")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("quest");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to load this entry")
                .HasColumnName("patch_max");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
        });

        modelBuilder.Entity<CreatureLinking>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("creature_linking", tb => tb.HasComment("Creature Linking System"));

            entity.Property(e => e.Guid)
                .HasComment("creature.guid of the slave mob that is linked")
                .HasColumnName("guid");
            entity.Property(e => e.Flag)
                .HasComment("flag - describing what should happen when")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("flag");
            entity.Property(e => e.MasterGuid)
                .HasComment("master to trigger events")
                .HasColumnName("master_guid");
        });

        modelBuilder.Entity<CreatureLinkingTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Map }).HasName("PRIMARY");

            entity.ToTable("creature_linking_template", tb => tb.HasComment("Creature Linking System"));

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasComment("creature_template.entry of the slave mob that is linked")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Map)
                .HasComment("Id of map of the mobs")
                .HasColumnName("map");
            entity.Property(e => e.Flag)
                .HasDefaultValueSql("'0'")
                .HasComment("flag - describing what should happen when")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("flag");
            entity.Property(e => e.MasterEntry)
                .HasDefaultValueSql("'0'")
                .HasComment("master to trigger events")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("master_entry");
            entity.Property(e => e.SearchRange)
                .HasDefaultValueSql("'0'")
                .HasComment("search_range - describing in which range (spawn-coords) master and slave are linked together")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("search_range");
        });

        modelBuilder.Entity<CreatureLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item, e.Groupid, e.PatchMin, e.PatchMax }).HasName("PRIMARY");

            entity.ToTable("creature_loot_template", tb => tb.HasComment("Loot System"));

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasComment("entry 0 used for player insignia loot")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Item)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("item");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to load this entry")
                .HasColumnName("patch_max");
            entity.Property(e => e.ChanceOrQuestChance).HasDefaultValueSql("'100'");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_id");
            entity.Property(e => e.Maxcount)
                .HasDefaultValueSql("'1'")
                .HasColumnName("maxcount");
            entity.Property(e => e.MincountOrRef)
                .HasDefaultValueSql("'1'")
                .HasColumnType("mediumint")
                .HasColumnName("mincountOrRef");
        });

        modelBuilder.Entity<CreatureMovement>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Point }).HasName("PRIMARY");

            entity.ToTable("creature_movement", tb => tb.HasComment("Creature System"));

            entity.Property(e => e.Id)
                .HasComment("Creature GUID")
                .HasColumnName("id");
            entity.Property(e => e.Point)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("point");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PathId).HasColumnName("path_id");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
            entity.Property(e => e.ScriptId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("script_id");
            entity.Property(e => e.Waittime).HasColumnName("waittime");
        });

        modelBuilder.Entity<CreatureMovementScript>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creature_movement_scripts");

            entity.Property(e => e.Command).HasColumnName("command");
            entity.Property(e => e.Comments)
                .HasMaxLength(255)
                .HasColumnName("comments");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_id");
            entity.Property(e => e.DataFlags).HasColumnName("data_flags");
            entity.Property(e => e.Dataint).HasColumnName("dataint");
            entity.Property(e => e.Dataint2).HasColumnName("dataint2");
            entity.Property(e => e.Dataint3).HasColumnName("dataint3");
            entity.Property(e => e.Dataint4).HasColumnName("dataint4");
            entity.Property(e => e.Datalong).HasColumnName("datalong");
            entity.Property(e => e.Datalong2).HasColumnName("datalong2");
            entity.Property(e => e.Datalong3).HasColumnName("datalong3");
            entity.Property(e => e.Datalong4).HasColumnName("datalong4");
            entity.Property(e => e.Delay).HasColumnName("delay");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.O).HasColumnName("o");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.TargetParam1).HasColumnName("target_param1");
            entity.Property(e => e.TargetParam2).HasColumnName("target_param2");
            entity.Property(e => e.TargetType).HasColumnName("target_type");
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
            entity.Property(e => e.Z).HasColumnName("z");
        });

        modelBuilder.Entity<CreatureMovementSpecial>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Point }).HasName("PRIMARY");

            entity.ToTable("creature_movement_special", tb => tb.HasComment("Creature System"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Point)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("point");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PathId).HasColumnName("path_id");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
            entity.Property(e => e.ScriptId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("script_id");
            entity.Property(e => e.Waittime).HasColumnName("waittime");
        });

        modelBuilder.Entity<CreatureMovementTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Point }).HasName("PRIMARY");

            entity.ToTable("creature_movement_template", tb => tb.HasComment("Creature waypoint system"));

            entity.Property(e => e.Entry)
                .HasComment("Creature entry")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Point)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("point");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PathId).HasColumnName("path_id");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
            entity.Property(e => e.ScriptId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("script_id");
            entity.Property(e => e.Waittime).HasColumnName("waittime");
        });

        modelBuilder.Entity<CreatureOnkillReputation>(entity =>
        {
            entity.HasKey(e => new { e.CreatureId, e.Patch }).HasName("PRIMARY");

            entity.ToTable("creature_onkill_reputation", tb => tb.HasComment("Creature OnKill Reputation gain"));

            entity.Property(e => e.CreatureId)
                .HasDefaultValueSql("'0'")
                .HasComment("Creature Identifier")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("creature_id");
            entity.Property(e => e.Patch)
                .HasComment("Content patch in which this exact version of the entry was added")
                .HasColumnName("patch");
            entity.Property(e => e.RewOnKillRepValue1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint");
            entity.Property(e => e.RewOnKillRepValue2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint");
        });

        modelBuilder.Entity<CreatureQuestrelation>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Quest }).HasName("PRIMARY");

            entity.ToTable("creature_questrelation", tb => tb.HasComment("Creature System"));

            entity.Property(e => e.Id)
                .HasDefaultValueSql("'0'")
                .HasComment("Identifier")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Quest)
                .HasDefaultValueSql("'0'")
                .HasComment("Quest Identifier")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("quest");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to load this entry")
                .HasColumnName("patch_max");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
        });

        modelBuilder.Entity<CreatureSpell>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("creature_spells");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.CastFlags1).HasColumnName("castFlags_1");
            entity.Property(e => e.CastFlags2).HasColumnName("castFlags_2");
            entity.Property(e => e.CastFlags3).HasColumnName("castFlags_3");
            entity.Property(e => e.CastFlags4).HasColumnName("castFlags_4");
            entity.Property(e => e.CastFlags5).HasColumnName("castFlags_5");
            entity.Property(e => e.CastFlags6).HasColumnName("castFlags_6");
            entity.Property(e => e.CastFlags7).HasColumnName("castFlags_7");
            entity.Property(e => e.CastFlags8).HasColumnName("castFlags_8");
            entity.Property(e => e.CastTarget1)
                .HasDefaultValueSql("'1'")
                .HasColumnName("castTarget_1");
            entity.Property(e => e.CastTarget2)
                .HasDefaultValueSql("'1'")
                .HasColumnName("castTarget_2");
            entity.Property(e => e.CastTarget3)
                .HasDefaultValueSql("'1'")
                .HasColumnName("castTarget_3");
            entity.Property(e => e.CastTarget4)
                .HasDefaultValueSql("'1'")
                .HasColumnName("castTarget_4");
            entity.Property(e => e.CastTarget5)
                .HasDefaultValueSql("'1'")
                .HasColumnName("castTarget_5");
            entity.Property(e => e.CastTarget6)
                .HasDefaultValueSql("'1'")
                .HasColumnName("castTarget_6");
            entity.Property(e => e.CastTarget7)
                .HasDefaultValueSql("'1'")
                .HasColumnName("castTarget_7");
            entity.Property(e => e.CastTarget8)
                .HasDefaultValueSql("'1'")
                .HasColumnName("castTarget_8");
            entity.Property(e => e.DelayInitialMax1).HasColumnName("delayInitialMax_1");
            entity.Property(e => e.DelayInitialMax2).HasColumnName("delayInitialMax_2");
            entity.Property(e => e.DelayInitialMax3).HasColumnName("delayInitialMax_3");
            entity.Property(e => e.DelayInitialMax4).HasColumnName("delayInitialMax_4");
            entity.Property(e => e.DelayInitialMax5).HasColumnName("delayInitialMax_5");
            entity.Property(e => e.DelayInitialMax6).HasColumnName("delayInitialMax_6");
            entity.Property(e => e.DelayInitialMax7).HasColumnName("delayInitialMax_7");
            entity.Property(e => e.DelayInitialMax8).HasColumnName("delayInitialMax_8");
            entity.Property(e => e.DelayInitialMin1).HasColumnName("delayInitialMin_1");
            entity.Property(e => e.DelayInitialMin2).HasColumnName("delayInitialMin_2");
            entity.Property(e => e.DelayInitialMin3).HasColumnName("delayInitialMin_3");
            entity.Property(e => e.DelayInitialMin4).HasColumnName("delayInitialMin_4");
            entity.Property(e => e.DelayInitialMin5).HasColumnName("delayInitialMin_5");
            entity.Property(e => e.DelayInitialMin6).HasColumnName("delayInitialMin_6");
            entity.Property(e => e.DelayInitialMin7).HasColumnName("delayInitialMin_7");
            entity.Property(e => e.DelayInitialMin8).HasColumnName("delayInitialMin_8");
            entity.Property(e => e.DelayRepeatMax1).HasColumnName("delayRepeatMax_1");
            entity.Property(e => e.DelayRepeatMax2).HasColumnName("delayRepeatMax_2");
            entity.Property(e => e.DelayRepeatMax3).HasColumnName("delayRepeatMax_3");
            entity.Property(e => e.DelayRepeatMax4).HasColumnName("delayRepeatMax_4");
            entity.Property(e => e.DelayRepeatMax5).HasColumnName("delayRepeatMax_5");
            entity.Property(e => e.DelayRepeatMax6).HasColumnName("delayRepeatMax_6");
            entity.Property(e => e.DelayRepeatMax7).HasColumnName("delayRepeatMax_7");
            entity.Property(e => e.DelayRepeatMax8).HasColumnName("delayRepeatMax_8");
            entity.Property(e => e.DelayRepeatMin1).HasColumnName("delayRepeatMin_1");
            entity.Property(e => e.DelayRepeatMin2).HasColumnName("delayRepeatMin_2");
            entity.Property(e => e.DelayRepeatMin3).HasColumnName("delayRepeatMin_3");
            entity.Property(e => e.DelayRepeatMin4).HasColumnName("delayRepeatMin_4");
            entity.Property(e => e.DelayRepeatMin5).HasColumnName("delayRepeatMin_5");
            entity.Property(e => e.DelayRepeatMin6).HasColumnName("delayRepeatMin_6");
            entity.Property(e => e.DelayRepeatMin7).HasColumnName("delayRepeatMin_7");
            entity.Property(e => e.DelayRepeatMin8).HasColumnName("delayRepeatMin_8");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Probability1)
                .HasDefaultValueSql("'100'")
                .HasColumnName("probability_1");
            entity.Property(e => e.Probability2)
                .HasDefaultValueSql("'100'")
                .HasColumnName("probability_2");
            entity.Property(e => e.Probability3)
                .HasDefaultValueSql("'100'")
                .HasColumnName("probability_3");
            entity.Property(e => e.Probability4)
                .HasDefaultValueSql("'100'")
                .HasColumnName("probability_4");
            entity.Property(e => e.Probability5)
                .HasDefaultValueSql("'100'")
                .HasColumnName("probability_5");
            entity.Property(e => e.Probability6)
                .HasDefaultValueSql("'100'")
                .HasColumnName("probability_6");
            entity.Property(e => e.Probability7)
                .HasDefaultValueSql("'100'")
                .HasColumnName("probability_7");
            entity.Property(e => e.Probability8)
                .HasDefaultValueSql("'100'")
                .HasColumnName("probability_8");
            entity.Property(e => e.ScriptId1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("scriptId_1");
            entity.Property(e => e.ScriptId2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("scriptId_2");
            entity.Property(e => e.ScriptId3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("scriptId_3");
            entity.Property(e => e.ScriptId4)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("scriptId_4");
            entity.Property(e => e.ScriptId5)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("scriptId_5");
            entity.Property(e => e.ScriptId6)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("scriptId_6");
            entity.Property(e => e.ScriptId7)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("scriptId_7");
            entity.Property(e => e.ScriptId8)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("scriptId_8");
            entity.Property(e => e.SpellId1).HasColumnName("spellId_1");
            entity.Property(e => e.SpellId2).HasColumnName("spellId_2");
            entity.Property(e => e.SpellId3).HasColumnName("spellId_3");
            entity.Property(e => e.SpellId4).HasColumnName("spellId_4");
            entity.Property(e => e.SpellId5).HasColumnName("spellId_5");
            entity.Property(e => e.SpellId6).HasColumnName("spellId_6");
            entity.Property(e => e.SpellId7).HasColumnName("spellId_7");
            entity.Property(e => e.SpellId8).HasColumnName("spellId_8");
            entity.Property(e => e.TargetParam11).HasColumnName("targetParam1_1");
            entity.Property(e => e.TargetParam12).HasColumnName("targetParam1_2");
            entity.Property(e => e.TargetParam13).HasColumnName("targetParam1_3");
            entity.Property(e => e.TargetParam14).HasColumnName("targetParam1_4");
            entity.Property(e => e.TargetParam15).HasColumnName("targetParam1_5");
            entity.Property(e => e.TargetParam16).HasColumnName("targetParam1_6");
            entity.Property(e => e.TargetParam17).HasColumnName("targetParam1_7");
            entity.Property(e => e.TargetParam18).HasColumnName("targetParam1_8");
            entity.Property(e => e.TargetParam21).HasColumnName("targetParam2_1");
            entity.Property(e => e.TargetParam22).HasColumnName("targetParam2_2");
            entity.Property(e => e.TargetParam23).HasColumnName("targetParam2_3");
            entity.Property(e => e.TargetParam24).HasColumnName("targetParam2_4");
            entity.Property(e => e.TargetParam25).HasColumnName("targetParam2_5");
            entity.Property(e => e.TargetParam26).HasColumnName("targetParam2_6");
            entity.Property(e => e.TargetParam27).HasColumnName("targetParam2_7");
            entity.Property(e => e.TargetParam28).HasColumnName("targetParam2_8");
        });

        modelBuilder.Entity<CreatureSpellsScript>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creature_spells_scripts");

            entity.Property(e => e.Command).HasColumnName("command");
            entity.Property(e => e.Comments)
                .HasMaxLength(255)
                .HasColumnName("comments");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_id");
            entity.Property(e => e.DataFlags).HasColumnName("data_flags");
            entity.Property(e => e.Dataint).HasColumnName("dataint");
            entity.Property(e => e.Dataint2).HasColumnName("dataint2");
            entity.Property(e => e.Dataint3).HasColumnName("dataint3");
            entity.Property(e => e.Dataint4).HasColumnName("dataint4");
            entity.Property(e => e.Datalong).HasColumnName("datalong");
            entity.Property(e => e.Datalong2).HasColumnName("datalong2");
            entity.Property(e => e.Datalong3).HasColumnName("datalong3");
            entity.Property(e => e.Datalong4).HasColumnName("datalong4");
            entity.Property(e => e.Delay).HasColumnName("delay");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.O).HasColumnName("o");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.TargetParam1).HasColumnName("target_param1");
            entity.Property(e => e.TargetParam2).HasColumnName("target_param2");
            entity.Property(e => e.TargetType).HasColumnName("target_type");
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
            entity.Property(e => e.Z).HasColumnName("z");
        });

        modelBuilder.Entity<CreatureTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Patch }).HasName("PRIMARY");

            entity.ToTable("creature_template", tb => tb.HasComment("Creature System"));

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Patch)
                .HasComment("Content patch in which this exact version of the entry was added")
                .HasColumnName("patch");
            entity.Property(e => e.AiName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("ai_name");
            entity.Property(e => e.ArcaneRes).HasColumnName("arcane_res");
            entity.Property(e => e.ArmorMultiplier)
                .HasDefaultValueSql("'1'")
                .HasColumnName("armor_multiplier");
            entity.Property(e => e.Auras)
                .HasColumnType("text")
                .HasColumnName("auras");
            entity.Property(e => e.BaseAttackTime)
                .HasDefaultValueSql("'2000'")
                .HasColumnName("base_attack_time");
            entity.Property(e => e.CallForHelpRange)
                .HasDefaultValueSql("'5'")
                .HasColumnName("call_for_help_range");
            entity.Property(e => e.Civilian).HasColumnName("civilian");
            entity.Property(e => e.DamageMultiplier)
                .HasDefaultValueSql("'1'")
                .HasColumnName("damage_multiplier");
            entity.Property(e => e.DamageSchool).HasColumnName("damage_school");
            entity.Property(e => e.DamageVariance)
                .HasDefaultValueSql("'0.14'")
                .HasColumnName("damage_variance");
            entity.Property(e => e.DetectionRange)
                .HasDefaultValueSql("'18'")
                .HasColumnName("detection_range");
            entity.Property(e => e.DisplayId1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("display_id1");
            entity.Property(e => e.DisplayId2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("display_id2");
            entity.Property(e => e.DisplayId3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("display_id3");
            entity.Property(e => e.DisplayId4)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("display_id4");
            entity.Property(e => e.DisplayProbability1).HasColumnName("display_probability1");
            entity.Property(e => e.DisplayProbability2).HasColumnName("display_probability2");
            entity.Property(e => e.DisplayProbability3).HasColumnName("display_probability3");
            entity.Property(e => e.DisplayProbability4).HasColumnName("display_probability4");
            entity.Property(e => e.DisplayScale1).HasColumnName("display_scale1");
            entity.Property(e => e.DisplayScale2).HasColumnName("display_scale2");
            entity.Property(e => e.DisplayScale3).HasColumnName("display_scale3");
            entity.Property(e => e.DisplayScale4).HasColumnName("display_scale4");
            entity.Property(e => e.DisplayTotalProbability).HasColumnName("display_total_probability");
            entity.Property(e => e.EquipmentId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("equipment_id");
            entity.Property(e => e.Faction).HasColumnName("faction");
            entity.Property(e => e.FireRes).HasColumnName("fire_res");
            entity.Property(e => e.FlagsExtra).HasColumnName("flags_extra");
            entity.Property(e => e.FrostRes).HasColumnName("frost_res");
            entity.Property(e => e.GoldMax)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("gold_max");
            entity.Property(e => e.GoldMin)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("gold_min");
            entity.Property(e => e.GossipMenuId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("gossip_menu_id");
            entity.Property(e => e.HealthMultiplier)
                .HasDefaultValueSql("'1'")
                .HasColumnName("health_multiplier");
            entity.Property(e => e.HolyRes).HasColumnName("holy_res");
            entity.Property(e => e.ImmunityFlags).HasColumnName("immunity_flags");
            entity.Property(e => e.InhabitType)
                .HasDefaultValueSql("'3'")
                .HasColumnName("inhabit_type");
            entity.Property(e => e.LeashRange).HasColumnName("leash_range");
            entity.Property(e => e.LevelMax)
                .HasDefaultValueSql("'1'")
                .HasColumnName("level_max");
            entity.Property(e => e.LevelMin)
                .HasDefaultValueSql("'1'")
                .HasColumnName("level_min");
            entity.Property(e => e.LootId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("loot_id");
            entity.Property(e => e.ManaMultiplier)
                .HasDefaultValueSql("'1'")
                .HasColumnName("mana_multiplier");
            entity.Property(e => e.MechanicImmuneMask).HasColumnName("mechanic_immune_mask");
            entity.Property(e => e.MountDisplayId).HasColumnName("mount_display_id");
            entity.Property(e => e.MovementType).HasColumnName("movement_type");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("'0'")
                .IsFixedLength()
                .HasColumnName("name");
            entity.Property(e => e.NatureRes).HasColumnName("nature_res");
            entity.Property(e => e.NpcFlags).HasColumnName("npc_flags");
            entity.Property(e => e.PetFamily).HasColumnName("pet_family");
            entity.Property(e => e.PetSpellListId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("pet_spell_list_id");
            entity.Property(e => e.PickpocketLootId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("pickpocket_loot_id");
            entity.Property(e => e.RacialLeader).HasColumnName("racial_leader");
            entity.Property(e => e.RangedAttackTime)
                .HasDefaultValueSql("'2000'")
                .HasColumnName("ranged_attack_time");
            entity.Property(e => e.Rank).HasColumnName("rank");
            entity.Property(e => e.Regeneration)
                .HasDefaultValueSql("'3'")
                .HasColumnName("regeneration");
            entity.Property(e => e.SchoolImmuneMask).HasColumnName("school_immune_mask");
            entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("script_name");
            entity.Property(e => e.ShadowRes).HasColumnName("shadow_res");
            entity.Property(e => e.SkinningLootId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("skinning_loot_id");
            entity.Property(e => e.SpawnSpellId)
                .HasComment("Spell with effect 46 that will be cast immediately upon spawning. Creature will remain unattackable until the cast finishes.")
                .HasColumnName("spawn_spell_id");
            entity.Property(e => e.SpeedRun)
                .HasDefaultValueSql("'1.14286'")
                .HasComment("Result of 8.0/7.0, most common value")
                .HasColumnName("speed_run");
            entity.Property(e => e.SpeedWalk)
                .HasDefaultValueSql("'1'")
                .HasComment("Result of 2.5/2.5, most common value")
                .HasColumnName("speed_walk");
            entity.Property(e => e.SpellId1).HasColumnName("spell_id1");
            entity.Property(e => e.SpellId2).HasColumnName("spell_id2");
            entity.Property(e => e.SpellId3).HasColumnName("spell_id3");
            entity.Property(e => e.SpellId4).HasColumnName("spell_id4");
            entity.Property(e => e.SpellListId).HasColumnName("spell_list_id");
            entity.Property(e => e.Subname)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("subname");
            entity.Property(e => e.TrainerClass).HasColumnName("trainer_class");
            entity.Property(e => e.TrainerId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("trainer_id");
            entity.Property(e => e.TrainerRace).HasColumnName("trainer_race");
            entity.Property(e => e.TrainerSpell).HasColumnName("trainer_spell");
            entity.Property(e => e.TrainerType).HasColumnName("trainer_type");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.TypeFlags).HasColumnName("type_flags");
            entity.Property(e => e.UnitClass).HasColumnName("unit_class");
            entity.Property(e => e.UnitFlags).HasColumnName("unit_flags");
            entity.Property(e => e.VendorId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("vendor_id");
            entity.Property(e => e.XpMultiplier)
                .HasDefaultValueSql("'1'")
                .HasColumnName("xp_multiplier");
        });

        modelBuilder.Entity<CustomText>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("custom_texts", tb => tb.HasComment("Custom Texts"));

            entity.Property(e => e.Entry)
                .HasColumnType("mediumint")
                .HasColumnName("entry");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.ContentDefault)
                .HasColumnType("text")
                .HasColumnName("content_default");
            entity.Property(e => e.ContentLoc1)
                .HasColumnType("text")
                .HasColumnName("content_loc1");
            entity.Property(e => e.ContentLoc2)
                .HasColumnType("text")
                .HasColumnName("content_loc2");
            entity.Property(e => e.ContentLoc3)
                .HasColumnType("text")
                .HasColumnName("content_loc3");
            entity.Property(e => e.ContentLoc4)
                .HasColumnType("text")
                .HasColumnName("content_loc4");
            entity.Property(e => e.ContentLoc5)
                .HasColumnType("text")
                .HasColumnName("content_loc5");
            entity.Property(e => e.ContentLoc6)
                .HasColumnType("text")
                .HasColumnName("content_loc6");
            entity.Property(e => e.ContentLoc7)
                .HasColumnType("text")
                .HasColumnName("content_loc7");
            entity.Property(e => e.ContentLoc8)
                .HasColumnType("text")
                .HasColumnName("content_loc8");
            entity.Property(e => e.Emote).HasColumnName("emote");
            entity.Property(e => e.Language).HasColumnName("language");
            entity.Property(e => e.Sound)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("sound");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<DisenchantLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item }).HasName("PRIMARY");

            entity.ToTable("disenchant_loot_template", tb => tb.HasComment("Loot System"));

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasComment("Recommended id selection: item_level*100 + item_quality")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Item)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("item");
            entity.Property(e => e.ChanceOrQuestChance).HasDefaultValueSql("'100'");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_id");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Maxcount)
                .HasDefaultValueSql("'1'")
                .HasColumnName("maxcount");
            entity.Property(e => e.MincountOrRef)
                .HasDefaultValueSql("'1'")
                .HasColumnType("mediumint")
                .HasColumnName("mincountOrRef");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to load this entry")
                .HasColumnName("patch_max");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
        });

        modelBuilder.Entity<EventScript>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("event_scripts");

            entity.Property(e => e.Command).HasColumnName("command");
            entity.Property(e => e.Comments)
                .HasMaxLength(255)
                .HasColumnName("comments");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_id");
            entity.Property(e => e.DataFlags).HasColumnName("data_flags");
            entity.Property(e => e.Dataint).HasColumnName("dataint");
            entity.Property(e => e.Dataint2).HasColumnName("dataint2");
            entity.Property(e => e.Dataint3).HasColumnName("dataint3");
            entity.Property(e => e.Dataint4).HasColumnName("dataint4");
            entity.Property(e => e.Datalong).HasColumnName("datalong");
            entity.Property(e => e.Datalong2).HasColumnName("datalong2");
            entity.Property(e => e.Datalong3).HasColumnName("datalong3");
            entity.Property(e => e.Datalong4).HasColumnName("datalong4");
            entity.Property(e => e.Delay).HasColumnName("delay");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.O).HasColumnName("o");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.TargetParam1).HasColumnName("target_param1");
            entity.Property(e => e.TargetParam2).HasColumnName("target_param2");
            entity.Property(e => e.TargetType).HasColumnName("target_type");
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
            entity.Property(e => e.Z).HasColumnName("z");
        });

        modelBuilder.Entity<ExplorationBasexp>(entity =>
        {
            entity.HasKey(e => e.Level).HasName("PRIMARY");

            entity.ToTable("exploration_basexp", tb => tb.HasComment("Exploration System"));

            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Basexp)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("basexp");
        });

        modelBuilder.Entity<Faction>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Build }).HasName("PRIMARY");

            entity.ToTable("faction");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Build)
                .HasDefaultValueSql("'5875'")
                .HasComment("Game client build for which to load this entry")
                .HasColumnName("build");
            entity.Property(e => e.BaseRepClassMask1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("base_rep_class_mask1");
            entity.Property(e => e.BaseRepClassMask2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("base_rep_class_mask2");
            entity.Property(e => e.BaseRepClassMask3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("base_rep_class_mask3");
            entity.Property(e => e.BaseRepClassMask4)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("base_rep_class_mask4");
            entity.Property(e => e.BaseRepRaceMask1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("base_rep_race_mask1");
            entity.Property(e => e.BaseRepRaceMask2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("base_rep_race_mask2");
            entity.Property(e => e.BaseRepRaceMask3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("base_rep_race_mask3");
            entity.Property(e => e.BaseRepRaceMask4)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("base_rep_race_mask4");
            entity.Property(e => e.BaseRepValue1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("base_rep_value1");
            entity.Property(e => e.BaseRepValue2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("base_rep_value2");
            entity.Property(e => e.BaseRepValue3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("base_rep_value3");
            entity.Property(e => e.BaseRepValue4)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("base_rep_value4");
            entity.Property(e => e.Description)
                .HasMaxLength(512)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.ReputationFlags1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("reputation_flags1");
            entity.Property(e => e.ReputationFlags2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("reputation_flags2");
            entity.Property(e => e.ReputationFlags3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("reputation_flags3");
            entity.Property(e => e.ReputationFlags4)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("reputation_flags4");
            entity.Property(e => e.ReputationListId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("reputation_list_id");
            entity.Property(e => e.Team)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("team");
        });

        modelBuilder.Entity<FactionTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Build }).HasName("PRIMARY");

            entity.ToTable("faction_template");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Build)
                .HasDefaultValueSql("'5875'")
                .HasComment("Game client build for which to load this entry")
                .HasColumnName("build");
            entity.Property(e => e.EnemyFaction1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("enemy_faction1");
            entity.Property(e => e.EnemyFaction2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("enemy_faction2");
            entity.Property(e => e.EnemyFaction3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("enemy_faction3");
            entity.Property(e => e.EnemyFaction4)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("enemy_faction4");
            entity.Property(e => e.FactionFlags)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("faction_flags");
            entity.Property(e => e.FactionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("faction_id");
            entity.Property(e => e.FriendFaction1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("friend_faction1");
            entity.Property(e => e.FriendFaction2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("friend_faction2");
            entity.Property(e => e.FriendFaction3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("friend_faction3");
            entity.Property(e => e.FriendFaction4)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("friend_faction4");
            entity.Property(e => e.FriendlyMask)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("friendly_mask");
            entity.Property(e => e.HostileMask)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("hostile_mask");
            entity.Property(e => e.OurMask)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("our_mask");
        });

        modelBuilder.Entity<FishingLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item }).HasName("PRIMARY");

            entity.ToTable("fishing_loot_template", tb => tb.HasComment("Loot System"));

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasComment("entry 0 used for junk loot at fishing fail (if allowed by config option)")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Item)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("item");
            entity.Property(e => e.ChanceOrQuestChance).HasDefaultValueSql("'100'");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_id");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Maxcount)
                .HasDefaultValueSql("'1'")
                .HasColumnName("maxcount");
            entity.Property(e => e.MincountOrRef)
                .HasDefaultValueSql("'1'")
                .HasColumnType("mediumint")
                .HasColumnName("mincountOrRef");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to load this entry")
                .HasColumnName("patch_max");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
        });

        modelBuilder.Entity<ForbiddenItem>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.AfterOrBefore }).HasName("PRIMARY");

            entity.ToTable("forbidden_items");

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.AfterOrBefore).HasColumnName("after_or_before");
            entity.Property(e => e.Patch).HasColumnName("patch");
        });

        modelBuilder.Entity<GameEvent>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("game_event");

            entity.Property(e => e.Entry)
                .HasComment("Entry of the game event")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasComment("Description of the event displayed in console")
                .HasColumnName("description");
            entity.Property(e => e.Disabled).HasColumnName("disabled");
            entity.Property(e => e.EndTime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasComment("Absolute end date, the event will never start afler")
                .HasColumnType("timestamp")
                .HasColumnName("end_time");
            entity.Property(e => e.Hardcoded).HasColumnName("hardcoded");
            entity.Property(e => e.Holiday)
                .HasDefaultValueSql("'0'")
                .HasComment("Client side holiday id")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("holiday");
            entity.Property(e => e.Length)
                .HasDefaultValueSql("'2592000'")
                .HasComment("Length in minutes of the event")
                .HasColumnName("length");
            entity.Property(e => e.Occurence)
                .HasDefaultValueSql("'5184000'")
                .HasComment("Delay in minutes between occurences of the event")
                .HasColumnName("occurence");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to enable this event")
                .HasColumnName("patch_max");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to enable this event")
                .HasColumnName("patch_min");
            entity.Property(e => e.StartTime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasComment("Absolute start date, the event will never start before")
                .HasColumnType("timestamp")
                .HasColumnName("start_time");
        });

        modelBuilder.Entity<GameEventCreature>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Event }).HasName("PRIMARY");

            entity.ToTable("game_event_creature");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Event)
                .HasComment("Put negatives values to remove during event")
                .HasColumnName("event");
        });

        modelBuilder.Entity<GameEventCreatureDatum>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Event, e.Patch }).HasName("PRIMARY");

            entity.ToTable("game_event_creature_data");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Event).HasColumnName("event");
            entity.Property(e => e.Patch)
                .HasComment("Content patch in which this exact version of the entry was added")
                .HasColumnName("patch");
            entity.Property(e => e.DisplayId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("display_id");
            entity.Property(e => e.EntryId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry_id");
            entity.Property(e => e.EquipmentId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("equipment_id");
            entity.Property(e => e.SpellEnd).HasColumnName("spell_end");
            entity.Property(e => e.SpellStart).HasColumnName("spell_start");
        });

        modelBuilder.Entity<GameEventGameobject>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Event }).HasName("PRIMARY");

            entity.ToTable("game_event_gameobject");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Event)
                .HasComment("Put negatives values to remove during event")
                .HasColumnName("event");
        });

        modelBuilder.Entity<GameEventMail>(entity =>
        {
            entity.HasKey(e => new { e.Event, e.RaceMask, e.Quest }).HasName("PRIMARY");

            entity.ToTable("game_event_mail", tb => tb.HasComment("Game event system"));

            entity.Property(e => e.Event)
                .HasComment("Negatives value to send at event stop, positive value for send at event start.")
                .HasColumnName("event");
            entity.Property(e => e.RaceMask)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("raceMask");
            entity.Property(e => e.Quest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("quest");
            entity.Property(e => e.MailTemplateId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("mailTemplateId");
            entity.Property(e => e.SenderEntry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("senderEntry");
        });

        modelBuilder.Entity<GameEventQuest>(entity =>
        {
            entity.HasKey(e => new { e.Quest, e.Event }).HasName("PRIMARY");

            entity.ToTable("game_event_quest", tb => tb.HasComment("Game event system"));

            entity.Property(e => e.Quest)
                .HasDefaultValueSql("'0'")
                .HasComment("entry from quest_template")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("quest");
            entity.Property(e => e.Event)
                .HasComment("entry from game_event")
                .HasColumnName("event");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
        });

        modelBuilder.Entity<GameGraveyardZone>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.GhostZone, e.PatchMax }).HasName("PRIMARY");

            entity.ToTable("game_graveyard_zone", tb => tb.HasComment("Trigger System"));

            entity.Property(e => e.Id)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("id");
            entity.Property(e => e.GhostZone)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("ghost_zone");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to load this entry")
                .HasColumnName("patch_max");
            entity.Property(e => e.Faction).HasColumnName("faction");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
        });

        modelBuilder.Entity<GameTele>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("game_tele", tb => tb.HasComment("Tele Command"));

            entity.Property(e => e.Id)
                .HasColumnType("mediumint unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Map).HasColumnName("map");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
        });

        modelBuilder.Entity<GameWeather>(entity =>
        {
            entity.HasKey(e => e.Zone).HasName("PRIMARY");

            entity.ToTable("game_weather", tb => tb.HasComment("Weather System"));

            entity.Property(e => e.Zone)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("zone");
            entity.Property(e => e.FallRainChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("fall_rain_chance");
            entity.Property(e => e.FallSnowChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("fall_snow_chance");
            entity.Property(e => e.FallStormChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("fall_storm_chance");
            entity.Property(e => e.SpringRainChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("spring_rain_chance");
            entity.Property(e => e.SpringSnowChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("spring_snow_chance");
            entity.Property(e => e.SpringStormChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("spring_storm_chance");
            entity.Property(e => e.SummerRainChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("summer_rain_chance");
            entity.Property(e => e.SummerSnowChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("summer_snow_chance");
            entity.Property(e => e.SummerStormChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("summer_storm_chance");
            entity.Property(e => e.WinterRainChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("winter_rain_chance");
            entity.Property(e => e.WinterSnowChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("winter_snow_chance");
            entity.Property(e => e.WinterStormChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("winter_storm_chance");
        });

        modelBuilder.Entity<Gameobject>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("gameobject", tb => tb.HasComment("Gameobject System"));

            entity.HasIndex(e => e.Id, "idx_id");

            entity.HasIndex(e => e.Map, "idx_map");

            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Animprogress).HasColumnName("animprogress");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("'0'")
                .HasComment("Gameobject Identifier")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Map)
                .HasComment("Map Identifier")
                .HasColumnName("map");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to load this entry")
                .HasColumnName("patch_max");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
            entity.Property(e => e.Rotation0).HasColumnName("rotation0");
            entity.Property(e => e.Rotation1).HasColumnName("rotation1");
            entity.Property(e => e.Rotation2).HasColumnName("rotation2");
            entity.Property(e => e.Rotation3).HasColumnName("rotation3");
            entity.Property(e => e.SpawnFlags).HasColumnName("spawn_flags");
            entity.Property(e => e.Spawntimesecsmax).HasColumnName("spawntimesecsmax");
            entity.Property(e => e.Spawntimesecsmin).HasColumnName("spawntimesecsmin");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.VisibilityMod)
                .HasDefaultValueSql("'0'")
                .HasColumnName("visibility_mod");
        });

        modelBuilder.Entity<GameobjectBattleground>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Event1, e.Event2 }).HasName("PRIMARY");

            entity.ToTable("gameobject_battleground", tb => tb.HasComment("GameObject battleground indexing system"));

            entity.Property(e => e.Guid)
                .HasComment("GameObject's GUID")
                .HasColumnName("guid");
            entity.Property(e => e.Event1)
                .HasComment("main event")
                .HasColumnName("event1");
            entity.Property(e => e.Event2)
                .HasComment("sub event")
                .HasColumnName("event2");
        });

        modelBuilder.Entity<GameobjectDisplayInfoAddon>(entity =>
        {
            entity.HasKey(e => e.DisplayId).HasName("PRIMARY");

            entity.ToTable("gameobject_display_info_addon");

            entity.Property(e => e.DisplayId).HasColumnName("display_id");
            entity.Property(e => e.MaxX).HasColumnName("max_x");
            entity.Property(e => e.MaxY).HasColumnName("max_y");
            entity.Property(e => e.MaxZ).HasColumnName("max_z");
            entity.Property(e => e.MinX).HasColumnName("min_x");
            entity.Property(e => e.MinY).HasColumnName("min_y");
            entity.Property(e => e.MinZ).HasColumnName("min_z");
        });

        modelBuilder.Entity<GameobjectInvolvedrelation>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Quest }).HasName("PRIMARY");

            entity.ToTable("gameobject_involvedrelation");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Quest)
                .HasDefaultValueSql("'0'")
                .HasComment("Quest Identifier")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("quest");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to load this entry")
                .HasColumnName("patch_max");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
        });

        modelBuilder.Entity<GameobjectLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item }).HasName("PRIMARY");

            entity.ToTable("gameobject_loot_template", tb => tb.HasComment("Loot System"));

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Item)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("item");
            entity.Property(e => e.ChanceOrQuestChance).HasDefaultValueSql("'100'");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_id");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Maxcount)
                .HasDefaultValueSql("'1'")
                .HasColumnName("maxcount");
            entity.Property(e => e.MincountOrRef)
                .HasDefaultValueSql("'1'")
                .HasColumnType("mediumint")
                .HasColumnName("mincountOrRef");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to load this entry")
                .HasColumnName("patch_max");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
        });

        modelBuilder.Entity<GameobjectQuestrelation>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Quest }).HasName("PRIMARY");

            entity.ToTable("gameobject_questrelation");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Quest)
                .HasDefaultValueSql("'0'")
                .HasComment("Quest Identifier")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("quest");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to load this entry")
                .HasColumnName("patch_max");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
        });

        modelBuilder.Entity<GameobjectRequirement>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("gameobject_requirement", tb => tb.HasComment("Gameobject System"));

            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.ReqGuid)
                .HasComment("Gameobject Identifier")
                .HasColumnName("reqGuid");
            entity.Property(e => e.ReqType)
                .HasComment("Gameobject Identifier")
                .HasColumnName("reqType");
        });

        modelBuilder.Entity<GameobjectScript>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("gameobject_scripts");

            entity.Property(e => e.Command).HasColumnName("command");
            entity.Property(e => e.Comments)
                .HasMaxLength(255)
                .HasColumnName("comments");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_id");
            entity.Property(e => e.DataFlags).HasColumnName("data_flags");
            entity.Property(e => e.Dataint).HasColumnName("dataint");
            entity.Property(e => e.Dataint2).HasColumnName("dataint2");
            entity.Property(e => e.Dataint3).HasColumnName("dataint3");
            entity.Property(e => e.Dataint4).HasColumnName("dataint4");
            entity.Property(e => e.Datalong).HasColumnName("datalong");
            entity.Property(e => e.Datalong2).HasColumnName("datalong2");
            entity.Property(e => e.Datalong3).HasColumnName("datalong3");
            entity.Property(e => e.Datalong4).HasColumnName("datalong4");
            entity.Property(e => e.Delay).HasColumnName("delay");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.O).HasColumnName("o");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.TargetParam1).HasColumnName("target_param1");
            entity.Property(e => e.TargetParam2).HasColumnName("target_param2");
            entity.Property(e => e.TargetType).HasColumnName("target_type");
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
            entity.Property(e => e.Z).HasColumnName("z");
        });

        modelBuilder.Entity<GameobjectTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Patch }).HasName("PRIMARY");

            entity.ToTable("gameobject_template", tb => tb.HasComment("Gameobject System"));

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Patch)
                .HasComment("Content patch in which this exact version of the entry was added")
                .HasColumnName("patch");
            entity.Property(e => e.Data0).HasColumnName("data0");
            entity.Property(e => e.Data1).HasColumnName("data1");
            entity.Property(e => e.Data10).HasColumnName("data10");
            entity.Property(e => e.Data11).HasColumnName("data11");
            entity.Property(e => e.Data12).HasColumnName("data12");
            entity.Property(e => e.Data13).HasColumnName("data13");
            entity.Property(e => e.Data14).HasColumnName("data14");
            entity.Property(e => e.Data15).HasColumnName("data15");
            entity.Property(e => e.Data16).HasColumnName("data16");
            entity.Property(e => e.Data17).HasColumnName("data17");
            entity.Property(e => e.Data18).HasColumnName("data18");
            entity.Property(e => e.Data19).HasColumnName("data19");
            entity.Property(e => e.Data2).HasColumnName("data2");
            entity.Property(e => e.Data20).HasColumnName("data20");
            entity.Property(e => e.Data21).HasColumnName("data21");
            entity.Property(e => e.Data22).HasColumnName("data22");
            entity.Property(e => e.Data23).HasColumnName("data23");
            entity.Property(e => e.Data3).HasColumnName("data3");
            entity.Property(e => e.Data4).HasColumnName("data4");
            entity.Property(e => e.Data5).HasColumnName("data5");
            entity.Property(e => e.Data6).HasColumnName("data6");
            entity.Property(e => e.Data7).HasColumnName("data7");
            entity.Property(e => e.Data8).HasColumnName("data8");
            entity.Property(e => e.Data9).HasColumnName("data9");
            entity.Property(e => e.DisplayId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("displayId");
            entity.Property(e => e.Faction).HasColumnName("faction");
            entity.Property(e => e.Flags).HasColumnName("flags");
            entity.Property(e => e.Maxgold)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("maxgold");
            entity.Property(e => e.Mingold)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("mingold");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("script_name");
            entity.Property(e => e.Size)
                .HasDefaultValueSql("'1'")
                .HasColumnName("size");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<GenericScript>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("generic_scripts");

            entity.Property(e => e.Command).HasColumnName("command");
            entity.Property(e => e.Comments)
                .HasMaxLength(255)
                .HasColumnName("comments");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_id");
            entity.Property(e => e.DataFlags).HasColumnName("data_flags");
            entity.Property(e => e.Dataint).HasColumnName("dataint");
            entity.Property(e => e.Dataint2).HasColumnName("dataint2");
            entity.Property(e => e.Dataint3).HasColumnName("dataint3");
            entity.Property(e => e.Dataint4).HasColumnName("dataint4");
            entity.Property(e => e.Datalong).HasColumnName("datalong");
            entity.Property(e => e.Datalong2).HasColumnName("datalong2");
            entity.Property(e => e.Datalong3).HasColumnName("datalong3");
            entity.Property(e => e.Datalong4).HasColumnName("datalong4");
            entity.Property(e => e.Delay).HasColumnName("delay");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.O).HasColumnName("o");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.TargetParam1).HasColumnName("target_param1");
            entity.Property(e => e.TargetParam2).HasColumnName("target_param2");
            entity.Property(e => e.TargetType).HasColumnName("target_type");
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
            entity.Property(e => e.Z).HasColumnName("z");
        });

        modelBuilder.Entity<GossipMenu>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.TextId }).HasName("PRIMARY");

            entity.ToTable("gossip_menu");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.TextId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("text_id");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_id");
            entity.Property(e => e.ScriptId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("script_id");
        });

        modelBuilder.Entity<GossipMenuOption>(entity =>
        {
            entity.HasKey(e => new { e.MenuId, e.Id }).HasName("PRIMARY");

            entity.ToTable("gossip_menu_option");

            entity.Property(e => e.MenuId).HasColumnName("menu_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionMenuId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("action_menu_id");
            entity.Property(e => e.ActionPoiId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("action_poi_id");
            entity.Property(e => e.ActionScriptId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("action_script_id");
            entity.Property(e => e.BoxBroadcastText)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("box_broadcast_text");
            entity.Property(e => e.BoxCoded).HasColumnName("box_coded");
            entity.Property(e => e.BoxMoney).HasColumnName("box_money");
            entity.Property(e => e.BoxText)
                .HasColumnType("text")
                .HasColumnName("box_text");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_id");
            entity.Property(e => e.NpcOptionNpcflag).HasColumnName("npc_option_npcflag");
            entity.Property(e => e.OptionBroadcastText)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("option_broadcast_text");
            entity.Property(e => e.OptionIcon)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("option_icon");
            entity.Property(e => e.OptionId).HasColumnName("option_id");
            entity.Property(e => e.OptionText)
                .HasColumnType("text")
                .HasColumnName("option_text");
        });

        modelBuilder.Entity<GossipScript>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("gossip_scripts");

            entity.Property(e => e.Command).HasColumnName("command");
            entity.Property(e => e.Comments)
                .HasMaxLength(255)
                .HasColumnName("comments");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_id");
            entity.Property(e => e.DataFlags).HasColumnName("data_flags");
            entity.Property(e => e.Dataint).HasColumnName("dataint");
            entity.Property(e => e.Dataint2).HasColumnName("dataint2");
            entity.Property(e => e.Dataint3).HasColumnName("dataint3");
            entity.Property(e => e.Dataint4).HasColumnName("dataint4");
            entity.Property(e => e.Datalong).HasColumnName("datalong");
            entity.Property(e => e.Datalong2).HasColumnName("datalong2");
            entity.Property(e => e.Datalong3).HasColumnName("datalong3");
            entity.Property(e => e.Datalong4).HasColumnName("datalong4");
            entity.Property(e => e.Delay).HasColumnName("delay");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.O).HasColumnName("o");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.TargetParam1).HasColumnName("target_param1");
            entity.Property(e => e.TargetParam2).HasColumnName("target_param2");
            entity.Property(e => e.TargetType).HasColumnName("target_type");
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
            entity.Property(e => e.Z).HasColumnName("z");
        });

        modelBuilder.Entity<InstanceBuffRemoval>(entity =>
        {
            entity.HasKey(e => new { e.MapId, e.SpellId }).HasName("PRIMARY");

            entity.ToTable("instance_buff_removal", tb => tb.HasComment("Aura removal on map entry"));

            entity.Property(e => e.MapId)
                .HasComment("MapId to remove aura from")
                .HasColumnName("map_id");
            entity.Property(e => e.SpellId)
                .HasComment("aura id to remove on entering MapId")
                .HasColumnName("spell_id");
            entity.Property(e => e.Comment)
                .HasMaxLength(256)
                .HasComment("description, what is removed")
                .HasColumnName("comment");
            entity.Property(e => e.Enabled)
                .HasComment("aura removal enabled or not")
                .HasColumnName("enabled");
            entity.Property(e => e.Flags)
                .HasComment("flags, see AuraRemovalMgr.h")
                .HasColumnName("flags");
        });

        modelBuilder.Entity<ItemDisplayInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("item_display_info");

            entity.Property(e => e.Icon)
                .HasMaxLength(255)
                .HasColumnName("icon");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<ItemEnchantmentTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Ench, e.PatchMin, e.PatchMax }).HasName("PRIMARY");

            entity.ToTable("item_enchantment_template", tb => tb.HasComment("Item Random Enchantment System"));

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Ench)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("ench");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to load this entry")
                .HasColumnName("patch_max");
        });

        modelBuilder.Entity<ItemLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item, e.PatchMin, e.PatchMax }).HasName("PRIMARY");

            entity.ToTable("item_loot_template", tb => tb.HasComment("Loot System"));

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Item)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("item");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to load this entry")
                .HasColumnName("patch_max");
            entity.Property(e => e.ChanceOrQuestChance).HasDefaultValueSql("'100'");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_id");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Maxcount)
                .HasDefaultValueSql("'1'")
                .HasColumnName("maxcount");
            entity.Property(e => e.MincountOrRef)
                .HasDefaultValueSql("'1'")
                .HasColumnType("mediumint")
                .HasColumnName("mincountOrRef");
        });

        modelBuilder.Entity<ItemRequiredTarget>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("item_required_target");

            entity.HasIndex(e => new { e.Entry, e.Type, e.TargetEntry }, "entry_type_target").IsUnique();

            entity.Property(e => e.Entry)
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.TargetEntry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("target_entry");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<ItemTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Patch }).HasName("PRIMARY");

            entity.ToTable("item_template", tb => tb.HasComment("Item System"));

            entity.HasIndex(e => e.Class, "items_index");

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Patch)
                .HasComment("Content patch in which this exact version of the entry was added")
                .HasColumnName("patch");
            entity.Property(e => e.AllowableClass)
                .HasDefaultValueSql("'-1'")
                .HasColumnType("mediumint")
                .HasColumnName("allowable_class");
            entity.Property(e => e.AllowableRace)
                .HasDefaultValueSql("'-1'")
                .HasColumnType("mediumint")
                .HasColumnName("allowable_race");
            entity.Property(e => e.AmmoType).HasColumnName("ammo_type");
            entity.Property(e => e.ArcaneRes).HasColumnName("arcane_res");
            entity.Property(e => e.AreaBound)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("area_bound");
            entity.Property(e => e.Armor).HasColumnName("armor");
            entity.Property(e => e.BagFamily)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("bag_family");
            entity.Property(e => e.Block)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("block");
            entity.Property(e => e.Bonding).HasColumnName("bonding");
            entity.Property(e => e.BuyCount)
                .HasDefaultValueSql("'1'")
                .HasColumnName("buy_count");
            entity.Property(e => e.BuyPrice).HasColumnName("buy_price");
            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.ContainerSlots).HasColumnName("container_slots");
            entity.Property(e => e.Delay)
                .HasDefaultValueSql("'1000'")
                .HasColumnName("delay");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            entity.Property(e => e.DisenchantId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("disenchant_id");
            entity.Property(e => e.DisplayId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("display_id");
            entity.Property(e => e.DmgMax1).HasColumnName("dmg_max1");
            entity.Property(e => e.DmgMax2).HasColumnName("dmg_max2");
            entity.Property(e => e.DmgMax3).HasColumnName("dmg_max3");
            entity.Property(e => e.DmgMax4).HasColumnName("dmg_max4");
            entity.Property(e => e.DmgMax5).HasColumnName("dmg_max5");
            entity.Property(e => e.DmgMin1).HasColumnName("dmg_min1");
            entity.Property(e => e.DmgMin2).HasColumnName("dmg_min2");
            entity.Property(e => e.DmgMin3).HasColumnName("dmg_min3");
            entity.Property(e => e.DmgMin4).HasColumnName("dmg_min4");
            entity.Property(e => e.DmgMin5).HasColumnName("dmg_min5");
            entity.Property(e => e.DmgType1).HasColumnName("dmg_type1");
            entity.Property(e => e.DmgType2).HasColumnName("dmg_type2");
            entity.Property(e => e.DmgType3).HasColumnName("dmg_type3");
            entity.Property(e => e.DmgType4).HasColumnName("dmg_type4");
            entity.Property(e => e.DmgType5).HasColumnName("dmg_type5");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.ExtraFlags).HasColumnName("extra_flags");
            entity.Property(e => e.FireRes).HasColumnName("fire_res");
            entity.Property(e => e.Flags).HasColumnName("flags");
            entity.Property(e => e.FoodType).HasColumnName("food_type");
            entity.Property(e => e.FrostRes).HasColumnName("frost_res");
            entity.Property(e => e.HolyRes).HasColumnName("holy_res");
            entity.Property(e => e.InventoryType).HasColumnName("inventory_type");
            entity.Property(e => e.ItemLevel).HasColumnName("item_level");
            entity.Property(e => e.LockId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("lock_id");
            entity.Property(e => e.MapBound).HasColumnName("map_bound");
            entity.Property(e => e.Material).HasColumnName("material");
            entity.Property(e => e.MaxCount).HasColumnName("max_count");
            entity.Property(e => e.MaxDurability).HasColumnName("max_durability");
            entity.Property(e => e.MaxMoneyLoot).HasColumnName("max_money_loot");
            entity.Property(e => e.MinMoneyLoot).HasColumnName("min_money_loot");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.NatureRes).HasColumnName("nature_res");
            entity.Property(e => e.OtherTeamEntry)
                .HasDefaultValueSql("'1'")
                .HasColumnName("other_team_entry");
            entity.Property(e => e.PageLanguage).HasColumnName("page_language");
            entity.Property(e => e.PageMaterial).HasColumnName("page_material");
            entity.Property(e => e.PageText)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("page_text");
            entity.Property(e => e.Quality).HasColumnName("quality");
            entity.Property(e => e.RandomProperty)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("random_property");
            entity.Property(e => e.RangeMod).HasColumnName("range_mod");
            entity.Property(e => e.RequiredCityRank)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("required_city_rank");
            entity.Property(e => e.RequiredHonorRank)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("required_honor_rank");
            entity.Property(e => e.RequiredLevel).HasColumnName("required_level");
            entity.Property(e => e.RequiredReputationFaction).HasColumnName("required_reputation_faction");
            entity.Property(e => e.RequiredReputationRank).HasColumnName("required_reputation_rank");
            entity.Property(e => e.RequiredSkill).HasColumnName("required_skill");
            entity.Property(e => e.RequiredSkillRank).HasColumnName("required_skill_rank");
            entity.Property(e => e.RequiredSpell).HasColumnName("required_spell");
            entity.Property(e => e.SellPrice).HasColumnName("sell_price");
            entity.Property(e => e.SetId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("set_id");
            entity.Property(e => e.ShadowRes).HasColumnName("shadow_res");
            entity.Property(e => e.Sheath).HasColumnName("sheath");
            entity.Property(e => e.Spellcategory1).HasColumnName("spellcategory_1");
            entity.Property(e => e.Spellcategory2).HasColumnName("spellcategory_2");
            entity.Property(e => e.Spellcategory3).HasColumnName("spellcategory_3");
            entity.Property(e => e.Spellcategory4).HasColumnName("spellcategory_4");
            entity.Property(e => e.Spellcategory5).HasColumnName("spellcategory_5");
            entity.Property(e => e.Spellcategorycooldown1)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcategorycooldown_1");
            entity.Property(e => e.Spellcategorycooldown2)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcategorycooldown_2");
            entity.Property(e => e.Spellcategorycooldown3)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcategorycooldown_3");
            entity.Property(e => e.Spellcategorycooldown4)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcategorycooldown_4");
            entity.Property(e => e.Spellcategorycooldown5)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcategorycooldown_5");
            entity.Property(e => e.Spellcharges1).HasColumnName("spellcharges_1");
            entity.Property(e => e.Spellcharges2).HasColumnName("spellcharges_2");
            entity.Property(e => e.Spellcharges3).HasColumnName("spellcharges_3");
            entity.Property(e => e.Spellcharges4).HasColumnName("spellcharges_4");
            entity.Property(e => e.Spellcharges5).HasColumnName("spellcharges_5");
            entity.Property(e => e.Spellcooldown1)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcooldown_1");
            entity.Property(e => e.Spellcooldown2)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcooldown_2");
            entity.Property(e => e.Spellcooldown3)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcooldown_3");
            entity.Property(e => e.Spellcooldown4)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcooldown_4");
            entity.Property(e => e.Spellcooldown5)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcooldown_5");
            entity.Property(e => e.Spellid1).HasColumnName("spellid_1");
            entity.Property(e => e.Spellid2).HasColumnName("spellid_2");
            entity.Property(e => e.Spellid3).HasColumnName("spellid_3");
            entity.Property(e => e.Spellid4).HasColumnName("spellid_4");
            entity.Property(e => e.Spellid5).HasColumnName("spellid_5");
            entity.Property(e => e.Spellppmrate1).HasColumnName("spellppmrate_1");
            entity.Property(e => e.Spellppmrate2).HasColumnName("spellppmrate_2");
            entity.Property(e => e.Spellppmrate3).HasColumnName("spellppmrate_3");
            entity.Property(e => e.Spellppmrate4).HasColumnName("spellppmrate_4");
            entity.Property(e => e.Spellppmrate5).HasColumnName("spellppmrate_5");
            entity.Property(e => e.Spelltrigger1).HasColumnName("spelltrigger_1");
            entity.Property(e => e.Spelltrigger2).HasColumnName("spelltrigger_2");
            entity.Property(e => e.Spelltrigger3).HasColumnName("spelltrigger_3");
            entity.Property(e => e.Spelltrigger4).HasColumnName("spelltrigger_4");
            entity.Property(e => e.Spelltrigger5).HasColumnName("spelltrigger_5");
            entity.Property(e => e.Stackable)
                .HasDefaultValueSql("'1'")
                .HasColumnName("stackable");
            entity.Property(e => e.StartQuest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("start_quest");
            entity.Property(e => e.StatType1).HasColumnName("stat_type1");
            entity.Property(e => e.StatType10).HasColumnName("stat_type10");
            entity.Property(e => e.StatType2).HasColumnName("stat_type2");
            entity.Property(e => e.StatType3).HasColumnName("stat_type3");
            entity.Property(e => e.StatType4).HasColumnName("stat_type4");
            entity.Property(e => e.StatType5).HasColumnName("stat_type5");
            entity.Property(e => e.StatType6).HasColumnName("stat_type6");
            entity.Property(e => e.StatType7).HasColumnName("stat_type7");
            entity.Property(e => e.StatType8).HasColumnName("stat_type8");
            entity.Property(e => e.StatType9).HasColumnName("stat_type9");
            entity.Property(e => e.StatValue1).HasColumnName("stat_value1");
            entity.Property(e => e.StatValue10).HasColumnName("stat_value10");
            entity.Property(e => e.StatValue2).HasColumnName("stat_value2");
            entity.Property(e => e.StatValue3).HasColumnName("stat_value3");
            entity.Property(e => e.StatValue4).HasColumnName("stat_value4");
            entity.Property(e => e.StatValue5).HasColumnName("stat_value5");
            entity.Property(e => e.StatValue6).HasColumnName("stat_value6");
            entity.Property(e => e.StatValue7).HasColumnName("stat_value7");
            entity.Property(e => e.StatValue8).HasColumnName("stat_value8");
            entity.Property(e => e.StatValue9).HasColumnName("stat_value9");
            entity.Property(e => e.Subclass).HasColumnName("subclass");
            entity.Property(e => e.WrappedGift)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("wrapped_gift");
        });

        modelBuilder.Entity<LocalesArea>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("locales_area");

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint");
            entity.Property(e => e.NameLoc1)
                .HasMaxLength(100)
                .HasDefaultValueSql("''");
            entity.Property(e => e.NameLoc2)
                .HasMaxLength(100)
                .HasDefaultValueSql("''");
            entity.Property(e => e.NameLoc3)
                .HasMaxLength(100)
                .HasDefaultValueSql("''");
            entity.Property(e => e.NameLoc4)
                .HasMaxLength(100)
                .HasDefaultValueSql("''");
            entity.Property(e => e.NameLoc5)
                .HasMaxLength(100)
                .HasDefaultValueSql("''");
            entity.Property(e => e.NameLoc6)
                .HasMaxLength(100)
                .HasDefaultValueSql("''");
            entity.Property(e => e.NameLoc7)
                .HasMaxLength(100)
                .HasDefaultValueSql("''");
            entity.Property(e => e.NameLoc8)
                .HasMaxLength(100)
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<LocalesAreatrigger>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("locales_areatrigger");

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.MessageLoc1)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("message_loc1");
            entity.Property(e => e.MessageLoc2)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("message_loc2");
            entity.Property(e => e.MessageLoc3)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("message_loc3");
            entity.Property(e => e.MessageLoc4)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("message_loc4");
            entity.Property(e => e.MessageLoc5)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("message_loc5");
            entity.Property(e => e.MessageLoc6)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("message_loc6");
            entity.Property(e => e.MessageLoc7)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("message_loc7");
            entity.Property(e => e.MessageLoc8)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("message_loc8");
        });

        modelBuilder.Entity<LocalesBroadcastText>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("locales_broadcast_text");

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.FemaleTextLoc1).HasColumnName("female_text_loc1");
            entity.Property(e => e.FemaleTextLoc2).HasColumnName("female_text_loc2");
            entity.Property(e => e.FemaleTextLoc3).HasColumnName("female_text_loc3");
            entity.Property(e => e.FemaleTextLoc4).HasColumnName("female_text_loc4");
            entity.Property(e => e.FemaleTextLoc5).HasColumnName("female_text_loc5");
            entity.Property(e => e.FemaleTextLoc6).HasColumnName("female_text_loc6");
            entity.Property(e => e.FemaleTextLoc7).HasColumnName("female_text_loc7");
            entity.Property(e => e.FemaleTextLoc8).HasColumnName("female_text_loc8");
            entity.Property(e => e.MaleTextLoc1).HasColumnName("male_text_loc1");
            entity.Property(e => e.MaleTextLoc2).HasColumnName("male_text_loc2");
            entity.Property(e => e.MaleTextLoc3).HasColumnName("male_text_loc3");
            entity.Property(e => e.MaleTextLoc4).HasColumnName("male_text_loc4");
            entity.Property(e => e.MaleTextLoc5).HasColumnName("male_text_loc5");
            entity.Property(e => e.MaleTextLoc6).HasColumnName("male_text_loc6");
            entity.Property(e => e.MaleTextLoc7).HasColumnName("male_text_loc7");
            entity.Property(e => e.MaleTextLoc8).HasColumnName("male_text_loc8");
        });

        modelBuilder.Entity<LocalesCreature>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("locales_creature");

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.NameLoc1)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc1");
            entity.Property(e => e.NameLoc2)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc2");
            entity.Property(e => e.NameLoc3)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc3");
            entity.Property(e => e.NameLoc4)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc4");
            entity.Property(e => e.NameLoc5)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc5");
            entity.Property(e => e.NameLoc6)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc6");
            entity.Property(e => e.NameLoc7)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc7");
            entity.Property(e => e.NameLoc8)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc8");
            entity.Property(e => e.SubnameLoc1)
                .HasMaxLength(100)
                .HasColumnName("subname_loc1");
            entity.Property(e => e.SubnameLoc2)
                .HasMaxLength(100)
                .HasColumnName("subname_loc2");
            entity.Property(e => e.SubnameLoc3)
                .HasMaxLength(100)
                .HasColumnName("subname_loc3");
            entity.Property(e => e.SubnameLoc4)
                .HasMaxLength(100)
                .HasColumnName("subname_loc4");
            entity.Property(e => e.SubnameLoc5)
                .HasMaxLength(100)
                .HasColumnName("subname_loc5");
            entity.Property(e => e.SubnameLoc6)
                .HasMaxLength(100)
                .HasColumnName("subname_loc6");
            entity.Property(e => e.SubnameLoc7)
                .HasMaxLength(100)
                .HasColumnName("subname_loc7");
            entity.Property(e => e.SubnameLoc8)
                .HasMaxLength(100)
                .HasColumnName("subname_loc8");
        });

        modelBuilder.Entity<LocalesFaction>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("locales_faction");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.DescriptionLoc1)
                .HasMaxLength(512)
                .HasDefaultValueSql("''")
                .HasColumnName("description_loc1");
            entity.Property(e => e.DescriptionLoc2)
                .HasMaxLength(512)
                .HasDefaultValueSql("''")
                .HasColumnName("description_loc2");
            entity.Property(e => e.DescriptionLoc3)
                .HasMaxLength(512)
                .HasDefaultValueSql("''")
                .HasColumnName("description_loc3");
            entity.Property(e => e.DescriptionLoc4)
                .HasMaxLength(512)
                .HasDefaultValueSql("''")
                .HasColumnName("description_loc4");
            entity.Property(e => e.DescriptionLoc5)
                .HasMaxLength(512)
                .HasDefaultValueSql("''")
                .HasColumnName("description_loc5");
            entity.Property(e => e.DescriptionLoc6)
                .HasMaxLength(512)
                .HasDefaultValueSql("''")
                .HasColumnName("description_loc6");
            entity.Property(e => e.NameLoc1)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc1");
            entity.Property(e => e.NameLoc2)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc2");
            entity.Property(e => e.NameLoc3)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc3");
            entity.Property(e => e.NameLoc4)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc4");
            entity.Property(e => e.NameLoc5)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc5");
            entity.Property(e => e.NameLoc6)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc6");
        });

        modelBuilder.Entity<LocalesGameobject>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("locales_gameobject");

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.NameLoc1)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc1");
            entity.Property(e => e.NameLoc2)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc2");
            entity.Property(e => e.NameLoc3)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc3");
            entity.Property(e => e.NameLoc4)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc4");
            entity.Property(e => e.NameLoc5)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc5");
            entity.Property(e => e.NameLoc6)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc6");
            entity.Property(e => e.NameLoc7)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc7");
            entity.Property(e => e.NameLoc8)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc8");
        });

        modelBuilder.Entity<LocalesGossipMenuOption>(entity =>
        {
            entity.HasKey(e => new { e.MenuId, e.Id }).HasName("PRIMARY");

            entity.ToTable("locales_gossip_menu_option");

            entity.Property(e => e.MenuId).HasColumnName("menu_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BoxTextLoc1)
                .HasColumnType("text")
                .HasColumnName("box_text_loc1");
            entity.Property(e => e.BoxTextLoc2)
                .HasColumnType("text")
                .HasColumnName("box_text_loc2");
            entity.Property(e => e.BoxTextLoc3)
                .HasColumnType("text")
                .HasColumnName("box_text_loc3");
            entity.Property(e => e.BoxTextLoc4)
                .HasColumnType("text")
                .HasColumnName("box_text_loc4");
            entity.Property(e => e.BoxTextLoc5)
                .HasColumnType("text")
                .HasColumnName("box_text_loc5");
            entity.Property(e => e.BoxTextLoc6)
                .HasColumnType("text")
                .HasColumnName("box_text_loc6");
            entity.Property(e => e.BoxTextLoc7)
                .HasColumnType("text")
                .HasColumnName("box_text_loc7");
            entity.Property(e => e.BoxTextLoc8)
                .HasColumnType("text")
                .HasColumnName("box_text_loc8");
            entity.Property(e => e.OptionTextLoc1)
                .HasColumnType("text")
                .HasColumnName("option_text_loc1");
            entity.Property(e => e.OptionTextLoc2)
                .HasColumnType("text")
                .HasColumnName("option_text_loc2");
            entity.Property(e => e.OptionTextLoc3)
                .HasColumnType("text")
                .HasColumnName("option_text_loc3");
            entity.Property(e => e.OptionTextLoc4)
                .HasColumnType("text")
                .HasColumnName("option_text_loc4");
            entity.Property(e => e.OptionTextLoc5)
                .HasColumnType("text")
                .HasColumnName("option_text_loc5");
            entity.Property(e => e.OptionTextLoc6)
                .HasColumnType("text")
                .HasColumnName("option_text_loc6");
            entity.Property(e => e.OptionTextLoc7)
                .HasColumnType("text")
                .HasColumnName("option_text_loc7");
            entity.Property(e => e.OptionTextLoc8)
                .HasColumnType("text")
                .HasColumnName("option_text_loc8");
        });

        modelBuilder.Entity<LocalesItem>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("locales_item");

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.DescriptionLoc1)
                .HasMaxLength(255)
                .HasColumnName("description_loc1");
            entity.Property(e => e.DescriptionLoc2)
                .HasMaxLength(255)
                .HasColumnName("description_loc2");
            entity.Property(e => e.DescriptionLoc3)
                .HasMaxLength(255)
                .HasColumnName("description_loc3");
            entity.Property(e => e.DescriptionLoc4)
                .HasMaxLength(255)
                .HasColumnName("description_loc4");
            entity.Property(e => e.DescriptionLoc5)
                .HasMaxLength(255)
                .HasColumnName("description_loc5");
            entity.Property(e => e.DescriptionLoc6)
                .HasMaxLength(255)
                .HasColumnName("description_loc6");
            entity.Property(e => e.DescriptionLoc7)
                .HasMaxLength(255)
                .HasColumnName("description_loc7");
            entity.Property(e => e.DescriptionLoc8)
                .HasMaxLength(255)
                .HasColumnName("description_loc8");
            entity.Property(e => e.NameLoc1)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc1");
            entity.Property(e => e.NameLoc2)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc2");
            entity.Property(e => e.NameLoc3)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc3");
            entity.Property(e => e.NameLoc4)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc4");
            entity.Property(e => e.NameLoc5)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc5");
            entity.Property(e => e.NameLoc6)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc6");
            entity.Property(e => e.NameLoc7)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc7");
            entity.Property(e => e.NameLoc8)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc8");
        });

        modelBuilder.Entity<LocalesPageText>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("locales_page_text");

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.TextLoc1).HasColumnName("Text_loc1");
            entity.Property(e => e.TextLoc2).HasColumnName("Text_loc2");
            entity.Property(e => e.TextLoc3).HasColumnName("Text_loc3");
            entity.Property(e => e.TextLoc4).HasColumnName("Text_loc4");
            entity.Property(e => e.TextLoc5).HasColumnName("Text_loc5");
            entity.Property(e => e.TextLoc6).HasColumnName("Text_loc6");
            entity.Property(e => e.TextLoc7).HasColumnName("Text_loc7");
            entity.Property(e => e.TextLoc8).HasColumnName("Text_loc8");
        });

        modelBuilder.Entity<LocalesPointsOfInterest>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("locales_points_of_interest");

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.IconNameLoc1)
                .HasColumnType("text")
                .HasColumnName("icon_name_loc1");
            entity.Property(e => e.IconNameLoc2)
                .HasColumnType("text")
                .HasColumnName("icon_name_loc2");
            entity.Property(e => e.IconNameLoc3)
                .HasColumnType("text")
                .HasColumnName("icon_name_loc3");
            entity.Property(e => e.IconNameLoc4)
                .HasColumnType("text")
                .HasColumnName("icon_name_loc4");
            entity.Property(e => e.IconNameLoc5)
                .HasColumnType("text")
                .HasColumnName("icon_name_loc5");
            entity.Property(e => e.IconNameLoc6)
                .HasColumnType("text")
                .HasColumnName("icon_name_loc6");
            entity.Property(e => e.IconNameLoc7)
                .HasColumnType("text")
                .HasColumnName("icon_name_loc7");
            entity.Property(e => e.IconNameLoc8)
                .HasColumnType("text")
                .HasColumnName("icon_name_loc8");
        });

        modelBuilder.Entity<LocalesQuest>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("locales_quest");

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.DetailsLoc1)
                .HasColumnType("text")
                .HasColumnName("Details_loc1");
            entity.Property(e => e.DetailsLoc2)
                .HasColumnType("text")
                .HasColumnName("Details_loc2");
            entity.Property(e => e.DetailsLoc3)
                .HasColumnType("text")
                .HasColumnName("Details_loc3");
            entity.Property(e => e.DetailsLoc4)
                .HasColumnType("text")
                .HasColumnName("Details_loc4");
            entity.Property(e => e.DetailsLoc5)
                .HasColumnType("text")
                .HasColumnName("Details_loc5");
            entity.Property(e => e.DetailsLoc6)
                .HasColumnType("text")
                .HasColumnName("Details_loc6");
            entity.Property(e => e.DetailsLoc7)
                .HasColumnType("text")
                .HasColumnName("Details_loc7");
            entity.Property(e => e.DetailsLoc8)
                .HasColumnType("text")
                .HasColumnName("Details_loc8");
            entity.Property(e => e.EndTextLoc1)
                .HasColumnType("text")
                .HasColumnName("EndText_loc1");
            entity.Property(e => e.EndTextLoc2)
                .HasColumnType("text")
                .HasColumnName("EndText_loc2");
            entity.Property(e => e.EndTextLoc3)
                .HasColumnType("text")
                .HasColumnName("EndText_loc3");
            entity.Property(e => e.EndTextLoc4)
                .HasColumnType("text")
                .HasColumnName("EndText_loc4");
            entity.Property(e => e.EndTextLoc5)
                .HasColumnType("text")
                .HasColumnName("EndText_loc5");
            entity.Property(e => e.EndTextLoc6)
                .HasColumnType("text")
                .HasColumnName("EndText_loc6");
            entity.Property(e => e.EndTextLoc7)
                .HasColumnType("text")
                .HasColumnName("EndText_loc7");
            entity.Property(e => e.EndTextLoc8)
                .HasColumnType("text")
                .HasColumnName("EndText_loc8");
            entity.Property(e => e.ObjectiveText1Loc1)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText1_loc1");
            entity.Property(e => e.ObjectiveText1Loc2)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText1_loc2");
            entity.Property(e => e.ObjectiveText1Loc3)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText1_loc3");
            entity.Property(e => e.ObjectiveText1Loc4)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText1_loc4");
            entity.Property(e => e.ObjectiveText1Loc5)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText1_loc5");
            entity.Property(e => e.ObjectiveText1Loc6)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText1_loc6");
            entity.Property(e => e.ObjectiveText1Loc7)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText1_loc7");
            entity.Property(e => e.ObjectiveText1Loc8)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText1_loc8");
            entity.Property(e => e.ObjectiveText2Loc1)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText2_loc1");
            entity.Property(e => e.ObjectiveText2Loc2)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText2_loc2");
            entity.Property(e => e.ObjectiveText2Loc3)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText2_loc3");
            entity.Property(e => e.ObjectiveText2Loc4)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText2_loc4");
            entity.Property(e => e.ObjectiveText2Loc5)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText2_loc5");
            entity.Property(e => e.ObjectiveText2Loc6)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText2_loc6");
            entity.Property(e => e.ObjectiveText2Loc7)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText2_loc7");
            entity.Property(e => e.ObjectiveText2Loc8)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText2_loc8");
            entity.Property(e => e.ObjectiveText3Loc1)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText3_loc1");
            entity.Property(e => e.ObjectiveText3Loc2)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText3_loc2");
            entity.Property(e => e.ObjectiveText3Loc3)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText3_loc3");
            entity.Property(e => e.ObjectiveText3Loc4)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText3_loc4");
            entity.Property(e => e.ObjectiveText3Loc5)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText3_loc5");
            entity.Property(e => e.ObjectiveText3Loc6)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText3_loc6");
            entity.Property(e => e.ObjectiveText3Loc7)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText3_loc7");
            entity.Property(e => e.ObjectiveText3Loc8)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText3_loc8");
            entity.Property(e => e.ObjectiveText4Loc1)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText4_loc1");
            entity.Property(e => e.ObjectiveText4Loc2)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText4_loc2");
            entity.Property(e => e.ObjectiveText4Loc3)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText4_loc3");
            entity.Property(e => e.ObjectiveText4Loc4)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText4_loc4");
            entity.Property(e => e.ObjectiveText4Loc5)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText4_loc5");
            entity.Property(e => e.ObjectiveText4Loc6)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText4_loc6");
            entity.Property(e => e.ObjectiveText4Loc7)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText4_loc7");
            entity.Property(e => e.ObjectiveText4Loc8)
                .HasColumnType("text")
                .HasColumnName("ObjectiveText4_loc8");
            entity.Property(e => e.ObjectivesLoc1)
                .HasColumnType("text")
                .HasColumnName("Objectives_loc1");
            entity.Property(e => e.ObjectivesLoc2)
                .HasColumnType("text")
                .HasColumnName("Objectives_loc2");
            entity.Property(e => e.ObjectivesLoc3)
                .HasColumnType("text")
                .HasColumnName("Objectives_loc3");
            entity.Property(e => e.ObjectivesLoc4)
                .HasColumnType("text")
                .HasColumnName("Objectives_loc4");
            entity.Property(e => e.ObjectivesLoc5)
                .HasColumnType("text")
                .HasColumnName("Objectives_loc5");
            entity.Property(e => e.ObjectivesLoc6)
                .HasColumnType("text")
                .HasColumnName("Objectives_loc6");
            entity.Property(e => e.ObjectivesLoc7)
                .HasColumnType("text")
                .HasColumnName("Objectives_loc7");
            entity.Property(e => e.ObjectivesLoc8)
                .HasColumnType("text")
                .HasColumnName("Objectives_loc8");
            entity.Property(e => e.OfferRewardTextLoc1)
                .HasColumnType("text")
                .HasColumnName("OfferRewardText_loc1");
            entity.Property(e => e.OfferRewardTextLoc2)
                .HasColumnType("text")
                .HasColumnName("OfferRewardText_loc2");
            entity.Property(e => e.OfferRewardTextLoc3)
                .HasColumnType("text")
                .HasColumnName("OfferRewardText_loc3");
            entity.Property(e => e.OfferRewardTextLoc4)
                .HasColumnType("text")
                .HasColumnName("OfferRewardText_loc4");
            entity.Property(e => e.OfferRewardTextLoc5)
                .HasColumnType("text")
                .HasColumnName("OfferRewardText_loc5");
            entity.Property(e => e.OfferRewardTextLoc6)
                .HasColumnType("text")
                .HasColumnName("OfferRewardText_loc6");
            entity.Property(e => e.OfferRewardTextLoc7)
                .HasColumnType("text")
                .HasColumnName("OfferRewardText_loc7");
            entity.Property(e => e.OfferRewardTextLoc8)
                .HasColumnType("text")
                .HasColumnName("OfferRewardText_loc8");
            entity.Property(e => e.RequestItemsTextLoc1)
                .HasColumnType("text")
                .HasColumnName("RequestItemsText_loc1");
            entity.Property(e => e.RequestItemsTextLoc2)
                .HasColumnType("text")
                .HasColumnName("RequestItemsText_loc2");
            entity.Property(e => e.RequestItemsTextLoc3)
                .HasColumnType("text")
                .HasColumnName("RequestItemsText_loc3");
            entity.Property(e => e.RequestItemsTextLoc4)
                .HasColumnType("text")
                .HasColumnName("RequestItemsText_loc4");
            entity.Property(e => e.RequestItemsTextLoc5)
                .HasColumnType("text")
                .HasColumnName("RequestItemsText_loc5");
            entity.Property(e => e.RequestItemsTextLoc6)
                .HasColumnType("text")
                .HasColumnName("RequestItemsText_loc6");
            entity.Property(e => e.RequestItemsTextLoc7)
                .HasColumnType("text")
                .HasColumnName("RequestItemsText_loc7");
            entity.Property(e => e.RequestItemsTextLoc8)
                .HasColumnType("text")
                .HasColumnName("RequestItemsText_loc8");
            entity.Property(e => e.TitleLoc1)
                .HasColumnType("text")
                .HasColumnName("Title_loc1");
            entity.Property(e => e.TitleLoc2)
                .HasColumnType("text")
                .HasColumnName("Title_loc2");
            entity.Property(e => e.TitleLoc3)
                .HasColumnType("text")
                .HasColumnName("Title_loc3");
            entity.Property(e => e.TitleLoc4)
                .HasColumnType("text")
                .HasColumnName("Title_loc4");
            entity.Property(e => e.TitleLoc5)
                .HasColumnType("text")
                .HasColumnName("Title_loc5");
            entity.Property(e => e.TitleLoc6)
                .HasColumnType("text")
                .HasColumnName("Title_loc6");
            entity.Property(e => e.TitleLoc7)
                .HasColumnType("text")
                .HasColumnName("Title_loc7");
            entity.Property(e => e.TitleLoc8)
                .HasColumnType("text")
                .HasColumnName("Title_loc8");
        });

        modelBuilder.Entity<LocalesSpell>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("locales_spell");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.AuraDescriptionLoc1)
                .HasMaxLength(512)
                .HasDefaultValueSql("''")
                .HasColumnName("auraDescription_loc1");
            entity.Property(e => e.AuraDescriptionLoc2)
                .HasMaxLength(512)
                .HasDefaultValueSql("''")
                .HasColumnName("auraDescription_loc2");
            entity.Property(e => e.AuraDescriptionLoc3)
                .HasMaxLength(512)
                .HasDefaultValueSql("''")
                .HasColumnName("auraDescription_loc3");
            entity.Property(e => e.AuraDescriptionLoc4)
                .HasMaxLength(512)
                .HasDefaultValueSql("''")
                .HasColumnName("auraDescription_loc4");
            entity.Property(e => e.AuraDescriptionLoc5)
                .HasMaxLength(512)
                .HasDefaultValueSql("''")
                .HasColumnName("auraDescription_loc5");
            entity.Property(e => e.AuraDescriptionLoc6)
                .HasMaxLength(512)
                .HasDefaultValueSql("''")
                .HasColumnName("auraDescription_loc6");
            entity.Property(e => e.DescriptionLoc1)
                .HasMaxLength(1024)
                .HasDefaultValueSql("''")
                .HasColumnName("description_loc1");
            entity.Property(e => e.DescriptionLoc2)
                .HasMaxLength(1024)
                .HasDefaultValueSql("''")
                .HasColumnName("description_loc2");
            entity.Property(e => e.DescriptionLoc3)
                .HasMaxLength(1024)
                .HasDefaultValueSql("''")
                .HasColumnName("description_loc3");
            entity.Property(e => e.DescriptionLoc4)
                .HasMaxLength(1024)
                .HasDefaultValueSql("''")
                .HasColumnName("description_loc4");
            entity.Property(e => e.DescriptionLoc5)
                .HasMaxLength(1024)
                .HasDefaultValueSql("''")
                .HasColumnName("description_loc5");
            entity.Property(e => e.DescriptionLoc6)
                .HasMaxLength(1024)
                .HasDefaultValueSql("''")
                .HasColumnName("description_loc6");
            entity.Property(e => e.NameLoc1)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc1");
            entity.Property(e => e.NameLoc2)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc2");
            entity.Property(e => e.NameLoc3)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc3");
            entity.Property(e => e.NameLoc4)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc4");
            entity.Property(e => e.NameLoc5)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc5");
            entity.Property(e => e.NameLoc6)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc6");
            entity.Property(e => e.NameSubtextLoc1)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("nameSubtext_loc1");
            entity.Property(e => e.NameSubtextLoc2)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("nameSubtext_loc2");
            entity.Property(e => e.NameSubtextLoc3)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("nameSubtext_loc3");
            entity.Property(e => e.NameSubtextLoc4)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("nameSubtext_loc4");
            entity.Property(e => e.NameSubtextLoc5)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("nameSubtext_loc5");
            entity.Property(e => e.NameSubtextLoc6)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("nameSubtext_loc6");
        });

        modelBuilder.Entity<LocalesTaxiNode>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("locales_taxi_node");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.NameLoc1)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc1");
            entity.Property(e => e.NameLoc2)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc2");
            entity.Property(e => e.NameLoc3)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc3");
            entity.Property(e => e.NameLoc4)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc4");
            entity.Property(e => e.NameLoc5)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc5");
            entity.Property(e => e.NameLoc6)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("name_loc6");
        });

        modelBuilder.Entity<MailLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item }).HasName("PRIMARY");

            entity.ToTable("mail_loot_template", tb => tb.HasComment("Loot System"));

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Item)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("item");
            entity.Property(e => e.ChanceOrQuestChance).HasDefaultValueSql("'100'");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_id");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Maxcount)
                .HasDefaultValueSql("'1'")
                .HasColumnName("maxcount");
            entity.Property(e => e.MincountOrRef)
                .HasDefaultValueSql("'1'")
                .HasColumnType("mediumint")
                .HasColumnName("mincountOrRef");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to load this entry")
                .HasColumnName("patch_max");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
        });

        modelBuilder.Entity<MailTextTemplate>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("mail_text_template");

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.ContentDefault)
                .HasColumnType("text")
                .HasColumnName("content_default");
            entity.Property(e => e.ContentLoc1)
                .HasColumnType("text")
                .HasColumnName("content_loc1");
            entity.Property(e => e.ContentLoc2)
                .HasColumnType("text")
                .HasColumnName("content_loc2");
            entity.Property(e => e.ContentLoc3)
                .HasColumnType("text")
                .HasColumnName("content_loc3");
            entity.Property(e => e.ContentLoc4)
                .HasColumnType("text")
                .HasColumnName("content_loc4");
            entity.Property(e => e.ContentLoc5)
                .HasColumnType("text")
                .HasColumnName("content_loc5");
            entity.Property(e => e.ContentLoc6)
                .HasColumnType("text")
                .HasColumnName("content_loc6");
            entity.Property(e => e.ContentLoc7)
                .HasColumnType("text")
                .HasColumnName("content_loc7");
        });

        modelBuilder.Entity<MangosString>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("mangos_string");

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.ContentDefault)
                .HasColumnType("text")
                .HasColumnName("content_default");
            entity.Property(e => e.ContentLoc1)
                .HasColumnType("text")
                .HasColumnName("content_loc1");
            entity.Property(e => e.ContentLoc2)
                .HasColumnType("text")
                .HasColumnName("content_loc2");
            entity.Property(e => e.ContentLoc3)
                .HasColumnType("text")
                .HasColumnName("content_loc3");
            entity.Property(e => e.ContentLoc4)
                .HasColumnType("text")
                .HasColumnName("content_loc4");
            entity.Property(e => e.ContentLoc5)
                .HasColumnType("text")
                .HasColumnName("content_loc5");
            entity.Property(e => e.ContentLoc6)
                .HasColumnType("text")
                .HasColumnName("content_loc6");
            entity.Property(e => e.ContentLoc7)
                .HasColumnType("text")
                .HasColumnName("content_loc7");
            entity.Property(e => e.ContentLoc8)
                .HasColumnType("text")
                .HasColumnName("content_loc8");
        });

        modelBuilder.Entity<MapLootDisabled>(entity =>
        {
            entity.HasKey(e => e.MapId).HasName("PRIMARY");

            entity.ToTable("map_loot_disabled");

            entity.Property(e => e.MapId).HasColumnName("map_id");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasColumnName("comment");
        });

        modelBuilder.Entity<MapTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Patch }).HasName("PRIMARY");

            entity.ToTable("map_template");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Patch)
                .HasComment("Content patch in which this exact version of the entry was added")
                .HasColumnName("patch");
            entity.Property(e => e.GhostEntranceMap)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("ghost_entrance_map");
            entity.Property(e => e.GhostEntranceX).HasColumnName("ghost_entrance_x");
            entity.Property(e => e.GhostEntranceY).HasColumnName("ghost_entrance_y");
            entity.Property(e => e.LinkedZone).HasColumnName("linked_zone");
            entity.Property(e => e.MapName)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("map_name");
            entity.Property(e => e.MapType).HasColumnName("map_type");
            entity.Property(e => e.Parent).HasColumnName("parent");
            entity.Property(e => e.PlayerLimit).HasColumnName("player_limit");
            entity.Property(e => e.ResetDelay).HasColumnName("reset_delay");
            entity.Property(e => e.ScriptName)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("script_name");
        });

        modelBuilder.Entity<Migration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("migrations");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<NpcGossip>(entity =>
        {
            entity.HasKey(e => e.NpcGuid).HasName("PRIMARY");

            entity.ToTable("npc_gossip");

            entity.Property(e => e.NpcGuid).HasColumnName("npc_guid");
            entity.Property(e => e.Textid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("textid");
        });

        modelBuilder.Entity<NpcText>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("npc_text");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("ID");
            entity.Property(e => e.BroadcastTextId0)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("BroadcastTextID0");
            entity.Property(e => e.BroadcastTextId1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("BroadcastTextID1");
            entity.Property(e => e.BroadcastTextId2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("BroadcastTextID2");
            entity.Property(e => e.BroadcastTextId3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("BroadcastTextID3");
            entity.Property(e => e.BroadcastTextId4)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("BroadcastTextID4");
            entity.Property(e => e.BroadcastTextId5)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("BroadcastTextID5");
            entity.Property(e => e.BroadcastTextId6)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("BroadcastTextID6");
            entity.Property(e => e.BroadcastTextId7)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("BroadcastTextID7");
        });

        modelBuilder.Entity<NpcTrainer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("npc_trainer");

            entity.HasIndex(e => new { e.Entry, e.Spell, e.BuildMax }, "entry_spell").IsUnique();

            entity.Property(e => e.BuildMax)
                .HasDefaultValueSql("'5875'")
                .HasComment("Maximum game client build to load this entry")
                .HasColumnName("build_max");
            entity.Property(e => e.BuildMin)
                .HasComment("Minimum game client build to load this entry")
                .HasColumnName("build_min");
            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Reqlevel).HasColumnName("reqlevel");
            entity.Property(e => e.Reqskill).HasColumnName("reqskill");
            entity.Property(e => e.Reqskillvalue).HasColumnName("reqskillvalue");
            entity.Property(e => e.Spell).HasColumnName("spell");
            entity.Property(e => e.Spellcost).HasColumnName("spellcost");
        });

        modelBuilder.Entity<NpcTrainerGreeting>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("npc_trainer_greeting");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.ContentDefault)
                .HasColumnType("text")
                .HasColumnName("content_default");
            entity.Property(e => e.ContentLoc1)
                .HasColumnType("text")
                .HasColumnName("content_loc1");
            entity.Property(e => e.ContentLoc2)
                .HasColumnType("text")
                .HasColumnName("content_loc2");
            entity.Property(e => e.ContentLoc3)
                .HasColumnType("text")
                .HasColumnName("content_loc3");
            entity.Property(e => e.ContentLoc4)
                .HasColumnType("text")
                .HasColumnName("content_loc4");
            entity.Property(e => e.ContentLoc5)
                .HasColumnType("text")
                .HasColumnName("content_loc5");
            entity.Property(e => e.ContentLoc6)
                .HasColumnType("text")
                .HasColumnName("content_loc6");
            entity.Property(e => e.ContentLoc7)
                .HasColumnType("text")
                .HasColumnName("content_loc7");
            entity.Property(e => e.ContentLoc8)
                .HasColumnType("text")
                .HasColumnName("content_loc8");
        });

        modelBuilder.Entity<NpcTrainerTemplate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("npc_trainer_template");

            entity.HasIndex(e => new { e.Entry, e.Spell, e.BuildMax }, "entry_spell").IsUnique();

            entity.Property(e => e.BuildMax)
                .HasDefaultValueSql("'5875'")
                .HasComment("Maximum game client build to load this entry")
                .HasColumnName("build_max");
            entity.Property(e => e.BuildMin)
                .HasComment("Minimum game client build to load this entry")
                .HasColumnName("build_min");
            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Reqlevel).HasColumnName("reqlevel");
            entity.Property(e => e.Reqskill).HasColumnName("reqskill");
            entity.Property(e => e.Reqskillvalue).HasColumnName("reqskillvalue");
            entity.Property(e => e.Spell).HasColumnName("spell");
            entity.Property(e => e.Spellcost).HasColumnName("spellcost");
        });

        modelBuilder.Entity<NpcVendor>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item }).HasName("PRIMARY");

            entity.ToTable("npc_vendor", tb => tb.HasComment("Npc System"));

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Item)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("item");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_id");
            entity.Property(e => e.Incrtime).HasColumnName("incrtime");
            entity.Property(e => e.Itemflags).HasColumnName("itemflags");
            entity.Property(e => e.Maxcount).HasColumnName("maxcount");
            entity.Property(e => e.Slot).HasColumnName("slot");
        });

        modelBuilder.Entity<NpcVendorTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item }).HasName("PRIMARY");

            entity.ToTable("npc_vendor_template", tb => tb.HasComment("Npc System"));

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Item)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("item");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_id");
            entity.Property(e => e.Incrtime).HasColumnName("incrtime");
            entity.Property(e => e.Itemflags).HasColumnName("itemflags");
            entity.Property(e => e.Maxcount).HasColumnName("maxcount");
            entity.Property(e => e.Slot).HasColumnName("slot");
        });

        modelBuilder.Entity<PageText>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("page_text", tb => tb.HasComment("Item System"));

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.NextPage)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("next_page");
            entity.Property(e => e.Text).HasColumnName("text");
        });

        modelBuilder.Entity<PetLevelstat>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Level }).HasName("PRIMARY");

            entity.ToTable("pet_levelstats", tb => tb.HasComment("Stores pet levels stats."));

            entity.Property(e => e.Entry)
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Agility).HasColumnName("agility");
            entity.Property(e => e.Armor).HasColumnName("armor");
            entity.Property(e => e.DmgMax).HasColumnName("dmg_max");
            entity.Property(e => e.DmgMin).HasColumnName("dmg_min");
            entity.Property(e => e.Health).HasColumnName("health");
            entity.Property(e => e.Intellect).HasColumnName("intellect");
            entity.Property(e => e.Mana).HasColumnName("mana");
            entity.Property(e => e.Spirit).HasColumnName("spirit");
            entity.Property(e => e.Stamina).HasColumnName("stamina");
            entity.Property(e => e.Strength).HasColumnName("strength");
        });

        modelBuilder.Entity<PetNameGeneration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("pet_name_generation");

            entity.Property(e => e.Id)
                .HasColumnType("mediumint unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Half).HasColumnName("half");
            entity.Property(e => e.Word)
                .HasColumnType("tinytext")
                .HasColumnName("word");
        });

        modelBuilder.Entity<PetSpellDatum>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Build }).HasName("PRIMARY");

            entity.ToTable("pet_spell_data");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Build).HasColumnName("build");
            entity.Property(e => e.SpellId1).HasColumnName("spell_id1");
            entity.Property(e => e.SpellId2).HasColumnName("spell_id2");
            entity.Property(e => e.SpellId3).HasColumnName("spell_id3");
            entity.Property(e => e.SpellId4).HasColumnName("spell_id4");
        });

        modelBuilder.Entity<PetcreateinfoSpell>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("petcreateinfo_spell", tb => tb.HasComment("Pet Create Spells"));

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to load this entry")
                .HasColumnName("patch_max");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
            entity.Property(e => e.Spell1).HasColumnName("spell1");
            entity.Property(e => e.Spell2).HasColumnName("spell2");
            entity.Property(e => e.Spell3).HasColumnName("spell3");
            entity.Property(e => e.Spell4).HasColumnName("spell4");
        });

        modelBuilder.Entity<PickpocketingLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item }).HasName("PRIMARY");

            entity.ToTable("pickpocketing_loot_template", tb => tb.HasComment("Loot System"));

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Item)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("item");
            entity.Property(e => e.ChanceOrQuestChance).HasDefaultValueSql("'100'");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_id");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Maxcount)
                .HasDefaultValueSql("'1'")
                .HasColumnName("maxcount");
            entity.Property(e => e.MincountOrRef)
                .HasDefaultValueSql("'1'")
                .HasColumnType("mediumint")
                .HasColumnName("mincountOrRef");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to load this entry")
                .HasColumnName("patch_max");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
        });

        modelBuilder.Entity<PlayerClasslevelstat>(entity =>
        {
            entity.HasKey(e => new { e.Class, e.Level }).HasName("PRIMARY");

            entity.ToTable("player_classlevelstats", tb => tb.HasComment("Stores levels stats."));

            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Basehp).HasColumnName("basehp");
            entity.Property(e => e.Basemana).HasColumnName("basemana");
        });

        modelBuilder.Entity<PlayerFactionchangeItem>(entity =>
        {
            entity.HasKey(e => new { e.AllianceId, e.HordeId }).HasName("PRIMARY");

            entity.ToTable("player_factionchange_items");

            entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            entity.Property(e => e.HordeId).HasColumnName("horde_id");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("comment");
        });

        modelBuilder.Entity<PlayerFactionchangeMount>(entity =>
        {
            entity.HasKey(e => new { e.RaceId, e.MountNum }).HasName("PRIMARY");

            entity.ToTable("player_factionchange_mounts");

            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<PlayerFactionchangeQuest>(entity =>
        {
            entity.HasKey(e => new { e.AllianceId, e.HordeId }).HasName("PRIMARY");

            entity.ToTable("player_factionchange_quests");

            entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            entity.Property(e => e.HordeId).HasColumnName("horde_id");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("comment");
        });

        modelBuilder.Entity<PlayerFactionchangeReputation>(entity =>
        {
            entity.HasKey(e => new { e.AllianceId, e.HordeId }).HasName("PRIMARY");

            entity.ToTable("player_factionchange_reputations");

            entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            entity.Property(e => e.HordeId).HasColumnName("horde_id");
        });

        modelBuilder.Entity<PlayerFactionchangeSpell>(entity =>
        {
            entity.HasKey(e => new { e.AllianceId, e.HordeId }).HasName("PRIMARY");

            entity.ToTable("player_factionchange_spells");

            entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            entity.Property(e => e.HordeId).HasColumnName("horde_id");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("comment");
        });

        modelBuilder.Entity<PlayerLevelstat>(entity =>
        {
            entity.HasKey(e => new { e.Race, e.Class, e.Level }).HasName("PRIMARY");

            entity.ToTable("player_levelstats", tb => tb.HasComment("Stores levels stats."));

            entity.Property(e => e.Race).HasColumnName("race");
            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Agi).HasColumnName("agi");
            entity.Property(e => e.Inte).HasColumnName("inte");
            entity.Property(e => e.Spi).HasColumnName("spi");
            entity.Property(e => e.Sta).HasColumnName("sta");
            entity.Property(e => e.Str).HasColumnName("str");
        });

        modelBuilder.Entity<PlayerPremadeItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("player_premade_item");

            entity.Property(e => e.Enchant).HasColumnName("enchant");
            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Item).HasColumnName("item");
            entity.Property(e => e.Team).HasColumnName("team");
        });

        modelBuilder.Entity<PlayerPremadeItemTemplate>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("player_premade_item_template");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Level)
                .HasDefaultValueSql("'60'")
                .HasColumnName("level");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Role).HasColumnName("role");
        });

        modelBuilder.Entity<PlayerPremadeSpell>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Spell }).HasName("PRIMARY");

            entity.ToTable("player_premade_spell");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Spell).HasColumnName("spell");
        });

        modelBuilder.Entity<PlayerPremadeSpellTemplate>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("player_premade_spell_template");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Level)
                .HasDefaultValueSql("'60'")
                .HasColumnName("level");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Role).HasColumnName("role");
        });

        modelBuilder.Entity<PlayerXpForLevel>(entity =>
        {
            entity.HasKey(e => e.Lvl).HasName("PRIMARY");

            entity.ToTable("player_xp_for_level");

            entity.Property(e => e.Lvl).HasColumnName("lvl");
            entity.Property(e => e.XpForNextLevel).HasColumnName("xp_for_next_level");
        });

        modelBuilder.Entity<Playercreateinfo>(entity =>
        {
            entity.HasKey(e => new { e.Race, e.Class }).HasName("PRIMARY");

            entity.ToTable("playercreateinfo");

            entity.Property(e => e.Race).HasColumnName("race");
            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Map).HasColumnName("map");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
            entity.Property(e => e.Zone)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("zone");
        });

        modelBuilder.Entity<PlayercreateinfoAction>(entity =>
        {
            entity.HasKey(e => new { e.Race, e.Class, e.Button }).HasName("PRIMARY");

            entity.ToTable("playercreateinfo_action");

            entity.HasIndex(e => new { e.Race, e.Class }, "playercreateinfo_race_class_index");

            entity.Property(e => e.Race).HasColumnName("race");
            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Button).HasColumnName("button");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<PlayercreateinfoItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("playercreateinfo_item");

            entity.HasIndex(e => new { e.Race, e.Class }, "playercreateinfo_race_class_index");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'1'")
                .HasColumnName("amount");
            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Itemid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("itemid");
            entity.Property(e => e.Race).HasColumnName("race");
        });

        modelBuilder.Entity<PlayercreateinfoSpell>(entity =>
        {
            entity.HasKey(e => new { e.Race, e.Class, e.Spell }).HasName("PRIMARY");

            entity.ToTable("playercreateinfo_spell");

            entity.Property(e => e.Race).HasColumnName("race");
            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Spell).HasColumnName("spell");
            entity.Property(e => e.BuildMax)
                .HasDefaultValueSql("'5875'")
                .HasComment("Maximum game client build to load this entry")
                .HasColumnName("build_max");
            entity.Property(e => e.BuildMin)
                .HasComment("Minimum game client build to load this entry")
                .HasColumnName("build_min");
            entity.Property(e => e.Note)
                .HasMaxLength(255)
                .HasColumnName("note");
        });

        modelBuilder.Entity<PointsOfInterest>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("points_of_interest");

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("data");
            entity.Property(e => e.Flags)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("flags");
            entity.Property(e => e.Icon)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("icon");
            entity.Property(e => e.IconName)
                .HasColumnType("text")
                .HasColumnName("icon_name");
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
        });

        modelBuilder.Entity<PoolCreature>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("pool_creature");

            entity.HasIndex(e => e.PoolEntry, "pool_idx");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Flags)
                .HasComment("FLAG_SPAWN_ENABLE_IF_WORLD_POP_OVER_BLIZZLIKE = 1")
                .HasColumnName("flags");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to load this entry")
                .HasColumnName("patch_max");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
            entity.Property(e => e.PoolEntry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("pool_entry");
        });

        modelBuilder.Entity<PoolCreatureTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("pool_creature_template");

            entity.HasIndex(e => e.PoolEntry, "pool_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Flags)
                .HasComment("FLAG_SPAWN_ENABLE_IF_WORLD_POP_OVER_BLIZZLIKE = 1")
                .HasColumnName("flags");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to load this entry")
                .HasColumnName("patch_max");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
            entity.Property(e => e.PoolEntry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("pool_entry");
        });

        modelBuilder.Entity<PoolGameobject>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("pool_gameobject");

            entity.HasIndex(e => e.PoolEntry, "pool_idx");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Flags)
                .HasComment("FLAG_SPAWN_ENABLE_IF_WORLD_POP_OVER_BLIZZLIKE = 1")
                .HasColumnName("flags");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to load this entry")
                .HasColumnName("patch_max");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
            entity.Property(e => e.PoolEntry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("pool_entry");
        });

        modelBuilder.Entity<PoolGameobjectTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("pool_gameobject_template");

            entity.HasIndex(e => e.PoolEntry, "pool_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Flags)
                .HasComment("FLAG_SPAWN_ENABLE_IF_WORLD_POP_OVER_BLIZZLIKE = 1")
                .HasColumnName("flags");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to load this entry")
                .HasColumnName("patch_max");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
            entity.Property(e => e.PoolEntry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("pool_entry");
        });

        modelBuilder.Entity<PoolPool>(entity =>
        {
            entity.HasKey(e => e.PoolId).HasName("PRIMARY");

            entity.ToTable("pool_pool");

            entity.HasIndex(e => e.MotherPool, "pool_idx");

            entity.Property(e => e.PoolId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("pool_id");
            entity.Property(e => e.Chance).HasColumnName("chance");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Flags)
                .HasComment("FLAG_SPAWN_ENABLE_IF_WORLD_POP_OVER_BLIZZLIKE = 1")
                .HasColumnName("flags");
            entity.Property(e => e.MotherPool)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("mother_pool");
        });

        modelBuilder.Entity<PoolTemplate>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("pool_template");

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasComment("Pool entry")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Flags).HasColumnName("flags");
            entity.Property(e => e.Instance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("instance");
            entity.Property(e => e.MaxLimit)
                .HasComment("Max number of objects (0) is no limit")
                .HasColumnName("max_limit");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to load this entry")
                .HasColumnName("patch_max");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
        });

        modelBuilder.Entity<QuestEndScript>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("quest_end_scripts");

            entity.Property(e => e.Command).HasColumnName("command");
            entity.Property(e => e.Comments)
                .HasMaxLength(255)
                .HasColumnName("comments");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_id");
            entity.Property(e => e.DataFlags).HasColumnName("data_flags");
            entity.Property(e => e.Dataint).HasColumnName("dataint");
            entity.Property(e => e.Dataint2).HasColumnName("dataint2");
            entity.Property(e => e.Dataint3).HasColumnName("dataint3");
            entity.Property(e => e.Dataint4).HasColumnName("dataint4");
            entity.Property(e => e.Datalong).HasColumnName("datalong");
            entity.Property(e => e.Datalong2).HasColumnName("datalong2");
            entity.Property(e => e.Datalong3).HasColumnName("datalong3");
            entity.Property(e => e.Datalong4).HasColumnName("datalong4");
            entity.Property(e => e.Delay).HasColumnName("delay");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.O).HasColumnName("o");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.TargetParam1).HasColumnName("target_param1");
            entity.Property(e => e.TargetParam2).HasColumnName("target_param2");
            entity.Property(e => e.TargetType).HasColumnName("target_type");
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
            entity.Property(e => e.Z).HasColumnName("z");
        });

        modelBuilder.Entity<QuestGreeting>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Type }).HasName("PRIMARY");

            entity.ToTable("quest_greeting");

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.ContentDefault)
                .HasColumnType("text")
                .HasColumnName("content_default");
            entity.Property(e => e.ContentLoc1)
                .HasColumnType("text")
                .HasColumnName("content_loc1");
            entity.Property(e => e.ContentLoc2)
                .HasColumnType("text")
                .HasColumnName("content_loc2");
            entity.Property(e => e.ContentLoc3)
                .HasColumnType("text")
                .HasColumnName("content_loc3");
            entity.Property(e => e.ContentLoc4)
                .HasColumnType("text")
                .HasColumnName("content_loc4");
            entity.Property(e => e.ContentLoc5)
                .HasColumnType("text")
                .HasColumnName("content_loc5");
            entity.Property(e => e.ContentLoc6)
                .HasColumnType("text")
                .HasColumnName("content_loc6");
            entity.Property(e => e.ContentLoc7)
                .HasColumnType("text")
                .HasColumnName("content_loc7");
            entity.Property(e => e.ContentLoc8)
                .HasColumnType("text")
                .HasColumnName("content_loc8");
            entity.Property(e => e.EmoteDelay).HasColumnName("emote_delay");
            entity.Property(e => e.EmoteId).HasColumnName("emote_id");
        });

        modelBuilder.Entity<QuestStartScript>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("quest_start_scripts");

            entity.Property(e => e.Command).HasColumnName("command");
            entity.Property(e => e.Comments)
                .HasMaxLength(255)
                .HasColumnName("comments");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_id");
            entity.Property(e => e.DataFlags).HasColumnName("data_flags");
            entity.Property(e => e.Dataint).HasColumnName("dataint");
            entity.Property(e => e.Dataint2).HasColumnName("dataint2");
            entity.Property(e => e.Dataint3).HasColumnName("dataint3");
            entity.Property(e => e.Dataint4).HasColumnName("dataint4");
            entity.Property(e => e.Datalong).HasColumnName("datalong");
            entity.Property(e => e.Datalong2).HasColumnName("datalong2");
            entity.Property(e => e.Datalong3).HasColumnName("datalong3");
            entity.Property(e => e.Datalong4).HasColumnName("datalong4");
            entity.Property(e => e.Delay).HasColumnName("delay");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.O).HasColumnName("o");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.TargetParam1).HasColumnName("target_param1");
            entity.Property(e => e.TargetParam2).HasColumnName("target_param2");
            entity.Property(e => e.TargetType).HasColumnName("target_type");
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
            entity.Property(e => e.Z).HasColumnName("z");
        });

        modelBuilder.Entity<QuestTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Patch }).HasName("PRIMARY");

            entity.ToTable("quest_template", tb => tb.HasComment("Quest System"));

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Patch)
                .HasComment("Content patch in which this exact version of the entry was added")
                .HasColumnName("patch");
            entity.Property(e => e.BreadcrumbForQuestId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.CompleteScript)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.Details).HasColumnType("text");
            entity.Property(e => e.EndText).HasColumnType("text");
            entity.Property(e => e.ExclusiveGroup)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint");
            entity.Property(e => e.Method).HasDefaultValueSql("'2'");
            entity.Property(e => e.NextQuestId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint");
            entity.Property(e => e.NextQuestInChain)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.ObjectiveText1).HasColumnType("text");
            entity.Property(e => e.ObjectiveText2).HasColumnType("text");
            entity.Property(e => e.ObjectiveText3).HasColumnType("text");
            entity.Property(e => e.ObjectiveText4).HasColumnType("text");
            entity.Property(e => e.Objectives).HasColumnType("text");
            entity.Property(e => e.OfferRewardText).HasColumnType("text");
            entity.Property(e => e.PointOpt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.PrevQuestId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint");
            entity.Property(e => e.RepObjectiveValue)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint");
            entity.Property(e => e.ReqCreatureOrGocount1).HasColumnName("ReqCreatureOrGOCount1");
            entity.Property(e => e.ReqCreatureOrGocount2).HasColumnName("ReqCreatureOrGOCount2");
            entity.Property(e => e.ReqCreatureOrGocount3).HasColumnName("ReqCreatureOrGOCount3");
            entity.Property(e => e.ReqCreatureOrGocount4).HasColumnName("ReqCreatureOrGOCount4");
            entity.Property(e => e.ReqCreatureOrGoid1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("ReqCreatureOrGOId1");
            entity.Property(e => e.ReqCreatureOrGoid2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("ReqCreatureOrGOId2");
            entity.Property(e => e.ReqCreatureOrGoid3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("ReqCreatureOrGOId3");
            entity.Property(e => e.ReqCreatureOrGoid4)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("ReqCreatureOrGOId4");
            entity.Property(e => e.ReqItemId1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.ReqItemId2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.ReqItemId3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.ReqItemId4)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.ReqSourceCount1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.ReqSourceCount2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.ReqSourceCount3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.ReqSourceCount4)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.ReqSourceId1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.ReqSourceId2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.ReqSourceId3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.ReqSourceId4)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.RequestItemsText).HasColumnType("text");
            entity.Property(e => e.RequiredCondition)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.RequiredMaxRepValue)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint");
            entity.Property(e => e.RequiredMinRepValue)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint");
            entity.Property(e => e.RewChoiceItemId1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.RewChoiceItemId2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.RewChoiceItemId3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.RewChoiceItemId4)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.RewChoiceItemId5)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.RewChoiceItemId6)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.RewItemId1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.RewItemId2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.RewItemId3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.RewItemId4)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.RewMailTemplateId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint");
            entity.Property(e => e.RewRepFaction1).HasComment("faction id from Faction.dbc in this case");
            entity.Property(e => e.RewRepFaction2).HasComment("faction id from Faction.dbc in this case");
            entity.Property(e => e.RewRepFaction3).HasComment("faction id from Faction.dbc in this case");
            entity.Property(e => e.RewRepFaction4).HasComment("faction id from Faction.dbc in this case");
            entity.Property(e => e.RewRepFaction5).HasComment("faction id from Faction.dbc in this case");
            entity.Property(e => e.RewRepValue1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint");
            entity.Property(e => e.RewRepValue2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint");
            entity.Property(e => e.RewRepValue3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint");
            entity.Property(e => e.RewRepValue4)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint");
            entity.Property(e => e.RewRepValue5)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint");
            entity.Property(e => e.RewXp)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("RewXP");
            entity.Property(e => e.SrcItemId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.StartScript)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.Title).HasColumnType("text");
        });

        modelBuilder.Entity<ReferenceLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item, e.PatchMin, e.PatchMax }).HasName("PRIMARY");

            entity.ToTable("reference_loot_template", tb => tb.HasComment("Loot System"));

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Item)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("item");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to load this entry")
                .HasColumnName("patch_max");
            entity.Property(e => e.ChanceOrQuestChance).HasDefaultValueSql("'100'");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_id");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Maxcount)
                .HasDefaultValueSql("'1'")
                .HasColumnName("maxcount");
            entity.Property(e => e.MincountOrRef)
                .HasDefaultValueSql("'1'")
                .HasColumnType("mediumint")
                .HasColumnName("mincountOrRef");
        });

        modelBuilder.Entity<ReputationRewardRate>(entity =>
        {
            entity.HasKey(e => e.Faction).HasName("PRIMARY");

            entity.ToTable("reputation_reward_rate");

            entity.Property(e => e.Faction)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("faction");
            entity.Property(e => e.CreatureRate)
                .HasDefaultValueSql("'1'")
                .HasColumnName("creature_rate");
            entity.Property(e => e.QuestRate)
                .HasDefaultValueSql("'1'")
                .HasColumnName("quest_rate");
            entity.Property(e => e.SpellRate)
                .HasDefaultValueSql("'1'")
                .HasColumnName("spell_rate");
        });

        modelBuilder.Entity<ReputationSpilloverTemplate>(entity =>
        {
            entity.HasKey(e => e.Faction).HasName("PRIMARY");

            entity.ToTable("reputation_spillover_template", tb => tb.HasComment("Reputation spillover reputation gain"));

            entity.Property(e => e.Faction)
                .HasComment("faction entry")
                .HasColumnName("faction");
            entity.Property(e => e.Faction1)
                .HasComment("faction to give spillover for")
                .HasColumnName("faction1");
            entity.Property(e => e.Faction2).HasColumnName("faction2");
            entity.Property(e => e.Faction3).HasColumnName("faction3");
            entity.Property(e => e.Faction4).HasColumnName("faction4");
            entity.Property(e => e.Rank1)
                .HasComment("max rank, above this will not give any spillover")
                .HasColumnName("rank_1");
            entity.Property(e => e.Rank2).HasColumnName("rank_2");
            entity.Property(e => e.Rank3).HasColumnName("rank_3");
            entity.Property(e => e.Rank4).HasColumnName("rank_4");
            entity.Property(e => e.Rate1)
                .HasComment("the given rep points * rate")
                .HasColumnName("rate_1");
            entity.Property(e => e.Rate2).HasColumnName("rate_2");
            entity.Property(e => e.Rate3).HasColumnName("rate_3");
            entity.Property(e => e.Rate4).HasColumnName("rate_4");
        });

        modelBuilder.Entity<ReservedName>(entity =>
        {
            entity.HasKey(e => e.Name).HasName("PRIMARY");

            entity.ToTable("reserved_name", tb => tb.HasComment("Player Reserved Names"));

            entity.Property(e => e.Name)
                .HasMaxLength(12)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
        });

        modelBuilder.Entity<ScriptEscortDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("script_escort_data");

            entity.HasIndex(e => e.CreatureId, "creature_id").IsUnique();

            entity.Property(e => e.CreatureId).HasColumnName("creature_id");
            entity.Property(e => e.EscortFaction).HasColumnName("escort_faction");
            entity.Property(e => e.Quest).HasColumnName("quest");
        });

        modelBuilder.Entity<ScriptText>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("script_texts", tb => tb.HasComment("Script Texts"));

            entity.Property(e => e.Entry)
                .HasColumnType("mediumint")
                .HasColumnName("entry");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.ContentDefault)
                .HasColumnType("text")
                .HasColumnName("content_default");
            entity.Property(e => e.ContentLoc1)
                .HasColumnType("text")
                .HasColumnName("content_loc1");
            entity.Property(e => e.ContentLoc2)
                .HasColumnType("text")
                .HasColumnName("content_loc2");
            entity.Property(e => e.ContentLoc3)
                .HasColumnType("text")
                .HasColumnName("content_loc3");
            entity.Property(e => e.ContentLoc4)
                .HasColumnType("text")
                .HasColumnName("content_loc4");
            entity.Property(e => e.ContentLoc5)
                .HasColumnType("text")
                .HasColumnName("content_loc5");
            entity.Property(e => e.ContentLoc6)
                .HasColumnType("text")
                .HasColumnName("content_loc6");
            entity.Property(e => e.ContentLoc7)
                .HasColumnType("text")
                .HasColumnName("content_loc7");
            entity.Property(e => e.ContentLoc8)
                .HasColumnType("text")
                .HasColumnName("content_loc8");
            entity.Property(e => e.Emote).HasColumnName("emote");
            entity.Property(e => e.Language).HasColumnName("language");
            entity.Property(e => e.Sound)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("sound");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<ScriptWaypoint>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Pointid }).HasName("PRIMARY");

            entity.ToTable("script_waypoint", tb => tb.HasComment("Script Creature waypoints"));

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasComment("creature_template entry")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Pointid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("pointid");
            entity.Property(e => e.LocationX).HasColumnName("location_x");
            entity.Property(e => e.LocationY).HasColumnName("location_y");
            entity.Property(e => e.LocationZ).HasColumnName("location_z");
            entity.Property(e => e.PointComment)
                .HasColumnType("text")
                .HasColumnName("point_comment");
            entity.Property(e => e.Waittime)
                .HasComment("waittime in millisecs")
                .HasColumnName("waittime");
        });

        modelBuilder.Entity<ScriptedAreatrigger>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("scripted_areatrigger");

            entity.Property(e => e.Entry)
                .HasColumnType("mediumint")
                .HasColumnName("entry");
            entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .IsFixedLength()
                .HasColumnName("script_name");
        });

        modelBuilder.Entity<ScriptedEventId>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("scripted_event_id", tb => tb.HasComment("Script library scripted events"));

            entity.Property(e => e.Id)
                .HasColumnType("mediumint")
                .HasColumnName("id");
            entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .IsFixedLength()
                .HasColumnName("script_name");
        });

        modelBuilder.Entity<SkillFishingBaseLevel>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("skill_fishing_base_level", tb => tb.HasComment("Fishing system"));

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasComment("Area identifier")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Skill)
                .HasComment("Base skill level requirement")
                .HasColumnName("skill");
        });

        modelBuilder.Entity<SkillLineAbility>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Build }).HasName("PRIMARY");

            entity.ToTable("skill_line_ability");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Build)
                .HasComment("Game client build for which to load this entry")
                .HasColumnName("build");
            entity.Property(e => e.ClassMask).HasColumnName("class_mask");
            entity.Property(e => e.LearnOnGetSkill).HasColumnName("learn_on_get_skill");
            entity.Property(e => e.MaxValue).HasColumnName("max_value");
            entity.Property(e => e.MinValue).HasColumnName("min_value");
            entity.Property(e => e.RaceMask).HasColumnName("race_mask");
            entity.Property(e => e.ReqSkillValue).HasColumnName("req_skill_value");
            entity.Property(e => e.ReqTrainPoints).HasColumnName("req_train_points");
            entity.Property(e => e.SkillId).HasColumnName("skill_id");
            entity.Property(e => e.SpellId).HasColumnName("spell_id");
            entity.Property(e => e.SupersededBySpell).HasColumnName("superseded_by_spell");
        });

        modelBuilder.Entity<SkinningLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item, e.PatchMin, e.PatchMax }).HasName("PRIMARY");

            entity.ToTable("skinning_loot_template", tb => tb.HasComment("Loot System"));

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Item)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("item");
            entity.Property(e => e.PatchMin)
                .HasComment("Minimum content patch to load this entry")
                .HasColumnName("patch_min");
            entity.Property(e => e.PatchMax)
                .HasDefaultValueSql("'10'")
                .HasComment("Maximum content patch to load this entry")
                .HasColumnName("patch_max");
            entity.Property(e => e.ChanceOrQuestChance).HasDefaultValueSql("'100'");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_id");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Maxcount)
                .HasDefaultValueSql("'1'")
                .HasColumnName("maxcount");
            entity.Property(e => e.MincountOrRef)
                .HasDefaultValueSql("'1'")
                .HasColumnType("mediumint")
                .HasColumnName("mincountOrRef");
        });

        modelBuilder.Entity<SoundEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("sound_entries");

            entity.HasIndex(e => e.Id, "ID").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
        });

        modelBuilder.Entity<SpellAffect>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.EffectId }).HasName("PRIMARY");

            entity.ToTable("spell_affect");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.EffectId).HasColumnName("effectId");
            entity.Property(e => e.BuildMax)
                .HasDefaultValueSql("'5875'")
                .HasComment("Maximum game client build to load this entry")
                .HasColumnName("build_max");
            entity.Property(e => e.BuildMin)
                .HasComment("Minimum game client build to load this entry")
                .HasColumnName("build_min");
        });

        modelBuilder.Entity<SpellArea>(entity =>
        {
            entity.HasKey(e => new { e.Spell, e.Area, e.QuestStart, e.QuestStartActive, e.AuraSpell, e.Racemask, e.Gender }).HasName("PRIMARY");

            entity.ToTable("spell_area");

            entity.Property(e => e.Spell).HasColumnName("spell");
            entity.Property(e => e.Area)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("area");
            entity.Property(e => e.QuestStart)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("quest_start");
            entity.Property(e => e.QuestStartActive).HasColumnName("quest_start_active");
            entity.Property(e => e.AuraSpell).HasColumnName("aura_spell");
            entity.Property(e => e.Racemask)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("racemask");
            entity.Property(e => e.Gender)
                .HasDefaultValueSql("'2'")
                .HasColumnName("gender");
            entity.Property(e => e.Autocast).HasColumnName("autocast");
            entity.Property(e => e.QuestEnd)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("quest_end");
        });

        modelBuilder.Entity<SpellChain>(entity =>
        {
            entity.HasKey(e => new { e.SpellId, e.BuildMin, e.BuildMax }).HasName("PRIMARY");

            entity.ToTable("spell_chain", tb => tb.HasComment("Spell Additinal Data"));

            entity.Property(e => e.SpellId).HasColumnName("spell_id");
            entity.Property(e => e.BuildMin)
                .HasComment("Minimum game client build to load this entry")
                .HasColumnName("build_min");
            entity.Property(e => e.BuildMax)
                .HasDefaultValueSql("'5875'")
                .HasComment("Maximum game client build to load this entry")
                .HasColumnName("build_max");
            entity.Property(e => e.FirstSpell).HasColumnName("first_spell");
            entity.Property(e => e.PrevSpell).HasColumnName("prev_spell");
            entity.Property(e => e.Rank).HasColumnName("rank");
            entity.Property(e => e.ReqSpell).HasColumnName("req_spell");
        });

        modelBuilder.Entity<SpellCheck>(entity =>
        {
            entity.HasKey(e => new { e.Spellid, e.SpellFamilyName, e.SpellFamilyMask, e.SpellIcon, e.SpellVisual, e.SpellCategory, e.Code }).HasName("PRIMARY");

            entity.ToTable("spell_check");

            entity.Property(e => e.Spellid).HasColumnName("spellid");
            entity.Property(e => e.SpellFamilyName).HasDefaultValueSql("'-1'");
            entity.Property(e => e.SpellFamilyMask).HasDefaultValueSql("'-1'");
            entity.Property(e => e.SpellIcon).HasDefaultValueSql("'-1'");
            entity.Property(e => e.SpellVisual).HasDefaultValueSql("'-1'");
            entity.Property(e => e.SpellCategory).HasDefaultValueSql("'-1'");
            entity.Property(e => e.Code)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
            entity.Property(e => e.EffectAura).HasDefaultValueSql("'-1'");
            entity.Property(e => e.EffectIdx).HasDefaultValueSql("'-1'");
            entity.Property(e => e.EffectType).HasDefaultValueSql("'-1'");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<SpellDisabled>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("spell_disabled");

            entity.Property(e => e.Entry)
                .HasComment("Disabled spell")
                .HasColumnName("entry");
        });

        modelBuilder.Entity<SpellEffectMod>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.EffectIndex }).HasName("PRIMARY");

            entity.ToTable("spell_effect_mod");

            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.Effect).HasDefaultValueSql("'-1'");
            entity.Property(e => e.EffectAmplitude).HasDefaultValueSql("'-1'");
            entity.Property(e => e.EffectApplyAuraName).HasDefaultValueSql("'-1'");
            entity.Property(e => e.EffectBaseDice).HasDefaultValueSql("'-1'");
            entity.Property(e => e.EffectBasePoints).HasDefaultValueSql("'-1'");
            entity.Property(e => e.EffectChainTarget).HasDefaultValueSql("'-1'");
            entity.Property(e => e.EffectDicePerLevel).HasDefaultValueSql("'-1'");
            entity.Property(e => e.EffectDieSides).HasDefaultValueSql("'-1'");
            entity.Property(e => e.EffectImplicitTargetA).HasDefaultValueSql("'-1'");
            entity.Property(e => e.EffectImplicitTargetB).HasDefaultValueSql("'-1'");
            entity.Property(e => e.EffectItemType).HasDefaultValueSql("'-1'");
            entity.Property(e => e.EffectMechanic).HasDefaultValueSql("'-1'");
            entity.Property(e => e.EffectMiscValue).HasDefaultValueSql("'-1'");
            entity.Property(e => e.EffectMultipleValue).HasDefaultValueSql("'-1'");
            entity.Property(e => e.EffectPointsPerComboPoint).HasDefaultValueSql("'-1'");
            entity.Property(e => e.EffectRadiusIndex).HasDefaultValueSql("'-1'");
            entity.Property(e => e.EffectRealPointsPerLevel).HasDefaultValueSql("'-1'");
            entity.Property(e => e.EffectTriggerSpell).HasDefaultValueSql("'-1'");
        });

        modelBuilder.Entity<SpellElixir>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("spell_elixir", tb => tb.HasComment("Spell System"));

            entity.Property(e => e.Entry)
                .HasComment("SpellId of potion")
                .HasColumnName("entry");
            entity.Property(e => e.BuildMax)
                .HasDefaultValueSql("'5875'")
                .HasComment("Maximum game client build to load this entry")
                .HasColumnName("build_max");
            entity.Property(e => e.BuildMin)
                .HasComment("Minimum game client build to load this entry")
                .HasColumnName("build_min");
            entity.Property(e => e.Mask)
                .HasComment("Mask 0x1 battle 0x2 guardian 0x3 flask 0x7 unstable flasks 0xB shattrath flasks")
                .HasColumnName("mask");
        });

        modelBuilder.Entity<SpellEnchantCharge>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("spell_enchant_charges");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Charges).HasColumnName("charges");
        });

        modelBuilder.Entity<SpellGroup>(entity =>
        {
            entity.HasKey(e => new { e.GroupId, e.GroupSpellId, e.SpellId }).HasName("PRIMARY");

            entity.ToTable("spell_group", tb => tb.HasComment("Spell System"));

            entity.HasIndex(e => new { e.GroupId, e.GroupSpellId }, "group_id").IsUnique();

            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.GroupSpellId).HasColumnName("group_spell_id");
            entity.Property(e => e.SpellId).HasColumnName("spell_id");
            entity.Property(e => e.BuildMax)
                .HasDefaultValueSql("'5875'")
                .HasComment("Maximum game client build to load this entry")
                .HasColumnName("build_max");
            entity.Property(e => e.BuildMin)
                .HasComment("Minimum game client build to load this entry")
                .HasColumnName("build_min");
        });

        modelBuilder.Entity<SpellGroupStackRule>(entity =>
        {
            entity.HasKey(e => new { e.GroupId, e.Build }).HasName("PRIMARY");

            entity.ToTable("spell_group_stack_rules");

            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.Build)
                .HasComment("Game client build in which this exact stacking rule was added")
                .HasColumnName("build");
            entity.Property(e => e.StackRule)
                .HasDefaultValueSql("'1'")
                .HasColumnName("stack_rule");
        });

        modelBuilder.Entity<SpellLearnSpell>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.SpellId }).HasName("PRIMARY");

            entity.ToTable("spell_learn_spell", tb => tb.HasComment("Item System"));

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.SpellId).HasColumnName("SpellID");
            entity.Property(e => e.Active).HasDefaultValueSql("'1'");
            entity.Property(e => e.BuildMax)
                .HasDefaultValueSql("'5875'")
                .HasComment("Maximum game client build to load this entry")
                .HasColumnName("build_max");
            entity.Property(e => e.BuildMin)
                .HasComment("Minimum game client build to load this entry")
                .HasColumnName("build_min");
        });

        modelBuilder.Entity<SpellMod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("spell_mod");

            entity.Property(e => e.ActiveIconId)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("activeIconID");
            entity.Property(e => e.Attributes).HasDefaultValueSql("'-1'");
            entity.Property(e => e.AttributesEx).HasDefaultValueSql("'-1'");
            entity.Property(e => e.AttributesEx2).HasDefaultValueSql("'-1'");
            entity.Property(e => e.AttributesEx3).HasDefaultValueSql("'-1'");
            entity.Property(e => e.AttributesEx4).HasDefaultValueSql("'-1'");
            entity.Property(e => e.AuraInterruptFlags).HasDefaultValueSql("'-1'");
            entity.Property(e => e.CastingTimeIndex).HasDefaultValueSql("'-1'");
            entity.Property(e => e.Category).HasDefaultValueSql("'-1'");
            entity.Property(e => e.CategoryRecoveryTime).HasDefaultValueSql("'-1'");
            entity.Property(e => e.ChannelInterruptFlags).HasDefaultValueSql("'-1'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.Custom).HasDefaultValueSql("'0'");
            entity.Property(e => e.Dispel).HasDefaultValueSql("'-1'");
            entity.Property(e => e.DmgClass).HasDefaultValueSql("'-1'");
            entity.Property(e => e.DurationIndex).HasDefaultValueSql("'-1'");
            entity.Property(e => e.EquippedItemClass).HasDefaultValueSql("'-1'");
            entity.Property(e => e.InterruptFlags).HasDefaultValueSql("'-1'");
            entity.Property(e => e.ManaCost)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("manaCost");
            entity.Property(e => e.ManaCostPercentage).HasDefaultValueSql("'-1'");
            entity.Property(e => e.MaxAffectedTargets).HasDefaultValueSql("'-1'");
            entity.Property(e => e.MaxTargetLevel).HasDefaultValueSql("'-1'");
            entity.Property(e => e.Mechanic).HasDefaultValueSql("'-1'");
            entity.Property(e => e.ProcChance)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("procChance");
            entity.Property(e => e.ProcCharges)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("procCharges");
            entity.Property(e => e.ProcFlags)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("procFlags");
            entity.Property(e => e.RangeIndex)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("rangeIndex");
            entity.Property(e => e.RecoveryTime).HasDefaultValueSql("'-1'");
            entity.Property(e => e.SpellFamilyFlags).HasDefaultValueSql("'0'");
            entity.Property(e => e.SpellFamilyName).HasDefaultValueSql("'-1'");
            entity.Property(e => e.SpellIconId)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("SpellIconID");
            entity.Property(e => e.SpellVisual).HasDefaultValueSql("'-1'");
            entity.Property(e => e.StackAmount).HasDefaultValueSql("'-1'");
            entity.Property(e => e.Stances).HasDefaultValueSql("'-1'");
            entity.Property(e => e.StancesNot).HasDefaultValueSql("'-1'");
            entity.Property(e => e.StartRecoveryCategory).HasDefaultValueSql("'-1'");
            entity.Property(e => e.StartRecoveryTime).HasDefaultValueSql("'-1'");
        });

        modelBuilder.Entity<SpellPetAura>(entity =>
        {
            entity.HasKey(e => new { e.Spell, e.Pet }).HasName("PRIMARY");

            entity.ToTable("spell_pet_auras");

            entity.Property(e => e.Spell)
                .HasComment("dummy spell id")
                .HasColumnName("spell");
            entity.Property(e => e.Pet)
                .HasDefaultValueSql("'0'")
                .HasComment("pet id; 0 = all")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("pet");
            entity.Property(e => e.Aura)
                .HasComment("pet aura id")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("aura");
        });

        modelBuilder.Entity<SpellProcEvent>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.BuildMin, e.BuildMax }).HasName("PRIMARY");

            entity.ToTable("spell_proc_event");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.BuildMin)
                .HasComment("Minimum game client build to load this entry")
                .HasColumnName("build_min");
            entity.Property(e => e.BuildMax)
                .HasDefaultValueSql("'5875'")
                .HasComment("Maximum game client build to load this entry")
                .HasColumnName("build_max");
            entity.Property(e => e.PpmRate).HasColumnName("ppmRate");
            entity.Property(e => e.ProcEx).HasColumnName("procEx");
            entity.Property(e => e.ProcFlags).HasColumnName("procFlags");
        });

        modelBuilder.Entity<SpellProcItemEnchant>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("spell_proc_item_enchant");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.PpmRate).HasColumnName("ppmRate");
        });

        modelBuilder.Entity<SpellScript>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("spell_scripts");

            entity.Property(e => e.Command).HasColumnName("command");
            entity.Property(e => e.Comments)
                .HasMaxLength(255)
                .HasColumnName("comments");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("condition_id");
            entity.Property(e => e.DataFlags).HasColumnName("data_flags");
            entity.Property(e => e.Dataint).HasColumnName("dataint");
            entity.Property(e => e.Dataint2).HasColumnName("dataint2");
            entity.Property(e => e.Dataint3).HasColumnName("dataint3");
            entity.Property(e => e.Dataint4).HasColumnName("dataint4");
            entity.Property(e => e.Datalong).HasColumnName("datalong");
            entity.Property(e => e.Datalong2).HasColumnName("datalong2");
            entity.Property(e => e.Datalong3).HasColumnName("datalong3");
            entity.Property(e => e.Datalong4).HasColumnName("datalong4");
            entity.Property(e => e.Delay).HasColumnName("delay");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.O).HasColumnName("o");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.TargetParam1).HasColumnName("target_param1");
            entity.Property(e => e.TargetParam2).HasColumnName("target_param2");
            entity.Property(e => e.TargetType).HasColumnName("target_type");
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
            entity.Property(e => e.Z).HasColumnName("z");
        });

        modelBuilder.Entity<SpellScriptTarget>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("spell_script_target", tb => tb.HasComment("Spell System"));

            entity.HasIndex(e => new { e.Entry, e.Type, e.TargetEntry }, "entry_type_target").IsUnique();

            entity.Property(e => e.BuildMax)
                .HasDefaultValueSql("'5875'")
                .HasComment("Maximum game client build to load this entry")
                .HasColumnName("build_max");
            entity.Property(e => e.BuildMin)
                .HasComment("Minimum game client build to load this entry")
                .HasColumnName("build_min");
            entity.Property(e => e.ConditionId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("conditionId");
            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.InverseEffectMask)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("inverseEffectMask");
            entity.Property(e => e.TargetEntry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("targetEntry");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<SpellTargetPosition>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.TargetMap }).HasName("PRIMARY");

            entity.ToTable("spell_target_position", tb => tb.HasComment("Spell System"));

            entity.Property(e => e.Id)
                .HasComment("Identifier")
                .HasColumnName("id");
            entity.Property(e => e.TargetMap).HasColumnName("target_map");
            entity.Property(e => e.BuildMax)
                .HasDefaultValueSql("'5875'")
                .HasComment("Maximum game client build to load this entry")
                .HasColumnName("build_max");
            entity.Property(e => e.BuildMin)
                .HasComment("Minimum game client build to load this entry")
                .HasColumnName("build_min");
            entity.Property(e => e.TargetOrientation).HasColumnName("target_orientation");
            entity.Property(e => e.TargetPositionX).HasColumnName("target_position_x");
            entity.Property(e => e.TargetPositionY).HasColumnName("target_position_y");
            entity.Property(e => e.TargetPositionZ).HasColumnName("target_position_z");
        });

        modelBuilder.Entity<SpellTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Build }).HasName("PRIMARY");

            entity.ToTable("spell_template");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Build)
                .HasDefaultValueSql("'5875'")
                .HasComment("Game client build for which to load this entry")
                .HasColumnName("build");
            entity.Property(e => e.ActiveIconId)
                .HasComment("SpellIcon.dbc")
                .HasColumnName("activeIconId");
            entity.Property(e => e.Attributes).HasColumnName("attributes");
            entity.Property(e => e.AttributesEx).HasColumnName("attributesEx");
            entity.Property(e => e.AttributesEx2).HasColumnName("attributesEx2");
            entity.Property(e => e.AttributesEx3).HasColumnName("attributesEx3");
            entity.Property(e => e.AttributesEx4).HasColumnName("attributesEx4");
            entity.Property(e => e.AuraDescription)
                .HasMaxLength(512)
                .HasDefaultValueSql("''")
                .HasColumnName("auraDescription");
            entity.Property(e => e.AuraDescriptionFlags).HasColumnName("auraDescriptionFlags");
            entity.Property(e => e.AuraInterruptFlags).HasColumnName("auraInterruptFlags");
            entity.Property(e => e.BaseLevel).HasColumnName("baseLevel");
            entity.Property(e => e.CastUi).HasColumnName("castUI");
            entity.Property(e => e.CasterAuraState).HasColumnName("casterAuraState");
            entity.Property(e => e.CastingTimeIndex)
                .HasComment("SpellCastTimes.dbc")
                .HasColumnName("castingTimeIndex");
            entity.Property(e => e.Category)
                .HasComment("SpellCategory.dbc")
                .HasColumnName("category");
            entity.Property(e => e.CategoryRecoveryTime).HasColumnName("categoryRecoveryTime");
            entity.Property(e => e.ChannelInterruptFlags).HasColumnName("channelInterruptFlags");
            entity.Property(e => e.CustomFlags)
                .HasComment("Custom Field")
                .HasColumnName("customFlags");
            entity.Property(e => e.Description)
                .HasMaxLength(1024)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            entity.Property(e => e.DescriptionFlags).HasColumnName("descriptionFlags");
            entity.Property(e => e.Dispel)
                .HasComment("SpellDispelType.dbc")
                .HasColumnName("dispel");
            entity.Property(e => e.DmgClass).HasColumnName("dmgClass");
            entity.Property(e => e.DmgMultiplier1).HasColumnName("dmgMultiplier1");
            entity.Property(e => e.DmgMultiplier2).HasColumnName("dmgMultiplier2");
            entity.Property(e => e.DmgMultiplier3).HasColumnName("dmgMultiplier3");
            entity.Property(e => e.DurationIndex)
                .HasComment("SpellDuration.dbc")
                .HasColumnName("durationIndex");
            entity.Property(e => e.Effect1).HasColumnName("effect1");
            entity.Property(e => e.Effect2).HasColumnName("effect2");
            entity.Property(e => e.Effect3).HasColumnName("effect3");
            entity.Property(e => e.EffectAmplitude1).HasColumnName("effectAmplitude1");
            entity.Property(e => e.EffectAmplitude2).HasColumnName("effectAmplitude2");
            entity.Property(e => e.EffectAmplitude3).HasColumnName("effectAmplitude3");
            entity.Property(e => e.EffectApplyAuraName1).HasColumnName("effectApplyAuraName1");
            entity.Property(e => e.EffectApplyAuraName2).HasColumnName("effectApplyAuraName2");
            entity.Property(e => e.EffectApplyAuraName3).HasColumnName("effectApplyAuraName3");
            entity.Property(e => e.EffectBaseDice1).HasColumnName("effectBaseDice1");
            entity.Property(e => e.EffectBaseDice2).HasColumnName("effectBaseDice2");
            entity.Property(e => e.EffectBaseDice3).HasColumnName("effectBaseDice3");
            entity.Property(e => e.EffectBasePoints1).HasColumnName("effectBasePoints1");
            entity.Property(e => e.EffectBasePoints2).HasColumnName("effectBasePoints2");
            entity.Property(e => e.EffectBasePoints3).HasColumnName("effectBasePoints3");
            entity.Property(e => e.EffectBonusCoefficient1)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("effectBonusCoefficient1");
            entity.Property(e => e.EffectBonusCoefficient2)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("effectBonusCoefficient2");
            entity.Property(e => e.EffectBonusCoefficient3)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("effectBonusCoefficient3");
            entity.Property(e => e.EffectChainTarget1).HasColumnName("effectChainTarget1");
            entity.Property(e => e.EffectChainTarget2).HasColumnName("effectChainTarget2");
            entity.Property(e => e.EffectChainTarget3).HasColumnName("effectChainTarget3");
            entity.Property(e => e.EffectDicePerLevel1).HasColumnName("effectDicePerLevel1");
            entity.Property(e => e.EffectDicePerLevel2).HasColumnName("effectDicePerLevel2");
            entity.Property(e => e.EffectDicePerLevel3).HasColumnName("effectDicePerLevel3");
            entity.Property(e => e.EffectDieSides1).HasColumnName("effectDieSides1");
            entity.Property(e => e.EffectDieSides2).HasColumnName("effectDieSides2");
            entity.Property(e => e.EffectDieSides3).HasColumnName("effectDieSides3");
            entity.Property(e => e.EffectImplicitTargetA1).HasColumnName("effectImplicitTargetA1");
            entity.Property(e => e.EffectImplicitTargetA2).HasColumnName("effectImplicitTargetA2");
            entity.Property(e => e.EffectImplicitTargetA3).HasColumnName("effectImplicitTargetA3");
            entity.Property(e => e.EffectImplicitTargetB1).HasColumnName("effectImplicitTargetB1");
            entity.Property(e => e.EffectImplicitTargetB2).HasColumnName("effectImplicitTargetB2");
            entity.Property(e => e.EffectImplicitTargetB3).HasColumnName("effectImplicitTargetB3");
            entity.Property(e => e.EffectItemType1).HasColumnName("effectItemType1");
            entity.Property(e => e.EffectItemType2).HasColumnName("effectItemType2");
            entity.Property(e => e.EffectItemType3).HasColumnName("effectItemType3");
            entity.Property(e => e.EffectMechanic1).HasColumnName("effectMechanic1");
            entity.Property(e => e.EffectMechanic2).HasColumnName("effectMechanic2");
            entity.Property(e => e.EffectMechanic3).HasColumnName("effectMechanic3");
            entity.Property(e => e.EffectMiscValue1).HasColumnName("effectMiscValue1");
            entity.Property(e => e.EffectMiscValue2).HasColumnName("effectMiscValue2");
            entity.Property(e => e.EffectMiscValue3).HasColumnName("effectMiscValue3");
            entity.Property(e => e.EffectMultipleValue1).HasColumnName("effectMultipleValue1");
            entity.Property(e => e.EffectMultipleValue2).HasColumnName("effectMultipleValue2");
            entity.Property(e => e.EffectMultipleValue3).HasColumnName("effectMultipleValue3");
            entity.Property(e => e.EffectPointsPerComboPoint1).HasColumnName("effectPointsPerComboPoint1");
            entity.Property(e => e.EffectPointsPerComboPoint2).HasColumnName("effectPointsPerComboPoint2");
            entity.Property(e => e.EffectPointsPerComboPoint3).HasColumnName("effectPointsPerComboPoint3");
            entity.Property(e => e.EffectRadiusIndex1)
                .HasComment("SpellRadius.dbc")
                .HasColumnName("effectRadiusIndex1");
            entity.Property(e => e.EffectRadiusIndex2)
                .HasComment("SpellRadius.dbc")
                .HasColumnName("effectRadiusIndex2");
            entity.Property(e => e.EffectRadiusIndex3)
                .HasComment("SpellRadius.dbc")
                .HasColumnName("effectRadiusIndex3");
            entity.Property(e => e.EffectRealPointsPerLevel1).HasColumnName("effectRealPointsPerLevel1");
            entity.Property(e => e.EffectRealPointsPerLevel2).HasColumnName("effectRealPointsPerLevel2");
            entity.Property(e => e.EffectRealPointsPerLevel3).HasColumnName("effectRealPointsPerLevel3");
            entity.Property(e => e.EffectTriggerSpell1).HasColumnName("effectTriggerSpell1");
            entity.Property(e => e.EffectTriggerSpell2).HasColumnName("effectTriggerSpell2");
            entity.Property(e => e.EffectTriggerSpell3).HasColumnName("effectTriggerSpell3");
            entity.Property(e => e.EquippedItemClass)
                .HasComment("ItemClass.dbc")
                .HasColumnName("equippedItemClass");
            entity.Property(e => e.EquippedItemInventoryTypeMask).HasColumnName("equippedItemInventoryTypeMask");
            entity.Property(e => e.EquippedItemSubClassMask)
                .HasComment("ItemSubClass.dbc")
                .HasColumnName("equippedItemSubClassMask");
            entity.Property(e => e.InterruptFlags).HasColumnName("interruptFlags");
            entity.Property(e => e.ManCostPerLevel).HasColumnName("manCostPerLevel");
            entity.Property(e => e.ManaCost).HasColumnName("manaCost");
            entity.Property(e => e.ManaCostPercentage).HasColumnName("manaCostPercentage");
            entity.Property(e => e.ManaPerSecond).HasColumnName("manaPerSecond");
            entity.Property(e => e.ManaPerSecondPerLevel).HasColumnName("manaPerSecondPerLevel");
            entity.Property(e => e.MaxAffectedTargets).HasColumnName("maxAffectedTargets");
            entity.Property(e => e.MaxLevel).HasColumnName("maxLevel");
            entity.Property(e => e.MaxTargetLevel).HasColumnName("maxTargetLevel");
            entity.Property(e => e.Mechanic)
                .HasComment("SpellMechanic.dbc")
                .HasColumnName("mechanic");
            entity.Property(e => e.MinFactionId).HasColumnName("minFactionId");
            entity.Property(e => e.MinReputation).HasColumnName("minReputation");
            entity.Property(e => e.MinTargetLevel)
                .HasComment("Custom Field")
                .HasColumnName("minTargetLevel");
            entity.Property(e => e.ModelNextSpell).HasColumnName("modelNextSpell");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.NameFlags).HasColumnName("nameFlags");
            entity.Property(e => e.NameSubtext)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("nameSubtext");
            entity.Property(e => e.NameSubtextFlags).HasColumnName("nameSubtextFlags");
            entity.Property(e => e.PowerType).HasColumnName("powerType");
            entity.Property(e => e.PreventionType).HasColumnName("preventionType");
            entity.Property(e => e.ProcChance).HasColumnName("procChance");
            entity.Property(e => e.ProcCharges).HasColumnName("procCharges");
            entity.Property(e => e.ProcFlags).HasColumnName("procFlags");
            entity.Property(e => e.RangeIndex)
                .HasComment("SpellRange.dbc")
                .HasColumnName("rangeIndex");
            entity.Property(e => e.Reagent1).HasColumnName("reagent1");
            entity.Property(e => e.Reagent2).HasColumnName("reagent2");
            entity.Property(e => e.Reagent3).HasColumnName("reagent3");
            entity.Property(e => e.Reagent4).HasColumnName("reagent4");
            entity.Property(e => e.Reagent5).HasColumnName("reagent5");
            entity.Property(e => e.Reagent6).HasColumnName("reagent6");
            entity.Property(e => e.Reagent7).HasColumnName("reagent7");
            entity.Property(e => e.Reagent8).HasColumnName("reagent8");
            entity.Property(e => e.ReagentCount1).HasColumnName("reagentCount1");
            entity.Property(e => e.ReagentCount2).HasColumnName("reagentCount2");
            entity.Property(e => e.ReagentCount3).HasColumnName("reagentCount3");
            entity.Property(e => e.ReagentCount4).HasColumnName("reagentCount4");
            entity.Property(e => e.ReagentCount5).HasColumnName("reagentCount5");
            entity.Property(e => e.ReagentCount6).HasColumnName("reagentCount6");
            entity.Property(e => e.ReagentCount7).HasColumnName("reagentCount7");
            entity.Property(e => e.ReagentCount8).HasColumnName("reagentCount8");
            entity.Property(e => e.RecoveryTime).HasColumnName("recoveryTime");
            entity.Property(e => e.RequiredAuraVision).HasColumnName("requiredAuraVision");
            entity.Property(e => e.RequiresSpellFocus)
                .HasComment("SpellFocusObject.dbc")
                .HasColumnName("requiresSpellFocus");
            entity.Property(e => e.School)
                .HasComment("Resistances.dbc")
                .HasColumnName("school");
            entity.Property(e => e.Speed).HasColumnName("speed");
            entity.Property(e => e.SpellFamilyFlags).HasColumnName("spellFamilyFlags");
            entity.Property(e => e.SpellFamilyName)
                .HasComment("ChrClasses.dbc")
                .HasColumnName("spellFamilyName");
            entity.Property(e => e.SpellIconId)
                .HasComment("SpellIcon.dbc")
                .HasColumnName("spellIconId");
            entity.Property(e => e.SpellLevel).HasColumnName("spellLevel");
            entity.Property(e => e.SpellPriority).HasColumnName("spellPriority");
            entity.Property(e => e.SpellVisual1)
                .HasComment("SpellVisual.dbc")
                .HasColumnName("spellVisual1");
            entity.Property(e => e.SpellVisual2)
                .HasComment("SpellVisual.dbc")
                .HasColumnName("spellVisual2");
            entity.Property(e => e.StackAmount).HasColumnName("stackAmount");
            entity.Property(e => e.StanceBarOrder).HasColumnName("stanceBarOrder");
            entity.Property(e => e.Stances)
                .HasComment("SpellShapeshiftForm.dbc")
                .HasColumnName("stances");
            entity.Property(e => e.StancesNot)
                .HasComment("SpellShapeshiftForm.dbc")
                .HasColumnName("stancesNot");
            entity.Property(e => e.StartRecoveryCategory).HasColumnName("startRecoveryCategory");
            entity.Property(e => e.StartRecoveryTime).HasColumnName("startRecoveryTime");
            entity.Property(e => e.TargetAuraState).HasColumnName("targetAuraState");
            entity.Property(e => e.TargetCreatureType)
                .HasComment("CreatureType.dbc")
                .HasColumnName("targetCreatureType");
            entity.Property(e => e.Targets).HasColumnName("targets");
            entity.Property(e => e.Totem1).HasColumnName("totem1");
            entity.Property(e => e.Totem2).HasColumnName("totem2");
        });

        modelBuilder.Entity<SpellThreat>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("spell_threat");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.ApBonus)
                .HasComment("additional threat bonus from attack power")
                .HasColumnName("ap_bonus");
            entity.Property(e => e.BuildMax)
                .HasDefaultValueSql("'5875'")
                .HasComment("Maximum game client build to load this entry")
                .HasColumnName("build_max");
            entity.Property(e => e.BuildMin)
                .HasComment("Minimum game client build to load this entry")
                .HasColumnName("build_min");
            entity.Property(e => e.Multiplier)
                .HasDefaultValueSql("'1'")
                .HasComment("threat multiplier for damage/healing")
                .HasColumnName("multiplier");
        });

        modelBuilder.Entity<TaxiNode>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Build }).HasName("PRIMARY");

            entity.ToTable("taxi_nodes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Build)
                .HasComment("Game client build for which to load this entry")
                .HasColumnName("build");
            entity.Property(e => e.MapId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("map_id");
            entity.Property(e => e.MountCreatureId1).HasColumnName("mount_creature_id1");
            entity.Property(e => e.MountCreatureId2).HasColumnName("mount_creature_id2");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
            entity.Property(e => e.Z).HasColumnName("z");
        });

        modelBuilder.Entity<TaxiPathTransition>(entity =>
        {
            entity.HasKey(e => new { e.InPath, e.OutPath }).HasName("PRIMARY");

            entity.ToTable("taxi_path_transitions");

            entity.Property(e => e.InPath)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("in_path");
            entity.Property(e => e.OutPath)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("out_path");
            entity.Property(e => e.BuildMin)
                .HasComment("Minimum game client build to load this entry")
                .HasColumnName("build_min");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.InNode)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("in_node");
            entity.Property(e => e.OutNode)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("out_node");
        });

        modelBuilder.Entity<Transport>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("transports", tb => tb.HasComment("Transports"));

            entity.Property(e => e.Entry)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("entry");
            entity.Property(e => e.Name)
                .HasColumnType("text")
                .HasColumnName("name");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("period");
        });

        modelBuilder.Entity<Variable>(entity =>
        {
            entity.HasKey(e => e.Index).HasName("PRIMARY");

            entity.ToTable("variables");

            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<WardenScan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("warden_scans");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Address)
                .HasDefaultValueSql("'0'")
                .HasColumnName("address");
            entity.Property(e => e.BuildMax)
                .HasDefaultValueSql("'5875'")
                .HasColumnName("build_max");
            entity.Property(e => e.BuildMin)
                .HasDefaultValueSql("'5875'")
                .HasColumnName("build_min");
            entity.Property(e => e.Comment)
                .HasColumnType("tinytext")
                .HasColumnName("comment");
            entity.Property(e => e.Data)
                .HasColumnType("text")
                .HasColumnName("data");
            entity.Property(e => e.Flags)
                .HasColumnType("mediumint unsigned")
                .HasColumnName("flags");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Length)
                .HasDefaultValueSql("'0'")
                .HasColumnName("length");
            entity.Property(e => e.Penalty)
                .HasDefaultValueSql("'-1'")
                .HasComment("Action to take if check fails")
                .HasColumnName("penalty");
            entity.Property(e => e.Result)
                .HasColumnType("tinytext")
                .HasColumnName("result");
            entity.Property(e => e.Str)
                .HasColumnType("text")
                .HasColumnName("str");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("'0'")
                .HasColumnName("type");
        });

        modelBuilder.Entity<WorldSafeLocsFacing>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("world_safe_locs_facing");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
