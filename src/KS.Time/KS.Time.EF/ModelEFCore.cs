 
 
 
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using KS.Time.BusinessObjects;

namespace KS.Time
{

  public partial class KSTimeContext : DbContext
    {
	  public string ConnectionString { get; set; }
        public KSTimeContext()
        {

        }
		 public KSTimeContext(string connectionString )
        {
			this.ConnectionString = connectionString;
        }

        public KSTimeContext(DbContextOptions<KSTimeContext> options)
            : base(options)
        {
        }
#region
        public virtual DbSet<KstEmailTemplate> KstEmailTemplates { get; set; }
        public virtual DbSet<KstProxyGeoCity> KstProxyGeoCities { get; set; }
        public virtual DbSet<KstProxyGeoCountry> KstProxyGeoCountries { get; set; }
        public virtual DbSet<KstProxyGeoState> KstProxyGeoStates { get; set; }
        public virtual DbSet<KstActivity> KstActivities { get; set; }
        public virtual DbSet<KstProject> KstProjects { get; set; }
        public virtual DbSet<KstProjectUser> KstProjectUsers { get; set; }
        public virtual DbSet<KstWorkTime> KstWorkTimes { get; set; }
        public virtual DbSet<KstFile> KstFiles { get; set; }
        public virtual DbSet<KstProjectFile> KstProjectFiles { get; set; }
        public virtual DbSet<KstUserFile> KstUserFiles { get; set; }
        public virtual DbSet<KstWorkTimeFile> KstWorkTimeFiles { get; set; }
        public virtual DbSet<KstProxyRole> KstProxyRoles { get; set; }
        public virtual DbSet<KstProxyUser> KstProxyUsers { get; set; }
#endregion
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
			
            if (!optionsBuilder.IsConfigured)
            {
				#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(this.ConnectionString);
            }
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<KstEmailTemplate>(entity =>
            {
			entity.HasKey(e => new { e.GuidEmailTemplate});

			
			 entity.ToTable("KstEmailTemplate");
			 entity.Property(e => e.GuidEmailTemplate);
			 entity.Property(e => e.Title);
			 entity.Property(e => e.TitleKey);
			 entity.Property(e => e.Content);
			 entity.Property(e => e.GuidCompany);
			 entity.Property(e => e.CreatedBy);
			 entity.Property(e => e.UpdatedBy);
			 entity.Property(e => e.IsDeleted);
			 entity.Property(e => e.BizKeyEngine);
			 entity.Property(e => e.CreatedDate);
			 entity.Property(e => e.UpdatedDate);
			 entity.Property(e => e.Bytes);


		});
			modelBuilder.Entity<KstProxyGeoCity>(entity =>
            {
			entity.HasKey(e => new { e.GuidCity});

			
			 entity.ToTable("KstProxyGeoCity");
			 entity.Property(e => e.GuidCity);
			 entity.Property(e => e.Name);
			 entity.Property(e => e.IsDeleted);
			 entity.Property(e => e.GuidState);
			 entity.Property(e => e.GuidParent);

		entity.HasOne(d => d.KstProxyGeoCity2)
                    .WithMany(p => p.KstProxyGeoCity1)
                    .HasForeignKey(d => d.GuidParent)
                    .OnDelete(DeleteBehavior.ClientSetNull);

		entity.HasOne(d => d.KstProxyGeoState)
                    .WithMany(p => p.KstProxyGeoCities)
                    .HasForeignKey(d => d.GuidState)
                    .OnDelete(DeleteBehavior.ClientSetNull);


		});
			modelBuilder.Entity<KstProxyGeoCountry>(entity =>
            {
			entity.HasKey(e => new { e.GuidCountry});

			
			 entity.ToTable("KstProxyGeoCountry");
			 entity.Property(e => e.GuidCountry);
			 entity.Property(e => e.Name);
			 entity.Property(e => e.IsDeleted);


		});
			modelBuilder.Entity<KstProxyGeoState>(entity =>
            {
			entity.HasKey(e => new { e.GuidState});

			
			 entity.ToTable("KstProxyGeoState");
			 entity.Property(e => e.GuidState);
			 entity.Property(e => e.Name);
			 entity.Property(e => e.IsDeleted);
			 entity.Property(e => e.GuidCountry);

		entity.HasOne(d => d.KstProxyGeoCountry)
                    .WithMany(p => p.KstProxyGeoStates)
                    .HasForeignKey(d => d.GuidCountry)
                    .OnDelete(DeleteBehavior.ClientSetNull);


		});
			modelBuilder.Entity<KstActivity>(entity =>
            {
			entity.HasKey(e => new { e.GuidActivity});

			
			 entity.ToTable("KstActivity");
			 entity.Property(e => e.GuidActivity);
			 entity.Property(e => e.Name);
			 entity.Property(e => e.GuidProject);
			 entity.Property(e => e.IsCustomByUser);
			 entity.Property(e => e.GuidCompany);
			 entity.Property(e => e.CreatedBy);
			 entity.Property(e => e.UpdatedBy);
			 entity.Property(e => e.IsDeleted);
			 entity.Property(e => e.BizKeyEngine);
			 entity.Property(e => e.CreatedDate);
			 entity.Property(e => e.UpdatedDate);
			 entity.Property(e => e.Bytes);

		entity.HasOne(d => d.KstProject)
                    .WithMany(p => p.KstActivities)
                    .HasForeignKey(d => d.GuidProject)
                    .OnDelete(DeleteBehavior.ClientSetNull);


		});
			modelBuilder.Entity<KstProject>(entity =>
            {
			entity.HasKey(e => new { e.GuidProject});

			
			 entity.ToTable("KstProject");
			 entity.Property(e => e.GuidProject);
			 entity.Property(e => e.Name);
			 entity.Property(e => e.GuidCompany);
			 entity.Property(e => e.CreatedBy);
			 entity.Property(e => e.UpdatedBy);
			 entity.Property(e => e.IsDeleted);
			 entity.Property(e => e.BizKeyEngine);
			 entity.Property(e => e.CreatedDate);
			 entity.Property(e => e.UpdatedDate);
			 entity.Property(e => e.Bytes);


		});
			modelBuilder.Entity<KstProjectUser>(entity =>
            {
			entity.HasKey(e => new { e.GuidProjectUser});

			
			 entity.ToTable("KstProjectUser");
			 entity.Property(e => e.GuidProjectUser);
			 entity.Property(e => e.GuidProject);
			 entity.Property(e => e.GuidUser);
			 entity.Property(e => e.StartDate);
			 entity.Property(e => e.EndDate);
			 entity.Property(e => e.GuidCompany);
			 entity.Property(e => e.CreatedBy);
			 entity.Property(e => e.UpdatedBy);
			 entity.Property(e => e.IsDeleted);
			 entity.Property(e => e.BizKeyEngine);
			 entity.Property(e => e.CreatedDate);
			 entity.Property(e => e.UpdatedDate);
			 entity.Property(e => e.Bytes);

		entity.HasOne(d => d.KstProject)
                    .WithMany(p => p.KstProjectUsers)
                    .HasForeignKey(d => d.GuidProject)
                    .OnDelete(DeleteBehavior.ClientSetNull);

		entity.HasOne(d => d.KstProxyUser)
                    .WithMany(p => p.KstProjectUsers)
                    .HasForeignKey(d => d.GuidUser)
                    .OnDelete(DeleteBehavior.ClientSetNull);


		});
			modelBuilder.Entity<KstWorkTime>(entity =>
            {
			entity.HasKey(e => new { e.GuidWorkTime});

			
			 entity.ToTable("KstWorkTime");
			 entity.Property(e => e.GuidWorkTime);
			 entity.Property(e => e.Title);
			 entity.Property(e => e.Comments);
			 entity.Property(e => e.Hours);
			 entity.Property(e => e.GuidProject);
			 entity.Property(e => e.GuidActivity);
			 entity.Property(e => e.GuidCompany);
			 entity.Property(e => e.CreatedBy);
			 entity.Property(e => e.UpdatedBy);
			 entity.Property(e => e.IsDeleted);
			 entity.Property(e => e.BizKeyEngine);
			 entity.Property(e => e.CreatedDate);
			 entity.Property(e => e.UpdatedDate);
			 entity.Property(e => e.Bytes);

		entity.HasOne(d => d.KstActivity)
                    .WithMany(p => p.KstWorkTimes)
                    .HasForeignKey(d => d.GuidActivity)
                    .OnDelete(DeleteBehavior.ClientSetNull);

		entity.HasOne(d => d.KstProject)
                    .WithMany(p => p.KstWorkTimes)
                    .HasForeignKey(d => d.GuidProject)
                    .OnDelete(DeleteBehavior.ClientSetNull);


		});
			modelBuilder.Entity<KstFile>(entity =>
            {
			entity.HasKey(e => new { e.GuidFile});

			
			 entity.ToTable("KstFile");
			 entity.Property(e => e.GuidFile);
			 entity.Property(e => e.FileName);
			 entity.Property(e => e.FileType);
			 entity.Property(e => e.FileData);
			 entity.Property(e => e.FileStorage);
			 entity.Property(e => e.ContainerStorage);
			 entity.Property(e => e.FileThumbSizes);
			 entity.Property(e => e.FileSize);
			 entity.Property(e => e.GuidCompany);
			 entity.Property(e => e.CreatedBy);
			 entity.Property(e => e.UpdatedBy);
			 entity.Property(e => e.IsDeleted);
			 entity.Property(e => e.BizKeyEngine);
			 entity.Property(e => e.CreatedDate);
			 entity.Property(e => e.UpdatedDate);
			 entity.Property(e => e.Bytes);


		});
			modelBuilder.Entity<KstProjectFile>(entity =>
            {
			entity.HasKey(e => new { e.GuidProjectFile});

			
			 entity.ToTable("KstProjectFile");
			 entity.Property(e => e.GuidProjectFile);
			 entity.Property(e => e.GuidProject);
			 entity.Property(e => e.GuidFile);
			 entity.Property(e => e.GuidCompany);
			 entity.Property(e => e.CreatedBy);
			 entity.Property(e => e.UpdatedBy);
			 entity.Property(e => e.IsDeleted);
			 entity.Property(e => e.BizKeyEngine);
			 entity.Property(e => e.CreatedDate);
			 entity.Property(e => e.UpdatedDate);
			 entity.Property(e => e.Bytes);

		entity.HasOne(d => d.KstFile)
                    .WithMany(p => p.KstProjectFiles)
                    .HasForeignKey(d => d.GuidFile)
                    .OnDelete(DeleteBehavior.ClientSetNull);

		entity.HasOne(d => d.KstProject)
                    .WithMany(p => p.KstProjectFiles)
                    .HasForeignKey(d => d.GuidProject)
                    .OnDelete(DeleteBehavior.ClientSetNull);


		});
			modelBuilder.Entity<KstUserFile>(entity =>
            {
			entity.HasKey(e => new { e.GuidUserFile});

			
			 entity.ToTable("KstUserFile");
			 entity.Property(e => e.GuidUserFile);
			 entity.Property(e => e.GuidUser);
			 entity.Property(e => e.GuidFile);
			 entity.Property(e => e.IsProfileDefault);
			 entity.Property(e => e.GuidCompany);
			 entity.Property(e => e.CreatedBy);
			 entity.Property(e => e.UpdatedBy);
			 entity.Property(e => e.IsDeleted);
			 entity.Property(e => e.BizKeyEngine);
			 entity.Property(e => e.CreatedDate);
			 entity.Property(e => e.UpdatedDate);
			 entity.Property(e => e.Bytes);

		entity.HasOne(d => d.KstFile)
                    .WithMany(p => p.KstUserFiles)
                    .HasForeignKey(d => d.GuidFile)
                    .OnDelete(DeleteBehavior.ClientSetNull);

		entity.HasOne(d => d.KstProxyUser)
                    .WithMany(p => p.KstUserFiles)
                    .HasForeignKey(d => d.GuidUser)
                    .OnDelete(DeleteBehavior.ClientSetNull);


		});
			modelBuilder.Entity<KstWorkTimeFile>(entity =>
            {
			entity.HasKey(e => new { e.GuidWorkTimeFile});

			
			 entity.ToTable("KstWorkTimeFile");
			 entity.Property(e => e.GuidWorkTimeFile);
			 entity.Property(e => e.GuidWorkTime);
			 entity.Property(e => e.GuidFile);
			 entity.Property(e => e.GuidCompany);
			 entity.Property(e => e.CreatedBy);
			 entity.Property(e => e.UpdatedBy);
			 entity.Property(e => e.IsDeleted);
			 entity.Property(e => e.BizKeyEngine);
			 entity.Property(e => e.CreatedDate);
			 entity.Property(e => e.UpdatedDate);
			 entity.Property(e => e.Bytes);

		entity.HasOne(d => d.KstFile)
                    .WithMany(p => p.KstWorkTimeFiles)
                    .HasForeignKey(d => d.GuidFile)
                    .OnDelete(DeleteBehavior.ClientSetNull);

		entity.HasOne(d => d.KstWorkTime)
                    .WithMany(p => p.KstWorkTimeFiles)
                    .HasForeignKey(d => d.GuidWorkTime)
                    .OnDelete(DeleteBehavior.ClientSetNull);


		});
			modelBuilder.Entity<KstProxyRole>(entity =>
            {
			entity.HasKey(e => new { e.GuidRole});

			
			 entity.ToTable("KstProxyRole");
			 entity.Property(e => e.GuidRole);
			 entity.Property(e => e.RoleName);
			 entity.Property(e => e.NameKey);
			 entity.Property(e => e.UpdatedDate);
			 entity.Property(e => e.IsDeleted);
			 entity.Property(e => e.CreatedDate);


		});
			modelBuilder.Entity<KstProxyUser>(entity =>
            {
			entity.HasKey(e => new { e.GuidUser});

			
			 entity.ToTable("KstProxyUser");
			 entity.Property(e => e.GuidUser);
			 entity.Property(e => e.DisplayName);
			 entity.Property(e => e.Username);
			 entity.Property(e => e.Password);
			 entity.Property(e => e.FirstName);
			 entity.Property(e => e.LastName);
			 entity.Property(e => e.Email);
			 entity.Property(e => e.GuidRole);
			 entity.Property(e => e.UpdatedDate);
			 entity.Property(e => e.IsDeleted);
			 entity.Property(e => e.CreatedDate);
			 entity.Property(e => e.Disabled);

		entity.HasOne(d => d.KstProxyRole)
                    .WithMany(p => p.KstProxyUsers)
                    .HasForeignKey(d => d.GuidRole)
                    .OnDelete(DeleteBehavior.ClientSetNull);


		});
OnModelCreatingPartial(modelBuilder);
		}

		 partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
   }

}


