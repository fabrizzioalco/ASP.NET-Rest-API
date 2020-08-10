using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        
        bool SaveChanges();
        //Defining operations 
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        void UpdateCommands(Command cmd);

        void DelteCommand(Command cmd);
    }

}