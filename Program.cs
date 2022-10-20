//Harrison Busby
//10/20/2022
//RestaurantPicker

int index = 0;
string playAgain = "yes";
string[] sitdown = {"Denny's", "Black Bear Diner", "BJ's", "Chili's", "Tacos Chapala", "Applebee's", "Olive Garden", "Angelinas", "The Kitchen @ Stonebrier", "Nena's Mexican Cuisine"};
string[] fastFood = {"Raising Canes", "In and Out", "McDonalds", "Popeyes", "WingStop", "Carl's Jr.", "Arbys", "KFC", "Burger King", "Taco Bell"};
string [] Mexican = {"El Comal Taco Truck", "La Picosita", "Don Luis", "La Casita", "Guadalejara", "Los Gordos", "Tacos Chapala", "Tacos El Agua Dulce", "Tacos La Kora", "TACOS LOPEZ"};

while(playAgain == "yes"){

Console.WriteLine("Hi there! What would you like to eat for dinner?");
Console.WriteLine("What would you like? Would you like sitdown, fast food, or Mexican?");

string answer = Console.ReadLine().ToLower();

if(answer == "sitdown"){
    Random R = new Random();
    index = R.Next(0,10);
    Console.WriteLine("I figured out one for you.");
    Console.WriteLine(sitdown[index]);
    }else if(answer == "fastFood"){
    Random rand = new Random();
    index = rand.Next(0,10);
    Console.WriteLine("I figured out one for you");
    Console.WriteLine(fastFood[index]);
}else if(answer == "mexican"){
    Random randm = new Random();
    index = randm.Next(0,10);
    Console.WriteLine("I figured out one for you");
    Console.WriteLine(Mexican[index]);
}else{
Console.WriteLine("Please input a valid response");
}

Console.WriteLine("Would you like to play again. If yes type 'yes', if no type anything to end");
playAgain = Console.ReadLine().ToLower();

if(playAgain == "yes"){
Console.WriteLine("Lets play again.");
}else{
    Console.WriteLine("Go away");
}
}    

    








