using System.Runtime.InteropServices.ComTypes;
using System.Security.AccessControl;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantReservation.API.Controllers;

[ApiController]
[Route("/api/")]
public class CustomersController  : ControllerBase
{
    private static List<Customer> _customer =  new List<Customer>() ;
    private List<Manager> _manager =  new List<Manager>() ;
    private List<Reservations> _reservations =  new List<Reservations>() ;
    private List<Order> _orders =  new List<Order>() ;

    public CustomersController ()
    {
        // Customer customer = new Customer();
        // customer.customer_id = 11;
        // customer.customer_name = "wajeed";
        // _customer.Add(customer );
        
        Manager manager = new Manager();
        manager.manager_id = 11;
        manager.manager_name = "ibrahim";
        _manager.Add(manager );

        Order order1 = new Order(10, "Crispy" , 2 , 200.0);
        Order order2 = new Order(11, "Prost" , 3 , 100.0);
        
        _orders.Add(order1);
        _orders.Add(order2);

        Reservations reservation1 = new Reservations(88, _orders);
        
        Order order3 = new Order(22, "Crispy" , 2 , 300.0);
        Order order4 = new Order(33, "Prost" , 7, 120.0);
        
        _orders.Add(order3);
        _orders.Add(order2);
        
        Reservations reservation2 = new Reservations(77, _orders);
        
        _reservations.Add(reservation1);
        _reservations.Add(reservation2);


    }

    [HttpGet("GetReservationsByCustomer")]
    public List<Customer> GetReservationsByCustomer()
    {
       return _customer;
    }
    
    [HttpGet("employees/managers")]
    public List<Manager> Get_employees_managers()
    {
        return _manager;
    }
    
    
    [HttpGet("reservations/customer/{customerId}")]
    public Customer Get_customerId(int customerId)
    {
        foreach (var customer in _customer)
        {
            if (customer.customer_id == customerId)
            {
                return customer;
            }
        }

        return null;
    }
    
    [HttpGet("reservations/{reservationId}/orders")]
    public Reservations Get_reservationId(int reservationId)
    {
        foreach (var reservation in _reservations)
        {
            if (reservation.reservations_id == reservationId)
            {
                return reservation;
            }
        }

        return null;
    }
    
    [HttpPost]
    public List<Customer> Post_CreateCustomer([FromBody] Customer customer)
    {
        if (customer == null)
        {
           return null;
        }
        _customer.Add(customer);
        return  _customer;
    }
    
    [HttpPut("{id}")]
    public Customer UpdateCustomer(int id, [FromBody]  Customer customer)
    {
        if (customer == null)
        {
            return null;
        }

        foreach (var customer_Update in _customer)
        {
            if (customer_Update.customer_id == id)
            {
                customer_Update.customer_id = customer.customer_id;
                customer_Update.customer_name = customer.customer_name;
                return customer_Update;
            }
        }

        return null;
    }

    [HttpDelete("{id}")]
    public string DeleteCustomer(int id, [FromBody]  Customer customer)
    {
        if (customer == null)
        {
            return "";
        }

        foreach (var customer_Update in _customer)
        {
            if (customer_Update.customer_id == id)
            {
                _customer.Remove(customer_Update);
                return "Success";
            }
        }

        return "";
    }
    
}
