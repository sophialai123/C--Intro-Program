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
      string name ="Shadow";
      string breed ="Golden Retriever";
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
     Console.WriteLine(myDouble);
    
    // Round myDouble to the nearest whole number
    double myDouble2 = 4.9;
    int myInt2 = (int)myDouble2;
    Console.WriteLine(myInt2);


    // Ask user for fave number, default will be string
      Console.Write("Enter your favorite number: ");
      
    //Convert string intput into an int:
     int faveNumber = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine($"My favorite number is {faveNumber}.");
    

     }
  }
};
 