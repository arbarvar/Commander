using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//here is Second place to start programing by creating Interface to present what the program prepare.
namespace Commander.Interfaces
{
    public interface ICommanderRepo
    {
        public IEnumerable<Command> GetAllComandes();
        public Command GetCommandByID(int id);

    }
}
