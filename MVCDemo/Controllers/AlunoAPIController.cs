using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoAPIController : ControllerBase
    {
        protected readonly Repositorio _repositorio = new Repositorio();
        // GET: api/<AlunoAPIController>
        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            return _repositorio.GetAlunos();
        }

        // GET api/<AlunoAPIController>/5
        [HttpGet("{id}")]
        public Aluno Get(string RA)
        {
            return _repositorio.GetAluno(RA);
        }

        // POST api/<AlunoAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AlunoAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AlunoAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
