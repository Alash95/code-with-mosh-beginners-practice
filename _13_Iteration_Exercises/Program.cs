namespace _13_Iteration_Exercises;

    public class Loops
    {
        public void Exercise1()
        {
            var count = 0;
            for (var i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine("The count of numbers between 1 and 100 that are divisible by 3 is: {0}",count);

        }

        public void Exercise2()
        {
            var sum = 0;

            while (true)
            {
                Console.Write("Enter a number (or 'ok' to exit:)");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("Sum of all numbers inputted is: " + sum);
        }

        public void Exercise3()
        {
            Console.WriteLine("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());


            var factorial = 1;
            for (var i = 1; i <= number; i++)
                factorial *= i;
            
            Console.WriteLine("{0}! = {1}", number, factorial);
        }

        public void Exercise4()
        {
            var number = new Random().Next(1, 10);

            Console.WriteLine("Secret is " +  number);
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Guess the number: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You Won!");
                    return;
                }
            }
            Console.WriteLine("You lost!");
        }

        public void Exercise5()
        {
            Console.WriteLine("Enter comma separated numbers: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            //Assume the first number is the max
            var max = Convert.ToInt32(numbers[0]);

            foreach (var num in numbers)
            {
                var number = Convert.ToInt32(num);
                if (number > max)
                    max = number;
            }
            Console.WriteLine("Max is " + max);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var loops = new Loops();
            //loops.Exercise1();
            //loops.Exercise2();
            //loops.Exercise3();
            //loops.Exercise4();
            loops.Exercise5();
        }
    }

