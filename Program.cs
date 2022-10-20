//Harrison Busby
//10/20/2022
//RestaurantPicker
//Peer Reviewed By: Kenneth Fujimura -- Project works for the most part and there's an eligance to how simple your program is. But there's a few bugs worth mentioning:
//- When you ask for cateogry inputs, the way you have things set up asks for very specific string inputs that could potentially confuse users. So at the very least, I would include instructions in your code to very clearly instruct the user what to type. So I would include quotes (e.g. "fast food") around the words you're asking the user to type. Because if they type something different but don't get it exactly right it could lead to confusion.
//- The else if check for the fast food category on line 23 checks for "fastFood" but your input string forces all inputs to be lowercase. So there's no way to actually call the fast food category. I would probably change this check to "fast food" because you present "fast food" as an option in the program dialog with the user.
//- On Line 24, you've got that line indented which I assume is on accident. It doesn't affect how your program runs, and it's not the biggest thing, but it triggers my OCD lol.
//Fix those things and I think you've got a pretty solid program.

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

    








