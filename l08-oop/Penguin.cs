public class Penguin : Animal
{
    public bool flies;

    public Penguin(string name, int age, bool canFly)
    {
        animalName = name;
        animalAge = age;
        flies = canFly;
    }

    public bool CanFly
    {
        get { return flies; }
        set { flies = value; }
    }
}