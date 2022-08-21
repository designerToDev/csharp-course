// READ A FILE --------------------------------------------------------------------------------------------------------------------------------------


// string text = File.ReadAllText("textfile.txt");
// Console.WriteLine(text);


// ANOTHER WAY TO READ A FILE (GOOD FOR TABLES BC IT MAKES AN AN ARRAY) ------------------------------------------------------------------------------


// string[] text = File.ReadAllLines("textfile.txt");

// foreach (string t in text)
// {
//     Console.WriteLine(t);
// }


// WRITING FILES -------------------------------------------------------------------------------------------------------------------
// WRITE TO A FILE WITH WRITEALLLINES ----------------------------

// string[] names = { 
//     "Kadria",
//     "Johnny",
//     "Sarah", 
//     "Josh"
// };

// Naming convention either ads to a file or creates the "newfile.txt" and the second input is the array name
// File.WriteAllLines("newfile.txt", names);



// WRITE TO A FILE WITH WRITEALLTEXT ----------------------------



// string[] names = { 
//     "Kadria",
//     "Johnny",
//     "Sarah", 
//     "Josh"
// };

// File.WriteAllLines("newfile.txt", names);

// string newString = "I am a terrific programmer!";

// // for WriteAllText, the second paramter that it takes HAS to be a string
// File.WriteAllText("newtext.txt", newString);



// WRITE TO A FILE WITH STREAMWRITER ----------------------------


// string[] names = { 
//     "Kadria",
//     "Johnny",
//     "Sarah", 
//     "Josh"
// };

// using (StreamWriter file = new StreamWriter("myNewFile.txt", true)){
//     foreach(string name in names){
//         file.WriteLine(name);
//     }
// }


// DATE/TIME CLASSES -------------------------------------------------------------------------------------------------------------------



// Initialize a specific date as a DateTime variable
DateTime date1 = new DateTime(2020, 7, 15, 18, 30, 45);

// Output 07 15 20 18:30:45
Console.WriteLine(date1.ToString("MM dd yy HH:mm:ss"));

// Outputs Wednesday July, 2020 06:30:45 PM
Console.WriteLine(date1.ToString("dddd MMMM, yyyy hh:mm:ss tt"));

// Outputs 07/15/2020
Console.WriteLine(date1.ToString("MM/dd/yyyy"));

// Outputs 06:30:45 PM
Console.WriteLine(date1.ToString("hh:mm:ss tt"));

