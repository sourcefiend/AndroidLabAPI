using CleanArchitecture.Application.Cars.Queries;
using CleanArchitecture.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebUI.Controllers;
public class CarController : ApiControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<Car>>> GetCars([FromQuery] GetCarsQuery query)
    {
        return await Mediator.Send(query);
    }
}
