using ApiTemplate.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiTemplate.Data
{
    public class ITILContext : DbContext
    {
        public ITILContext(DbContextOptions<ITILContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuario");

        }

    }
}
