namespace YYModels;

public class GameMakerProperty : Attribute
{
    public string PropertyName;
    public GameMakerProperty(string propertyName) => PropertyName = propertyName;
}



public class GameMakerIgnore : Attribute { }
public class GameMakerIgnoreWhenWritingNull : Attribute { }

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, Inherited = false)]
public class GameMakerPolymorphic : Attribute
{
    public string DiscriminatorName { get; } = "resourceType";
}

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, Inherited = false)]
public sealed class GameMakerKeyPolymorphic : Attribute { }

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = false)]
public class GameMakerDerivedType : Attribute
{
    public Type DerivedType { get; }
    public string TypeDiscriminator { get; }

    public GameMakerDerivedType(Type derivedType, string typeDiscriminator)
    {
        DerivedType = derivedType;
        TypeDiscriminator = typeDiscriminator;
    }
}

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class GMResourceAttribute : Attribute
{
    public string Path { get; }
    public GMResourceAttribute(string path) => Path = path;
}
