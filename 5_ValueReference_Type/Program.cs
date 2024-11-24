
namespace _5_ValueReference_Type;

    public class Person
    {
        public int Age;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() { Age = 20};
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        private static void MakeOld(Person person)
        {
            person.Age += 10;
        }

        private static void Increment(int number)
        {
            number += 10;
        }
    }
