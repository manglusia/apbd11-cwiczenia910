using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Data;

public class DatabaseContext : DbContext
{
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    public DbSetor<Author> Authors { set; get; }
}