namespace YYModels.Models;

public interface IResourceBase
{
    public string ResourceVersion { get; set; }
    public string ResourceName { get; set; }
}