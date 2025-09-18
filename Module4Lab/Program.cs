using System;
namespace Module4Lab
{
    class Program
    {
        // Main method - entry point to your app
        static void Main(string[] args)
        {
            //Output greeting
            Console.WriteLine("🦁 Welcome to Como Park Zoo! 🐘");
            Console.WriteLine("=================================");
            // First, let's see a simple array example
            Console.WriteLine("Here are some animals we already have: ");
            string[] sampleAnimals = { "Sea Lion", "Giraffe", "Lemur", "Polar Bear" };
            // Use a for loop to iterate (walk through) the elements of the array
            // ++ operator that increments the value of a variable by one
            // i++ that is the same as i = i + 1
            for (int i = 0; i < sampleAnimals.Length; i++)
            {
                // Print the name of the current animal in the array
                Console.WriteLine($"- {sampleAnimals[i]}");
            } //end for loop
            Console.WriteLine("\nNow let's add your animals to the Como Zoo!\n");
            // Use a while loop to get valid input
            Console.Write("How many animals do you want to add?");
            // Holds the number of animals
            int numberOfAnimals;
            // Use a while loop when you aren't sure how many times the loop needs to run
            while (!int.TryParse(Console.ReadLine(), out numberOfAnimals) || numberOfAnimals <= 0)
            {
                Console.Write("Please enter a number greater than o: ");
            } //end while loop
            // Create an array to store the animals and make it's size equal to 
            //the number of animals the user wanted to add to the zoo
            string[] animals = new string[numberOfAnimals];
             // Use a for loop to collect animal names
            for (int i = 0; i < numberOfAnimals; i++)
            {
                Console.Write($"Enter animal #{i + 1}: ");
                animals[i] = Console.ReadLine();
            } //end for loop
            // Display the animals using another for loop
            Console.WriteLine("\nYour new Como Zoo animals: ");
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {animals[i]}");
            } //end for loop
            // Output a closing message
            Console.WriteLine($"\nYou added {animals.Length} animals in to Como Zoo!");
        } // end main method
    } // end class
} // end namespace