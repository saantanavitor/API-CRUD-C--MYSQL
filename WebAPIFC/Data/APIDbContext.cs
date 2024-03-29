﻿using Microsoft.EntityFrameworkCore;
using WebAPIFC.Models;

namespace WebAPIFC.Data
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }

    }
}
