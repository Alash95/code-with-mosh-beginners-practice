
namespace _6_Type_Conversion;

    class Program
    {
        static void Main(string[] args)
        {
            /*byte b = 1;
            int i = b;
            Console.WriteLine(i);*/

            int a = 1000;
            byte c = (byte) a;
            Console.WriteLine(c);
            

            try
            {
                var number = "1234";
                byte i = Convert.ToByte(number);
                Console.WriteLine(i);

                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)  
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }


        }
    }
