public class Employee
{
    public string firstName;
    public string lastName;
    public int employeeId;
    public string title;
    public string startDate;



    public Employee() 
    {
        firstName = "";
        lastName = "";
        employeeId = 0;
        title = "";
        startDate = "";

    }

    public Employee(string first, string last, int numId, string employeeTitle)
    {
        firstName = first;
        lastName = last;
        employeeId = numId;
        title = employeeTitle;
        startDate = DateTime.Now.ToShortDateString();
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    // Figure out how to assign random number ----------------
    // public int employeeTitle {
    //     get { return phoneNumber;}
    //     set { phoneNumber = value;}
    // }

    public int EmployeeId
    {
        get { return employeeId;}
        set { employeeId = value;}
    }

    public string EmployeeTitle
    {
        get { return title;}
        set { title = value;}
    }

    public string Start
    {
        get { return startDate;}
        set { startDate = value;}
    }

    // I'll need this but not sure the exact layout yet EDIT THIS --------------------
    public void printDetails()
    {
        Console.WriteLine(firstName + " " + lastName + ", " + title);
        Console.WriteLine("\n\tEmployee ID: " + employeeId);
        Console.WriteLine("\n\tStart Date: " + startDate);
        Console.WriteLine("\n");
    }



      public override string ToString()
    {
        
        return $"{firstName}, {lastName}, {employeeId}, {title}, {startDate}";

    }









}