using Entities.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        #region Seeding User Data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().HasData(
                    new UserModel()
                    {
                        Id = 1,
                        UserName = "burhan_admin",
                        EmailAdress = "bsozer@gmail.com",
                        Password = "123456",
                        GivenName = "Burhan",
                        Surname = "Sozer",
                        Role = "Administration"
                    },
                    new UserModel()
                    {
                        Id = 2,
                        UserName = "orhan_seller",
                        EmailAdress = "bxxxx@gmail.com",
                        Password = "123456",
                        GivenName = "Orhan",
                        Surname = "Atmaca",
                        Role = "Seller"
                    }
           );
        }
        #endregion

        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<UserModel> UserModels { get; set; }
    }
}
