namespace hello_graphql.Types;

[UnionType("Mammal")]
public interface IMammal
{
    
}

public record Randomm(String Foo) : IMammal;