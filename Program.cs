// Daniel Decoito
// 10-19-2022 
// Challenge 3: "Restraunt Picker"
// 

Console.Clear();
string [] Restaurant = new string []{"La Mesa", "Besitos", "Mezo", "Mi Ranchito", "Mi Cocina", "Irmas","Octavios", "Nena's", "Susy's", "Xochimilco", "Hilda's", "Domo", "Shomi", "Thai Me Up", "SunKing", "New fu Lim", "Tsing Tao", "Peking", "China Palace", "Dynasty Seafood", "Dave Wong's", "George's", "LumberJacks", "Cast Iron Co.", " The Creamery", "Market Tavern", "The Downtowner", "the Black Rabbit", "Squeeze Burger", "ElkHorn", "FED", "Prime Table", "Mannys California Fresh", "Bud's Seafood Grille", "Midgley's Public House"  };
bool terminateGame = true;
Random randomNum = new Random ();
 

while (terminateGame == true)
{
 int mex = randomNum.Next(0,10);
 int asian = randomNum.Next(11,21);
 int american = randomNum.Next(22, 34);
 int allChoice = randomNum.Next(0,34);

Console.WriteLine("Hungry? let me decide some food for you?\n<><><><><><><><><><><><><><> \nPress 1 for all Restaurants\nPress 2 for Mexican\nPress 3 for American\nPress 4 for Asian\nPress \"q\" key and enter to quit\n<><><><><><><><><><><><><><>");

string userInput = Console.ReadLine();
Console.Clear();

switch (userInput)
{
    case "1":
    Console.WriteLine($"You're Restaurant is... \n\n-*-*-*- {Restaurant[allChoice]} -*-*-*-\n");
    break;
    case "2":
    Console.WriteLine($"You're Restaurant is... \n\n-*-*-*- {Restaurant[mex]} -*-*-*-\n");
    break;
    case "3":
    Console.WriteLine($"You're Restaurant is... \n\n-*-*-*- {Restaurant[american]} -*-*-*-\n");
    break;
    case "4":
    Console.WriteLine($"You're Restaurant is... \n\n-*-*-*- {Restaurant[asian]} -*-*-*-\n");
    break;
    case "q":
    terminateGame = false;
    break;
    default:
    Console.WriteLine("\n --------> Incorect Input <---------\n");
    break;
}
}
