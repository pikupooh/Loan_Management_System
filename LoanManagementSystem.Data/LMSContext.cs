using System;
using LoanManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace LoanManagementSystem.Data
{
    public partial class LMSContext : DbContext
    {
        public LMSContext()
        {
        }

        public LMSContext(DbContextOptions<LMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BankDetail> BankDetails { get; set; }
        public virtual DbSet<CustomerInfo> CustomerInfos { get; set; }
        public virtual DbSet<Emi> Emis { get; set; }
        public virtual DbSet<Emipayment> Emipayments { get; set; }
        public virtual DbSet<LoanApplication> LoanApplications { get; set; }
        public virtual DbSet<LoanType> LoanTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server= RIA-THINKPAD\\PROJECTSREMOTE;Database=LMS; User Id= project_remote;pwd= ProjectsRemote@123; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<BankDetail>(entity =>
            {
                entity.HasKey(e => e.BankName)
                    .HasName("PK_Bank");

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerInfo>(entity =>
            {
                entity.HasKey(e => e.Custid)
                    .HasName("PK__Customer__049D3E81E80459D9");

                entity.ToTable("CustomerInfo");

                entity.Property(e => e.CustAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Custname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pan)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PAN");

                entity.Property(e => e.Phoneno)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Emi>(entity =>
            {
                entity.ToTable("EMI");

                entity.Property(e => e.Emiid).HasColumnName("EMIId");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LoanType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.Emis)
                    .HasForeignKey(d => d.Custid)
                    .HasConstraintName("FK__EMI__Custid__2B3F6F97");
            });

            modelBuilder.Entity<Emipayment>(entity =>
            {
                entity.ToTable("EMIPayments");

                entity.Property(e => e.Emiamount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("EMIAmount");

                entity.Property(e => e.Emiid).HasColumnName("EMIId");

                entity.Property(e => e.Fine).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.LastPaid).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReceiptDate).HasColumnType("datetime");

                entity.HasOne(d => d.Emi)
                    .WithMany(p => p.Emipayments)
                    .HasForeignKey(d => d.Emiid)
                    .HasConstraintName("FK__EMIPaymen__EMIId__2E1BDC42");
            });

            modelBuilder.Entity<LoanApplication>(entity =>
            {
                entity.HasKey(e => e.AppId)
                    .HasName("PK__LoanAppl__8E2CF7F935191B9F");

                entity.ToTable("LoanApplication");

                entity.Property(e => e.LoanType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.LoanApplications)
                    .HasForeignKey(d => d.Custid)
                    .HasConstraintName("FK__LoanAppli__Custi__286302EC");
            });

            modelBuilder.Entity<LoanType>(entity =>
            {
                entity.HasKey(e => e.LoanType1)
                    .HasName("PK__LoanType__3C62B94646D5B118");

                entity.ToTable("LoanType");

                entity.Property(e => e.LoanType1)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LoanType");

                entity.Property(e => e.InterestRate)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
