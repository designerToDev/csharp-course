// DIFFERENT TYPES OF ARRAYS ----------------------------------------------------------------------------------------


// Declare and Initialize an array with a size of 5, with no initial values
/* int[] array = new int[5];

// Declare and assign elements at the same time
int[] array2 = new int[5] { 1, 2, 3, 4, 5 };

// Initialize with 5 elements, indicating the size of the array
int[] array3 = new int[] { 1, 2, 3, 4, 5 };

// Another way to initialize an array with an implicit size
int[] array4 = { 1, 2, 3, 4, 5 };

// Declare and initialize the array separately
int[] array5;
array5 = new int[] { 1, 2, 3, 4, 5 }; */


// ACCESSING ARRAY ELEMENTS -----------------------------------------------------------------------------------------


// Accesing strings
/* string[] nameList = { "Bob", "Will", "Joye", "Vali" };

Console.WriteLine(nameList[0]);
Console.WriteLine(nameList[3]);

Console.WriteLine(nameList[1]);
nameList[1] = "William";
Console.WriteLine(nameList[1]); */


// VIDEO EXAMPLE -----------------------------------------------------------------------------------------

/* string[] catNames = {"Fluffy", "Wigglesworth", "Stir Fry"};

// Console.WriteLine(catNames[2]);

catNames[0] = "Bandit";

// Console.WriteLine(catNames.Length);

for (int i = 0; i < catNames.Length; i++) {
    Console.WriteLine(catNames[i] + " ");
}

Console.WriteLine("\n\n");

foreach (string item in catNames) {
    Console.WriteLine(item);
}

Console.WriteLine("\n\n");

int indexOfWiggles = Array.IndexOf(catNames, "Wigglesworth");

Console.WriteLine($"Wigglesworth was found at {indexOfWiggles}");

Array.Sort(catNames);

foreach (string item in catNames) {
    Console.WriteLine(item);
} */

// LENGTH PROPERTY -----------------------------------------------------------------------------------------


// string[] myColors = {"red", "green", "yellow", "orange", "blue"};
// Console.WriteLine ("Length of array: " + myColors.Length);


// // TRAVERSING AN ARRAY -----------------------------------------------------------------------------------------


// string[] nameList = { "Bob", "Will", "Joye", "Vali" };

// for (int i = 0; i < nameList.Length; i++) {
//      nameList[i] = nameList[i] + " - Employee";
//      Console.WriteLine(nameList[i]);
// }


// FOREACH LOOP ------------------------------------------------------------------------------------------------
// -------------------------------------------------------------------------------------------------------------


// string[] nameList = { "Bob", "Will", "Joye", "Vali" };

// for (int idx = 0; idx < nameList.Length; idx++) {
    
// }

// foreach (string name in nameList) {
//     Console.WriteLine(name);
// }


// INDEXOF() METHOD ----------------------------------------------------------------------------------------- I don't understand this.......


// string[] nameList = { "Bob", "Will", "Joye", "Vali" };

// int foundIndex = Array.IndexOf(nameList, "Will");
// Console.WriteLine("Found Will at index " + foundIndex);


// int foundIndex = Array.IndexOf(nameList, "Will");

// if (foundIndex != -1) {
//     Console.WriteLine("Found Will at index " + foundIndex);
// } else {
//     Console.WriteLine("Was not able to find Will");
// }


// SORT() METHOD ------------------------------------------------------------------------------------------------


// string[] nameList = { "Bob", "Will", "Joye", "Vali" };

// Array.Sort (nameList);

// foreach (string name in nameList)
// {
//     Console.WriteLine(name);
// }


// MULTIDIMENSIONAL ARRAYS ------------------------------------------------------------------------------------------------
// -------------------------------------------------------------------------------------------------------------


// string[,] dreamData = new string[4,2]{
//     {"Will", "Rocket Scientist"}, 
//     {"Bob", "Chef"},
//     {"Joye", "Astronaut"}, 
//     {"Vali", "Preacher"}
// };

// foreach (string item in dreamData){
//     Console.WriteLine(item);
// }

// for (int row = 0; row < 4; row++)
// {
//     for (int col = 0; col < 2; col++)
//     {
//         Console.Write(dreamData[row,col] + " | ");
//     }
//     Console.WriteLine();
// }


// LISTS -------------------------------------------------------------------------------------------------------
// -------------------------------------------------------------------------------------------------------------


// VIDEO EXAMPLE -----------------------------------------------------------------------------------------------


// List<string> catNames = new List<string>() { "Fluffy" };

// catNames.Add("Sprinkles");
// catNames.Add("Garbage");
// catNames.Add("Lumpy");

// // Console.WriteLine(catNames[2]);
// catNames[2] = "Mr. Ash";
// Console.WriteLine(catNames[2]);


// // LIST LENGTH (COUNT) -----------------------------------------------------------------------------------------------



// for (int i = 0; i < catNames.Count; i++) {
//     Console.Write(catNames[i] + " ");
// }

// foreach (string cat in catNames) {
//     Console.WriteLine(cat);
// }


// // REMOVING FROM ARRAY -----------------------------------------------------------------------------------------------


// catNames.Remove("Lumpy");

// Console.WriteLine("\nAfter remove: ");

// foreach (string cat in catNames) {
//     Console.WriteLine(cat);
// }


// // INSERT INTO AN ARRAY -----------------------------------------------------------------------------------------------

// catNames.Insert(0, "Bandit");


// Console.WriteLine("\nAfter insert: ");

// foreach (string cat in catNames) {
//     Console.WriteLine(cat);
// }


// // LISTS (ADDING TO LIST EXAMPLE) -----------------------------------------------------------------------------------------------


// List<string> nameList = new List<string>();

// nameList.Add("Will");
// nameList.Add("Ivan");
// nameList.Add("Ben");
// nameList.Add("Jan");

// nameList.Add("Blake");

// foreach (string name in nameList) {
//     Console.Write(name + " ");
// }



// ARRAYLISTS -------------------------------------------------------------------------------------------------------
// -------------------------------------------------------------------------------------------------------------


// DECLARING ARRAYLISTS -----------------------------------------------------------------------------------------------

using System.Collections;

var arrList = new ArrayList();
arrList.Add(1);
arrList.Add("Fluffy");
arrList.Add(true);
arrList.Add(3.14);
arrList.Add(null);

// Using explicit casting
Console.WriteLine((string?) arrList[1]);

// Using `var`
var item = arrList[1];
Console.WriteLine(item);

// Finding length
Console.WriteLine("Size of the ArrayList: " + arrList.Count);

// Traversing an ArrayList
for (int i = 0; i < arrList.Count; i++) {
    Console.WriteLine(arrList[i]);
}

foreach (var element in arrList) {
    Console.WriteLine(element);
}