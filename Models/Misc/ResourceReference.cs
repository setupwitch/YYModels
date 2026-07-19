using System;

namespace YYModels.Models;

public interface IResourceReference
{
    string Name { get; }
    string Path { get; }
    Type TargetType { get; set; }
    ResourceBase? Resource { get; set; }
    bool ResourceLoaded { get; }
}

public class ResourceReference<T> : IResourceReference where T : ResourceBase
{
    /// <summary>
    /// The name of the reference.
    /// </summary>
    [GameMakerProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// The path of the reference.
    /// </summary>
    /// <example>$"{assetType}/{name}/{name}.yy"</example>
    [GameMakerProperty("path")]
    public string Path { get; set; }
    
    /// <summary>
    /// The asset that is being referenced
    /// </summary>
    /// <remarks>lib exclusive.</remarks>
    [GameMakerIgnore]
    public T? Resource { get; set; }
    
    ResourceBase? IResourceReference.Resource 
    { 
        get => this.Resource; 
        set => this.Resource = (T?)value; 
    }
    
    /// <summary>
    /// Whether the resource is loaded (not null)
    /// </summary>
    /// <remarks>lib exclusive.</remarks>
    [GameMakerIgnore]
    public bool ResourceLoaded => Resource is not null;

    private Type? _targetType;
    
    /// <summary>
    /// The type of the target
    /// </summary>
    /// <remarks>lib exclusive.</remarks>
    [GameMakerIgnore]
    public Type TargetType 
    { 
        get => _targetType ?? typeof(T); 
        set => _targetType = value; 
    }

    public ResourceReference() { }

    public ResourceReference(string name)
    {
        Name = name;
        var attr = (GMResourceAttribute?)Attribute.GetCustomAttribute(typeof(T), typeof(GMResourceAttribute));
        if (attr is not null)
        {
            // folders have weird references
            if (typeof(T) == typeof(GMFolder))
            {
                Path = $"{attr.Path}/{name}.yy";
            }
            else
            {
                Path = $"{attr.Path}/{name}/{name}.yy";
            }
        }
        else
        {
            Path = string.Empty;
        }
    }

    public ResourceReference(string name, string path)
    {
        Name = name;
        Path = path;
    }

    public ResourceReference(string name, Type type)
    {
        Name = name;
        var attr = (GMResourceAttribute?)Attribute.GetCustomAttribute(type, typeof(GMResourceAttribute));
        if (attr is not null)
        {
            if (type == typeof(GMFolder))
            {
                Path = $"{attr.Path}/{name}.yy";
            }
            else
            {
                Path = $"{attr.Path}/{name}/{name}.yy";
            }
        }
        else
        {
            Path = string.Empty;
        }
    }

    public ResourceReference(GMFolder folder)
    {
        Name = folder.Name;
        Path = folder.FolderPath;
    }
}

public class ResourceReferenceWithOrder : ResourceReference<ResourceBase>
{
    [GameMakerProperty("order")]
    public int Order { get; set; }

    public ResourceReferenceWithOrder() { }

    public ResourceReferenceWithOrder(string name, int order = 0) : base(name)
    {
        Order = order;
    }

    public ResourceReferenceWithOrder(string name, Type type, int order = 0) : base(name, type)
    {
        Order = order;
    }

    public ResourceReferenceWithOrder(string name, string path, int order = 0) : base(name, path)
    {
        Order = order;
    }
}