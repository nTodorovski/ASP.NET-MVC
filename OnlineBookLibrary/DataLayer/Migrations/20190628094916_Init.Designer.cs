﻿// <auto-generated />
using System;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Migrations
{
    [DbContext(typeof(OnlineBookLibraryDbContext))]
    [Migration("20190628094916_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DtoModels.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 54,
                            FirstName = "Dan",
                            LastName = "Brown"
                        },
                        new
                        {
                            Id = 2,
                            Age = 68,
                            FirstName = "Miguel",
                            LastName = "de Cervantes"
                        },
                        new
                        {
                            Id = 3,
                            Age = 74,
                            FirstName = "Mark",
                            LastName = "Twain"
                        },
                        new
                        {
                            Id = 4,
                            Age = 82,
                            FirstName = "Leo",
                            LastName = "Tolstoy"
                        });
                });

            modelBuilder.Entity("DtoModels.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId");

                    b.Property<int>("Genre");

                    b.Property<string>("Isbn");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<int>("Pages");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Genre = 6,
                            Isbn = "0-385-50420-9",
                            Name = "The DaVinci Code",
                            Pages = 589,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Genre = 6,
                            Isbn = "0-671-02735-2",
                            Name = "Angels and Demons",
                            Pages = 616,
                            Quantity = 8
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 2,
                            Genre = 4,
                            Isbn = "0-587-06995-6",
                            Name = "Don Quixote",
                            Pages = 863,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 4,
                            Genre = 12,
                            Isbn = "0-726-01278-8",
                            Name = "War and Peace",
                            Pages = 1225,
                            Quantity = 4
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 3,
                            Genre = 4,
                            Isbn = "0-924-37885-7",
                            Name = "Adventures of Huckleberry Finn",
                            Pages = 366,
                            Quantity = 6
                        });
                });

            modelBuilder.Entity("DtoModels.Loan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId");

                    b.Property<DateTime>("DateReturned");

                    b.Property<int>("FinePaid");

                    b.Property<DateTime>("LoanDate");

                    b.Property<int>("Status");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("DtoModels.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "User"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Librarian"
                        });
                });

            modelBuilder.Entity("DtoModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<bool>("IsLogged");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "petko.petkovski@gmail.com",
                            IsLogged = false,
                            Password = "petko123",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 2,
                            Email = "trajko.trajkovski@gmail.com",
                            IsLogged = false,
                            Password = "trajko123",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 3,
                            Email = "mirko.mirkovski@gmail.com",
                            IsLogged = false,
                            Password = "mirko123",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 4,
                            Email = "stanko.stankovski@gmail.com",
                            IsLogged = false,
                            Password = "stanko123",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 5,
                            Email = "zane.zanevska@gmail.com",
                            IsLogged = false,
                            Password = "zane123",
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("DtoModels.Book", b =>
                {
                    b.HasOne("DtoModels.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DtoModels.Loan", b =>
                {
                    b.HasOne("DtoModels.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DtoModels.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DtoModels.User", b =>
                {
                    b.HasOne("DtoModels.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
