

// LIST OF CONTACTS ------------------------------------------------------------------------------------------------



List<Contact> contactList = new List<Contact>();



// CONVERT TO CONTACT TO STRING ----------------------------------------------------------------------------------------------



string convertContactToString(string Contact) {

    foreach (Contact contact in contactList) {
            Console.WriteLine(contact.ToString());
    }

    return "";

}



// CONVERT STRING TO CONTACT ----------------------------------------------------------------------------------------------



Contact convertStringToContact(string inputContact) {
        string[] contactSplit = inputContact.Split(","); //size 4 array = []
        Contact newContact = new Contact(contactSplit[0], contactSplit[1], contactSplit[2], contactSplit[3]);

        return newContact;
}



// CREATE NEW CONTACT ----------------------------------------------------------------------------------------------



void createContact() {
    Console.WriteLine("What is the contact's first name?");
    string first = Console.ReadLine();

    Console.WriteLine("What is the contact's last name?");
    string last = Console.ReadLine();

    Console.WriteLine("What is the contact's phone number?");
    string phone = Console.ReadLine();

    Console.WriteLine("What is the contact's email address?");
    string mail = Console.ReadLine();

    Contact newContact = new Contact(first, last, phone, mail);
    
    contactList.Add(newContact);

    Console.WriteLine("New contact added!");

        using (StreamWriter file = new StreamWriter("contacts.txt", true)) {
        foreach (Contact contact in contactList) {
            file.WriteLine(contact);
        }
    }
}



// VIEW ALL CONTACTS ----------------------------------------------------------------------------------------------



void viewContacts() {

    Console.WriteLine($"*********************\nView All Tasks\n*********************\n");
     
        foreach (Contact contact in contactList) {
            contact.printDetails();
        }
        
}



// MENU ----------------------------------------------------------------------------------------------------------



void displayOptions() {
    Console.WriteLine("Starting Program...");
    
    try
    {
        string contactFileText = File.ReadAllText("contacts.txt");
        Contact initialContact = convertStringToContact(contactFileText);
        contactList.Add(initialContact);

        int choice = 0;

        while (choice != 3)
        {
            Console.WriteLine("\n");
            Console.WriteLine("*********************\n1. \tCreate a Contact\n2. \tView Contact List\n3. \tExit\n*********************");
            Console.Write("\nEnter Your Choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    createContact();
                    break;
                case 2:
                    viewContacts();
                    break;
                case 3:
                    Console.WriteLine("Exiting the program.");
                    break;
                default:
                    Console.WriteLine("Enter a number between 1-3.");
                    break;
            }
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Enter a number between 1-3.");
        displayOptions();
    }
}

displayOptions();
