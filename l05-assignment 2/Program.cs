
// // // Global Variables -------------------------------------------------------------------------------------------------
int num1 = 0;
int num2 = 0;


// // // Adding Numbers ------------------------------------------------------------------------------------------------------------


void addNumbers(int addNum1, int addNum2)
{
    Console.WriteLine($"The sum of your numbers is: {addNum1 + addNum2}");
}


// // // Multiplying Numbers ------------------------------------------------------------------------------------------------------------


void multiplyNumbers(int multiNum1, int multiNum2)
{
    Console.WriteLine($"{multiNum1} x {multiNum2} = {multiNum1 * multiNum2}");
}


// // // Odd or Even Numbers ------------------------------------------------------------------------------------------------------------


void oddOrEven(int orNum1, int orNum2)
{
    if (orNum1 % 2 == 0)
    {
        if (orNum2 % 2 == 0)
        {
            Console.WriteLine("Both numbers are even");
        }
    }
    if (orNum1 % 2 == 0)
    {
        if (orNum2 % 2 == 1)
        {
            Console.WriteLine("The first number is even and the second number is odd");
        }
    }
    if (orNum1 % 2 == 1)
    {
        if (orNum2 % 2 == 1)
        {
            Console.WriteLine("Both numbers are odd");
        }
    }
    if (orNum1 % 2 == 1)
    {
        if (orNum2 % 2 == 0)
        {
            Console.WriteLine("The first number is odd and the second number is even");
        }
    }
}


// // // Display Range ------------------------------------------------------------------------------------------------------------


void displayRange(int rangeNum1, int rangeNum2)
{
    if (rangeNum1 > rangeNum2) {
        for (int i = rangeNum2; i <= rangeNum1; i++ ) {
            Console.WriteLine(i);
        }
    }
    if (rangeNum2 > rangeNum1) {
        for (int i = rangeNum1; i <= rangeNum2; i++ ) {
            Console.WriteLine(i);
        }
    }
}


// // // Menu -------------------------------------------------------------------------------------------------------------------


try
{

    Console.WriteLine("Enter a number.");
    num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter another number.");
    num2 = int.Parse(Console.ReadLine());

    int choice = 0;

    while (choice != 5)
    {
        Console.WriteLine("Enter Your Option (1-4):\n1. \tAdd\n2. \tMultiply\n3. \tOdd / Even\n4. \tDisplay Range\n5. \tExit");

        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                addNumbers(num1, num2);
                break;
            case 2:
                multiplyNumbers(num1, num2);
                break;
            case 3:
                oddOrEven(num1, num2);
                break;
            case 4:
                displayRange(num1, num2);
                break;
            default:
                Console.WriteLine("Exiting the program.");
                break;
        }
    }
}
catch (Exception)
{
    Console.WriteLine("Enter a number between 1-4.");

}

