// Console.WriteLine("";

// int num = "string";

// if ()
// {
//     Console.WriteLine("This is a Test");
// }

// HANDLING ARRAY -------------------------------------------


// int[] arr = { 1,2,3,4,5,6 };


// TRY CATCH TO DEAL WITH EXCEPTION -----------------------------------


// try
// {
//     Console.WriteLine(arr[9]);
// }
// catch (IndexOutOfRangeException) {
//     Console.WriteLine("Index is out of bounds");
// }


// IF STATEMENT TO HANDLE INVALID INDEX -----------------------------------


// if (arr.Length > 9) {
//     Console.WriteLine(arr[9]);
// }


// RUNTIME ERROR DIVIDING BY ZERO TRY CATCH -----------------------------------------


// int num = 20;
// int num2 = 0;

// try
// {
//     int num3 = num / num2;
// } catch (DivideByZeroException){
//     Console.WriteLine("Do not divide by zero");
// }


// IF STATEMENT DIVIDE BY ZERO HANDLING ------------------------------


int num = 20;
int num2 = 0;

if (num2 != 0) {
    int num3 = num / num2;
}
else {
    Console.WriteLine("You cannot divide by zero");
}


// NULL REFERENCE EXCEPTION ------------------------------------------


String test;
test.Contains("xyz");

/* Explained: If this were valid code on its own, attempting to call a method on test, a null variable,
would cause a Null Reference Exception. These types of errors are more common in larger programs, especially
in server applications that receive input from external sources.*/

