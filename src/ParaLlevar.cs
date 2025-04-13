using Ucu.Poo.Restaurant;

namespace IsTakeAway
{
    public class OutOfRestaurant
    {
        public bool IsTakeAway {get; set;}

        public bool AskIsTakeAway()
        {
            Console.WriteLine("Es para llevar? si/no");

            string answer = Console.ReadLine().ToLower();

            if(answer == "si")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
            

   
    