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
    private static List<Reservations> _reservations =  new List<Reservations>() ;
    private List<Order> _orders = new List<Order>() ;
  

    public CustomersController ()
    {
        // Customer customer = new Customer();
        // customer.customer_id = 11;
        // customer.customer_name = "wajeed";
        // _customer.Add(customer );
     
        
        Manager manager = new Manager();
        manager.manager_id = 11;
        manager.manager_name = "ibrahim";
        

        Menu_item m1 = new Menu_item(1,"Crispy",200.0,2);
        Menu_item m2 = new Menu_item(2,"Prost" , 100.0,3);
        Menu_item m3 = new Menu_item(3,"Crispy" , 300.0,5);
        Menu_item m4 = new Menu_item(4,"Prost" , 120.0,6);

        Order order1 = new Order(10,m1);
        Order order2 = new Order(11,m2 );

        manager.order.Add(order1);
        manager.order.Add(order2);
        _manager.Add(manager );
        
        _orders.Add(order1);
        _orders.Add(order2);

        Reservations reservation1 = new Reservations(88, new List<Order>(_orders));
        _reservations.Add(reservation1);
        
        Order order3 = new Order(22,m3 );
        Order order4 = new Order(33,m4 );
        
        _orders.Clear();
        
        _orders.Add(order3);
        _orders.Add(order4);
        
        Reservations reservation2 = new Reservations(77, new List<Order>(_orders));
        
        
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
    public Reservations Get_reservationId_order(int reservationId)
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
    
    
    [HttpGet("reservations/{reservationId}/menu-items")]
    public  List<Menu_item> Get_reservationId_menu(int reservationId)
    {
        List<Menu_item> menuItems = new List<Menu_item>();
        
        foreach (var reservation in _reservations)
        {
            if (reservation.reservations_id == reservationId)
            {
                foreach (var menu in reservation._Orders)
                {
                    menuItems.Add(menu.menu_items);
                }
                return menuItems;
            }
        }
        return menuItems;
        
    }

    [HttpGet("{employeeId}/average-order-amount")]
    public decimal  GetAverageOrderAmount(int employeeId)
    {
        List<Decimal> AverageOrderAmount = new List<Decimal>();
        
        foreach (var manager in _manager)
        {
            if (manager.manager_id == employeeId)
            {
                foreach (var menu in manager.order)
                {
                    AverageOrderAmount.Add((decimal)menu.menu_items.Price);
                }
               
            }
        }

        decimal average = AverageOrderAmount.Average();
        return average;




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
    public string DeleteCustomer(int id)
    {
        if (id == 0)
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
