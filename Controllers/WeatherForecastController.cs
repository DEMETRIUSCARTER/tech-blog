using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogApi.Models;

namespace BlogApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController] public class ValuesController: ControllerBase
{
List<BlogPost> Posts = new List<BlogPost>
{
  new BlogPost
{
  Id = 1,
  Title = "example post",
  Summary = "this is just some text",
  Author = new Author
    {
Id = 1,
Name = "Dee",
Description = "Hi, my name is Dee"
    },
    Tags = new string []
    {
        "example",
        "post"
    }
}
};
 [HttpGet]
 public ActionResult<IEnumerable<BlogPost>> Get()
  {
    return Posts;
  }

  [HttpGet("{id}")]
  public ActionResult<BlogPost> Get(int id)
   {
     return Posts.FirstOrDefault(post => post.Id == id);
   }

  [HttpPost]
  public void Post([FromBody] BlogPost value)
   {
   }

  [HttpPut("{id}")]
  public void Put(int id, [FromBody] BlogPost value)
   {
   }

  [HttpDelete("{id}")]
  public void Delete(int id)
   {
   }
    }
}
