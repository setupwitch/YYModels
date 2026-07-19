namespace YYModels.Models;

/// <summary>
/// Common interface for GMRUI nodes
/// </summary>
[GameMakerPolymorphic]
[GameMakerDerivedType(typeof(GMRUIContainer), nameof(GMRUIContainer))]
[GameMakerDerivedType(typeof(GMRFlexPanel), nameof(GMRFlexPanel))]
[GameMakerDerivedType(typeof(GMRUIFolder), nameof(GMRUIFolder))]
[GameMakerDerivedType(typeof(GMRUILayer), nameof(GMRUILayer))]
public interface IGMRUI
{
    
}