using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCarBook.EntityLayer.Concrete;
using MyCarBookEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarBook.DataAccessLayer.Concrete
{
  

    public class CarBookContext : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-H67U406; initial catalog=CarBookDb;integrated Security =true");
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars{ get; set; }
        public DbSet<CarCategory> CarCategories{ get; set; }

        public DbSet<CarStatus> CarStatuses{ get; set; }

        public DbSet<Location> Locations{ get; set; }
        public DbSet<Price> Prices{ get; set; }





        //Ders 17 bitti 
    }
}
