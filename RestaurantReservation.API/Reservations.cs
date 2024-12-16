namespace RestaurantReservation.API;

public class Reservations
{
    public int reservations_id  { set ; get; }
    public List<Order> _Orders { set; get; }

    public Reservations(int reservations_id, List<Order> _orders)
    {
        this.reservations_id = reservations_id;
        this._Orders = _orders;
    }

    // public override string ToString()
    // {
    //     string out_print = "";
    //     foreach (var order_out in _Orders)
    //     {
    //         out_print += order_out.ToString();
    //     }
    //     return $"{reservations_id} \n bjbnjn \n";
    // }
}