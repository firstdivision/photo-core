using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PhotoCore.DataAccess.MySql.Models
{
    public partial class firstdi_coppermineContext : DbContext
    {
        public firstdi_coppermineContext()
        {
        }

        public firstdi_coppermineContext(DbContextOptions<firstdi_coppermineContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CmineAlbums> CmineAlbums { get; set; }
        public virtual DbSet<CmineBanned> CmineBanned { get; set; }
        public virtual DbSet<CmineBridge> CmineBridge { get; set; }
        public virtual DbSet<CmineCategories> CmineCategories { get; set; }
        public virtual DbSet<CmineCategorymap> CmineCategorymap { get; set; }
        public virtual DbSet<CmineComments> CmineComments { get; set; }
        public virtual DbSet<CmineConfig> CmineConfig { get; set; }
        public virtual DbSet<CmineDict> CmineDict { get; set; }
        public virtual DbSet<CmineEcards> CmineEcards { get; set; }
        public virtual DbSet<CmineExif> CmineExif { get; set; }
        public virtual DbSet<CmineFavpics> CmineFavpics { get; set; }
        public virtual DbSet<CmineFiletypes> CmineFiletypes { get; set; }
        public virtual DbSet<CmineHitStats> CmineHitStats { get; set; }
        public virtual DbSet<CmineLanguages> CmineLanguages { get; set; }
        public virtual DbSet<CminePictures> CminePictures { get; set; }
        public virtual DbSet<CminePlugins> CminePlugins { get; set; }
        public virtual DbSet<CmineSessions> CmineSessions { get; set; }
        public virtual DbSet<CmineTempMessages> CmineTempMessages { get; set; }
        public virtual DbSet<CmineUsergroups> CmineUsergroups { get; set; }
        public virtual DbSet<CmineUsers> CmineUsers { get; set; }
        public virtual DbSet<CmineVoteStats> CmineVoteStats { get; set; }
        public virtual DbSet<CmineVotes> CmineVotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CmineAlbums>(entity =>
            {
                entity.HasKey(e => e.Aid)
                    .HasName("PRIMARY");

                entity.ToTable("cmine_albums");

                entity.HasIndex(e => e.Category)
                    .HasName("alb_category");

                entity.HasIndex(e => e.ModeratorGroup)
                    .HasName("moderator_group");

                entity.Property(e => e.Aid)
                    .HasColumnName("aid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlbHits)
                    .HasColumnName("alb_hits")
                    .HasColumnType("int(10)");

                entity.Property(e => e.AlbPassword)
                    .HasColumnName("alb_password")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AlbPasswordHint).HasColumnName("alb_password_hint");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments")
                    .HasColumnType("enum('YES','NO')")
                    .HasDefaultValueSql("'YES'");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Keyword)
                    .IsRequired()
                    .HasColumnName("keyword")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LastAddition)
                    .HasColumnName("last_addition")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModeratorGroup)
                    .HasColumnName("moderator_group")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.PicCount)
                    .HasColumnName("pic_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pos)
                    .HasColumnName("pos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StatUptodate)
                    .IsRequired()
                    .HasColumnName("stat_uptodate")
                    .HasColumnType("enum('YES','NO')")
                    .HasDefaultValueSql("'NO'");

                entity.Property(e => e.Thumb)
                    .HasColumnName("thumb")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Uploads)
                    .IsRequired()
                    .HasColumnName("uploads")
                    .HasColumnType("enum('YES','NO')")
                    .HasDefaultValueSql("'NO'");

                entity.Property(e => e.Visibility)
                    .HasColumnName("visibility")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Votes)
                    .IsRequired()
                    .HasColumnName("votes")
                    .HasColumnType("enum('YES','NO')")
                    .HasDefaultValueSql("'YES'");
            });

            modelBuilder.Entity<CmineBanned>(entity =>
            {
                entity.HasKey(e => e.BanId)
                    .HasName("PRIMARY");

                entity.ToTable("cmine_banned");

                entity.Property(e => e.BanId)
                    .HasColumnName("ban_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BruteForce)
                    .HasColumnName("brute_force")
                    .HasColumnType("tinyint(5)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Expiry).HasColumnName("expiry");

                entity.Property(e => e.IpAddr)
                    .HasColumnName("ip_addr")
                    .HasColumnType("tinytext");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CmineBridge>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cmine_bridge");

                entity.HasIndex(e => e.Name)
                    .HasName("name")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CmineCategories>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PRIMARY");

                entity.ToTable("cmine_categories");

                entity.HasIndex(e => e.OwnerId)
                    .HasName("cat_owner_id");

                entity.HasIndex(e => e.Parent)
                    .HasName("cat_parent");

                entity.HasIndex(e => e.Pos)
                    .HasName("cat_pos");

                entity.HasIndex(e => new { e.Depth, e.Cid })
                    .HasName("depth_cid");

                entity.HasIndex(e => new { e.Lft, e.Depth })
                    .HasName("lft_depth");

                entity.Property(e => e.Cid)
                    .HasColumnName("cid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlbCount)
                    .HasColumnName("alb_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Depth)
                    .HasColumnName("depth")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Lft)
                    .HasColumnName("lft")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Parent)
                    .HasColumnName("parent")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PicCount)
                    .HasColumnName("pic_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pos)
                    .HasColumnName("pos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Rgt)
                    .HasColumnName("rgt")
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StatUptodate)
                    .IsRequired()
                    .HasColumnName("stat_uptodate")
                    .HasColumnType("enum('YES','NO')")
                    .HasDefaultValueSql("'NO'");

                entity.Property(e => e.SubcatCount)
                    .HasColumnName("subcat_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Thumb)
                    .HasColumnName("thumb")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CmineCategorymap>(entity =>
            {
                entity.HasKey(e => new { e.Cid, e.GroupId })
                    .HasName("PRIMARY");

                entity.ToTable("cmine_categorymap");

                entity.HasComment("Holds the categories where groups can create albums");

                entity.Property(e => e.Cid)
                    .HasColumnName("cid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CmineComments>(entity =>
            {
                entity.HasKey(e => e.MsgId)
                    .HasName("PRIMARY");

                entity.ToTable("cmine_comments");

                entity.HasIndex(e => e.AuthorId)
                    .HasName("author_id");

                entity.HasIndex(e => e.Pid)
                    .HasName("com_pic_id");

                entity.Property(e => e.MsgId)
                    .HasColumnName("msg_id")
                    .HasColumnType("mediumint(10)");

                entity.Property(e => e.Approval)
                    .IsRequired()
                    .HasColumnName("approval")
                    .HasColumnType("enum('YES','NO')")
                    .HasDefaultValueSql("'YES'");

                entity.Property(e => e.AuthorId)
                    .HasColumnName("author_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AuthorMd5Id)
                    .IsRequired()
                    .HasColumnName("author_md5_id")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MsgAuthor)
                    .IsRequired()
                    .HasColumnName("msg_author")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MsgBody)
                    .IsRequired()
                    .HasColumnName("msg_body");

                entity.Property(e => e.MsgDate)
                    .HasColumnName("msg_date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.MsgHdrIp)
                    .HasColumnName("msg_hdr_ip")
                    .HasColumnType("tinytext");

                entity.Property(e => e.MsgRawIp)
                    .HasColumnName("msg_raw_ip")
                    .HasColumnType("tinytext");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .HasColumnType("mediumint(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spam)
                    .IsRequired()
                    .HasColumnName("spam")
                    .HasColumnType("enum('YES','NO')")
                    .HasDefaultValueSql("'NO'");
            });

            modelBuilder.Entity<CmineConfig>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PRIMARY");

                entity.ToTable("cmine_config");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CmineDict>(entity =>
            {
                entity.HasKey(e => e.KeyId)
                    .HasName("PRIMARY");

                entity.ToTable("cmine_dict");

                entity.HasComment("Holds the keyword dictionary");

                entity.HasIndex(e => e.Keyword)
                    .HasName("keyword")
                    .IsUnique();

                entity.Property(e => e.KeyId)
                    .HasColumnName("keyId")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Keyword)
                    .IsRequired()
                    .HasColumnName("keyword")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CmineEcards>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PRIMARY");

                entity.ToTable("cmine_ecards");

                entity.HasComment("Used to log ecards");

                entity.Property(e => e.Eid)
                    .HasColumnName("eid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasColumnName("date")
                    .HasColumnType("tinytext");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasColumnName("link");

                entity.Property(e => e.RecipientEmail)
                    .IsRequired()
                    .HasColumnName("recipient_email");

                entity.Property(e => e.RecipientName)
                    .IsRequired()
                    .HasColumnName("recipient_name")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SenderEmail)
                    .IsRequired()
                    .HasColumnName("sender_email");

                entity.Property(e => e.SenderIp)
                    .IsRequired()
                    .HasColumnName("sender_ip")
                    .HasColumnType("tinytext");

                entity.Property(e => e.SenderName)
                    .IsRequired()
                    .HasColumnName("sender_name")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CmineExif>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PRIMARY");

                entity.ToTable("cmine_exif");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExifData)
                    .IsRequired()
                    .HasColumnName("exifData");
            });

            modelBuilder.Entity<CmineFavpics>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("cmine_favpics");

                entity.HasComment("Stores the server side favourites");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserFavpics)
                    .IsRequired()
                    .HasColumnName("user_favpics");
            });

            modelBuilder.Entity<CmineFiletypes>(entity =>
            {
                entity.HasKey(e => e.Extension)
                    .HasName("PRIMARY");

                entity.ToTable("cmine_filetypes");

                entity.HasComment("Used to store the file extensions");

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Mime)
                    .HasColumnName("mime")
                    .HasMaxLength(254)
                    .IsFixedLength();

                entity.Property(e => e.Player)
                    .HasColumnName("player")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CmineHitStats>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PRIMARY");

                entity.ToTable("cmine_hit_stats");

                entity.Property(e => e.Sid)
                    .HasColumnName("sid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Browser)
                    .IsRequired()
                    .HasColumnName("browser")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Os)
                    .IsRequired()
                    .HasColumnName("os")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Pid)
                    .IsRequired()
                    .HasColumnName("pid")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Referer)
                    .IsRequired()
                    .HasColumnName("referer");

                entity.Property(e => e.Sdate)
                    .HasColumnName("sdate")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.SearchPhrase)
                    .IsRequired()
                    .HasColumnName("search_phrase")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CmineLanguages>(entity =>
            {
                entity.HasKey(e => e.LangId)
                    .HasName("PRIMARY");

                entity.ToTable("cmine_languages");

                entity.HasComment("Contains the language file definitions");

                entity.Property(e => e.LangId)
                    .HasColumnName("lang_id")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Abbr)
                    .IsRequired()
                    .HasColumnName("abbr")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Available)
                    .IsRequired()
                    .HasColumnName("available")
                    .HasColumnType("enum('YES','NO')")
                    .HasDefaultValueSql("'NO'");

                entity.Property(e => e.Complete)
                    .IsRequired()
                    .HasColumnName("complete")
                    .HasColumnType("enum('YES','NO')")
                    .HasDefaultValueSql("'NO'");

                entity.Property(e => e.CustomName)
                    .HasColumnName("custom_name")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasColumnName("enabled")
                    .HasColumnType("enum('YES','NO')")
                    .HasDefaultValueSql("'NO'");

                entity.Property(e => e.EnglishName)
                    .HasColumnName("english_name")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NativeName)
                    .HasColumnName("native_name")
                    .HasMaxLength(70)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CminePictures>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PRIMARY");

                entity.ToTable("cmine_pictures");

                entity.HasIndex(e => e.Hits)
                    .HasName("pic_hits");

                entity.HasIndex(e => e.OwnerId)
                    .HasName("owner_id");

                entity.HasIndex(e => e.PicRating)
                    .HasName("pic_rate");

                entity.HasIndex(e => new { e.Aid, e.Approved })
                    .HasName("aid_approved");

                entity.HasIndex(e => new { e.Aid, e.Pid })
                    .HasName("pic_aid");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Aid)
                    .HasColumnName("aid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Approved)
                    .IsRequired()
                    .HasColumnName("approved")
                    .HasColumnType("enum('YES','NO')")
                    .HasDefaultValueSql("'NO'");

                entity.Property(e => e.Caption)
                    .IsRequired()
                    .HasColumnName("caption");

                entity.Property(e => e.Ctime)
                    .HasColumnName("ctime")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasColumnName("filename")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Filepath)
                    .IsRequired()
                    .HasColumnName("filepath")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Filesize)
                    .HasColumnName("filesize")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Galleryicon)
                    .HasColumnName("galleryicon")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.GuestToken)
                    .HasColumnName("guest_token")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Hits)
                    .HasColumnName("hits")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Keywords)
                    .IsRequired()
                    .HasColumnName("keywords")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LasthitIp)
                    .HasColumnName("lasthit_ip")
                    .HasColumnType("tinytext");

                entity.Property(e => e.Mtime)
                    .HasColumnName("mtime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pheight)
                    .HasColumnName("pheight")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.PicHdrIp)
                    .HasColumnName("pic_hdr_ip")
                    .HasColumnType("tinytext");

                entity.Property(e => e.PicRating)
                    .HasColumnName("pic_rating")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PicRawIp)
                    .HasColumnName("pic_raw_ip")
                    .HasColumnType("tinytext");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pwidth)
                    .HasColumnName("pwidth")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TotalFilesize)
                    .HasColumnName("total_filesize")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UrlPrefix)
                    .HasColumnName("url_prefix")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.User1)
                    .IsRequired()
                    .HasColumnName("user1")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.User2)
                    .IsRequired()
                    .HasColumnName("user2")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.User3)
                    .IsRequired()
                    .HasColumnName("user3")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.User4)
                    .IsRequired()
                    .HasColumnName("user4")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Votes)
                    .HasColumnName("votes")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CminePlugins>(entity =>
            {
                entity.HasKey(e => e.PluginId)
                    .HasName("PRIMARY");

                entity.ToTable("cmine_plugins");

                entity.HasComment("Stores the plugins");

                entity.HasIndex(e => e.Name)
                    .HasName("name")
                    .IsUnique();

                entity.HasIndex(e => e.Path)
                    .HasName("path")
                    .IsUnique();

                entity.Property(e => e.PluginId)
                    .HasColumnName("plugin_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<CmineSessions>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PRIMARY");

                entity.ToTable("cmine_sessions");

                entity.HasComment("Used to store sessions");

                entity.Property(e => e.SessionId)
                    .HasColumnName("session_id")
                    .HasMaxLength(32)
                    .IsFixedLength()
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Remember)
                    .HasColumnName("remember")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CmineTempMessages>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PRIMARY");

                entity.ToTable("cmine_temp_messages");

                entity.HasComment("Used to store messages from one page to the other");

                entity.Property(e => e.MessageId)
                    .HasColumnName("message_id")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CmineUsergroups>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PRIMARY");

                entity.ToTable("cmine_usergroups");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AccessLevel)
                    .HasColumnName("access_level")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.CanCreateAlbums)
                    .HasColumnName("can_create_albums")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.CanPostComments)
                    .HasColumnName("can_post_comments")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.CanRatePictures)
                    .HasColumnName("can_rate_pictures")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.CanSendEcards)
                    .HasColumnName("can_send_ecards")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.CanUploadPictures)
                    .HasColumnName("can_upload_pictures")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("group_name")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GroupQuota)
                    .HasColumnName("group_quota")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HasAdminAccess)
                    .HasColumnName("has_admin_access")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.PrivUplNeedApproval)
                    .HasColumnName("priv_upl_need_approval")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.PubUplNeedApproval)
                    .HasColumnName("pub_upl_need_approval")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<CmineUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("cmine_users");

                entity.HasIndex(e => e.UserGroup)
                    .HasName("user_group");

                entity.HasIndex(e => e.UserName)
                    .HasName("user_name")
                    .IsUnique();

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserActive)
                    .IsRequired()
                    .HasColumnName("user_active")
                    .HasColumnType("enum('YES','NO')")
                    .HasDefaultValueSql("'NO'");

                entity.Property(e => e.UserActkey)
                    .IsRequired()
                    .HasColumnName("user_actkey")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasColumnName("user_email")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserEmailValid)
                    .IsRequired()
                    .HasColumnName("user_email_valid")
                    .HasColumnType("enum('YES','')")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserGroup)
                    .HasColumnName("user_group")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.UserGroupList)
                    .IsRequired()
                    .HasColumnName("user_group_list")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserLanguage)
                    .IsRequired()
                    .HasColumnName("user_language")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserLastvisit)
                    .HasColumnName("user_lastvisit")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasColumnName("user_password")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserProfile1)
                    .HasColumnName("user_profile1")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserProfile2)
                    .HasColumnName("user_profile2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserProfile3)
                    .HasColumnName("user_profile3")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserProfile4)
                    .HasColumnName("user_profile4")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserProfile5)
                    .IsRequired()
                    .HasColumnName("user_profile5")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserProfile6)
                    .IsRequired()
                    .HasColumnName("user_profile6");

                entity.Property(e => e.UserRegdate)
                    .HasColumnName("user_regdate")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");
            });

            modelBuilder.Entity<CmineVoteStats>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PRIMARY");

                entity.ToTable("cmine_vote_stats");

                entity.Property(e => e.Sid)
                    .HasColumnName("sid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Browser)
                    .IsRequired()
                    .HasColumnName("browser")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Os)
                    .IsRequired()
                    .HasColumnName("os")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Pid)
                    .IsRequired()
                    .HasColumnName("pid")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Rating)
                    .HasColumnName("rating")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Referer)
                    .IsRequired()
                    .HasColumnName("referer");

                entity.Property(e => e.Sdate)
                    .HasColumnName("sdate")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CmineVotes>(entity =>
            {
                entity.HasKey(e => new { e.PicId, e.UserMd5Id })
                    .HasName("PRIMARY");

                entity.ToTable("cmine_votes");

                entity.Property(e => e.PicId)
                    .HasColumnName("pic_id")
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserMd5Id)
                    .HasColumnName("user_md5_id")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VoteTime)
                    .HasColumnName("vote_time")
                    .HasColumnType("int(11)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
