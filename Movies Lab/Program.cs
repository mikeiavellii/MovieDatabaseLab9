using Movies_Lab;
using Validation;

List<Movie> Films = new List<Movie>()
{
  new Movie("Star Wars", "Scifi"),
  new Movie("2001: A Space Odyssey", "Scifi"),
  new Movie("A Clockwork Orange", "Scifi"),
  new Movie("Close Encounters of the Third Kind", "Scifi"),

  new Movie("WALL·E", "Animated"),
  new Movie("Inside Out", "Animated"),
  new Movie("Zootopia", "Animated"),
  new Movie("Soul", "Animated"),
  new Movie("Spirited Away", "Animated"),
  new Movie("Turning Red", "Animated"),
  new Movie("Coco", "Animated"),
  new Movie("Toy Story 4", "Animated"),
  new Movie("Up", "Animated"),
  new Movie("Toy Story 3", "Animated"),
  new Movie("Toy Story 2", "Animated"),
  new Movie("Toy Story 1", "Animated"),

  new Movie("Boyhood", "Drama"),
  new Movie("The Last of the Mohicans", "Drama"),
  new Movie("Dances with Wolves", "Drama"),
  new Movie("Into the Wild", "Drama"),
  new Movie("Dead Poets Society", "Drama"),
  new Movie("Casablanca", "Drama"),
  new Movie("Citizen Kane", "Drama"),
  new Movie("Schindler's List", "Drama"),
  new Movie("On the Waterfront", "Drama"),
  new Movie("Paris, Texas", "Drama"),

  new Movie("Train to Busan", "Horror"),
  new Movie("Let the Right One In", "Horror"),
  new Movie("28 Days Later", "Horror"),
  new Movie("The Wailing", "Horror"),
  new Movie("The Conjuring", "Horror")
};

Console.WriteLine("Welcome to the Movie List Application!\n");
Console.WriteLine($"There are {Films.Count()} movies in this list.");
bool runProgram = true;

while (runProgram)
{
  while (runProgram)
  {
    Console.WriteLine("What category are you interested in?" +
    "\nAnimated\nDrama\nHorror\nScifi");
    string reply = Validator.GetNormalCasing("");
    if (reply == "Scifi")
    {
      Console.Clear();
      Console.WriteLine($"Here are all the movies in the {reply} category:");
      foreach (Movie m in Films.Where(m => m.Category == reply))
      {
        Console.WriteLine(m.GetTitles());
      }
      Console.WriteLine();
      break;
    }
    else if (reply == "Drama")
    {
      Console.Clear();
      Console.WriteLine($"Here are all the movies in the {reply} category:");
      foreach (Movie m in Films.Where(m => m.Category == reply))
      {
        Console.WriteLine(m.GetTitles());
      }
      Console.WriteLine();
      break;
    }
    else if (reply == "Horror")
    {
      Console.Clear();
      Console.WriteLine($"Here are all the movies in the {reply} category:");
      foreach (Movie m in Films.Where(m => m.Category == reply))
      {
        Console.WriteLine(m.GetTitles());
      }
      Console.WriteLine();
      break;
    }
    else if (reply == "Animated")
    {
      Console.Clear();
      Console.WriteLine($"Here are all the movies in the {reply} category:");
      foreach (Movie m in Films.Where(m => m.Category == reply))
      {
        Console.WriteLine(m.GetTitles());
      }
      Console.WriteLine();
      break;
    }
    else
    {
      Console.WriteLine("Invalid selection. Try again.");
    }
  }
    

  runProgram = Validator.GetContinue("Would you like to see movies in different category?", "y", "n");
}