using Microsoft.EntityFrameworkCore;
using MvcProject.Models;

namespace MvcProject.Data;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<HeThongPP> HeThongPP {get; set;}
        public DbSet<DaiLy> DaiLy {get; set;}
    }
