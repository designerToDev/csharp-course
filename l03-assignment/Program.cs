/* Should there be some kind of loop in here that helps make sure that they can't just not enter a non int over and over?
I know we haven't learned anything like that yet, but I feel like it makes sense */
int age = 0;

Console.Write("What is your name?");
string newName = Console.ReadLine();

Console.Write("How old are you?");

try {
    age = int.Parse(Console.ReadLine());
}

catch (Exception) {
    Console.WriteLine("Please enter a valid number.");
    age = int.Parse(Console.ReadLine());
}

void readUserInput(string input) {
  Console.WriteLine ($"Hello {newName}, I can't believe you are {age} years old!");
}

readUserInput("");
