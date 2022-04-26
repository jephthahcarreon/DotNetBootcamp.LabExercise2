// submitted by: Jephthah B. Carreon

using System;

namespace CSharp.LabExercise2
{
    // CSharp Lab Exercise 2 Activity 1
    class UserInputValidator
    {
        // validates user input for invalid format and out of range values
        public float ValidateUserInput()
        {
            while (true)
            {
                Console.Write("Enter number: ");
                string userStringInput = Console.ReadLine();

                try
                {
                    float userNumberInput = (float)Math.Round(Convert.ToSingle(userStringInput), 2);
                    if (userNumberInput >= 10 && userNumberInput <= 100)
                    {
                        return userNumberInput;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 10 and 100.");
                        continue;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }
            }
        }
    }

    class ArrayServices
    {
        // writes validated elements of array for every iteration inside Class NumbersArray
        public void WriteArrayElements(float[] inputNumberArray, float userNumberInput)
        {
            foreach (float inputNumber in inputNumberArray)
            {
                if (inputNumber != 0)
                    Console.Write(inputNumber + " ");
            }
            Console.WriteLine("");
        }
    }

    class NumbersArray
    {
        public void DisplayArray()
        {
            int arraySize = 5;
            float[] inputNumberArray = new float[arraySize];
            int i = 0;

            while (i < arraySize)
            {
                UserInputValidator userInputValidator = new UserInputValidator();
                float userNumberInput = userInputValidator.ValidateUserInput();

                // validates user input for existing elements inside the array
                if (Array.Exists(inputNumberArray, element => element.Equals(userNumberInput)) == false)
                {
                    inputNumberArray[i] = userNumberInput;
                    i++;
                }
                else
                {
                    Console.WriteLine("{0} has already been entered", userNumberInput);
                    continue;
                }

                ArrayServices arrayServices = new ArrayServices();
                arrayServices.WriteArrayElements(inputNumberArray, userNumberInput);
            }
        }
    }

    class ArrayApplication
    {
        public void RunArrayApplication()
        {
            NumbersArray numbersArray = new NumbersArray();
            numbersArray.DisplayArray();

            Console.WriteLine("Press any key to close this application . . .");
            Console.ReadLine();
            Console.Clear();
        }
    }

    // CSharp Lab Exercise 2 Activity 2
    class LasagnaDisplayOptions
    {
        // display all application options available to the user
        public void DisplayLasagnaAppOptions()
        {
            Console.WriteLine("Welcome to the Lasagna Cooking Guide\n");
            Console.WriteLine("1. Expected minutes in oven.");
            Console.WriteLine("2. Remaining minutes in oven.");
            Console.WriteLine("3. Preparation time in minutes.");
            Console.WriteLine("4. Elapse time in minutes.");
        }
    }

    class LasagnaInputValidator
    {
        public int ValidateMinutesElapseInOven()
        {
            // gets user input for minutes elapse inside oven
            int minutesInOven;
            while (true)
            {
                Console.Write("\n\tEnter minutes elapse inside oven: ");
                string minutesInOvenString = Console.ReadLine();

                try
                {
                    minutesInOven = Convert.ToInt32(minutesInOvenString);
                    if (minutesInOven >= 0 && minutesInOven <= 40)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\tInvalid input. Please enter a number between 0 and 40.");
                        continue;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\tInvalid input. Please enter a number.");
                    continue;
                }
            }
            return minutesInOven;
        }

        public int ValidateLayersOfLasagna()
        {
            // gets user input for number of layers in lasagna
            int layersOfLasagna;
            while (true)
            {
                Console.Write("\n\tEnter number of layers of lasagna: ");
                string layersOfLasagnaString = Console.ReadLine();

                try
                {
                    layersOfLasagna = Convert.ToInt32(layersOfLasagnaString);
                    if (layersOfLasagna > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\tInvalid input. Please enter a number greater than zero.");
                        continue;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\tInvalid input. Please enter a number.");
                    continue;
                }
            }
            return layersOfLasagna;
        }

        public int ValidateLasagnaAppOptionsInput()
        {
            // gets user input for choice of options in lasagna application
            int userChoiceAsInt;
            while (true)
            {
                Console.Write("\nPlease enter your choice: ");
                string userChoiceAsString = Console.ReadLine();

                try
                {
                    userChoiceAsInt = Convert.ToInt32(userChoiceAsString);
                    if (userChoiceAsInt >= 1 && userChoiceAsInt <= 4)
                    {
                        return userChoiceAsInt;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                        continue;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }
            }
        }
    }

    class LasagnaDisplay
    {
        public void ResultsDisplay(int optionSelected, int minutes)
        {
            switch (optionSelected)
            {
                // Expected minutes in oven
                case 1:
                    Console.WriteLine("\n\tExpected oven time: {0} minutes\n", minutes);
                    break;
                // Remaining minutes in oven
                case 2:
                    Console.WriteLine("\n\tRemaining minutes in oven: {0} minutes\n", minutes);
                    break;
                // Preparation time in minutes
                case 3:
                    Console.WriteLine("\n\tPreparation time: {0} minutes\n", minutes);
                    break;
                // Elapse time in minutes
                case 4:
                    Console.WriteLine("\n\tElapse time: {0} minutes\n", minutes);
                    break;
            }
        }
    }

    class Lasagna
    {
        public int ExpectedMinutesInOven()
        {
            // According to the cooking book, the expected oven time in minutes is 40
            int cookingTimeInOven = 40;
            return cookingTimeInOven;
        }

        public int RemainingMinutesInOven(int minutesInOven)
        {
            int remainingMinutesInOven = ExpectedMinutesInOven() - minutesInOven;
            return remainingMinutesInOven;
            
        }

        public int PreparationTimeInMinutes(int layersOfLasagna)
        {
            // According to the cooking book, the expected preparation time per layer in minutes is 2
            int preparationPerLayer = 2; 
            int preparationTimeInMinutes = preparationPerLayer * layersOfLasagna;
            return preparationTimeInMinutes;
        }

        public int ElapseTimeInMinutes(int minutesInOven, int layersOfLasagna)
        {
            int elapseTimeInMinutes = PreparationTimeInMinutes(layersOfLasagna) + minutesInOven;
            return elapseTimeInMinutes;
        }
    }

    class LasagnaCookingGuide
    {
        public void RunLasagnaCookingGuide()
        {
            Console.WriteLine("Welcome to the Lasagna Cooking Guide\n");
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadLine();

            Lasagna lasagna = new Lasagna();
            LasagnaDisplay lasagnaDisplay = new LasagnaDisplay();
            LasagnaInputValidator lasagnaInputValidator = new LasagnaInputValidator();
            LasagnaDisplayOptions lasagnaAppOptions = new LasagnaDisplayOptions();

            while (true)
            {
                Console.Clear();
                lasagnaAppOptions.DisplayLasagnaAppOptions();

                int userChoiceAsInt = lasagnaInputValidator.ValidateLasagnaAppOptionsInput();
                switch (userChoiceAsInt)
                {
                    // Expected minutes in oven
                    case 1:
                        lasagnaDisplay.ResultsDisplay(1, lasagna.ExpectedMinutesInOven());
                        break;
                    // Remaining minutes in oven
                    case 2:
                        int minutesInOven = lasagnaInputValidator.ValidateMinutesElapseInOven();
                        lasagnaDisplay.ResultsDisplay(2, lasagna.RemainingMinutesInOven(minutesInOven));
                        break;
                    // Preparation time in minutes
                    case 3:
                        int layersOfLasagna = lasagnaInputValidator.ValidateLayersOfLasagna();
                        lasagnaDisplay.ResultsDisplay(3, lasagna.PreparationTimeInMinutes(layersOfLasagna));
                        break;
                    // Elapse time in minutes
                    case 4:
                        int _layersOfLasagna = lasagnaInputValidator.ValidateLayersOfLasagna();
                        int _minutesInOven = lasagnaInputValidator.ValidateMinutesElapseInOven();
                        lasagnaDisplay.ResultsDisplay(4, lasagna.ElapseTimeInMinutes(_minutesInOven, _layersOfLasagna));
                        break;
                }

                while (true)
                {
                    //prompts user to exit or continue
                    Console.Write("Continue? (y/n): ");
                    string userChoiceInput = Console.ReadLine();
                    Console.WriteLine("");

                    //catch errors from invalid input
                    try
                    {
                        char userChoiceInputChar = char.ToLower(Convert.ToChar(userChoiceInput));

                        switch (userChoiceInputChar)
                        {
                            case 'y':
                                break;
                            case 'n':
                                goto ExitApp;
                            default:
                                Console.WriteLine("Invalid input.");
                                continue;
                        }
                        break;
                    }

                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input.");
                        continue;
                    }
                }
            }
            
            ExitApp:
            Console.WriteLine("Press any key to close this application . . .");
            Console.ReadLine();
            Console.Clear();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // CSharp Lab Exercise 2 Activity 1
            ArrayApplication arrayApplication = new ArrayApplication();
            arrayApplication.RunArrayApplication();

            // CSharp Lab Exercise 2 Activity 2
            LasagnaCookingGuide lasagnaCookingGuide = new LasagnaCookingGuide();
            lasagnaCookingGuide.RunLasagnaCookingGuide();
        }
    }
}






