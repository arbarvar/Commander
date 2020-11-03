using Commander.Interfaces;

namespace Commander.Repositories
{
    
    public class SqliteCommanderRepo : ICommanderRepo
    {

        public SqliteCommanderRepo(CommanderContext context)
        {
            _context = context;

        }

        public IEnumerable<Command> GetAllComandes()
        {
            
        }

        public Command GetCommandByID(int id)
        {
            
        }
    }
}