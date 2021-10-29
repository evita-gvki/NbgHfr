using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NbgHfrCore.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbgHfrCore.Data
{
    public class HfrDbContext : DbContext
    {
        public DbSet<User> User { set; get; }
        public DbSet<Renting> Renting { set; get; }
        public DbSet<Property> Property { set; get; }
        public DbSet<Host> Host { set; get; }

        public HfrDbContext(DbContextOptions<HfrDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-VP2IHB1T\\SQLEXPRESS;Initial Catalog=nbgHfr2021;Integrated Security=True");
        }

    }
    }

