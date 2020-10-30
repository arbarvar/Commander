using Commander.Interfaces;
using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//here is 3th  place to start programing by creating access to data model
namespace Commander.Repositories
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllComandes()
        {
            
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil  egg", Line = "Boil water", Platform = "kattel & Pan" },
                new Command { Id = 1, HowTo = "Boil  egg", Line = "Boil water", Platform = "kattel & Pan" },
                new Command { Id = 2, HowTo = "Boil  egg", Line = "Boil water", Platform = "kattel & Pan" }
            };
            return commands;
        }

        public Command GetCommandByID(int id)
        {
            return new Command { Id = 0, HowTo = "Boil  egg", Line = "Boil water", Platform = "kattel & Pan" };
        }
    }

}
