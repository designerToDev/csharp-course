public class Dog : Animal
{
    // Default constructor
    public Dog()
    {
        animalName = "";
        animalAge = 0;
    }

    // Parameterized constructor
    public Dog(string name, int age)
    {
        animalName = name;
        animalAge = age;
    }
}