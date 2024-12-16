namespace RestaurantReservation.API;

public class Menu_item
{
    public int MenuItemId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int TotalQuantity { get; set; }

    public Menu_item(int MenuItemId ,string Name , double Price ,int TotalQuantity)
    {
        this.MenuItemId = MenuItemId;
        this.Name = Name;
        this.Price = Price;
        this.TotalQuantity = TotalQuantity;
    }

    public Menu_item()
    {
        throw new NotImplementedException();
    }
}