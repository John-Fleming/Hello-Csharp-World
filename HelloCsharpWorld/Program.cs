using System;
using System.Security.Cryptography;

namespace HelloCsharpWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            var username = Console.ReadLine();

            var southern = "Howdy Y'all!!";
            var spanish = "Hola Amigos!!";
            var japanese = "Konnichiwa!!";
            var greeting = $"Hi {username}! Pick a Greeting: Southern, Spanish, or Japanese";

            Console.WriteLine(greeting);
            var userGreeting = Console.ReadLine();

            if (userGreeting == "Spanish")
            {
                Console.WriteLine(spanish);
            }
            else if (userGreeting == "Japanese")
            {
                Console.WriteLine(japanese);
            }
            else
            {
                Console.WriteLine(southern);
            }

            Console.WriteLine("Here are some animals that start with the letter 'T'");

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            foreach (var animal in animals)
            {
                if (animal[0] == 'T')
                {
                    Console.WriteLine(animal);
                }
            }

            var r = new Random();
            var randomAnimal = animals[r.Next(0, animals.Length)];

            Console.WriteLine("What's your favorite color?");
            var favColor = Console.ReadLine();

            Console.WriteLine($"Would you like to have a {favColor} {randomAnimal}?");
        }
    }
}
