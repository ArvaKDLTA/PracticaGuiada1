using Microsoft.AspNetCore.Mvc;
using PracticaGuiada1.Controllers.Modelos;

namespace PracticaGuiada1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        public string mensaje([FromBody] Mensaje mensaje)
        {
            Mensaje algo = new Mensaje(mensaje.Nombre, mensaje.Edad);
            return String.Format($"Hola mi nombre es {algo.Nombre} y tengo {algo.Edad} años");
        }

        
        [HttpPost]
        [Route("animal")]
        public string InfoAnimal([FromBody] Perro perroIn)
        {
            Animal animal = new Animal(perroIn.Nombre, perroIn.Edad, perroIn.Genero);
            Perro perro = new Perro(perroIn.Nombre, perroIn.Edad, perroIn.Genero, perroIn.Raza, perroIn.ColorPelo);

            return $"Nombre: {animal.Nombre} Edad: {animal.Edad} Especie: {animal.Genero} Raza: {perro.Raza} Color de pelo: {perro.ColorPelo}"; ;
        }
    }
}