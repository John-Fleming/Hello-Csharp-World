using System;

namespace HelloCsharpWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var southern = "Howdy Y'all!!";
            var spanish = "Hola Amigos!!";
            var japanese = "Konnichiwa!!";
            var greeting = "Pick a Greeting: Southern, Spanish, or Japanese";

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
        }
    }
}
