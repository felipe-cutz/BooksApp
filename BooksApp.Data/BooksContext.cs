﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace BooksApp.Data
{
    public class BooksContext : DbContext
    {
        private const string connectionString =
            "Data Source = (localdb \\MSSQLLocalDV; Initial Catalog = BooksAppData";
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
