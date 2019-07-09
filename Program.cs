using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            wordsAndDefinitions.Add("Cool", "When I get a job");
            wordsAndDefinitions.Add("Fun", "A lot a food to eat");
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            Console.WriteLine(wordsAndDefinitions["Awesome"]);

            
      foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
      {
        Console.WriteLine($"The definition of {word.Value} word {word.Key}");
      }
           
            

            
            // Console.WriteLine("Hello World!");
        }
    }
}
