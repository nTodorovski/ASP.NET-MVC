using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Data
{
    internal static class Storage
    {
        public static List<Author> Authors = new List<Author>
        {
            new Author(1,"Dan","Brown",54),
            new Author(2,"Miguel","de Cervantes",68),
            new Author(3,"Mark","Twain",74),
            new Author(4,"Leo","Tolstoy",82)
        };

        public static List<Book> Books = new List<Book>
        {
            new Book(1,"0-385-50420-9","The DaVinci Code",GenreEnum.Thriller,Authors.FirstOrDefault(x=>x.FirstName == "Dan" && x.LastName == "Brown"),589,10),
            new Book(2,"0-671-02735-2","Angels and Demons",GenreEnum.Thriller,Authors.FirstOrDefault(x=>x.FirstName == "Dan" && x.LastName == "Brown"),616,8),
            new Book(3,"0-587-06995-6","Don Quixote",GenreEnum.Novel,Authors.FirstOrDefault(x=>x.FirstName == "Miguel" && x.LastName == "de Cervantes"),863,5),
            new Book(4,"0-726-01278-8","War and Peace",GenreEnum.History,Authors.FirstOrDefault(x=>x.FirstName == "Leo" && x.LastName == "Tolstoy"),1225,4),
            new Book(5,"0-924-37885-7","Adventures of Huckleberry Finn",GenreEnum.Novel,Authors.FirstOrDefault(x=>x.FirstName == "Mark" && x.LastName == "Twain"),366,6)
        };

        public static List<Role> Roles = new List<Role>
        {
            new Role(1,"User"),
            new Role(2,"Librarian")
        };

        public static List<User> Users = new List<User>
        {
            new User(1,"petko.petkovski@gmail.com","petko123",Roles.FirstOrDefault(x=>x.Id == 1)),
            new User(2,"trajko.trajkovski@gmail.com","trajko123",Roles.FirstOrDefault(x=>x.Id == 1)),
            new User(3,"mirko.mirkovski@gmail.com","mirko123",Roles.FirstOrDefault(x=>x.Id == 1)),
            new User(4,"stanko.stankovski@gmail.com","stanko123",Roles.FirstOrDefault(x=>x.Id == 1)),
            new User(5,"zane.zanevska@gmail.com","zane123",Roles.FirstOrDefault(x=>x.Id == 2))
        };

        public static List<Loan> Loans = new List<Loan>();
    }
}
