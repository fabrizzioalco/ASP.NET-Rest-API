using System.Collections.Generic;
using AutoMapper;
using Commander.Data;
using Commander.Dtos;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controller
{
    //api/commands
    //Route would create the specific route youll need. such as route.app("") in python
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;
        private readonly IMapper _mapper;

        //constructor
        public CommandsController(ICommanderRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        // private readonly MockCommanderRepo _repository =  new MockCommanderRepo();
        //GET api/commands
        [HttpGet]
        //returnging CommandReadDtos wuold give me the objects that i need 
        public ActionResult <IEnumerable<CommandReadDtos>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();

            //Enumerable because this should be counting for the DB, like and id i think
            return Ok(_mapper.Map<IEnumerable<CommandReadDtos>>(commandItems));
        }
        //This would ask for an id in the url 
        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <CommandReadDtos> GetCommandById(int id)
        {
            var commandIem = _repository.GetCommandById(id);
            if(commandIem!= null)
            {
                return Ok(_mapper.Map<CommandReadDtos>(commandIem));    
            }

            return NotFound();
            
        }

        //POST api/commands
        [HttpPost]
        public ActionResult<CommandReadDtos> CreateCommand(CommandCreateDto commandCreadeDto)
        {
            var commandModel = _mapper.Map<Command>(commandCreadeDto);
            _repository.CreateCommand(commandModel);
            _repository.SaveChanges();

            var commanderReadDto = _mapper.Map<CommandReadDtos>(commandModel);
            return Ok(commanderReadDto);
        }
        //profiile we define how is going to be mapped
    }
}