using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("What would you like to Tweet?");
    string tweet = Console.ReadLine();

    if (tweet.Length <= 140) {
      Console.WriteLine(tweet);
      }
    else if (tweet.Length >= 140) {
      Console.WriteLine("Your tweet is too long.");
    }
  
    
  }
}