﻿using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdminPortal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        //private readonly ILogger<WeatherForecastController> _logger;

        //public WeatherForecastController(ILogger<WeatherForecastController> logger)
        //{
        //    _logger = logger;
        //}

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1,1).Select(index => new WeatherForecast
        //    {
        //        id = index,
        //        Employee_name = "Дима",
        //        mail = "LordOFPORN01@mail.ru",
        //        phone = "8 989 228 58 48"
        //        //Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //        //TemperatureC = Random.Shared.Next(-20, 55),
        //        //Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
        //[HttpPut(Name = "GetWeatherForecast")]

        //public IEnumerable<WeatherForecast> Put()
        //{

        //}

    }
}
