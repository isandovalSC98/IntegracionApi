using IntegracionApi.DTO;
using IntegracionApi.Servicios;
using IntegracionApi.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IntegracionApi.Controllers
{
    public class InicioController : Controller
    {
        private readonly IServicio_API _servicioApi;

        public InicioController(IServicio_API servicioApi)
        {
            _servicioApi = servicioApi ?? throw new ArgumentNullException(nameof(servicioApi));
        }

        //public IActionResult Inicio()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> Inicio(string nombre, int edad) {

            
        //    ViewBag.respuesta = nombre+" "+ edad;
        //    //Console.ReadKey();
        //    return View();
        //}
        [HttpGet("/seasons")]
        //public async Task<IActionResult>seasons() =>Ok(await _servicioApi.ObtenerSeason());
        public async Task<IActionResult> Inicio()
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
    }
}
