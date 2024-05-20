using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace MMO_EFCore
{
    class Program
    {
        // 초기화
        static void InitializeDB(bool forceReset = false)
        {
            using (AppDbContext db = new AppDbContext())
            {
                if (!forceReset && (db.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists())
                    return;

                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                Console.WriteLine("DB Initialize");
            }
        }


        static void Main(string[] args)
        {
            InitializeDB(forceReset: true);
        }

    }
}

