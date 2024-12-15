namespace RestaurantReservation.API;

public class Customer
{
    public int customer_id { get; set; }
    public string? customer_name { get; set; }

    public override string ToString()
    {
        return $"{customer_id} \n {customer_name} \n";
    }
}
