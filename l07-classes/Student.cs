// CREAING A CLASS ---------------------------------------------------------------------------------------------------------


class Student{
    private int studentID;
    private string? name;

    // Default Constructor
    public Student(){
        studentID = 0;
        name = "";
    }

    // Overloaded Parameterized Constructor
    public Student(int id, string sName){
        studentID = id;
        name  = sName;
    }

    public int StudentID{
        get { return studentID; }
        set { studentID = value; }
    }

    public string? Name {
        get { return name; }
        set { name = value; }
    }
}




// THESE DON'T NEED TO BE HERE ANYMORE BECAUSE OF THE ACCESSORS! --------------------

    // Student ID Getter and Setter
    // public int getStudentID() {
    //     return studentID;
    // }

    // public void setStudentID(int id) {
    //     studentID = id;
    // }
     
    // // Student Name Getter and Setter
    // public string? getStudentName() {
    //     return name;
    // }
    // public void setStudentName(string? studentName) {
    //     name = studentName;
    // }

    // -----------------------------------------------------------------------------------

