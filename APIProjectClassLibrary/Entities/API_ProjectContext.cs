using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace APIProjectClassLibrary.Entities
{
    public partial class API_ProjectContext : DbContext
    {
        public API_ProjectContext()
        {
        }

        public API_ProjectContext(DbContextOptions<API_ProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EnrolmentByGender> EnrolmentByGender { get; set; }
        public virtual DbSet<EnrolmentBySchool> EnrolmentBySchool { get; set; }
        public virtual DbSet<PrivateSchool> PrivateSchool { get; set; }
        public virtual DbSet<PrivateSchoolRate> PrivateSchoolRate { get; set; }
        public virtual DbSet<PublicSchool> PublicSchool { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=ontarioschool.cc3g7qwlc2ws.us-east-1.rds.amazonaws.com,1433;database=API_Project;User ID=admin;Password=1q2w3e4r!#;Integrated Security=False;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            }
            */
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EnrolmentByGender>(entity =>
            {
                entity.Property(e => e.BoardName)
                    .HasColumnName("Board_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BoardNumber)
                    .HasColumnName("Board_Number")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ElementaryFemaleEnrolment)
                    .HasColumnName("Elementary_Female_Enrolment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ElementaryMaleEnrolment)
                    .HasColumnName("Elementary_Male_Enrolment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryFemaleEnrolment)
                    .HasColumnName("Secondary_Female_Enrolment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryMaleEnrolment)
                    .HasColumnName("Secondary_Male_Enrolment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TotalFemaleEnrolment)
                    .HasColumnName("Total_Female_Enrolment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TotalMaleEnrolment)
                    .HasColumnName("Total_Male_Enrolment")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EnrolmentBySchool>(entity =>
            {
                entity.Property(e => e.BoardName)
                    .HasColumnName("Board_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BoardNumber)
                    .HasColumnName("Board_Number")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Enrolment).HasColumnName("_Enrolment_");

                entity.Property(e => e.SchoolLanguage)
                    .HasColumnName("School_Language")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolLevel)
                    .HasColumnName("School_Level")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolName)
                    .HasColumnName("School_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolNumber).HasColumnName("School_Number");

                entity.Property(e => e.SchoolType)
                    .HasColumnName("School_Type")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrivateSchool>(entity =>
            {
                entity.HasKey(e => e.SchoolNumber);

                entity.ToTable("privateSchool");

                entity.Property(e => e.SchoolNumber)
                    .HasColumnName("School_Number")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssociationMembership)
                    .HasColumnName("Association_Membership")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OssdCreditsOffered)
                    .HasColumnName("OSSD_Credits_Offered")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PoBox)
                    .HasColumnName("PO_Box")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("Postal_Code")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramType)
                    .HasColumnName("Program_Type")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolLevel)
                    .HasColumnName("School_Level")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolName)
                    .HasColumnName("School_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolSpecialConditionsCode)
                    .HasColumnName("School_Special_Conditions_Code")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolWebsite)
                    .HasColumnName("School_Website")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StreetAddress)
                    .HasColumnName("Street_Address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TelephoneNumber)
                    .HasColumnName("Telephone_Number")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tuition).HasColumnName("tuition");
            });

            modelBuilder.Entity<PrivateSchoolRate>(entity =>
            {
                entity.Property(e => e.PrivateSchoolRateId).HasColumnName("privateSchoolRateId");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.SchoolNumber).HasColumnName("school_number");

                entity.Property(e => e.StudentName)
                    .HasColumnName("studentName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StudentNumber)
                    .HasColumnName("studentNumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.SchoolNumberNavigation)
                    .WithMany(p => p.PrivateSchoolRates)
                    .HasForeignKey(d => d.SchoolNumber)
                    .HasConstraintName("FK_PrivateSchoolRate_PrivateSchool");
            });

            modelBuilder.Entity<PublicSchool>(entity =>
            {
                entity.ToTable("publicSchool");

                entity.Property(e => e.PublicSchoolId).HasColumnName("publicSchoolId");

                entity.Property(e => e.BoardLanguage)
                    .HasColumnName("Board_Language")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BoardName)
                    .HasColumnName("Board_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BoardNumber)
                    .HasColumnName("Board_Number")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BoardType)
                    .HasColumnName("Board_Type")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BoardWebsite)
                    .HasColumnName("Board_Website")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateOpen)
                    .HasColumnName("Date_Open")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GradeRange)
                    .HasColumnName("Grade_Range")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PoBox)
                    .HasColumnName("PO_Box")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("Postal_Code")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolEmail)
                    .HasColumnName("School_Email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolLanguage)
                    .HasColumnName("School_Language")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolLevel)
                    .HasColumnName("School_Level")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolName)
                    .HasColumnName("School_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolNumber).HasColumnName("School_Number");

                entity.Property(e => e.SchoolSpecialConditionsCode)
                    .HasColumnName("School_Special_Conditions_Code")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolType)
                    .HasColumnName("School_Type")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolWebsite)
                    .HasColumnName("School_Website")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Suite)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
