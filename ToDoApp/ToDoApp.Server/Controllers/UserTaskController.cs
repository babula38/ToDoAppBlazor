using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoApp.Server.Controllers
{
    [Route("api/[controller]")]
    public class UserTaskController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<UserTask> Get()
        {
            return Appstate.TaskList;
        }

        [HttpPost]
        public IActionResult Post(UserTask userTask)
        {
            if (Appstate.AddUserTask(userTask))
                return Ok();
            return StatusCode(Convert.ToInt32(HttpStatusCode.InternalServerError), "Unable to add the User task");
        }
    }
}
