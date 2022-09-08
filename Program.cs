// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, Sophia!");
// Console.WriteLine("I JUST DID IT");
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Sophia!");

            //Console.WriteLine("How are you today?");
            //take input from user
            //string input = Console.ReadLine();
            //Console.WriteLine($"I am {input} today.");
            // Create Variables
            string name = "Shadow";
            string breed = "Golden Retriever";

            /*  int age=5;
            double weight = 65.22;
            bool spayed = true; */
            // Print variables to the console
            Console.WriteLine($"{name} {breed}");

            // Console.WriteLine(breed);
            // Console.WriteLine(age);
            // Console.WriteLine(weight);
            // Console.WriteLine(spayed);
            //Converting Data Types
            int myInt = 3;

            // Turn it into a decimal
            double myDouble = myInt;
            Console.WriteLine (myDouble);

            // Round myDouble to the nearest whole number
            double myDouble2 = 4.9;
            int myInt2 = (int) myDouble2;
            Console.WriteLine (myInt2);

            // Ask user for fave number, default will be string
            Console.Write("Enter your favorite number: ");

            //Convert string intput into an int:
            int faveNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"My favorite number is {faveNumber}.");

            /* Numerical Data Types: int, decimal,double */
            // Number of pizza shops use int data type
            int pizzaShops = 4332;

            // use decimal data type as floate but end with "m"
            decimal revenue = 390819.28m;

            // Log the values to the console:
            Console.WriteLine (pizzaShops);
            Console.WriteLine (revenue);

            /* Arithmetic Operators */
            // Your Age
            int userAge = 19;

            // Length of years on Jupiter (in Earth years)
            double jupiterYears = 11.86;

            // Age on Jupiter
            double jupiterAge = userAge / jupiterYears;
            Console.WriteLine (jupiterAge);

            // Time to Jupiter
            double journeyToJupiter = 6.142466;

            // New Age on Earth
            double newEarthAge = userAge + journeyToJupiter;

            // New Age on Jupiter
            double newJupiterAge = newEarthAge / jupiterYears;

            // Log calculations to console
            Console.WriteLine (newEarthAge);
            Console.WriteLine (newJupiterAge);

            /* Modulo */
            // Number of students
            int students = 18;

            // Number of students in a group
            int groupSize = 3;

            // Does groupSize go evenly into students?
            Console.WriteLine(students % groupSize);

            /* Built-In Methods */
            // Starting variables
            int numberOne = 12932;
            int numberTwo = -2828472;

            // ind the square root of numberOne and
            //round the answer down so it doesn’t have a decimal.
            double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));

            // The built-in method Math.Sqrt() can only take a positive number
            //as a value, but the value of numberTwo is negative.
            //Math.Floor(Math.Sqrt(Math.Abs(number)));
            double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

            // Print the lowest number
            Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt));

            // Raise numberOne to the numberTwo power (2*2*2)
            Console.WriteLine(Math.Pow(2, 3));

            // Round number up
            Console.WriteLine(Math.Ceiling(2.4));

            // Find the larger number between two numbers
            Console.WriteLine(Math.Max(12, 34));

            // First string variable
            string firstSentence =
                "It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife.";

            // Second string variable
            string firstSpeech =
                "\"My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\"";

            // Print variable and newline
            Console.WriteLine (firstSentence);
            Console.WriteLine("\n");
            Console.WriteLine (firstSpeech);

            // Declare the variables
            string beginning = "Once upon a time,";
            string middle = "The kid climbed a tree";
            string end = "Everyone lived happily ever after.";

            // Interpolate the string and the variables
            string story = $"{beginning} {middle} {end}";

            // Print the story to the console
            Console.WriteLine (story);

            // Create password
            string password = "a92301j2add";

            // Get password length
            int passwordLength = password.Length;

            // Check if password uses symbol
            int passwordCheck = password.IndexOf("!");

            // If IndexOf()doesn’t exist in the string the method will return a -1
            Console.WriteLine($"The user password is {password}.");
            Console.WriteLine($"Its length is {passwordLength}");
            Console.WriteLine($" receives a {passwordCheck} check");

            // Get Parts of Strings
            string startStrand = "ATGCGATGAGCTTAC";

            // find location of "tga"
            int tga = startStrand.IndexOf("TGA");

            // start point and stop point variables
            int startPoint = 0;
            int length = tga + 3;

            // .Substring() grabs part of a string using
            //the specified character position, continues until the end of the string,
            string dna = startStrand.Substring(startPoint, length);
            Console.WriteLine (dna);

            // DNA mutation search
            Console.WriteLine(dna[3]);

            // Script line
            string script =
                "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";

            // Get camera directions
            int charPosition = script.IndexOf("Close");
            int length2 = "Close on".Length;
            string cameraDirections = script.Substring(charPosition, length2);

            // Get scene description
            charPosition = script.IndexOf("a portrait");
            string sceneDescription = script.Substring(charPosition);

            // Make camera directions uppercase
            cameraDirections = cameraDirections.ToUpper();

            // Make scene description lowercase
            sceneDescription = sceneDescription.ToLower();

            // Print results
            Console.WriteLine(cameraDirections + sceneDescription);
        }
    }
}
