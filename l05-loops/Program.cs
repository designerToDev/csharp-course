// void displayChoices(){
//     Console.WriteLine("MENU");
//     Console.WriteLine("----");
//     Console.WriteLine("1. Double Input");
//     Console.WriteLine("2. Quadruple Input");
//     Console.WriteLine("3. Exit");
// }

// bool continueProgram = true;
// int number;

// while (continueProgram) {
//     displayChoices();
//     Console.WriteLine("Enter Your Choice: ");

//     int choice = int.Parse(Console.ReadLine());
//     switch (choice) {
//         case 1:
//             Console.WriteLine("Enter Input Number: ");
//             number = int.Parse(Console.ReadLine());
//             Console.WriteLine("Double: " + 2 * number);
//             break;
//         case 2:
//             Console.WriteLine("Enter Input Number: ");
//             number = int.Parse(Console.ReadLine());
//             Console.WriteLine("Quadruple: " + 4 * number);
//             break;
//         default:
//             Console.WriteLine("Quitting....");
//             continueProgram = false;
//             break;
//     }
// }


// Where is this function called? ---------------------------------------------


static int readValidInput() {
    int number = 0;
    bool valid = false;
    Console.WriteLine("Enter a number: ");

    while (!valid) {
        valid = int.TryParse(Console.ReadLine(), out number);
        if (!valid) {
            Console.WriteLine("Enter a valid number: ");
        }
    }

    return number;
}

int num1 = readValidInput();
int num2 = readValidInput(); // Can you call a function and save the result to a variable at the same time?
// Console.WriteLine(); Why does this have to be here??

for (int i = 1; i <= num1; i++) {
    for (int j = 1; j <= i; j++) {
        Console.Write("* ");
    }
    Console.WriteLine();
}

// TRY THIS: num1 = 1, num2 = 10 AND num1 = 10, num2 = 1