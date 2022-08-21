public class Person 
{
    public string firstName;
    public string lastName;


    public Person()
    {
        firstName = "";
        lastName = "";
    }
    public Person(string first, string last)
    {
        firstName = first;
        lastName = last;
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


    public virtual void printDetails() {
        Console.WriteLine("The person's name is " + firstName + " " + lastName + ".");
    }

}