using _10_Control_Flow;

namespace ControlFlow
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season.");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's perfect to go to beach.");
                    break;

                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }


              int hour = 10;

             if (hour > 0 && hour < 12)
             {
                 Console.WriteLine("It's Morning");
             }
             else if (hour >= 12 && hour < 18)
             {
                 Console.WriteLine("It's Afternoon");
             }
             else
             {
                 Console.WriteLine("It's evening");
             }

             bool isGoldCustomer = true;

            float price;
            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f;

            price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);
        }
    }
}