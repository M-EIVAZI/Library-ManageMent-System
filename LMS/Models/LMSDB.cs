using System;
using System.Collections.Generic;
using LMS.AdminChildForms;
using Microsoft.EntityFrameworkCore;

namespace LMS.Models;

public partial class LMSDB : DbContext
{
    public LMSDB()
    {
    }

    public LMSDB(DbContextOptions<LMSDB> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }
    public virtual DbSet<Admins> Admins { get; set; }
    public virtual DbSet<Configurations> Configurations { get; set; }
    public virtual DbSet<Reports> Reports { get; set; }
    //Server = localhost; Port = 5432; Database = LMS; User Id = postgres; Password = mahdi1382

    //dotnet ef dbcontext scaffold "Server = localhost; Port = 5432; Database = LMS; User Id = postgres; Password = mahdi1382" Npgsql.EntityFrameworkCore.PostgreSQL --output-dir Models --force --context YourDbContextName

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server = localhost; Port = 5432; Database = LMS; User Id = postgres; Password = mahdi1382");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Authorid).HasName("authors_pkey");

            entity.ToTable("authors");

            entity.HasIndex(e => e.AuthorName, "authors_author_name_key").IsUnique();

            entity.Property(e => e.Authorid).HasColumnName("authorid");
            entity.Property(e => e.AuthorName)
                .HasMaxLength(50)
                .HasColumnName("author_name");
            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
        });
        modelBuilder.Entity<Configurations>(entity =>
        {
            entity.HasKey(c => c.MaxLoanTime).HasName("configurations_pkey");
            entity.ToTable("configurations");
            entity.HasIndex(c => c.MaxLoanNumber, "configurations_maxloannumber").IsUnique();
            entity.Property(c => c.MaxLoanNumber).HasColumnType("int").HasColumnName("maxloannumber");
            entity.Property(c => c.MaxLoanTime).HasColumnType("int").HasColumnName("maxloantime");
            entity.Property(c => c.FineDefault).HasColumnType("int").HasColumnName("finedefault");
        }
        );
        modelBuilder.Entity<Admins>(entity =>
        {
            entity.ToTable("admins");

            entity.HasKey(e => e.AdminId).HasName("admins_pkey");
            entity.Property(a => a.AdminId).HasColumnType("int").HasColumnName("adminid");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");

            entity.Property(e => e.password)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("password");

            entity.Property(e => e.salt)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("salt");

            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("email");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Bookid).HasName("books_pkey");

            entity.ToTable("books");

            entity.Property(e => e.Bookid).HasColumnName("bookid");
            entity.Property(e => e.AuthorName)
                .HasMaxLength(50)
                .HasColumnName("authorname");
            entity.Property(e => e.FilePath).HasColumnName("file_path");
            entity.Property(e => e.Format)
                .HasMaxLength(20)
                .HasColumnName("format");
            entity.Property(e => e.Genre)
                .HasMaxLength(50)
                .HasColumnName("genre");
            entity.Property(e => e.Isbn)
                .HasMaxLength(20)
                .HasColumnName("isbn");
            entity.Property(e => e.PublishedDate).HasColumnName("published_date");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
            entity.Property(e => e.IsValid).HasMaxLength(20).HasColumnName("isvalid");

            entity.HasOne(d => d.AuthorNameNavigation).WithMany(p => p.Books)
                .HasPrincipalKey(p => p.AuthorName)
                .HasForeignKey(d => d.AuthorName)
                .HasConstraintName("books_author_name_fkey");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Employeeid).HasName("employee_pkey");

            entity.ToTable("employee");

            entity.Property(e => e.Employeeid).HasColumnName("employeeid");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");
            entity.Property(e => e.Salt)
            .HasMaxLength(100)
            .HasColumnName("salt");
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.Memberid).HasName("members_pkey");

            entity.ToTable("members");

            entity.HasIndex(e => e.Password, "members_password_key").IsUnique();

            entity.Property(e => e.Memberid).HasColumnName("memberid");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Fine).HasColumnName("fine");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.Salt)
            .HasMaxLength(100)
            .HasColumnName("salt");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.Transactionid).HasName("transactions_pkey");

            entity.ToTable("transactions");

            entity.Property(e => e.Transactionid).HasColumnName("transactionid");
            entity.Property(e => e.Bookid).HasColumnName("bookid");
            entity.Property(e => e.BorrowDate).HasColumnName("borrow_date");
            entity.Property(e => e.Memberid).HasColumnName("memberid");
            entity.Property(e => e.ReturnDate).HasColumnName("return_date");
            entity.Property(e => e.Status).HasMaxLength(20)
                .HasColumnName("status");
            entity.Property(e => e.UserVeiw).HasMaxLength(200).HasColumnName("userveiw");


            entity.HasOne(d => d.Book).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.Bookid)
                .HasConstraintName("transactions_bookid_fkey")
                .OnDelete(DeleteBehavior.Cascade);
                

            entity.HasOne(d => d.Member).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.Memberid)
                .HasConstraintName("transactions_memberid_fkey")
                .OnDelete(DeleteBehavior.Cascade);
        });
        modelBuilder.Entity<Reports>(entity =>
        {
            entity.HasKey(r => r.ReportId).HasName("reports_pkey");
            entity.ToTable("reports");
            entity.Property(e => e.ReportId).HasColumnName("reportid");
            entity.Property(e => e.MemberId).HasColumnName("memberid");
            entity.Property(e => e.BookId).HasColumnName("bookid");
            entity.Property(r => r.Description).HasColumnName("description");
            entity.HasOne(r => r.Book)
          .WithMany(b => b.Reports)
          .HasForeignKey(r => r.BookId)
          .HasConstraintName("reports_bookid_fkey");
            entity.HasOne(r => r.Member)
          .WithMany(m => m.Reports)
          .HasForeignKey(r => r.MemberId)
          .HasConstraintName("reports_memberid_fkey");
        });


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
////dotnet ef dbcontext scaffold "Server = localhost; Port = 5432; Database = LMS; User Id = postgres; Password = mahdi1382" Npgsql.EntityFrameworkCore.PostgreSQL --output-dir Models --context LMSDB --force --project LMS.csproj
