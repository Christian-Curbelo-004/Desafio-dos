namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    private ArrayList order = new ArrayList();

    public int Number { get; set; }
    public bool IsOccupied { get; set; }

    public Table(int number)
    {
        this.Number = number;
    }

    public void Ocupy()
    {
        this.IsOccupied = true;
    }

    public void Free()
    {
        this.IsOccupied = false;
        this.order.Clear();
    }

    public void AddOrder(Dish dish)
    {
        this.order.Add(dish);
    }

    public bool HasOrders()
    {
        return this.order.Count > 0;
    }
    
    
    public double GetTotal()
    {
        double total = 0.0;
        foreach (Dish dish in this.order)
        {
            total += dish.Price;
        }
        return total;
    }
}
