
namespace Ucu.Poo.Restaurant
{
    using System;
    using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
            // Crear mesa y platos
            Table mesa1 = new Table(1);
            Dish plato1 = new Dish("Ensalada", 20.0, true);
            Dish plato2 = new Dish("Milanesa napolitana", 40.0, false);

            // Agregar platos a la mesa
            mesa1.AddOrder(plato1);
            mesa1.AddOrder(plato2);

    
            double totalMesa1 = mesa1.GetTotal();
            Console.WriteLine(totalMesa1);

            
        }
    }
}
