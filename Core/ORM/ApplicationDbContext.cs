using System.Data.Common;
using Core.ORM.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core.ORM;

public class ApplicationDbContext: DbContext
{
    public DbSet<AClassEntity> Classes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "Data Source=/data/home/AbeliaNymph/Data/SqliteDB/OpenJDK8-API-Browser.sqlite;";
        optionsBuilder.UseSqlite(connectionString);
    }
}
