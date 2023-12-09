using bibliotheque.Model;
using SQLite;


namespace bibliotheque.DataAccess.Services;

public class OwnerService
{
    SQLiteAsyncConnection Database;

   

    async Task Init()
    {
        if (Database is not null)
            return;

        Database = new SQLiteAsyncConnection(SqliteDbContext.DatabasePath, SqliteDbContext.Flags);
        var result = await Database.CreateTableAsync<Owner>();

    }
    public async Task<string> GetOwnerAsync(int id = 1)
    {
        await Init();
        Owner owner;
        owner =  await Database.Table<Owner>().Where(i => i.IdOwner == id).FirstOrDefaultAsync();
        return owner.Name;
    }
}
