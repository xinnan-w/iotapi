using System.Collections.Generic;
using System.Linq;
using IoT3D.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace IoT3D.Controllers
{
    [Route("api/[controller]")]
    public class PlayersController : Controller
    {
        private static List<Player> Players = new List<Player>()
        {
            new Player
            {
                Id =1,
                FullName = "Micheal Jordan",
                Score = 1000
            },
            new Player
            {
                Id =2,
                FullName = "Steve Jobs",
                Score = 2000
            },
            new Player
            {
                Id =3,
                FullName = "John Doe",
                Score = 500
            },
        };

        // GET api/players
        [HttpGet]
        public JsonResult Get()
        {
            return Json(Players);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Player player = Players.Single(p => p.Id == id);
            return Json(player);
        }

        // POST api/values
        [HttpPost]
        public JsonResult Post([FromBody]Player newPlayer)
        {
            Players.Add(newPlayer);
            return Json(Players);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public JsonResult Put(int id, [FromBody]float newScore)
        {
            Player player = Players.Single(p => p.Id == id);
            player.Score = newScore;
            return Json(player);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Player player = Players.Single(p => p.Id == id);
            Players.Remove(player);
        }
    }
}
