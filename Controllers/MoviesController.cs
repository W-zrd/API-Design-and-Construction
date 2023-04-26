using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace API_Design_and_Construction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private static List<Movies> film = new List<Movies>
        {
            new Movies("The Shawshank Redemption", "Frank Darabont", "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion",
                new List<string>{"Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler"}),
            new Movies("The Godfather", "Francis Ford Coppola", "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.",
                new List<string>{"Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton"}),
            new Movies("The Dark Knight", "Christoper Nolan", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                new List<string>{"Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine"})
        };

        [HttpGet()]
        public IEnumerable<Movies> Get()
        {
            return film;
        }

        [HttpPost]
        public void Post(Movies value)
        {
            /* Input versi hardcode
            Movies value2 = new Movies("The Lord of the Rings: The Return of the King", "Peter Jackson", "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                new List<string> { "Elijah Wood", "Viggo Mortensen", "Ian McKellen", "Orlando Bloom" }); */
            film.Add(value);
        }

        [HttpGet("{id}")]
        public Movies Get(int id)
        {
            return film[id];
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            film.RemoveAt(id);
        }
    }
}
