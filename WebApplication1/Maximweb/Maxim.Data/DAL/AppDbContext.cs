﻿using Maximweb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Maximweb.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
      
        public DbSet<AppUser> AppUsers { get; set; }
       

    }
}
