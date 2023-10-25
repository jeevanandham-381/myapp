using Microsoft.AspNetCore.Mvc;
using myapp001.EF_core;
using myapp001.models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace myapp001.Controllers
{
    // [Route("api/[controller]")]
    [ApiController]
    public class StudentApiController : ControllerBase
    {
        private readonly DbHelper _db;

        public StudentApiController(EF_Datacontext ef_datacontext)
        {
            _db = new DbHelper(ef_datacontext);
        }
        // GET: api/<StudentApiController>
        [HttpGet]
        [Route("api/[controller]/getall")]
        public IActionResult Get()
        {
            IEnumerable<Student_model> data = _db.Getall();
            if (!data.Any())
            {
                Console.WriteLine("not found");

            }
            return Ok(data);
        }
      

        [HttpGet]
        [Route("api/[controller]/getall/{id}")]
        public IActionResult Get(int id)
        {
            Student_model data=_db.GetById(id);
            if (data == null)
            {
                Console.WriteLine("NOT FOUND");
            }
            return Ok(data);
        }

        
      // POST api/<StudentApiController>
      [HttpPost]
        [Route("api/[controller]/newstu")]
        public IActionResult Post([FromBody] Student_model student)
      {
            _db.NewStu(student);
            return Ok(student);

      }
      
      // PUT api/<StudentApiController>/5
      [HttpPut]
        [Route("api/[controller]/updstu/{id}")]
        public IActionResult Put(int id, [FromBody] Student_model student)
        {
           _db.UpdStu(id,student);
            return Ok(student);

      }
        
            // DELETE api/<StudentApiController>/5
            [HttpDelete]
        [Route("api/[controller]/delstu/{id}")]
        public IActionResult Delete(int id)
            {
            _db.DelStu(id);
            return Ok();

            }
        }
    }

