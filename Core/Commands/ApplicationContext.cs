using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace Core;

public class ApplicationContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string sqliteDbFileLocation = "/home/AbeliaNymph/Data/SqliteDB/OpenJDK8-API-Browser.sqlite";
        
        optionsBuilder.UseSqlite($"Data Source={sqliteDbFileLocation};Version=3;");
    }
}
