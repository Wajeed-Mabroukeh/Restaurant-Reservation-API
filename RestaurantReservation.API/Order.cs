namespace RestaurantReservation.API;

public class Order
{
    public int order_id { set; get; }
    public string order_name { set; get; }
    public int order_quantity { set; get; }
    public double order_price { set; get; }

    public Order(int order_id,string order_name ,int order_quantity ,double order_price)
    {
        this.order_id = order_id;
        this.order_name = order_name;
        this.order_quantity = order_quantity;
        this.order_price = order_price;

    }
    public override string ToString()
    {
        return $"{order_id} \n {order_name} \n {order_quantity} \n {order_price} \n ";
    }
}