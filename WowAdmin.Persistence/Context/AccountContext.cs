using Microsoft.EntityFrameworkCore;

namespace WowAdmin.Persistence.Context;

public partial class AccountContext : DbContext
{
    public AccountContext()
    {
    }

    public AccountContext(DbContextOptions<AccountContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AccountAccess> AccountAccesses { get; set; }

    public virtual DbSet<AccountBanned> AccountBanneds { get; set; }

    public virtual DbSet<AllowedClient> AllowedClients { get; set; }

    public virtual DbSet<Geoip> Geoips { get; set; }

    public virtual DbSet<Ip2nation> Ip2nations { get; set; }

    public virtual DbSet<Ip2nationcountry> Ip2nationcountries { get; set; }

    public virtual DbSet<IpBanned> IpBanneds { get; set; }

    public virtual DbSet<Migration> Migrations { get; set; }

    public virtual DbSet<RbacAccountPermission> RbacAccountPermissions { get; set; }

    public virtual DbSet<RbacCommandPermission> RbacCommandPermissions { get; set; }

    public virtual DbSet<RbacPermission> RbacPermissions { get; set; }

    public virtual DbSet<Realmcharacter> Realmcharacters { get; set; }

    public virtual DbSet<Realmlist> Realmlists { get; set; }

    public virtual DbSet<Uptime> Uptimes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("account", tb => tb.HasComment("Account System"));

            entity.HasIndex(e => e.Gmlevel, "idx_gmlevel");

            entity.HasIndex(e => e.Username, "idx_username").IsUnique();

            entity.Property(e => e.Id)
                .HasComment("Identifier")
                .HasColumnName("id");
            entity.Property(e => e.CurrentRealm).HasColumnName("current_realm");
            entity.Property(e => e.Email)
                .HasColumnType("text")
                .HasColumnName("email");
            entity.Property(e => e.EmailVerif)
                .HasComment("Email verification")
                .HasColumnName("email_verif");
            entity.Property(e => e.Expansion).HasColumnName("expansion");
            entity.Property(e => e.FailedLogins).HasColumnName("failed_logins");
            entity.Property(e => e.Flags).HasColumnName("flags");
            entity.Property(e => e.GeolockPin)
                .HasDefaultValueSql("'0'")
                .HasColumnName("geolock_pin");
            entity.Property(e => e.Gmlevel).HasColumnName("gmlevel");
            entity.Property(e => e.Joindate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("joindate");
            entity.Property(e => e.LastIp)
                .HasMaxLength(30)
                .HasDefaultValueSql("'0.0.0.0'")
                .HasColumnName("last_ip");
            entity.Property(e => e.LastLogin)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("last_login");
            entity.Property(e => e.Locale).HasColumnName("locale");
            entity.Property(e => e.LockCountry)
                .HasMaxLength(2)
                .HasDefaultValueSql("'00'")
                .HasColumnName("lock_country");
            entity.Property(e => e.Locked).HasColumnName("locked");
            entity.Property(e => e.Mutetime).HasColumnName("mutetime");
            entity.Property(e => e.Online).HasColumnName("online");
            entity.Property(e => e.Os)
                .HasMaxLength(4)
                .HasDefaultValueSql("''")
                .HasColumnName("os");
            entity.Property(e => e.Platform)
                .HasMaxLength(4)
                .HasDefaultValueSql("''")
                .HasColumnName("platform");
            entity.Property(e => e.S).HasColumnName("s");
            entity.Property(e => e.Security)
                .HasMaxLength(255)
                .HasColumnName("security");
            entity.Property(e => e.Sessionkey).HasColumnName("sessionkey");
            entity.Property(e => e.TokenKey)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("token_key");
            entity.Property(e => e.Username)
                .HasMaxLength(32)
                .HasColumnName("username");
            entity.Property(e => e.V).HasColumnName("v");
        });

        modelBuilder.Entity<AccountAccess>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.RealmId }).HasName("PRIMARY");

            entity.ToTable("account_access");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RealmId).HasColumnName("RealmID");
            entity.Property(e => e.Gmlevel).HasColumnName("gmlevel");
        });

        modelBuilder.Entity<AccountBanned>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Bandate }).HasName("PRIMARY");

            entity.ToTable("account_banned", tb => tb.HasComment("Ban List"));

            entity.HasIndex(e => e.Banid, "banid").IsUnique();

            entity.Property(e => e.Id)
                .HasComment("Account id")
                .HasColumnName("id");
            entity.Property(e => e.Bandate).HasColumnName("bandate");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnName("active");
            entity.Property(e => e.Banid)
                .ValueGeneratedOnAdd()
                .HasColumnName("banid");
            entity.Property(e => e.Bannedby)
                .HasMaxLength(50)
                .HasColumnName("bannedby");
            entity.Property(e => e.Banreason)
                .HasMaxLength(255)
                .HasColumnName("banreason");
            entity.Property(e => e.Gmlevel).HasColumnName("gmlevel");
            entity.Property(e => e.Realm)
                .HasDefaultValueSql("'1'")
                .HasColumnName("realm");
            entity.Property(e => e.Unbandate).HasColumnName("unbandate");
        });

        modelBuilder.Entity<AllowedClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("allowed_clients");

            entity.Property(e => e.BugfixVersion).HasColumnName("bugfix_version");
            entity.Property(e => e.Build)
                .HasColumnType("mediumint unsigned")
                .HasColumnName("build");
            entity.Property(e => e.HotfixVersion)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("hotfix_version");
            entity.Property(e => e.IntegrityHash)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("integrity_hash");
            entity.Property(e => e.MajorVersion).HasColumnName("major_version");
            entity.Property(e => e.MinorVersion).HasColumnName("minor_version");
            entity.Property(e => e.Os)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("os");
            entity.Property(e => e.Platform)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("platform");
        });

        modelBuilder.Entity<Geoip>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("geoip");

            entity.HasIndex(e => e.NetworkLastInteger, "ip_end");

            entity.HasIndex(e => e.NetworkStartInteger, "ip_start");

            entity.Property(e => e.AccuracyRadius).HasColumnName("accuracy_radius");
            entity.Property(e => e.GeonameId)
                .HasColumnType("text")
                .HasColumnName("geoname_id");
            entity.Property(e => e.IsAnonymousProxy).HasColumnName("is_anonymous_proxy");
            entity.Property(e => e.IsSatelliteProvider).HasColumnName("is_satellite_provider");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
            entity.Property(e => e.NetworkLastInteger).HasColumnName("network_last_integer");
            entity.Property(e => e.NetworkStartInteger).HasColumnName("network_start_integer");
            entity.Property(e => e.PostalCode)
                .HasColumnType("text")
                .HasColumnName("postal_code");
            entity.Property(e => e.RegisteredCountryGeonameId)
                .HasColumnType("text")
                .HasColumnName("registered_country_geoname_id");
            entity.Property(e => e.RepresentedCountryGeonameId)
                .HasColumnType("text")
                .HasColumnName("represented_country_geoname_id");
        });

        modelBuilder.Entity<Ip2nation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ip2nation");

            entity.HasIndex(e => e.Ip, "ip");

            entity.Property(e => e.Country)
                .HasMaxLength(2)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("country");
            entity.Property(e => e.Ip).HasColumnName("ip");
        });

        modelBuilder.Entity<Ip2nationcountry>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PRIMARY");

            entity.ToTable("ip2nationcountries");

            entity.HasIndex(e => e.Code, "code");

            entity.Property(e => e.Code)
                .HasMaxLength(4)
                .HasDefaultValueSql("''")
                .HasColumnName("code");
            entity.Property(e => e.Country)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("country");
            entity.Property(e => e.IsoCode2)
                .HasMaxLength(2)
                .HasDefaultValueSql("''")
                .HasColumnName("iso_code_2");
            entity.Property(e => e.IsoCode3)
                .HasMaxLength(3)
                .HasDefaultValueSql("''")
                .HasColumnName("iso_code_3");
            entity.Property(e => e.IsoCountry)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("iso_country");
            entity.Property(e => e.Lat).HasColumnName("lat");
            entity.Property(e => e.Lon).HasColumnName("lon");
        });

        modelBuilder.Entity<IpBanned>(entity =>
        {
            entity.HasKey(e => e.Ip).HasName("PRIMARY");

            entity.ToTable("ip_banned", tb => tb.HasComment("Banned IPs"));

            entity.Property(e => e.Ip)
                .HasMaxLength(32)
                .HasDefaultValueSql("'0.0.0.0'")
                .HasColumnName("ip");
            entity.Property(e => e.Bandate).HasColumnName("bandate");
            entity.Property(e => e.Bannedby)
                .HasMaxLength(50)
                .HasDefaultValueSql("'[Console]'")
                .HasColumnName("bannedby");
            entity.Property(e => e.Banreason)
                .HasMaxLength(50)
                .HasDefaultValueSql("'no reason'")
                .HasColumnName("banreason");
            entity.Property(e => e.Unbandate).HasColumnName("unbandate");
        });

        modelBuilder.Entity<Migration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("migrations");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<RbacAccountPermission>(entity =>
        {
            entity.HasKey(e => new { e.AccountId, e.PermissionId }).HasName("PRIMARY");

            entity.ToTable("rbac_account_permissions");

            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");
            entity.Property(e => e.Granted)
                .HasDefaultValueSql("'1'")
                .HasColumnName("granted");
        });

        modelBuilder.Entity<RbacCommandPermission>(entity =>
        {
            entity.HasKey(e => new { e.Command, e.PermissionId }).HasName("PRIMARY");

            entity.ToTable("rbac_command_permissions");

            entity.Property(e => e.Command)
                .HasMaxLength(128)
                .HasColumnName("command");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");
        });

        modelBuilder.Entity<RbacPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("rbac_permissions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Realmcharacter>(entity =>
        {
            entity.HasKey(e => new { e.Realmid, e.Acctid }).HasName("PRIMARY");

            entity.ToTable("realmcharacters", tb => tb.HasComment("Realm Character Tracker"));

            entity.HasIndex(e => e.Acctid, "acctid");

            entity.Property(e => e.Realmid).HasColumnName("realmid");
            entity.Property(e => e.Acctid).HasColumnName("acctid");
            entity.Property(e => e.Numchars).HasColumnName("numchars");
        });

        modelBuilder.Entity<Realmlist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("realmlist", tb => tb.HasComment("Realm System"));

            entity.HasIndex(e => e.Name, "idx_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(32)
                .HasDefaultValueSql("'127.0.0.1'")
                .HasColumnName("address");
            entity.Property(e => e.AllowedSecurityLevel).HasColumnName("allowedSecurityLevel");
            entity.Property(e => e.Flag)
                .HasDefaultValueSql("'2'")
                .HasColumnName("flag");
            entity.Property(e => e.GamebuildMax).HasColumnName("gamebuild_max");
            entity.Property(e => e.GamebuildMin).HasColumnName("gamebuild_min");
            entity.Property(e => e.Icon).HasColumnName("icon");
            entity.Property(e => e.LocalAddress)
                .HasMaxLength(255)
                .HasDefaultValueSql("'127.0.0.1'")
                .HasColumnName("localAddress");
            entity.Property(e => e.LocalSubnetMask)
                .HasMaxLength(255)
                .HasDefaultValueSql("'255.255.255.0'")
                .HasColumnName("localSubnetMask");
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Port)
                .HasDefaultValueSql("'8085'")
                .HasColumnName("port");
            entity.Property(e => e.Realmbuilds)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("realmbuilds");
            entity.Property(e => e.Realmflags)
                .HasDefaultValueSql("'2'")
                .HasColumnName("realmflags");
            entity.Property(e => e.Timezone).HasColumnName("timezone");
        });

        modelBuilder.Entity<Uptime>(entity =>
        {
            entity.HasKey(e => new { e.Realmid, e.Starttime }).HasName("PRIMARY");

            entity.ToTable("uptime", tb => tb.HasComment("Uptime system"));

            entity.Property(e => e.Realmid).HasColumnName("realmid");
            entity.Property(e => e.Starttime).HasColumnName("starttime");
            entity.Property(e => e.Maxplayers).HasColumnName("maxplayers");
            entity.Property(e => e.Onlineplayers).HasColumnName("onlineplayers");
            entity.Property(e => e.Revision)
                .HasMaxLength(255)
                .HasDefaultValueSql("'VMangos'")
                .HasColumnName("revision");
            entity.Property(e => e.Startstring)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("startstring");
            entity.Property(e => e.Uptime1).HasColumnName("uptime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
