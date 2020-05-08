using System;
namespace BattleShip
{
    public class PlayerInput
    {

        public int ReadPlayerRowInput()
        {
           Console.WriteLine("Choose a grid row number between 1 and 10");
           var userInput = Convert.ToInt32(Console.ReadLine());
            while (userInput != 1 - 10)
            {
                Console.WriteLine("INVALID ENTRY!");
                Console.WriteLine("PLEASE ENTER A VALID NUMBER 1-10");
            }
           return Convert.ToInt32(Console.ReadLine());
        }

        public int ReadPlayerColumnInput()
        {
            Console.WriteLine("Choose a grid column number between 1 and 10");
            var userInput = Convert.ToInt32(Console.ReadLine());
            while (userInput != 1 - 10)
            {
                Console.WriteLine("INVALID ENTRY!");
                Console.WriteLine("PLEASE ENTER A VALID NUMBER 1-10");
            }
            return Convert.ToInt32(Console.ReadLine());
        } 
    }
}
