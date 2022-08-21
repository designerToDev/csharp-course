using System.Linq;

// LIST OF EMPLOYEES ------------------------------------------------------------------------------------------------



List<Employee> employeeList = new List<Employee>();



// CONVERT STRING TO EMLOYEE ----------------------------------------------------------------------------------------------

 

Employee convertStringToEmployee(string inputEmployee)
{
        string[] employeeSplit = inputEmployee.Split(","); //size 4 array = []
       
        int employeeIdNumber = int.Parse(employeeSplit[2]);
        Employee newEmployee = new Employee(employeeSplit[0], employeeSplit[1], employeeIdNumber, employeeSplit[3] );

        return newEmployee;
}



// CONVERT TO EMPLOYEE TO STRING ----------------------------------------------------------------------------------------------



string convertEmployeeToString(string Employee)
{

    foreach (Employee employee in employeeList) {
            Console.WriteLine(employee.ToString());
    }

    return "";

}



// SEARCH BY EMLOYEE ID ----------------------------------------------------------------------------------------------



void searchById()
{
    Console.WriteLine("PLease enter an employee ID: ");
    int emId = 0;
    string input = Console.ReadLine();

    try
    {
        emId = int.Parse(input);
        if (emId >= 0000 && emId <= 9999)
        {
            var filteredID = employeeList.Where(e => e.employeeId == emId);

            foreach (Employee e in filteredID)
            {
                e.printDetails();
            }
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Please enter a valid ID number.");
    }
}



// SEARCH BY EMLOYEE NAME ----------------------------------------------------------------------------------------------



void searchByName()
{
    Console.WriteLine("PLease enter an employee Name: ");
    string input = Console.ReadLine();
    
    try
    {
        if (input != "")
        {
            Console.WriteLine("\n");
            Console.WriteLine("*********************\nResult\n*********************\n");

            int employeeNameContains = 0;

            foreach (Employee employee in employeeList)
            {
                if (employee.firstName.Contains(input) || employee.lastName.Contains(input)) {
                    employeeNameContains++;
                    employee.printDetails();
                }
            }

            if (employeeNameContains < 1) {
                Console.WriteLine("Please enter a valid employee name.");
            }

        }
    }
    catch (Exception)
    {
        Console.WriteLine("Please enter a valid employee name.");
    }
}



// VIEW ALL EMPLOYEES --------------------------------------------------------------------------------------------------



void viewEmployees()  
{

    Console.WriteLine($"*********************\nView All Employees\n*********************\n");
     
        foreach (Employee employee in employeeList) {
            employee.printDetails();
        }
        
}



// DELETE AN EMPLOYEE ----------------------------------------------------------------------



void deleteEmployee()
{
    Console.WriteLine("PLease enter an employee ID to Delete: ");

    try
    {
        int input = int.Parse(Console.ReadLine());

        if (input >= 1000 || input <= 9999)
        {
            Console.WriteLine("\n");
            Console.WriteLine("*********************\nResult\n*********************\n");

            int deletedEmployeeCount = 0;

            for (int i = 0 ; i<employeeList.Count ; i++)
            {
                if (employeeList[i].employeeId == input) {
                    employeeList.RemoveAt(i);
                    deletedEmployeeCount++;
                    Console.WriteLine($"Employee with ID: {input} deleted");
                }
            }

            if (deletedEmployeeCount < 1) {
                Console.WriteLine($"There is no employee with that ID number: {input}");
            }

        }
    }
    catch (Exception)
    {
        Console.WriteLine("Please enter a valid employee Id.");
    }
}



// SEARCH BY EMPLOYEE ID ----------------------------------------------------------------------



void searchEmployees()
{
    
    try
    {
        int choice = 1;
        // while choice is greater than or equal to 1 and choice is less than and equal to 2
        while (choice >= 1 && choice <= 2)
        {
            Console.WriteLine("*********************\n Search Employees by:\n1. Employee ID\n2. Name\n*********************");
            Console.Write("\nEnter Your Choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice) 
            {
                case 1:
                    searchById();
                    break;
                case 2:
                    searchByName();
                    break;
                default:
                    Console.WriteLine("Enter a number between 1-2.");
                    break;
            }
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Please enter a number between 1-2.");
        
    }
}



// CREATE EMPLOYEE ID ----------------------------------------------------------------------------------------------



int createIdNum()
{
    
    Random random = new Random();
    int employeeRandomNum = random.Next(1000, 9999);
    
    return employeeRandomNum;
}



// CREATE NEW EMPLOYEE ----------------------------------------------------------------------------------------------



void createEmployee()
{
    Console.WriteLine("What is the Employee's first name?");
    string first = Console.ReadLine();

    Console.WriteLine("What is the Employee's last name?");
    string last = Console.ReadLine();

    Console.WriteLine("What is the Employee's title?");
    string title = Console.ReadLine();

    
    Employee newEmployee = new Employee(first, last, createIdNum(), title);
    string createNewEmployee = newEmployee.ToString();

    employeeList.Add(newEmployee);

    Console.WriteLine($"New Employee created. - Employee ID: {createIdNum()}");

        using (StreamWriter file = new StreamWriter("employees.txt", false)) {
        foreach (Employee employee in employeeList) {
        file.WriteLine(employee);

        }
    }
}



// MENU -------------------------------------------------------------------------------------------------------------
// ------------------------------------------------------------------------------------------------------------------
// ------------------------------------------------------------------------------------------------------------------
// ------------------------------------------------------------------------------------------------------------------



void displayOptions()
{
   
    try
    {   

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\n");
            Console.WriteLine("*********************\n1. \tCreate New Employee\n2. \tView All Employees\n3. \tSearch Employees\n4. \tDelete Employees\n5. \tQuit\n*********************");
            Console.Write("\nEnter Your Choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    createEmployee();
                    break;
                case 2:
                    viewEmployees();
                    break;
                case 3:
                    searchEmployees();
                    break;
                case 4:
                    deleteEmployee();
                    break;
                case 5:
                    Console.WriteLine("Quiting the program.");
                    break;
                default:
                    Console.WriteLine("Enter a number between 1-5.");
                    break;
            }
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Please enter a number between 1-5.");
        displayOptions();
    }

}


// INIT EMPLOYEE LIST -------------------------------------------------------------------------------------------------------------


void initProgram()
{
        Console.WriteLine("Starting Program...");
        try
        {
            foreach (string line in File.ReadLines("employees.txt"))
            {
                if (line != "")
                {
                    Employee initialEmployee = convertStringToEmployee(line);
                    employeeList.Add(initialEmployee);   
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            displayOptions();
        }
}

initProgram();

