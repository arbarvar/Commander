using Commander.Interfaces;
using Commander.Models;
using Commander.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//here is 4th  place to start programing by creating a controller how from outside access to data by define rules
//next step 6th  constructor for injection from Startup
namespace Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }
        
        

        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllComandes();

            return Ok(commandItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandByID(id);

            return Ok(commandItem);
        }
    }
}
