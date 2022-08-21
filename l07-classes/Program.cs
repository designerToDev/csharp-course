// VIDEO EXAMPLE ---------------------------------------------------------------------------------------------------------


// User thomas = new User();

// thomas.setFirstName("Thomas");
// thomas.setLastName("the Tank Engine");
// thomas.setEmail("thomas@thetrain.com");


// Console.WriteLine(thomas.getFirstName() + " " + thomas.getLasttName());


// CREAING A CLASS ---------------------------------------------------------------------------------------------------------

// GETTER AND SETTER VERSION --------------------------------------------


// richard.setStudentID(11);
// richard.setStudentName("Richard Prince");

// Console.WriteLine(richard.getStudentName() + " has the student ID: " + richard.getStudentID());


// ----------------------------------------------------------------------


// richard.StudentID = 11;
// richard.Name = "Richard Prince";

// Console.WriteLine(richard.Name + " has the student ID: " + richard.StudentID);

Student richard = new Student(11, "Richard Prince");

Console.WriteLine(richard.Name + " has the student ID: "
    + richard.StudentID);