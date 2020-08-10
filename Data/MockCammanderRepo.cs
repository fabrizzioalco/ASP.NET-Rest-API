using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil an egg", Platform="Kettle & Pan", Line="Boil water"},
                new Command{Id=1, HowTo="Cut bread", Platform="Shocolate", Line="Get a knife"},
                new Command{Id=2, HowTo="Make Coffee", Platform="Kalt Gerau", Line="Boil water"},
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Platform="Kettle & Pan", Line="Boil water"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommands(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }

}