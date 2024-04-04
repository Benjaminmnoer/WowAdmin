using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WowAdmin.Persistence.Context;

public partial class CharacterContext : DbContext
{
    public CharacterContext()
    {
    }

    public CharacterContext(DbContextOptions<CharacterContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountDatum> AccountData { get; set; }

    public virtual DbSet<Auction> Auctions { get; set; }

    public virtual DbSet<Character> Characters { get; set; }

    public virtual DbSet<CharacterAccountDatum> CharacterAccountData { get; set; }

    public virtual DbSet<CharacterAction> CharacterActions { get; set; }

    public virtual DbSet<CharacterAura> CharacterAuras { get; set; }

    public virtual DbSet<CharacterBattlegroundDatum> CharacterBattlegroundData { get; set; }

    public virtual DbSet<CharacterDeletedItem> CharacterDeletedItems { get; set; }

    public virtual DbSet<CharacterDuplicateAccount> CharacterDuplicateAccounts { get; set; }

    public virtual DbSet<CharacterForgottenSkill> CharacterForgottenSkills { get; set; }

    public virtual DbSet<CharacterGift> CharacterGifts { get; set; }

    public virtual DbSet<CharacterHomebind> CharacterHomebinds { get; set; }

    public virtual DbSet<CharacterHonorCp> CharacterHonorCps { get; set; }

    public virtual DbSet<CharacterInstance> CharacterInstances { get; set; }

    public virtual DbSet<CharacterInventory> CharacterInventories { get; set; }

    public virtual DbSet<CharacterPet> CharacterPets { get; set; }

    public virtual DbSet<CharacterQueststatus> CharacterQueststatuses { get; set; }

    public virtual DbSet<CharacterReputation> CharacterReputations { get; set; }

    public virtual DbSet<CharacterSkill> CharacterSkills { get; set; }

    public virtual DbSet<CharacterSocial> CharacterSocials { get; set; }

    public virtual DbSet<CharacterSpell> CharacterSpells { get; set; }

    public virtual DbSet<CharacterSpellCooldown> CharacterSpellCooldowns { get; set; }

    public virtual DbSet<CharacterStat> CharacterStats { get; set; }

    public virtual DbSet<CharacterTutorial> CharacterTutorials { get; set; }

    public virtual DbSet<CharactersGuidDelete> CharactersGuidDeletes { get; set; }

    public virtual DbSet<CharactersItemDelete> CharactersItemDeletes { get; set; }

    public virtual DbSet<Corpse> Corpses { get; set; }

    public virtual DbSet<CreatureRespawn> CreatureRespawns { get; set; }

    public virtual DbSet<GameEventStatus> GameEventStatuses { get; set; }

    public virtual DbSet<GameobjectRespawn> GameobjectRespawns { get; set; }

    public virtual DbSet<GmSubsurvey> GmSubsurveys { get; set; }

    public virtual DbSet<GmSurvey> GmSurveys { get; set; }

    public virtual DbSet<GmTicket> GmTickets { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupInstance> GroupInstances { get; set; }

    public virtual DbSet<GroupMember> GroupMembers { get; set; }

    public virtual DbSet<Guild> Guilds { get; set; }

    public virtual DbSet<GuildEventlog> GuildEventlogs { get; set; }

    public virtual DbSet<GuildMember> GuildMembers { get; set; }

    public virtual DbSet<GuildRank> GuildRanks { get; set; }

    public virtual DbSet<Instance> Instances { get; set; }

    public virtual DbSet<InstanceReset> InstanceResets { get; set; }

    public virtual DbSet<ItemInstance> ItemInstances { get; set; }

    public virtual DbSet<ItemLoot> ItemLoots { get; set; }

    public virtual DbSet<ItemText> ItemTexts { get; set; }

    public virtual DbSet<Mail> Mail { get; set; }

    public virtual DbSet<MailItem> MailItems { get; set; }

    public virtual DbSet<Migration> Migrations { get; set; }

    public virtual DbSet<PetAura> PetAuras { get; set; }

    public virtual DbSet<PetSpell> PetSpells { get; set; }

    public virtual DbSet<PetSpellCooldown> PetSpellCooldowns { get; set; }

    public virtual DbSet<Petition> Petitions { get; set; }

    public virtual DbSet<PetitionSign> PetitionSigns { get; set; }

    public virtual DbSet<Playerbot> Playerbots { get; set; }

    public virtual DbSet<SavedVariable> SavedVariables { get; set; }

    public virtual DbSet<World> Worlds { get; set; }

    public virtual DbSet<Worldstate> Worldstates { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountDatum>(entity =>
        {
            entity.HasKey(e => new { e.Account, e.Type }).HasName("PRIMARY");

            entity.ToTable("account_data");

            entity.Property(e => e.Account).HasColumnName("account");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Time).HasColumnName("time");
        });

        modelBuilder.Entity<Auction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("auction");

            entity.HasIndex(e => e.ItemGuid, "key_item_guid").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BuyerGuid).HasColumnName("buyer_guid");
            entity.Property(e => e.BuyoutPrice).HasColumnName("buyout_price");
            entity.Property(e => e.Deposit).HasColumnName("deposit");
            entity.Property(e => e.ExpireTime).HasColumnName("expire_time");
            entity.Property(e => e.HouseId).HasColumnName("house_id");
            entity.Property(e => e.ItemGuid).HasColumnName("item_guid");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.LastBid).HasColumnName("last_bid");
            entity.Property(e => e.SellerGuid).HasColumnName("seller_guid");
            entity.Property(e => e.StartBid).HasColumnName("start_bid");
        });

        modelBuilder.Entity<Character>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("characters", tb => tb.HasComment("Player System"));

            entity.HasIndex(e => e.Account, "idx_account");

            entity.HasIndex(e => e.Name, "idx_name");

            entity.HasIndex(e => e.Online, "idx_online");

            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Account)
                .HasComment("Account Identifier")
                .HasColumnName("account");
            entity.Property(e => e.ActionBars).HasColumnName("action_bars");
            entity.Property(e => e.AmmoId).HasColumnName("ammo_id");
            entity.Property(e => e.AtLoginFlags).HasColumnName("at_login_flags");
            entity.Property(e => e.BankBagSlots).HasColumnName("bank_bag_slots");
            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CurrentTaxiPath)
                .HasComment("flight destination")
                .HasColumnType("text")
                .HasColumnName("current_taxi_path");
            entity.Property(e => e.DeathExpireTime).HasColumnName("death_expire_time");
            entity.Property(e => e.DeletedAccount).HasColumnName("deleted_account");
            entity.Property(e => e.DeletedName)
                .HasMaxLength(12)
                .HasColumnName("deleted_name");
            entity.Property(e => e.DeletedTime).HasColumnName("deleted_time");
            entity.Property(e => e.Drunk).HasColumnName("drunk");
            entity.Property(e => e.EquipmentCache).HasColumnName("equipment_cache");
            entity.Property(e => e.ExploredZones).HasColumnName("explored_zones");
            entity.Property(e => e.ExtraFlags).HasColumnName("extra_flags");
            entity.Property(e => e.Face).HasColumnName("face");
            entity.Property(e => e.FacialHair).HasColumnName("facial_hair");
            entity.Property(e => e.Gender).HasColumnName("gender");
            entity.Property(e => e.HairColor).HasColumnName("hair_color");
            entity.Property(e => e.HairStyle).HasColumnName("hair_style");
            entity.Property(e => e.Health).HasColumnName("health");
            entity.Property(e => e.HonorHighestRank).HasColumnName("honor_highest_rank");
            entity.Property(e => e.HonorLastWeekCp).HasColumnName("honor_last_week_cp");
            entity.Property(e => e.HonorLastWeekHk).HasColumnName("honor_last_week_hk");
            entity.Property(e => e.HonorRankPoints).HasColumnName("honor_rank_points");
            entity.Property(e => e.HonorStanding).HasColumnName("honor_standing");
            entity.Property(e => e.HonorStoredDk).HasColumnName("honor_stored_dk");
            entity.Property(e => e.HonorStoredHk).HasColumnName("honor_stored_hk");
            entity.Property(e => e.IsLogoutResting).HasColumnName("is_logout_resting");
            entity.Property(e => e.KnownTaxiMask)
                .HasComment("discovered flight points")
                .HasColumnName("known_taxi_mask");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.LogoutTime).HasColumnName("logout_time");
            entity.Property(e => e.Map)
                .HasComment("Map Identifier")
                .HasColumnName("map");
            entity.Property(e => e.Money).HasColumnName("money");
            entity.Property(e => e.Name)
                .HasMaxLength(12)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Online).HasColumnName("online");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PlayedTimeLevel).HasColumnName("played_time_level");
            entity.Property(e => e.PlayedTimeTotal).HasColumnName("played_time_total");
            entity.Property(e => e.PlayerFlags).HasColumnName("player_flags");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
            entity.Property(e => e.Power1).HasColumnName("power1");
            entity.Property(e => e.Power2).HasColumnName("power2");
            entity.Property(e => e.Power3).HasColumnName("power3");
            entity.Property(e => e.Power4).HasColumnName("power4");
            entity.Property(e => e.Power5).HasColumnName("power5");
            entity.Property(e => e.Race).HasColumnName("race");
            entity.Property(e => e.ResetTalentsMultiplier).HasColumnName("reset_talents_multiplier");
            entity.Property(e => e.ResetTalentsTime).HasColumnName("reset_talents_time");
            entity.Property(e => e.RestBonus).HasColumnName("rest_bonus");
            entity.Property(e => e.Skin).HasColumnName("skin");
            entity.Property(e => e.StableSlots).HasColumnName("stable_slots");
            entity.Property(e => e.TransportGuid).HasColumnName("transport_guid");
            entity.Property(e => e.TransportO).HasColumnName("transport_o");
            entity.Property(e => e.TransportX).HasColumnName("transport_x");
            entity.Property(e => e.TransportY).HasColumnName("transport_y");
            entity.Property(e => e.TransportZ).HasColumnName("transport_z");
            entity.Property(e => e.WatchedFaction)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("watched_faction");
            entity.Property(e => e.WorldPhaseMask)
                .HasDefaultValueSql("'0'")
                .HasColumnName("world_phase_mask");
            entity.Property(e => e.Xp).HasColumnName("xp");
            entity.Property(e => e.Zone).HasColumnName("zone");
        });

        modelBuilder.Entity<CharacterAccountDatum>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Type }).HasName("PRIMARY");

            entity.ToTable("character_account_data");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Time).HasColumnName("time");
        });

        modelBuilder.Entity<CharacterAction>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Button }).HasName("PRIMARY");

            entity.ToTable("character_action", tb => tb.HasComment("Player System"));

            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Button).HasColumnName("button");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<CharacterAura>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.CasterGuid, e.ItemGuid, e.Spell }).HasName("PRIMARY");

            entity.ToTable("character_aura", tb => tb.HasComment("Player System"));

            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.CasterGuid)
                .HasComment("Full Global Unique Identifier")
                .HasColumnName("caster_guid");
            entity.Property(e => e.ItemGuid).HasColumnName("item_guid");
            entity.Property(e => e.Spell).HasColumnName("spell");
            entity.Property(e => e.BasePoints0).HasColumnName("base_points0");
            entity.Property(e => e.BasePoints1).HasColumnName("base_points1");
            entity.Property(e => e.BasePoints2).HasColumnName("base_points2");
            entity.Property(e => e.Charges).HasColumnName("charges");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.EffectIndexMask).HasColumnName("effect_index_mask");
            entity.Property(e => e.MaxDuration).HasColumnName("max_duration");
            entity.Property(e => e.PeriodicTime0).HasColumnName("periodic_time0");
            entity.Property(e => e.PeriodicTime1).HasColumnName("periodic_time1");
            entity.Property(e => e.PeriodicTime2).HasColumnName("periodic_time2");
            entity.Property(e => e.Stacks)
                .HasDefaultValueSql("'1'")
                .HasColumnName("stacks");
        });

        modelBuilder.Entity<CharacterBattlegroundDatum>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("character_battleground_data", tb => tb.HasComment("Player System"));

            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.InstanceId).HasColumnName("instance_id");
            entity.Property(e => e.JoinMap).HasColumnName("join_map");
            entity.Property(e => e.JoinO).HasColumnName("join_o");
            entity.Property(e => e.JoinX).HasColumnName("join_x");
            entity.Property(e => e.JoinY).HasColumnName("join_y");
            entity.Property(e => e.JoinZ).HasColumnName("join_z");
            entity.Property(e => e.Team).HasColumnName("team");
        });

        modelBuilder.Entity<CharacterDeletedItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("character_deleted_items");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("item_id");
            entity.Property(e => e.PlayerGuid).HasColumnName("player_guid");
            entity.Property(e => e.StackCount)
                .HasDefaultValueSql("'1'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("stack_count");
        });

        modelBuilder.Entity<CharacterDuplicateAccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("character_duplicate_account");

            entity.Property(e => e.Account).HasColumnName("account");
        });

        modelBuilder.Entity<CharacterForgottenSkill>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Skill }).HasName("PRIMARY");

            entity.ToTable("character_forgotten_skills", tb => tb.HasComment("Player System"));

            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Skill)
                .HasColumnType("mediumint unsigned")
                .HasColumnName("skill");
            entity.Property(e => e.Value)
                .HasColumnType("mediumint unsigned")
                .HasColumnName("value");
        });

        modelBuilder.Entity<CharacterGift>(entity =>
        {
            entity.HasKey(e => e.ItemGuid).HasName("PRIMARY");

            entity.ToTable("character_gifts");

            entity.HasIndex(e => e.Guid, "idx_guid");

            entity.Property(e => e.ItemGuid).HasColumnName("item_guid");
            entity.Property(e => e.Flags).HasColumnName("flags");
            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
        });

        modelBuilder.Entity<CharacterHomebind>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("character_homebind", tb => tb.HasComment("Player System"));

            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Map)
                .HasComment("Map Identifier")
                .HasColumnName("map");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
            entity.Property(e => e.Zone)
                .HasComment("Zone Identifier")
                .HasColumnName("zone");
        });

        modelBuilder.Entity<CharacterHonorCp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("character_honor_cp", tb => tb.HasComment("Player System"));

            entity.HasIndex(e => e.Guid, "idx_guid");

            entity.Property(e => e.Cp).HasColumnName("cp");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.VictimId)
                .HasComment("Creature Id / Player Guid")
                .HasColumnName("victim_id");
            entity.Property(e => e.VictimType)
                .HasDefaultValueSql("'4'")
                .HasComment("Object Type Id")
                .HasColumnName("victim_type");
        });

        modelBuilder.Entity<CharacterInstance>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Instance }).HasName("PRIMARY");

            entity.ToTable("character_instance");

            entity.HasIndex(e => e.Instance, "idx_instance");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Instance).HasColumnName("instance");
            entity.Property(e => e.Permanent).HasColumnName("permanent");
        });

        modelBuilder.Entity<CharacterInventory>(entity =>
        {
            entity.HasKey(e => e.ItemGuid).HasName("PRIMARY");

            entity.ToTable("character_inventory", tb => tb.HasComment("Player System"));

            entity.HasIndex(e => e.Guid, "idx_guid");

            entity.Property(e => e.ItemGuid)
                .HasComment("Item Global Unique Identifier")
                .HasColumnName("item_guid");
            entity.Property(e => e.Bag).HasColumnName("bag");
            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.ItemId)
                .HasComment("Item Identifier")
                .HasColumnName("item_id");
            entity.Property(e => e.Slot).HasColumnName("slot");
        });

        modelBuilder.Entity<CharacterPet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("character_pet", tb => tb.HasComment("Pet System"));

            entity.HasIndex(e => e.OwnerGuid, "idx_owner");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionBarData).HasColumnName("action_bar_data");
            entity.Property(e => e.CreatedBySpell).HasColumnName("created_by_spell");
            entity.Property(e => e.CurrentHappiness).HasColumnName("current_happiness");
            entity.Property(e => e.CurrentHealth)
                .HasDefaultValueSql("'1'")
                .HasColumnName("current_health");
            entity.Property(e => e.CurrentMana).HasColumnName("current_mana");
            entity.Property(e => e.DisplayId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("display_id");
            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Level)
                .HasDefaultValueSql("'1'")
                .HasColumnName("level");
            entity.Property(e => e.Loyalty).HasColumnName("loyalty");
            entity.Property(e => e.LoyaltyPoints).HasColumnName("loyalty_points");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("'Pet'")
                .HasColumnName("name");
            entity.Property(e => e.OwnerGuid).HasColumnName("owner_guid");
            entity.Property(e => e.PetType).HasColumnName("pet_type");
            entity.Property(e => e.ReactState).HasColumnName("react_state");
            entity.Property(e => e.Renamed).HasColumnName("renamed");
            entity.Property(e => e.ResetTalentsCost).HasColumnName("reset_talents_cost");
            entity.Property(e => e.ResetTalentsTime).HasColumnName("reset_talents_time");
            entity.Property(e => e.SaveTime).HasColumnName("save_time");
            entity.Property(e => e.Slot).HasColumnName("slot");
            entity.Property(e => e.TeachSpellData).HasColumnName("teach_spell_data");
            entity.Property(e => e.TrainingPoints).HasColumnName("training_points");
            entity.Property(e => e.Xp).HasColumnName("xp");
        });

        modelBuilder.Entity<CharacterQueststatus>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Quest }).HasName("PRIMARY");

            entity.ToTable("character_queststatus", tb => tb.HasComment("Player System"));

            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Quest)
                .HasComment("Quest Identifier")
                .HasColumnName("quest");
            entity.Property(e => e.Explored).HasColumnName("explored");
            entity.Property(e => e.ItemCount1).HasColumnName("item_count1");
            entity.Property(e => e.ItemCount2).HasColumnName("item_count2");
            entity.Property(e => e.ItemCount3).HasColumnName("item_count3");
            entity.Property(e => e.ItemCount4).HasColumnName("item_count4");
            entity.Property(e => e.MobCount1).HasColumnName("mob_count1");
            entity.Property(e => e.MobCount2).HasColumnName("mob_count2");
            entity.Property(e => e.MobCount3).HasColumnName("mob_count3");
            entity.Property(e => e.MobCount4).HasColumnName("mob_count4");
            entity.Property(e => e.RewardChoice).HasColumnName("reward_choice");
            entity.Property(e => e.Rewarded).HasColumnName("rewarded");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Timer).HasColumnName("timer");
        });

        modelBuilder.Entity<CharacterReputation>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Faction }).HasName("PRIMARY");

            entity.ToTable("character_reputation", tb => tb.HasComment("Player System"));

            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Faction).HasColumnName("faction");
            entity.Property(e => e.Flags).HasColumnName("flags");
            entity.Property(e => e.Standing).HasColumnName("standing");
        });

        modelBuilder.Entity<CharacterSkill>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Skill }).HasName("PRIMARY");

            entity.ToTable("character_skills", tb => tb.HasComment("Player System"));

            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Skill)
                .HasColumnType("mediumint unsigned")
                .HasColumnName("skill");
            entity.Property(e => e.Max)
                .HasColumnType("mediumint unsigned")
                .HasColumnName("max");
            entity.Property(e => e.Value)
                .HasColumnType("mediumint unsigned")
                .HasColumnName("value");
        });

        modelBuilder.Entity<CharacterSocial>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Friend, e.Flags }).HasName("PRIMARY");

            entity.ToTable("character_social", tb => tb.HasComment("Player System"));

            entity.HasIndex(e => e.Friend, "idx_friend");

            entity.HasIndex(e => new { e.Friend, e.Flags }, "idx_friend_flags");

            entity.HasIndex(e => e.Guid, "idx_guid");

            entity.HasIndex(e => new { e.Guid, e.Flags }, "idx_guid_flags");

            entity.Property(e => e.Guid)
                .HasComment("Character Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Friend)
                .HasComment("Friend Global Unique Identifier")
                .HasColumnName("friend");
            entity.Property(e => e.Flags)
                .HasComment("Friend Flags")
                .HasColumnName("flags");
        });

        modelBuilder.Entity<CharacterSpell>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Spell }).HasName("PRIMARY");

            entity.ToTable("character_spell", tb => tb.HasComment("Player System"));

            entity.HasIndex(e => e.Spell, "idx_spell");

            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Spell)
                .HasComment("Spell Identifier")
                .HasColumnName("spell");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnName("active");
            entity.Property(e => e.Disabled).HasColumnName("disabled");
        });

        modelBuilder.Entity<CharacterSpellCooldown>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Spell }).HasName("PRIMARY");

            entity.ToTable("character_spell_cooldown");

            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier, Low part")
                .HasColumnName("guid");
            entity.Property(e => e.Spell)
                .HasComment("Spell Identifier")
                .HasColumnName("spell");
            entity.Property(e => e.Category)
                .HasComment("Spell category")
                .HasColumnName("category");
            entity.Property(e => e.CategoryExpireTime)
                .HasComment("Spell category cooldown expire time")
                .HasColumnName("category_expire_time");
            entity.Property(e => e.ItemId)
                .HasComment("Item Identifier")
                .HasColumnName("item_id");
            entity.Property(e => e.SpellExpireTime)
                .HasComment("Spell cooldown expire time")
                .HasColumnName("spell_expire_time");
        });

        modelBuilder.Entity<CharacterStat>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("character_stats");

            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier, Low part")
                .HasColumnName("guid");
            entity.Property(e => e.Agility).HasColumnName("agility");
            entity.Property(e => e.ArcaneRes).HasColumnName("arcane_res");
            entity.Property(e => e.Armor).HasColumnName("armor");
            entity.Property(e => e.AttackPower).HasColumnName("attack_power");
            entity.Property(e => e.BlockChance).HasColumnName("block_chance");
            entity.Property(e => e.CritChance).HasColumnName("crit_chance");
            entity.Property(e => e.DodgeChance).HasColumnName("dodge_chance");
            entity.Property(e => e.FireRes).HasColumnName("fire_res");
            entity.Property(e => e.FrostRes).HasColumnName("frost_res");
            entity.Property(e => e.HolyRes).HasColumnName("holy_res");
            entity.Property(e => e.Intellect).HasColumnName("intellect");
            entity.Property(e => e.MaxHealth).HasColumnName("max_health");
            entity.Property(e => e.MaxPower1).HasColumnName("max_power1");
            entity.Property(e => e.MaxPower2).HasColumnName("max_power2");
            entity.Property(e => e.MaxPower3).HasColumnName("max_power3");
            entity.Property(e => e.MaxPower4).HasColumnName("max_power4");
            entity.Property(e => e.MaxPower5).HasColumnName("max_power5");
            entity.Property(e => e.MaxPower6).HasColumnName("max_power6");
            entity.Property(e => e.MaxPower7).HasColumnName("max_power7");
            entity.Property(e => e.NatureRes).HasColumnName("nature_res");
            entity.Property(e => e.ParryChance).HasColumnName("parry_chance");
            entity.Property(e => e.RangedAttackPower).HasColumnName("ranged_attack_power");
            entity.Property(e => e.RangedCritChance).HasColumnName("ranged_crit_chance");
            entity.Property(e => e.ShadowRes).HasColumnName("shadow_res");
            entity.Property(e => e.SpellCritChance).HasColumnName("spell_crit_chance");
            entity.Property(e => e.SpellDamage).HasColumnName("spell_damage");
            entity.Property(e => e.SpellHealing).HasColumnName("spell_healing");
            entity.Property(e => e.Spirit).HasColumnName("spirit");
            entity.Property(e => e.Stamina).HasColumnName("stamina");
            entity.Property(e => e.Strength).HasColumnName("strength");
        });

        modelBuilder.Entity<CharacterTutorial>(entity =>
        {
            entity.HasKey(e => e.Account).HasName("PRIMARY");

            entity.ToTable("character_tutorial", tb => tb.HasComment("Player System"));

            entity.Property(e => e.Account)
                .HasComment("Account Identifier")
                .HasColumnName("account");
            entity.Property(e => e.Tut0).HasColumnName("tut0");
            entity.Property(e => e.Tut1).HasColumnName("tut1");
            entity.Property(e => e.Tut2).HasColumnName("tut2");
            entity.Property(e => e.Tut3).HasColumnName("tut3");
            entity.Property(e => e.Tut4).HasColumnName("tut4");
            entity.Property(e => e.Tut5).HasColumnName("tut5");
            entity.Property(e => e.Tut6).HasColumnName("tut6");
            entity.Property(e => e.Tut7).HasColumnName("tut7");
        });

        modelBuilder.Entity<CharactersGuidDelete>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("characters_guid_delete");

            entity.HasIndex(e => e.Guid, "key_guid").IsUnique();

            entity.Property(e => e.Guid).HasColumnName("guid");
        });

        modelBuilder.Entity<CharactersItemDelete>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("characters_item_delete");

            entity.HasIndex(e => e.Entry, "key_entry").IsUnique();

            entity.Property(e => e.Entry).HasColumnName("entry");
        });

        modelBuilder.Entity<Corpse>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("corpse", tb => tb.HasComment("Death System"));

            entity.HasIndex(e => e.Instance, "idx_instance");

            entity.HasIndex(e => e.PlayerGuid, "idx_player");

            entity.HasIndex(e => e.Time, "idx_time");

            entity.HasIndex(e => e.CorpseType, "idx_type");

            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.CorpseType).HasColumnName("corpse_type");
            entity.Property(e => e.Instance).HasColumnName("instance");
            entity.Property(e => e.Map)
                .HasComment("Map Identifier")
                .HasColumnName("map");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PlayerGuid)
                .HasComment("Character Global Unique Identifier")
                .HasColumnName("player_guid");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
            entity.Property(e => e.Time).HasColumnName("time");
        });

        modelBuilder.Entity<CreatureRespawn>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Instance }).HasName("PRIMARY");

            entity.ToTable("creature_respawn", tb => tb.HasComment("Grid Loading System"));

            entity.HasIndex(e => e.Instance, "idx_instance");

            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Instance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("instance");
            entity.Property(e => e.Map)
                .HasDefaultValueSql("'0'")
                .HasColumnName("map");
            entity.Property(e => e.RespawnTime).HasColumnName("respawn_time");
        });

        modelBuilder.Entity<GameEventStatus>(entity =>
        {
            entity.HasKey(e => e.Event).HasName("PRIMARY");

            entity.ToTable("game_event_status", tb => tb.HasComment("Game event system"));

            entity.Property(e => e.Event).HasColumnName("event");
        });

        modelBuilder.Entity<GameobjectRespawn>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Instance }).HasName("PRIMARY");

            entity.ToTable("gameobject_respawn", tb => tb.HasComment("Grid Loading System"));

            entity.HasIndex(e => e.Instance, "idx_instance");

            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Instance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("instance");
            entity.Property(e => e.Map)
                .HasDefaultValueSql("'0'")
                .HasColumnName("map");
            entity.Property(e => e.RespawnTime).HasColumnName("respawn_time");
        });

        modelBuilder.Entity<GmSubsurvey>(entity =>
        {
            entity.HasKey(e => new { e.SurveyId, e.SubsurveyId }).HasName("PRIMARY");

            entity.ToTable("gm_subsurveys", tb => tb.HasComment("Player System"));

            entity.Property(e => e.SurveyId)
                .ValueGeneratedOnAdd()
                .HasColumnName("survey_id");
            entity.Property(e => e.SubsurveyId).HasColumnName("subsurvey_id");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.Rank).HasColumnName("rank");
        });

        modelBuilder.Entity<GmSurvey>(entity =>
        {
            entity.HasKey(e => e.SurveyId).HasName("PRIMARY");

            entity.ToTable("gm_surveys", tb => tb.HasComment("Player System"));

            entity.Property(e => e.SurveyId).HasColumnName("survey_id");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.MainSurvey).HasColumnName("main_survey");
            entity.Property(e => e.OverallComment).HasColumnName("overall_comment");
        });

        modelBuilder.Entity<GmTicket>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("PRIMARY");

            entity.ToTable("gm_tickets", tb => tb.HasComment("Player System"));

            entity.Property(e => e.TicketId).HasColumnName("ticket_id");
            entity.Property(e => e.AssignedTo)
                .HasComment("GUID of admin to whom ticket is assigned")
                .HasColumnName("assigned_to");
            entity.Property(e => e.ClosedBy).HasColumnName("closed_by");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.Completed).HasColumnName("completed");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.Escalated).HasColumnName("escalated");
            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier of ticket creator")
                .HasColumnName("guid");
            entity.Property(e => e.HaveTicket).HasColumnName("have_ticket");
            entity.Property(e => e.LastModifiedTime).HasColumnName("last_modified_time");
            entity.Property(e => e.Map).HasColumnName("map");
            entity.Property(e => e.Message)
                .HasColumnType("text")
                .HasColumnName("message");
            entity.Property(e => e.Name)
                .HasMaxLength(12)
                .HasComment("Name of ticket creator")
                .HasColumnName("name");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
            entity.Property(e => e.Response)
                .HasColumnType("text")
                .HasColumnName("response");
            entity.Property(e => e.SecurityNeeded).HasColumnName("security_needed");
            entity.Property(e => e.TicketType).HasColumnName("ticket_type");
            entity.Property(e => e.Viewed).HasColumnName("viewed");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PRIMARY");

            entity.ToTable("groups", tb => tb.HasComment("Groups"));

            entity.HasIndex(e => e.LeaderGuid, "key_leaderGuid").IsUnique();

            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.Icon1).HasColumnName("icon1");
            entity.Property(e => e.Icon2).HasColumnName("icon2");
            entity.Property(e => e.Icon3).HasColumnName("icon3");
            entity.Property(e => e.Icon4).HasColumnName("icon4");
            entity.Property(e => e.Icon5).HasColumnName("icon5");
            entity.Property(e => e.Icon6).HasColumnName("icon6");
            entity.Property(e => e.Icon7).HasColumnName("icon7");
            entity.Property(e => e.Icon8).HasColumnName("icon8");
            entity.Property(e => e.IsRaid).HasColumnName("is_raid");
            entity.Property(e => e.LeaderGuid).HasColumnName("leader_guid");
            entity.Property(e => e.LootMethod).HasColumnName("loot_method");
            entity.Property(e => e.LootThreshold).HasColumnName("loot_threshold");
            entity.Property(e => e.LooterGuid).HasColumnName("looter_guid");
            entity.Property(e => e.MainAssistantGuid).HasColumnName("main_assistant_guid");
            entity.Property(e => e.MainTankGuid).HasColumnName("main_tank_guid");
        });

        modelBuilder.Entity<GroupInstance>(entity =>
        {
            entity.HasKey(e => new { e.LeaderGuid, e.Instance }).HasName("PRIMARY");

            entity.ToTable("group_instance");

            entity.HasIndex(e => e.Instance, "idx_instance");

            entity.Property(e => e.LeaderGuid).HasColumnName("leader_guid");
            entity.Property(e => e.Instance).HasColumnName("instance");
            entity.Property(e => e.Permanent).HasColumnName("permanent");
        });

        modelBuilder.Entity<GroupMember>(entity =>
        {
            entity.HasKey(e => new { e.GroupId, e.MemberGuid }).HasName("PRIMARY");

            entity.ToTable("group_member", tb => tb.HasComment("Groups"));

            entity.HasIndex(e => e.MemberGuid, "idx_memberGuid");

            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.MemberGuid).HasColumnName("member_guid");
            entity.Property(e => e.Assistant).HasColumnName("assistant");
            entity.Property(e => e.Subgroup).HasColumnName("subgroup");
        });

        modelBuilder.Entity<Guild>(entity =>
        {
            entity.HasKey(e => e.GuildId).HasName("PRIMARY");

            entity.ToTable("guild", tb => tb.HasComment("Guild System"));

            entity.Property(e => e.GuildId).HasColumnName("guild_id");
            entity.Property(e => e.BackgroundColor).HasColumnName("background_color");
            entity.Property(e => e.BorderColor).HasColumnName("border_color");
            entity.Property(e => e.BorderStyle).HasColumnName("border_style");
            entity.Property(e => e.CreateDate).HasColumnName("create_date");
            entity.Property(e => e.EmblemColor).HasColumnName("emblem_color");
            entity.Property(e => e.EmblemStyle).HasColumnName("emblem_style");
            entity.Property(e => e.Info)
                .HasColumnType("text")
                .HasColumnName("info");
            entity.Property(e => e.LeaderGuid).HasColumnName("leader_guid");
            entity.Property(e => e.Motd)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("motd");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
        });

        modelBuilder.Entity<GuildEventlog>(entity =>
        {
            entity.HasKey(e => new { e.GuildId, e.LogGuid }).HasName("PRIMARY");

            entity.ToTable("guild_eventlog", tb => tb.HasComment("Guild Eventlog"));

            entity.HasIndex(e => e.LogGuid, "idx_LogGuid");

            entity.HasIndex(e => e.PlayerGuid1, "idx_PlayerGuid1");

            entity.HasIndex(e => e.PlayerGuid2, "idx_PlayerGuid2");

            entity.Property(e => e.GuildId)
                .HasComment("Guild Identificator")
                .HasColumnName("guild_id");
            entity.Property(e => e.LogGuid)
                .HasComment("Log record identificator - auxiliary column")
                .HasColumnName("log_guid");
            entity.Property(e => e.EventType)
                .HasComment("Event type")
                .HasColumnName("event_type");
            entity.Property(e => e.NewRank)
                .HasComment("New rank(in case promotion/demotion)")
                .HasColumnName("new_rank");
            entity.Property(e => e.PlayerGuid1)
                .HasComment("Player 1")
                .HasColumnName("player_guid1");
            entity.Property(e => e.PlayerGuid2)
                .HasComment("Player 2")
                .HasColumnName("player_guid2");
            entity.Property(e => e.Timestamp)
                .HasComment("Event UNIX time")
                .HasColumnName("timestamp");
        });

        modelBuilder.Entity<GuildMember>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("guild_member", tb => tb.HasComment("Guild System"));

            entity.HasIndex(e => e.GuildId, "idx_guildid");

            entity.HasIndex(e => new { e.GuildId, e.Rank }, "idx_guildid_rank");

            entity.HasIndex(e => e.Guid, "key_guid").IsUnique();

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.GuildId).HasColumnName("guild_id");
            entity.Property(e => e.OfficerNote)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("officer_note");
            entity.Property(e => e.PlayerNote)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("player_note");
            entity.Property(e => e.Rank).HasColumnName("rank");
        });

        modelBuilder.Entity<GuildRank>(entity =>
        {
            entity.HasKey(e => new { e.GuildId, e.Id }).HasName("PRIMARY");

            entity.ToTable("guild_rank", tb => tb.HasComment("Guild System"));

            entity.HasIndex(e => e.Id, "idx_rid");

            entity.Property(e => e.GuildId).HasColumnName("guild_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Rights).HasColumnName("rights");
        });

        modelBuilder.Entity<Instance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("instance");

            entity.HasIndex(e => e.Map, "idx_map");

            entity.HasIndex(e => e.ResetTime, "idx_resettime");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Map).HasColumnName("map");
            entity.Property(e => e.ResetTime).HasColumnName("reset_time");
        });

        modelBuilder.Entity<InstanceReset>(entity =>
        {
            entity.HasKey(e => e.Map).HasName("PRIMARY");

            entity.ToTable("instance_reset");

            entity.Property(e => e.Map).HasColumnName("map");
            entity.Property(e => e.ResetTime).HasColumnName("reset_time");
        });

        modelBuilder.Entity<ItemInstance>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("item_instance", tb => tb.HasComment("Item System"));

            entity.HasIndex(e => e.ItemId, "idx_itemEntry");

            entity.HasIndex(e => e.OwnerGuid, "idx_owner_guid");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Charges)
                .HasColumnType("tinytext")
                .HasColumnName("charges");
            entity.Property(e => e.Count)
                .HasDefaultValueSql("'1'")
                .HasColumnName("count");
            entity.Property(e => e.CreatorGuid).HasColumnName("creator_guid");
            entity.Property(e => e.Durability).HasColumnName("durability");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.Enchantments)
                .HasColumnType("text")
                .HasColumnName("enchantments");
            entity.Property(e => e.Flags)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("flags");
            entity.Property(e => e.GeneratedLoot)
                .HasDefaultValueSql("'0'")
                .HasColumnName("generated_loot");
            entity.Property(e => e.GiftCreatorGuid).HasColumnName("gift_creator_guid");
            entity.Property(e => e.ItemId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("item_id");
            entity.Property(e => e.OwnerGuid).HasColumnName("owner_guid");
            entity.Property(e => e.RandomPropertyId).HasColumnName("random_property_id");
            entity.Property(e => e.Text).HasColumnName("text");
        });

        modelBuilder.Entity<ItemLoot>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.ItemId }).HasName("PRIMARY");

            entity.ToTable("item_loot", tb => tb.HasComment("Item System"));

            entity.HasIndex(e => e.OwnerGuid, "idx_owner_guid");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.OwnerGuid).HasColumnName("owner_guid");
            entity.Property(e => e.Property).HasColumnName("property");
        });

        modelBuilder.Entity<ItemText>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("item_text", tb => tb.HasComment("Item System"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Text).HasColumnName("text");
        });

        modelBuilder.Entity<Mail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mail", tb => tb.HasComment("Mail System"));

            entity.HasIndex(e => e.ReceiverGuid, "idx_receiver");

            entity.Property(e => e.Id)
                .HasComment("Identifier")
                .HasColumnName("id");
            entity.Property(e => e.Checked).HasColumnName("checked");
            entity.Property(e => e.Cod).HasColumnName("cod");
            entity.Property(e => e.DeliverTime).HasColumnName("deliver_time");
            entity.Property(e => e.ExpireTime).HasColumnName("expire_time");
            entity.Property(e => e.HasItems).HasColumnName("has_items");
            entity.Property(e => e.ItemTextId).HasColumnName("item_text_id");
            entity.Property(e => e.MailTemplateId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint unsigned")
                .HasColumnName("mail_template_id");
            entity.Property(e => e.MessageType).HasColumnName("message_type");
            entity.Property(e => e.Money).HasColumnName("money");
            entity.Property(e => e.ReceiverGuid)
                .HasComment("Character Global Unique Identifier")
                .HasColumnName("receiver_guid");
            entity.Property(e => e.SenderGuid)
                .HasComment("Character Global Unique Identifier")
                .HasColumnName("sender_guid");
            entity.Property(e => e.Stationery)
                .HasDefaultValueSql("'41'")
                .HasColumnName("stationery");
            entity.Property(e => e.Subject).HasColumnName("subject");
        });

        modelBuilder.Entity<MailItem>(entity =>
        {
            entity.HasKey(e => new { e.MailId, e.ItemGuid }).HasName("PRIMARY");

            entity.ToTable("mail_items");

            entity.HasIndex(e => e.ItemGuid, "idx_item_guid");

            entity.HasIndex(e => e.ReceiverGuid, "idx_receiver");

            entity.Property(e => e.MailId).HasColumnName("mail_id");
            entity.Property(e => e.ItemGuid).HasColumnName("item_guid");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ReceiverGuid)
                .HasComment("Character Global Unique Identifier")
                .HasColumnName("receiver_guid");
        });

        modelBuilder.Entity<Migration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("migrations");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<PetAura>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.CasterGuid, e.ItemGuid, e.Spell }).HasName("PRIMARY");

            entity.ToTable("pet_aura", tb => tb.HasComment("Pet System"));

            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.CasterGuid)
                .HasComment("Full Global Unique Identifier")
                .HasColumnName("caster_guid");
            entity.Property(e => e.ItemGuid).HasColumnName("item_guid");
            entity.Property(e => e.Spell).HasColumnName("spell");
            entity.Property(e => e.BasePoints0).HasColumnName("base_points0");
            entity.Property(e => e.BasePoints1).HasColumnName("base_points1");
            entity.Property(e => e.BasePoints2).HasColumnName("base_points2");
            entity.Property(e => e.Charges).HasColumnName("charges");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.EffectIndexMask).HasColumnName("effect_index_mask");
            entity.Property(e => e.MaxDuration).HasColumnName("max_duration");
            entity.Property(e => e.PeriodicTime0).HasColumnName("periodic_time0");
            entity.Property(e => e.PeriodicTime1).HasColumnName("periodic_time1");
            entity.Property(e => e.PeriodicTime2).HasColumnName("periodic_time2");
            entity.Property(e => e.Stacks)
                .HasDefaultValueSql("'1'")
                .HasColumnName("stacks");
        });

        modelBuilder.Entity<PetSpell>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Spell }).HasName("PRIMARY");

            entity.ToTable("pet_spell", tb => tb.HasComment("Pet System"));

            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Spell)
                .HasComment("Spell Identifier")
                .HasColumnName("spell");
            entity.Property(e => e.Active).HasColumnName("active");
        });

        modelBuilder.Entity<PetSpellCooldown>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Spell }).HasName("PRIMARY");

            entity.ToTable("pet_spell_cooldown");

            entity.Property(e => e.Guid)
                .HasComment("Global Unique Identifier, Low part")
                .HasColumnName("guid");
            entity.Property(e => e.Spell)
                .HasComment("Spell Identifier")
                .HasColumnName("spell");
            entity.Property(e => e.Time).HasColumnName("time");
        });

        modelBuilder.Entity<Petition>(entity =>
        {
            entity.HasKey(e => e.OwnerGuid).HasName("PRIMARY");

            entity.ToTable("petition", tb => tb.HasComment("Guild System"));

            entity.HasIndex(e => e.CharterGuid, "charterguid").IsUnique();

            entity.HasIndex(e => new { e.OwnerGuid, e.PetitionGuid }, "key_ownerguid_petitionguid").IsUnique();

            entity.Property(e => e.OwnerGuid).HasColumnName("owner_guid");
            entity.Property(e => e.CharterGuid)
                .HasComment("Charter item GUID")
                .HasColumnName("charter_guid");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.PetitionGuid)
                .HasDefaultValueSql("'0'")
                .HasColumnName("petition_guid");
        });

        modelBuilder.Entity<PetitionSign>(entity =>
        {
            entity.HasKey(e => new { e.PetitionGuid, e.PlayerGuid }).HasName("PRIMARY");

            entity.ToTable("petition_sign", tb => tb.HasComment("Guild System"));

            entity.HasIndex(e => e.OwnerGuid, "idx_ownerguid");

            entity.HasIndex(e => e.PlayerGuid, "idx_playerguid");

            entity.Property(e => e.PetitionGuid).HasColumnName("petition_guid");
            entity.Property(e => e.PlayerGuid).HasColumnName("player_guid");
            entity.Property(e => e.OwnerGuid).HasColumnName("owner_guid");
            entity.Property(e => e.PlayerAccount).HasColumnName("player_account");
        });

        modelBuilder.Entity<Playerbot>(entity =>
        {
            entity.HasKey(e => e.CharGuid).HasName("PRIMARY");

            entity.ToTable("playerbot");

            entity.Property(e => e.CharGuid).HasColumnName("char_guid");
            entity.Property(e => e.Ai)
                .HasMaxLength(50)
                .HasColumnName("ai");
            entity.Property(e => e.Chance)
                .HasDefaultValueSql("'10'")
                .HasColumnName("chance");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasColumnName("comment");
        });

        modelBuilder.Entity<SavedVariable>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("PRIMARY");

            entity.ToTable("saved_variables", tb => tb.HasComment("Variable Saves"));

            entity.Property(e => e.Key).HasColumnName("key");
            entity.Property(e => e.CleaningFlags).HasColumnName("cleaning_flags");
            entity.Property(e => e.HonorLastMaintenanceDay).HasColumnName("honor_last_maintenance_day");
            entity.Property(e => e.HonorMaintenanceMarker).HasColumnName("honor_maintenance_marker");
            entity.Property(e => e.HonorNextMaintenanceDay).HasColumnName("honor_next_maintenance_day");
        });

        modelBuilder.Entity<World>(entity =>
        {
            entity.HasKey(e => e.Map).HasName("PRIMARY");

            entity.ToTable("world");

            entity.Property(e => e.Map).HasColumnName("map");
            entity.Property(e => e.Data).HasColumnName("data");
        });

        modelBuilder.Entity<Worldstate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("worldstates");

            entity.HasIndex(e => e.Entry, "key_entry").IsUnique();

            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasColumnName("comment");
            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
