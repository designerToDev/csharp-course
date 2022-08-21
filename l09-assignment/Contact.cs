public class Contact
{

    public string firstName;
    public string lastName;
    public string phoneNumber;
    public string email;


 public Contact()
    {
        firstName = "";
        lastName = "";
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


    public string PhoneNumber {
        get { return phoneNumber;}
        set { phoneNumber = value;}
    }


    public string Email {
        get { return email;}
        set { email = value;}
    }


    public void printDetails()
    {
        Console.WriteLine(firstName + lastName);
        Console.WriteLine("\n\tPhone:" + phoneNumber);
        Console.WriteLine("\n\tEmail:" + email);
    }

    public override string ToString()
    {
        
        return $"{firstName}, {lastName}, {phoneNumber}, {email}";

    }

}