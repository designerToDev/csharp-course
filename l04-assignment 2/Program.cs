/* I've tried everything I could think of to try and get this to execute, but it won't for some reason.
It just keeps returning the number I entered and then defaulting to exiting the application */

int num1 = 0;
int num2 = 0;


// // // Promt ------------------------------------------------------------------------------------------------------------


Console.WriteLine("Enter a number.");
    try {
        num1 = int.Parse(Console.ReadLine());
    }
    catch (Exception) {
        Console.WriteLine("Please enter a valid number.");
        num1 = int.Parse(Console.ReadLine());
    }

Console.WriteLine("Enter another number.");
    try {
        num2 = int.Parse(Console.ReadLine());
    }
    catch (Exception) {
        Console.WriteLine("Please enter a valid number.");
        num2 = int.Parse(Console.ReadLine());
    }


// // // Menu ------------------------------------------------------------------------------------------------------------


Console.WriteLine("Enter Your Option (1-4):\n1. \tAdd\n2. \tMultiply\n3. \tOdd / Even\n4. \tExit");
    try {
        int choice = int.Parse(Console.ReadLine());
        
        switch(choice) {
            case 1:
            addNumbers();
                break;
            case 2:
            multiplyNumbers();
                break;
            case 3:
            oddOrEven();
                break;
            default: 
            Console.WriteLine("Exiting the program.");
                break;
        }
    } catch (Exception) {
        Console.WriteLine("Enter a number between 1-4.");
    }


// // // Adding Numbers ------------------------------------------------------------------------------------------------------------


    void addNumbers() {
        Console.WriteLine($"The sum of your numbers is: {num1 + num2}");
    }


// // // Multiplying Numbers ------------------------------------------------------------------------------------------------------------


    void multiplyNumbers() {
        Console.WriteLine($"{num1} x {num2} = {num1*num2}");
    }


// Odd or Even Numbers ------------------------------------------------------------------------------------------------------------


void oddOrEven () {
     if (num1% 2 == 0) {
        if (num2% 2 == 0){
            Console.WriteLine("Both numbers are even");
        }
     }
     if (num1% 2 == 0) {
        if (num2% 2 == 1){
            Console.WriteLine("The first number is even and the second number is odd");
        }
     }
     if (num1% 2 == 1) {
        if (num2% 2 == 1){
            Console.WriteLine("Both numbers are odd");
        }
     }
     if (num1% 2 == 1) {
        if (num2% 2 == 0){
            Console.WriteLine("The first number is odd and the second number is even");
        }
     }
}


