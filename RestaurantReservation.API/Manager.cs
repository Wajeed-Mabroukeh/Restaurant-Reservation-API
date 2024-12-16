namespace RestaurantReservation.API;

public class Manager
{
    public int manager_id { get; set; }
    public string? manager_name { get; set; }
    public List<Order> order = new List<Order>();
}