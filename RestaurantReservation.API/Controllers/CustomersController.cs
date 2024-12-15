using Microsoft.AspNetCore.Mvc;

namespace RestaurantReservation.API.Controllers;

[ApiController]
[Route("api/")]
public class CustomersController  : ControllerBase
{
    private Customer _customer;
    public CustomersController (Customer customer)
    {
        _customer = customer;
    }

    [HttpGet("GetReservationsByCustomer")]
    public IEnumerable<string> GetReservationsByCustomer()
    {
        return new string[] { "Sunny", "Cloudy" };
    }
    
    [HttpGet("reservations/customer/{customerId}")]
    
    public void GetID()
    {
        Console.WriteLine("dcI");
    }
}
