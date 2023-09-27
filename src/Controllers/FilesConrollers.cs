using Microsoft.AspNetCore.Mvc;

namespace clouddrive.contollers
{
    [Route("/api/file")]
    public class FilesControllers : ControllerBase
    {
        [HttpGet]
        public string Get() // by default private
        {
            return "Hello World";
        }

        [HttpGet("{id}")]
        public int GetById(int id)
        {
            return id;
        }

        [HttpPost("{id}")]
        public int PostById(int id)
        {
            return id;
        }

        [HttpPost]
        public string PostByString([FromBody] string name)
        {
            return name;
        }

        [HttpPut("put/{id}")]
        public string Put(
            [FromBody] string name,
            [FromRoute] int id,
            [FromHeader] string header,
            [FromQuery] string query
        )
        {
            return "name " + name + " id " + id + " from header " + header + " from query " + query;
        }
    }
}
