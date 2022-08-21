public class Contact : Person
{
    public string phoneNumber;
    public string email;
    
    public Contact()
    {
        phoneNumber = "";
        email = "";
    }

    public Contact(string first, string last, string phone, string mail)
    {
        firstName = first;
        lastName = last;
        phoneNumber = phone;
        email = mail;
    }

    public string PhoneNumber {
        get { return phoneNumber;}
        set { phoneNumber = value;}
    }

    public string Email {
        get { return email;}
        set { email = value;}
    }

    public override void printDetails()
    {
        Console.WriteLine(firstName + " " + lastName);
        Console.WriteLine("\nPhone: " + phoneNumber);
        Console.WriteLine("\nEmail: " + email);
    }

}