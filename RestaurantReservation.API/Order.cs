namespace RestaurantReservation.API;

public class Order
{
    public int order_id { set; get; }
    public Menu_item menu_items { set; get; }

    public Order(int order_id, Menu_item menu_items )
    {
        this.order_id = order_id;
        this.menu_items = menu_items;

    }
    
}