using LendingLibraryInterview.Data;
using Microsoft.EntityFrameworkCore;

namespace LendingLibraryInterview.Tests.tests.Services;
public abstract class InMemoryDatabaseTestsBase
{
    protected InMemoryDatabaseTestsBase()
    {
        var options = new DbContextOptionsBuilder<SQLiteDbContext>()
                .UseInMemoryDatabase(databaseName: "SQLiteDbContext")
                .Options;

        DbContext = new SQLiteDbContext(options);
    }

    protected SQLiteDbContext DbContext { get; }
}
