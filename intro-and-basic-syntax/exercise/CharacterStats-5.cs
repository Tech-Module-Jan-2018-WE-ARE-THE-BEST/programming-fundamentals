//CONFIRMED from svetoslav0
using System;

namespace CharacterStats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            //We receive from the Console the name of the video game character
            string input = Console.ReadLine();
            /*                     
             In the next 4 lines we receive the current health of the character and his maximal health in numbers;
             his current and maximal energy. 
             */
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            /*
             * We are almost ready!
             * We should only print the results.
             * The handlebars {} corespond to the variable that we have to print.
             * You may also want to use "Name: {name}" and it should work fine.
             * */
            Console.WriteLine("Name: {0}", input);
            Console.WriteLine("Health: |{0}{1}|", new string('|', currentHealth), new string('.', maximumHealth - currentHealth));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', currentEnergy), new string('.', maximumEnergy - currentEnergy));
        }
    }
}
