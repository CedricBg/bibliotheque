using bibliotheque.Model;
using SQLite;

namespace bibliotheque.DataAccess.Services;

public class BookService
{
    SQLiteAsyncConnection Database;
    

    async Task Init()
    {
        if (Database is not null)
            return;

        Database = new SQLiteAsyncConnection(SqliteDbContext.DatabasePath, SqliteDbContext.Flags);
        var result = await Database.CreateTableAsync<Book>();
    }

    public async Task<Book> GetBookAsync(int id = 1)
    {
        await Init();
        return await Database.Table<Book>().Where(i => i.BookId == id).FirstOrDefaultAsync();
    }

    public async Task<List<Book>> GetBooksAsync()
    {
        await Init();
        return await Database.Table<Book>().ToListAsync();
    }

    public async Task<int> SaveBookAsync(Book book)
    {
        await Init();
        if(book.BookId != 0)
        {
           return await Database.UpdateAsync(book);
        }
        else
        {
            return await Database.InsertAsync(book);
        }

    }

}
