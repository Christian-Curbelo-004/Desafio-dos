using IsTakeAway;

class Program

{
    static void Main(string[] args)
    {
        OutOfRestaurant myOrder = new OutOfRestaurant();

        bool takeAwayStatus = myOrder.AskIsTakeAway();

        Console.WriteLine("Estado de la orden (para llevar):" + takeAwayStatus);  
    }
}