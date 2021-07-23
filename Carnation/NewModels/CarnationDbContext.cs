using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Carnation.NewModels
{
    public partial class CarnationDbContext : DbContext
    {
        public CarnationDbContext()
        {
        }

        public CarnationDbContext(DbContextOptions<CarnationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminTable> AdminTables { get; set; }
        public virtual DbSet<AdminUserLoginLog> AdminUserLoginLogs { get; set; }
        public virtual DbSet<CustomDesign> CustomDesigns { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<MerchantUserLoginLog> MerchantUserLoginLogs { get; set; }
        public virtual DbSet<MerchantUserRegister> MerchantUserRegisters { get; set; }
        public virtual DbSet<ProductDetail> ProductDetails { get; set; }
        public virtual DbSet<ServiceCenter> ServiceCenters { get; set; }
        public virtual DbSet<SimpleUserLoginLog> SimpleUserLoginLogs { get; set; }
        public virtual DbSet<SimpleUserRegister> SimpleUserRegisters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=LAPTOP-CB1CN660\\MSSQLSERVER1;database=CarnationDb;trusted_connection=true;");
            }
           // Server = tcp:carnationser.database.windows.net,1433; Initial Catalog = CarnationDb; Persist Security Info = False; User ID = mayankcarnationser; Password = Carnation@team12345; MultipleActiveResultSets = True; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminTable>(entity =>
            {
                entity.HasKey(e => e.Auid)
                    .HasName("PK__Admin_ta__0571F6BE9C88433C");

                entity.ToTable("Admin_table");

                entity.HasIndex(e => e.GroupName, "UQ__Admin_ta__6EFCD43440D909BA")
                    .IsUnique();

                entity.HasIndex(e => e.UserName, "UQ__Admin_ta__C9F28456CD11849C")
                    .IsUnique();

                entity.Property(e => e.Auid).HasColumnName("AUId");

                entity.Property(e => e.CreatedInfo)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AdminUserLoginLog>(entity =>
            {
                entity.HasKey(e => e.Auid)
                    .HasName("PK__Admin_Us__0571F6BEE586D758");

                entity.ToTable("Admin_User_Login_Log");

                entity.Property(e => e.Auid).HasColumnName("AUId");

                entity.Property(e => e.GroupName).HasMaxLength(100);

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CustomDesign>(entity =>
            {
                entity.ToTable("Custom_Design");

                entity.Property(e => e.CarRequired)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("Car_Required");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable("Feedback");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MerchantUserLoginLog>(entity =>
            {
                entity.HasKey(e => e.Muid)
                    .HasName("PK__Merchant__26349FADDD46A183");

                entity.ToTable("Merchant_User_Login_Log");

                entity.Property(e => e.Muid).HasColumnName("MUId");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastName).HasMaxLength(50);
            });

            modelBuilder.Entity<MerchantUserRegister>(entity =>
            {
                entity.HasKey(e => e.Muid)
                    .HasName("PK__Merchant__26349FADB1D753C3");

                entity.ToTable("Merchant_User_Register");

                entity.HasIndex(e => e.UserName, "UQ__Merchant__C9F28456F8C3B333")
                    .IsUnique();

                entity.HasIndex(e => e.Contact, "UQ__Merchant__F7C04665A103ED4D")
                    .IsUnique();

                entity.Property(e => e.Muid).HasColumnName("MUId");

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CreatedInfo)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ProductDetail>(entity =>
            {
                entity.HasKey(e => e.Pid);

                entity.ToTable("Product_Detail");

                entity.Property(e => e.Pid)
                    .ValueGeneratedNever()
                    .HasColumnName("PId");

                entity.Property(e => e.Pcompany)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PCompany");

                entity.Property(e => e.Pdescription)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("PDescription");

                entity.Property(e => e.Pname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PName");

                entity.Property(e => e.Pprice).HasColumnName("PPrice");

                entity.Property(e => e.Pquality)
                    .HasMaxLength(100)
                    .HasColumnName("PQuality");

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("UName");
            });

            modelBuilder.Entity<ServiceCenter>(entity =>
            {
                entity.ToTable("Service_Center");

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.ScenterCity)
                    .HasMaxLength(50)
                    .HasColumnName("SCenterCity");

                entity.Property(e => e.ScenterState)
                    .HasMaxLength(30)
                    .HasColumnName("SCenterState");

                entity.Property(e => e.Slocation)
                    .HasMaxLength(80)
                    .HasColumnName("SLocation");
            });

            modelBuilder.Entity<SimpleUserLoginLog>(entity =>
            {
                entity.HasKey(e => e.Suid)
                    .HasName("PK__Simple_U__A64B0E715BCBE0BF");

                entity.ToTable("Simple_User_Login_Log");

                entity.Property(e => e.Suid).HasColumnName("SUId");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastName).HasMaxLength(50);
            });

            modelBuilder.Entity<SimpleUserRegister>(entity =>
            {
                entity.HasKey(e => e.Suid)
                    .HasName("PK__Simple_U__A64B0E718D811A16");

                entity.ToTable("Simple_User_Register");

                entity.HasIndex(e => e.UserName, "UQ__Simple_U__C9F28456A29CEA55")
                    .IsUnique();

                entity.HasIndex(e => e.Contact, "UQ__Simple_U__F7C04665A8AFE4BD")
                    .IsUnique();

                entity.Property(e => e.Suid).HasColumnName("SUId");

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CreatedInfo)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
