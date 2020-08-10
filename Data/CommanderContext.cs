using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
    public class CommanderContext: DbContext
    {
        //base is used to call the constructor, still dont know for what
        public CommanderContext(DbContextOptions<CommanderContext> opt): base(opt)
        {
            
        }
 
        public DbSet<Command> Commands { get; set; }
    }
}