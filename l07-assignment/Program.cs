// NEW LIST -----------------------------------------------------------------


List<Task> taskList = new List<Task>();


// CREATE A TASK ----------------------------------------------------------------------


void createTask() {

    Console.Write("What is the name of the task you want to create? ");
    string addTask = Console.ReadLine();
    

    Console.Write("How long will the task take to complete? ");
    string taskTime = (Console.ReadLine());

    Task newtask = new Task(addTask, taskTime);

    taskList.Add(newtask);
    Console.WriteLine($"{newtask.getTaskName()} has been added to the task list.");

}


// VIEW ALL TASKS ----------------------------------------------------------------------


void viewTasks() {

    Console.WriteLine($"*********************\nView All Tasks\n*********************\n");
    for (int i = 0; i < taskList.Count; i++) {
        if (taskList[i].isComplete()) {
            Console.WriteLine($"{i + 1}. {taskList[i].getTaskName()}, {taskList[i].getDuration()} (Complete)");
        }
        else {
                    Console.WriteLine($"{i + 1}. {taskList[i].getTaskName()}, {taskList[i].getDuration()}");
        }
    }
}


// COMPLETE A TASK ----------------------------------------------------------------------


void completeTask() {
    try {
        Console.WriteLine($"*********************\nComplete a Task\n*********************\n");
        Console.Write("What task number would you like to mark as completed ");
        int indexComplete = int.Parse(Console.ReadLine()); 

        Console.WriteLine($"{taskList[indexComplete-1].getTaskName()} is now complete!");
        taskList[indexComplete-1].setComplete();
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
            Console.WriteLine("*********************\n1. \tCreate a Task\n2. \tView all Tasks\n3. \tComplete a Task\n4. \tQuit\n*********************");
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
                    completeTask();
                    break;
                case 4:
                    Console.WriteLine("Quiting the program.");
                    break;
                default:
                    Console.WriteLine("Enter a number between 1-4.");
                    break;
            }
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Enter a number between 1-4.");
        displayOptions();
    }
    // finally {
    //     displayOptions();
    // }
}

displayOptions();
