using System;
namespace BattleShip
{
    public class PlayerInput
    {

        public int ReadPlayerRowInput()
        {
            Console.WriteLine("Choose a grid row number between 1 and 10");
            var isNumber = int.TryParse(Console.ReadLine(), out int userInput);
            if (isNumber == false)
            {
                Console.WriteLine("INVALID ENTRY!");
                Console.WriteLine("PLEASE ENTER A VALID NUMBER 1-10");
                userInput = Convert.ToInt32(Console.ReadLine());
            }
            if (userInput >= 1 && userInput <= 10)
            {
                return userInput;
            }
                while (userInput < 1 || userInput > 10)
                {
                    Console.WriteLine("INVALID ENTRY!");
                    Console.WriteLine("PLEASE ENTER A VALID NUMBER 1-10");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }

                return userInput;
        }

        public int ReadPlayerColumnInput()
        {
            Console.WriteLine("Choose a grid column number between 1 and 10");
            var isNumber = int.TryParse(Console.ReadLine(), out int userInput);
            if (isNumber == false)
            {
                Console.WriteLine("INVALID ENTRY!");
                Console.WriteLine("PLEASE ENTER A VALID NUMBER 1-10");
                userInput = Convert.ToInt32(Console.ReadLine());
            }
            if (userInput >= 1 && userInput <= 10)
            {
                return userInput;
            }
            while (userInput < 1 || userInput > 10)
            {
                Console.WriteLine("INVALID ENTRY!");
                Console.WriteLine("PLEASE ENTER A VALID NUMBER 1-10");
                userInput = Convert.ToInt32(Console.ReadLine());
            }

            return userInput;
        }
    }
}
