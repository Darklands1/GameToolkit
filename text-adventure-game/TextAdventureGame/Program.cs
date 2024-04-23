using System;
namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerChoice;
            Console.WriteLine("You will make choices that affect the outcome of your adventure, but first you have to make your character.");

            Console.Write("Enter character name: ");
            string characterName = Console.ReadLine();
            Console.Write("Enter character age: ");
            int characterAge = int.Parse(Console.ReadLine());
            Console.Write("Enter character height (in meters, e.g., 1.75): ");
            float characterHeight = float.Parse(Console.ReadLine());
            Console.Write("Is your character a magic user? (yes/no): ");
            bool isMagicUser = Console.ReadLine().ToLower() == "yes";

            Console.WriteLine("\nCharacter Sheet:");
            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine($"Age: {characterAge}");
            Console.WriteLine($"Height: {characterHeight:0.00} meters");
            Console.WriteLine($"Magic User: {isMagicUser}");

            Console.WriteLine("You find yourself at a fork in the road. Do you go left or right?");
            Console.Write("Enter your choice (left/right): ");
            playerChoice = Console.ReadLine().ToLower();
            if (playerChoice == "left")
            {
                Console.WriteLine("You encounter a friendly wizard who gives you a magical staff.");
                Console.WriteLine("Do you take the staff or leave it?");
                Console.Write("Enter your choice (take/leave): ");
                playerChoice = Console.ReadLine().ToLower();
                if (playerChoice == "take")
                {
                    Console.WriteLine("You take the staff and become a powerful wizard. Congratulations, you win!");
                }
                else
                {
                    Console.WriteLine("You leave the staff and continue on your journey. Suddenly, a dragon appears and you have no way to defend yourself.You lose.");
                }
            }
            else if (playerChoice == "right")
            {
                Console.WriteLine("You find a treasure chest filled with gold and jewels. Congratulations, you win!");
            }
            else
            {
                Console.WriteLine("Invalid choice. You wander aimlessly and get lost. You lose.");
            }
            Console.WriteLine("Game over! Thanks for playing.");
        }
    }
}