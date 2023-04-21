using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using signLanguageApp.Models;

namespace signLanguageApp.Data
{
    public class signLanguageAppContext : DbContext
    {
        public signLanguageAppContext (DbContextOptions<signLanguageAppContext> options)
            : base(options)
        {
        }

        public DbSet<Sign> Sign { get; set; } = default!;
    }
}
