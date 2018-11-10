using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NETConfWebAPI.Data;
using System.Linq;

namespace NETConfWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpPost]
        public void Post([FromBody] Task task)
        {
            using (var context = new TasksContext())
            {
                context.Tasks.Add(task);
                context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Task>> Get()
        {
            using (var context = new TasksContext())
            {
                return context.Tasks.ToList();
            }
        }
    }
}