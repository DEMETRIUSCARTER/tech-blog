using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController] public class ValuesController : ControllerBase
{
List<BlogPost> Posts = new List<BlogPost>
{
  newBlogPost
  {
    Id=1,
    Title="Example post",
    Summary="This Is A Example Post",
    Body="Random post",
    Author=new Author
    {
      Id=1,
      Name="Dee"
      Description="Hi, my name is Dee"
    },
    Tags=new string[]
    {
      "example"
      "post"
    }
  }
};

[HttpGet]
public ActionResult<IEnumerable<string>> Get()
{
  return new string[] {"value1", "value2"};
}

[HttpGet("{id}")]
public ActionResult<string> Get(int id)
{
  return "value";
}

[HttpPost]
public void Post ([FromBody] string value)
{
}

[HttpPut("{id}")]
public void Put (int id, [FromBody] string value)
{
}

[HttpDelete ("{id}")]
public void Delete (int id)
{
}
}
}
