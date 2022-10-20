// Amardeep Mann
// 10-20-22
// Mini Challenge #10 - Restaurant Picker
// Randomly pick a restaurant for an indecisive user

string[] mexPlaces = {"Taco Bell", "Chipotle", "Tacos Chapala", "Flakkos Tacos", "Jimboy's Tacos", "Tepa Taqueria", "El Senor Frogs", "Tacos La Palmita", "Taqueria El Grullense", "Casa Flores"};
string[] fastPlaces = {"McDonalds", "Taco Bell", "Burger King", "Carl's Jr", "Wendy's", "Papa John's", "Pizza Hut", "Jack in the Box", "In-n-Out", "Raising Cane's"};
string[] asianPlaces = {"Panda Express", "Pho Island", "Spice It Up!", "Jimmies Place", "Maroo Korean BBQ", "Thai Me Up", "Green Papaya", "ShoMi", "Komachi Sushi", "Jitaro Japanese Food Truck"};

bool playAgain = true;

Console.Clear();
Console.WriteLine("Welcome to restaurant picker! We're going to help you find something to eat.");

while (playAgain) {

  Console.WriteLine("\nWhat kind of food are you in the mood for?\n1 - Mexican Food\n2 - Fast Food\n3 - Asian Food\n4 - Anything!");

  int userNumInt;
  string userNum = Console.ReadLine();
  string[] userPlaces = {};

  while (userNum != "1" && userNum != "2" && userNum != "3" && userNum != "4") {
    Console.WriteLine("Please enter a number between 1 and 4");
    userNum = Console.ReadLine();
  }

  Int32.TryParse(userNum, out userNumInt);

  Random randNum = new Random();


  if (userNumInt == 4) {
    userNumInt = randNum.Next(1,4);
  }

  if (userNumInt == 1) {
    userPlaces = mexPlaces;
  } else if (userNumInt == 2) {
    userPlaces = fastPlaces;
  } else if (userNumInt == 3) {
    userPlaces = asianPlaces;
  }

  Console.WriteLine($"\nYou should try {userPlaces[randNum.Next(0, userPlaces.Length)]}!");

  string userResponse;

  do {
    Console.WriteLine("\nIf that's not doing it for you- do you want to try again? (Type 'y' or 'n')");
    userResponse = Console.ReadLine().ToLower();
  } while (userResponse != "y" && userResponse != "n");

  if (userResponse == "n") {
    playAgain = false;
  }
}

Console.WriteLine("\nGood choice. Bon appetit!");