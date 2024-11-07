using System.Linq;

namespace hello_graphql.Types;

public class Query
{
    private bool _dog;

    public Book GetBook() => new Book("C# in Depth", new Author("Jon Skeet"));

    public IEnumerable<IPet> GetPets() 
        => new IPet[]
        {
            new Dog("Buddy", "Golden Retriever"),
            new Cat("Snowball_1", true, CatLives.Seven),
            new Cat("Snowball_2", true, CatLives.Eight),
            new Cat("Snowball_3", true, CatLives.Nine),
            new Parrot("Igy", false)
        };

    public IEnumerable<Cat> GetCats(CatLives? lives)
    {
        if (lives is not null)
        {
            return GetPets().OfType<Cat>().Where(t => t.Lives == lives);
        }

        return GetPets().OfType<Cat>();
    }

    public IMammal GetCatOrDog()
    {
        _dog = !_dog;

        return _dog 
            ? new Dog("Buddy", "Golden Retriver") 
            : new Cat("Snowball", true, CatLives.Three);
    }

    public string GetDogName(Dog dog)
    {
        return dog.Name;
    }

    public string GetDogOrCatName(DogOrCat dogOrCat)
    {
        return dogOrCat.Dog?.Name ?? dogOrCat.Cat.Name!;
    }
}

[OneOf]
public record DogOrCat(Dog? Dog, Cat? Cat);