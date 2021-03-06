// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using Budget_Tracker_Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace Budget_Tracker_Persistence.Data
{
    public partial class Budget_TrackerContext : DbContext
    {
        public Budget_TrackerContext()
        {
        }

        public Budget_TrackerContext(DbContextOptions<Budget_TrackerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Transaction> Transaction { get; set; }
        public virtual DbSet<TransactionType> TransactionType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RunningBalance).HasColumnType("money");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Account__Product__29572725");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PRODUCT__BankID__267ABA7A");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BankCharge).HasColumnType("money");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionTypeId).HasColumnName("TransactionTypeID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK__Transacti__Accou__31EC6D26");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK__Transacti__BankI__32E0915F");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Transacti__Produ__33D4B598");

                entity.HasOne(d => d.TransactionType)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.TransactionTypeId)
                    .HasConstraintName("FK__Transacti__Trans__30F848ED");
            });

            modelBuilder.Entity<TransactionType>(entity =>
            {
                entity.ToTable("Transaction_Type");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}