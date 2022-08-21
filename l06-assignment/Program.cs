// NEW LIST -----------------------------------------------------------------


List<string> taskList = new List<string>();


// CREATE A TASK ----------------------------------------------------------------------


void createTask() {

    Console.Write("What is the name of the task you want to create? ");
    string addTask = Console.ReadLine();
    
    taskList.Add($"{addTask}");
    Console.WriteLine($"{addTask} has been added to the task list.");

}


// VIEW ALL TASKS ----------------------------------------------------------------------


void viewTasks() {

    Console.WriteLine($"*********************\nView All Tasks\n*********************\n");
    for (int i = 0; i < taskList.Count; i++) {
    Console.WriteLine($"{i + 1}. {taskList[i]}");
    }
}


// VIEW ALL TASKS ----------------------------------------------------------------------


void deleteTask() {
    try {
        Console.WriteLine($"*********************\nDelete a Task\n*********************\n");
        Console.Write("What task number would you like to delete? ");
        int indexDelete = int.Parse(Console.ReadLine());
        Console.WriteLine($"{taskList[indexDelete-1]} was removed from the list");
        taskList.Remove(taskList[indexDelete-1]);
    }
    catch (FormatException e) {
        Console.WriteLine(e.Message);
    }
    catch (InvalidDataException) {
        Console.WriteLine("Invalid Choice");
    }
}


// MENU ----------------------------------------------------------------------


void displayOptions() {
    
    try
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("\n");
            Console.WriteLine("*********************\n1. \tCreate a Task\n2. \tView all Tasks\n3. \tDelete a Task\n4. \tQuit\n*********************");
            // Console.WriteLine(taskList);
            Console.Write("\nEnter Your Choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    createTask();
                    break;
                case 2:
                    viewTasks();
                    break;
                case 3:
                    deleteTask();
                    break;
                default:
                    Console.WriteLine("Quiting the program.");
                    break;
            }
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Enter a number between 1-4.");
    }
    finally {
        displayOptions();
    }
}

displayOptions();

