/* int addNums(int num1, int num2) {
  return num1 + num2;
}

void printMax(int num1, int num2) {
    if (num1 > num2) {
        Console.WriteLine("Number 1 is greater");
    }
    else if (num1 < num2) {
        Console.WriteLine("Number 2 is greater");
    }
    else {
        Console.WriteLine("Both numbers are equal");
    }
}

int param1 = 23;
int param2 = 34;

int sum = addNums(param1, param2);
Console.WriteLine("Sum: " + sum);
printMax(param1, param2); */

// -----------------------------------------------------------------------------------------------------------------------------

/* App that takes a name */
void greetingMaker(string inputName) {
  Console.WriteLine ("Hello " + inputName + "! Have a wonderful Day");
}

string newName = "Fern";
greetingMaker(newName);

// -----------------------------------------------------------------------------------------------------------------------------

/* Finding the Average */
/* int num1 = 0;
int num2 = 0;

double averageCalculator(int num1, int num2) {
    double sum = num1 + num2;
    double average = sum / 2;
    return average;
}

Console.WriteLine("Enter a number:");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter another number:");
num2 = int.Parse(Console.ReadLine());

double result = averageCalculator(num1, num2);
Console.WriteLine("The average of " + num1 + " and "
    + num2 + " is " + result); */

// -----------------------------------------------------------------------------------------------------------------------------

/* Number and String Data Types */
/* Console.WriteLine("Enter a Number: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("You entered " + num1);

Console.WriteLine("Enter A Favorite Movie: ");
string? movieName = Console.ReadLine();
Console.WriteLine("Your Favorite Movie is " + movieName); */

// -----------------------------------------------------------------------------------------------------------------------------

/* Try and Catch Statements */
Console.WriteLine("Enter a Number: ");
int num1 = 0;

try {
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("You entered " + num1);
}
catch (Exception) {
    Console.WriteLine("Please enter a valid number next time.");
}