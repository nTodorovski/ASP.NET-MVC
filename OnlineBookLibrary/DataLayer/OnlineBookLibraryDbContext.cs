using DtoModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class OnlineBookLibraryDbContext : DbContext
    {
        public OnlineBookLibraryDbContext(DbContextOptions<OnlineBookLibraryDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(x => x.Author)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.AuthorId);

            modelBuilder.Entity<User>()
                .HasOne(x => x.Role)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.RoleId);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Loans)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            
            #region Seed
            var authors = new List<Author>
            {
                new Author("Dan","Brown",54){ Id=1},
                new Author("Miguel","de Cervantes",68){ Id=2},
                new Author("Mark","Twain",74){ Id=3},
                new Author("Leo","Tolstoy",82){ Id=4}
            };

            var books = new List<Book>
            {
                new Book("0-385-50420-9","The DaVinci Code",GenreEnum.Thriller,589,10){ Id=1, AuthorId=1},
                new Book("0-671-02735-2","Angels and Demons",GenreEnum.Thriller,616,8){ Id=2, AuthorId=1},
                new Book("0-587-06995-6","Don Quixote",GenreEnum.Novel,863,5){ Id=3, AuthorId=2 },
                new Book("0-726-01278-8","War and Peace",GenreEnum.History,1225,4){ Id=4, AuthorId=4},
                new Book("0-924-37885-7","Adventures of Huckleberry Finn",GenreEnum.Novel,366,6){ Id=5, AuthorId=3}
            };

            var roles = new List<Role>
            {
                new Role("User"){ Id = 1},
                new Role("Librarian"){Id = 2}
            };

            var users = new List<User>
            {
                new User("petko.petkovski@gmail.com","petko123"){ Id=1, RoleId = 1},
                new User("trajko.trajkovski@gmail.com","trajko123"){ Id=2, RoleId = 1},
                new User("mirko.mirkovski@gmail.com","mirko123"){ Id=3 ,RoleId = 1},
                new User("stanko.stankovski@gmail.com","stanko123"){ Id=4, RoleId = 1},
                new User("zane.zanevska@gmail.com","zane123"){ Id=5, RoleId = 2}
            };

            modelBuilder.Entity<Book>().HasData(books);
            modelBuilder.Entity<Author>().HasData(authors);
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Role>().HasData(roles);

            #endregion
        }
    }
}
