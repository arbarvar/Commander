using System.Collections.Generic;
using Commander.Data;
using Commander.Interfaces;
using Commander.Models;

namespace Commander.Repositories
{
    
    public class SqliteCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqliteCommanderRepo(CommanderContext context)
        {
            _context = context;

        }

        public IEnumerable<Command> GetAllComandes()
        {
            throw new System.NotImplementedException();
        }

        public Command GetCommandByID(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}