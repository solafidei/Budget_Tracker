// <auto-generated />
using System;
using Budget_Tracker_Persistence.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Budget_Tracker_Persistence.Migrations
{
    [DbContext(typeof(Budget_TrackerContext))]
    [Migration("20220112200913_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Budget_Tracker_Persistence.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccountNumber")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<decimal>("RunningBalance")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("Budget_Tracker_Persistence.Models.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ShortName")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Bank");
                });

            modelBuilder.Entity("Budget_Tracker_Persistence.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BankId")
                        .HasColumnType("int")
                        .HasColumnName("BankID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Budget_Tracker_Persistence.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AccountId")
                        .HasColumnType("int")
                        .HasColumnName("AccountID");

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<decimal?>("BankCharge")
                        .HasColumnType("money");

                    b.Property<int?>("BankId")
                        .HasColumnType("int")
                        .HasColumnName("BankID");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(350)
                        .IsUnicode(false)
                        .HasColumnType("varchar(350)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("TransactionTypeId")
                        .HasColumnType("int")
                        .HasColumnName("TransactionTypeID");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("BankId");

                    b.HasIndex("ProductId");

                    b.HasIndex("TransactionTypeId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("Budget_Tracker_Persistence.Models.TransactionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Transaction_Type", (string)null);
                });

            modelBuilder.Entity("Budget_Tracker_Persistence.Models.Account", b =>
                {
                    b.HasOne("Budget_Tracker_Persistence.Models.Product", "Product")
                        .WithMany("Account")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__Account__Product__29572725");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Budget_Tracker_Persistence.Models.Product", b =>
                {
                    b.HasOne("Budget_Tracker_Persistence.Models.Bank", "Bank")
                        .WithMany("Product")
                        .HasForeignKey("BankId")
                        .IsRequired()
                        .HasConstraintName("FK__PRODUCT__BankID__267ABA7A");

                    b.Navigation("Bank");
                });

            modelBuilder.Entity("Budget_Tracker_Persistence.Models.Transaction", b =>
                {
                    b.HasOne("Budget_Tracker_Persistence.Models.Account", "Account")
                        .WithMany("Transaction")
                        .HasForeignKey("AccountId")
                        .HasConstraintName("FK__Transacti__Accou__31EC6D26");

                    b.HasOne("Budget_Tracker_Persistence.Models.Bank", "Bank")
                        .WithMany("Transaction")
                        .HasForeignKey("BankId")
                        .HasConstraintName("FK__Transacti__BankI__32E0915F");

                    b.HasOne("Budget_Tracker_Persistence.Models.Product", "Product")
                        .WithMany("Transaction")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__Transacti__Produ__33D4B598");

                    b.HasOne("Budget_Tracker_Persistence.Models.TransactionType", "TransactionType")
                        .WithMany("Transaction")
                        .HasForeignKey("TransactionTypeId")
                        .HasConstraintName("FK__Transacti__Trans__30F848ED");

                    b.Navigation("Account");

                    b.Navigation("Bank");

                    b.Navigation("Product");

                    b.Navigation("TransactionType");
                });

            modelBuilder.Entity("Budget_Tracker_Persistence.Models.Account", b =>
                {
                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("Budget_Tracker_Persistence.Models.Bank", b =>
                {
                    b.Navigation("Product");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("Budget_Tracker_Persistence.Models.Product", b =>
                {
                    b.Navigation("Account");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("Budget_Tracker_Persistence.Models.TransactionType", b =>
                {
                    b.Navigation("Transaction");
                });
#pragma warning restore 612, 618
        }
    }
}
