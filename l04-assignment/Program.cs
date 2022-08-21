/* I've tried everything I could think of to try and get this to execute, but it won't for some reason.
It just keeps returning the number I entered and then defaulting to exiting the application */


int getNum() {
    bool done = false;
    int num = 0;
    while(!done) {
        Console.WriteLine("Enter a number.");
        try {
            num = int.Parse(Console.ReadLine());
            done = true;
        }
        catch (Exception) {
            Console.WriteLine("Please enter a valid number.");
        }
    }
    return num;
}


// // // Menu ------------------------------------------------------------------------------------------------------------


int getMenuChoice() {
    bool done = false;
    int num = 0;
    while(!done) {
        Console.WriteLine("Enter Your Option (1-4):\n1. \tAdd\n2. \tMultiply\n3. \tOdd / Even\n4. \tExit");
        try {
            num = int.Parse(Console.ReadLine());
            if (num < 1 || num > 4) {
                Console.WriteLine("Please select a valid input.");
            }
            else {
                done = true;
            }
        }
        catch (Exception) {
            Console.WriteLine("Please enter a valid number.");
        }
    }            
 return num;
 }


// // // Adding Numbers ------------------------------------------------------------------------------------------------------------


    int addNumbers(int x, int y) {
        return x + y;
    }


// // // Multiplying Numbers ------------------------------------------------------------------------------------------------------------


    int multiplyNumbers(int x, int y) {
        return x*y;
    }


// Odd or Even Numbers ------------------------------------------------------------------------------------------------------------


void oddOrEven(int num1, int num2) {
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


// Run the Program ------------------------------------------------------------------------------------------------------------


void run() {
    Console.WriteLine("Program Running");
    int num1 = getNum();
    int num2 = getNum();
    int choice = getMenuChoice();
    int result = 0;
                switch(choice) {
                case 1:
                result = addNumbers(num1,num2);
                Console.WriteLine($"The sume of your numbers is {result}.");
                    break;
                case 2:
                result = multiplyNumbers(num1, num2);
                Console.WriteLine($"The product of your numbers is {result}.");
                    break;
                case 3:
                oddOrEven(num1, num2);
                    break;
                default: 
                Console.WriteLine("Exiting the program.");
                    break;
            }
}

run();