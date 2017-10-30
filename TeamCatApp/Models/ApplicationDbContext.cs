using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TeamCatApp.Models {
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> {
        public DbSet<Teams> Teams { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<AssignedProjects> AssignedProjects { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false) {
        }

        public static ApplicationDbContext Create() {
            return new ApplicationDbContext();
        }
    }
}