using System;

namespace ElevenFifty
{
    internal class ProgramUI
    {
        ElevenFiftyCafe _CafeRepo = new CafeRepsoitory();
        private readonly int _n1;
        readonly int _n2;
        private int _result;

        internal void Run()
        {
            Console.WriteLine("Welcome to the ElevinFifty Cafe");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("What would you like for lunch today? Please Select a number based on yourfood choice!");
            Console.WriteLine("1. Pizza\n" + "2. Cheeseburger\n" +
                "3. Tacos\n" +
                "4. Pasta\n"); 
         
            string answer = Console.ReadLine();

            int answerAsInt = int.Parse(answer);
            switch (answerAsInt)
            {
                case 1:
                    Console.WriteLine("Please enter the number associated with your first meal choice");
                    string numberOne = Console.ReadLine();
                    int numberOneAsInt = int.Parse(numberOne);


                    Console.WriteLine("Please enter the number associated with your secod meal choice");
                    string numberTwo = Console.ReadLine();
                    int numberTwoAsInt = int.Parse(numberTwo);

                    
                    
                    Console.WriteLine($"Enjoy your Meal!!: {_result}");
                    break;
                
            if (answerAsInt == 1)
            {
                Console.WriteLine("input 1");
            }
            else if (answerAsInt == 2)
            {
                Console.WriteLine("iput 2");
            }
            else if (answerAsInt == 3)
            {
                Console.WriteLine("input 3");
            }
            else if (answerAsInt == 4)
            {
                Console.WriteLine("input 4");
            }
            else if (answerAsInt == 5)
            {
                Console.WriteLine("input 5");
            }
        }
    }
}

    internal class ElevenFiftyCafe
    {
        public static implicit operator ElevenFiftyCafe(CafeRepsoitory v)
        {
            throw new NotImplementedException();
        }
    }

    internal class CafeRepsoitory
    {
        public CafeRepsoitory()
        {
        }
    } }