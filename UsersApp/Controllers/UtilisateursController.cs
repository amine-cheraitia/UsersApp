using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UsersApp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UsersApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateursController : ControllerBase
    {
        // GET: api/<UtilisateursController>
        string filePath = @".\Data\utilisateurs.json";
        


        [HttpGet]
        public ActionResult<IEnumerable<Utilisateur>> GetAll()
        {
            var utilisateurs = JsonConvert.DeserializeObject<List<Utilisateur>>(System.IO.File.ReadAllText(filePath));
            return Ok(utilisateurs);

        }
        /*
        // GET api/<UtilisateursController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UtilisateursController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UtilisateursController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UtilisateursController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
