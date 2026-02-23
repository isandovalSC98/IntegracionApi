using IntegracionApi.DTO;
using IntegracionApi.Servicios;
using IntegracionApi.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IntegracionApi.Controllers
{
    public class InicioController : Controller
    {
        private readonly IServicio_API _servicioApi;

        public InicioController(IServicio_API servicioApi)
        {
            _servicioApi = servicioApi ?? throw new ArgumentNullException(nameof(servicioApi));
        }

        public async Task<IActionResult> Inicio()
        {
            var topAnime = new TopAnimeViewModel { Items = await _servicioApi.ObtenerTopAnime() };

            return View(topAnime);
        }

        //[HttpPost]
        //public async Task<IActionResult> Inicio(string nombre, int edad) {


        //    ViewBag.respuesta = nombre+" "+ edad;
        //    //Console.ReadKey();
        //    return View();
        //}
        [HttpGet("/seasons")]
        //public async Task<IActionResult>seasons() =>Ok(await _servicioApi.ObtenerSeason());
        public async Task<IActionResult> Season()
        {

            var temporadas = new SeasonsViewModel { Items = await _servicioApi.ObtenerSeason() };
            return View(temporadas);
        }

        //[HttpGet("/anime/{id:int}/characters")]
        //public async Task<IActionResult> Characters(int id, CancellationToken ct) => Ok(await _servicioApi.ObtenerPersonajes(id, ct));

        [HttpGet("/anime/{id:int}/characters")]
        public async Task<IActionResult> Personajes(int id, CancellationToken ct)
        {
            var personajes = new AnimeCharactersViewModel { Items = await _servicioApi.ObtenerPersonajes(id, ct) };
            return View(personajes);

        }

        [HttpGet("/top/anime")]
        public async Task<IActionResult> Characters(CancellationToken ct) => Ok(await _servicioApi.ObtenerTopAnime(ct));
    }
}
