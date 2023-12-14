
Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();

Dog myDog = new Dog(myDogName);
//myDog._name = "Goodboy";
Dog neighboursDog = new Dog("Beanos");
//neighboursDog._name = "Beanos";

Console.WriteLine($"My dogs name is {myDog.Name}");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}");
myDog.rename("Mitte koer");

Console.WriteLine($"Level of happiness: {myDog.levelOfHapiness}");

Console.WriteLine("Tahad edasi? vajuta");
Console.ReadLine();
Console.Clear();

Console.WriteLine($"Level of happiness: {myDog.levelOfHapiness}");

while (myDog.levelOfHapiness !=5)
{
    myDog.Bark();
}
Console.WriteLine($"Level of happiness: {myDog.levelOfHapiness}");

myDog.WagTail();
myDog.WagTail();
myDog.WagTail();
myDog.WagTail();
myDog.WagTail();


class Dog
{
    private string _name = "Koer"; //field
    private int _levelOfHapiness = 0;

    //constructor
    public Dog(string name) //name - lets the user name the dogs
    {
        _name = name;
        _levelOfHapiness = 0;
    }

    //getter

    public string Name
    {
        get { return _name; } 
    }

    public int levelOfHapiness
    {
        get { return _levelOfHapiness; } 
    }


    public void rename(string newName)
    { 
        _name = newName;
        Console.WriteLine($"The dog hase been renamed to: {newName}");
    }


    public void Bark()
    {
        Console.WriteLine("Bork Bark");
        _levelOfHapiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Vasak-Parem");
    }



}


