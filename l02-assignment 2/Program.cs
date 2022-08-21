// Variables
int num1 = 0;
int num2 = 0;
int sum = num1 + num2;
string? myString = "";
string sentence = "Lorem ipsum is placeholder text commonly used in the graphic, print, and publishing industries for previewing layouts and visual mockups.";



Console.WriteLine("Enter a number:");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter another number:");
num2 = int.Parse(Console.ReadLine());
sum = num1 + num2;

Console.Write("The sum of your two numbers is:" + sum);



/* This section is done */
// Print a random word and uppercase
Console.WriteLine("Enter your favorite word:");
myString = Console.ReadLine();
Console.WriteLine("Your favorite word is: " + myString.ToUpper());

// // Sentence Contains
Console.WriteLine("Does the sentence contain \"to\"? " + sentence.Contains("to"));

// // Sentence Length
Console.WriteLine("The length of the sentence is: " + sentence.Length);



