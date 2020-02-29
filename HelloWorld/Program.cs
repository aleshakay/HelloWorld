using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                Console.WriteLine("Please enter a choose a dialect option? Southern, Northern, or Pirate");
                String dialect = Console.ReadLine();
                switch (dialect)
                {
                    case "Northern":
                        Console.WriteLine("Northern");
                        break;
                    case "Pirate":
                        Console.WriteLine("Pirate");
                        break;
                    default:
                        Console.WriteLine("Southern");
                        break;
                }

            }

            Console.WriteLine("Howdy Y'all!!");
            Console.WriteLine("Please enter you name:");
            String name = Console.ReadLine();
            Console.WriteLine($"Good Day: {name}");

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "cat", "dog" };
                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
                foreach( var animal in animals)
                {
                int numVowels = 0;
                foreach (var vowel in vowels)
                    {
                        if (animal.Contains(vowel))
                        {
                            numVowels++;
                        }
                    }
                    if(numVowels > 2)
                {
                    Console.WriteLine(animal);
                }

                }
            Console.WriteLine("Please enter your favorite color:");
            String favColor = Console.ReadLine();
            Console.WriteLine($"Would you like to have a {favColor} elephant?");
            
        }
    }
}
