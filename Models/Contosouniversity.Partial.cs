using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ASPcore3Homework.Models
{
    public partial class ContosouniversityContext : DbContext
    {
        public override int SaveChanges()
        {
            var entries = this.ChangeTracker.Entries();

            foreach (var entry in entries.Where(p => p.Entity is Course || p.Entity is Department
                || p.Entity is Person))
            {
                if (entry.State == EntityState.Deleted)
                {
                    entry.State = EntityState.Unchanged;
                    entry.CurrentValues.SetValues(new { IsDeleted = true });
                }
            }

            return base.SaveChanges();
        }
    }
}