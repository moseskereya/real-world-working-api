using Api3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api3.Data
{
    public class Api3Context: DbContext
    {
        public Api3Context(DbContextOptions<Api3Context> options) : base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Price> Prices { get; set; }
    }
}
