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
              
        }
    }
}
