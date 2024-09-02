namespace hello_graphql.Types;

public interface IPet
{
    string Name { get; }
}

public class Dog : IPet, IMammal
{
    public Dog(string name, string breed)
    {
        Name = name;
        Breed = breed;
    }

    public string Name { get; }
    public string Breed { get; }

    public string DisplayName()
    {
        return $"{Name} {Breed}";
    }
}

public class Cat : IPet, IMammal
{
    public Cat(string name, bool isEvil, CatLives lives)
    {
        Name = name;
        IsEvil = isEvil;
        Lives = lives;
    }

    public string Name { get; }
    public bool IsEvil { get; }
    public CatLives Lives { get; }
}

public enum CatLives
{
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    NineAndHalf
}

public class Parrot : IPet
{
    public Parrot(string name, bool canTalk)
    {
        Name = name;
        CanTalk = canTalk;
    }

    public string Name { get; }
    public bool CanTalk { get; }
}
