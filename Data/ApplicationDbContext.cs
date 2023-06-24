using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using truongblu001.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<truongblu001.Models.TXTCompany> TXTCompany { get; set; } = default!;

        public DbSet<truongblu001.Models.TXTStudent> TXTStudent { get; set; } = default!;
    }
