public class Animal
{
    // Properties
    protected string? animalName;
    protected int animalAge;

    // Default constructor
    public Animal()
    {
        animalName = "";
        animalAge = 0;
    }

    // Parameterized constructor
    public Animal(string name, int age)
    {
        animalName = name;
        animalAge = age;
    }

    // Accessor for animalName
    public string? AnimalName
    {
        get { return animalName; }
        set { animalName = value; }
    }

    // Accessor for animalAge
    public int AnimalAge
    {
        get { return animalAge; }
        set { animalAge = value; }
    }

    // Methods
    public void eat()
    {
        Console.WriteLine(animalName + " is eating a good meal!");
    }
    
    public void move()
    {
        Console.WriteLine(animalName + " is moving!");
    }
}