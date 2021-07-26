using System;

namespace Speak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What animal would you like to hear(dog, monkey, goat)?");
            string answer = Console.ReadLine().ToLower();

            string sound = Speak(answer);
            Console.WriteLine($"A {answer} makes a {sound}");
        }

        static string Speak(string animalNoise)
        {
            string sound;
            
            if (animalNoise == "dog")
            {
                sound = "woof-woof";
                return sound;
            }
            else if (animalNoise == "monkey")
            {
                sound = "ooh-oohh ahh-ahhh";
                return sound;
            }
            else if (animalNoise == "goat")
            {
                sound = "blehhhhhhhhhhhhhhhhhhhhhhhhhhhhh";
                return sound;
            }
            else
            {
                sound = "meow, oink, achoooo";
                return sound;
            }
        }
    }
}
