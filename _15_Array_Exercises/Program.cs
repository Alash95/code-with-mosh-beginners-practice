namespace _1_Array_Exercises;

public class Arrays
{
    public void Exercise1()
    {
        var myList = new List<string>();

        Console.WriteLine("Enter a Name: ");
        string input;
 
        do
        {
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                myList.Add(input);
                Console.WriteLine("Enter another name: ");
            }
        } while (!string.IsNullOrWhiteSpace(input));
   

        if (myList.Count == 0)
        {
        }

        else if (myList.Count == 1)
        {
            Console.Write("{0} likes your post.", myList[0]);
        }

        else if (myList.Count == 2)
        {
            Console.Write("{0} and {1} like your post", myList[0], myList[1]);
        }

        else
        {
            Console.Write("{0}, {1} and {2} others like your post.", myList[0], myList[1], myList.Count - 2);
        }
    }

    public void Exercise2()
    {
        Console.WriteLine("Enter your name: ");
        var input = Console.ReadLine();

        var nameCharArray = input.ToCharArray();


        Array.Reverse(nameCharArray);

        var reversedName = new string(nameCharArray);

        Console.Write("Reversed name: " + reversedName);
    }

    public void Exercise3()
    {
        Console.WriteLine("Enter 5 numbers: ");

        var numbers = new List<int>();

        for (var i = 0; i < 5; i++)
        {
            var input = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(input));

            if ((numbers[i + 1] == Convert.ToInt32(input)))
            {
                numbers.Add(Convert.ToInt32(input));
            }
            else
            {
                Console.WriteLine("This number is present please try again: ");
            }
        }

        Console.WriteLine(numbers);
    }

    public void Exercise4()
    {
        List<int> nums = new List<int>();
        Console.WriteLine("Enter a number: ");
        string input;
        string exitInput = "Quit";
        do
        {
            input = (Console.ReadLine());
            if (input.ToLower() == exitInput.ToLower())
                break;

            //Input validation for an integer
            if (int.TryParse(input, out int num))
            {
                nums.Add(num);
                Console.WriteLine("Enter another number (or type 'quit' to stop): ");
            }
            else
            {
                Console.WriteLine("Invalid input. Try again (or type 'quit' to stop): ");
            }
        } while (true);

        List<int> uniqueNums = new List<int>();
        foreach (var num in nums)
        {
            //bruteforce method would require either one for loop or two foreach loop
            if (!uniqueNums.Contains(num)) 
            {
                uniqueNums.Add(num);
            }
        }
        Console.WriteLine(string.Join(", ", uniqueNums));
    }

    //5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
    //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
    //otherwise, display the 3 smallest numbers in the list.
    public void Exercise5()
    {
        Console.WriteLine("Enter any numbers (separate by commas): ");
        string input;

        while (true)
        {
            input = Console.ReadLine();
            List<int> numbers = new List<int>();
        
            if (!string.IsNullOrWhiteSpace(input) || !string.IsNullOrEmpty(input))
            {
                string[] parts = input.Split(",");

                if (parts.Length < 5) 
                {
                    Console.WriteLine("'Invalid List' (please retry).");
                    continue;
                }

                foreach (var part in parts)
                {
                    if (!int.TryParse(part.Trim(), out int num)) 
                    {
                        Console.WriteLine("'Invalid List' (please retry).");
                        continue;
                    }

                    numbers.Add(num);
                }

                numbers.Sort();
                Console.WriteLine("The 3 smallest numbers are: " + string.Join(", ", numbers.Take(3)));
                break;
            }
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        var arrays = new Arrays();

        // arrays.Exercise1();
        // arrays.Exercise2();
        // arrays.Exercise3();
        // arrays.Exercise4();
        arrays.Exercise5();
        
    }
}