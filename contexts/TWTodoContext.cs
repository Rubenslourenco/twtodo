using Microsoft.EntityFrameworkCore;
using TwTodo.Models;

namespace TwTodo.contexts
{
    public class TWTodoContext : DbContext
    {
       public DbSet<Todo> Todos => Set<Todo>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=todos.sqlite3");
        }
    }
}