namespace YYModels.Models;

public partial class GMSequence
{
    /// <summary>
    /// An interface for track modifiers.
    /// </summary>
    [GameMakerKeyPolymorphic]
    [GameMakerDerivedType(typeof(InvisibleModifier), nameof(InvisibleModifier))]
    [GameMakerDerivedType(typeof(LockedModifier), nameof(LockedModifier))]
    public interface IModifier { }
    
    /// <summary>
    /// A track modifier for visibility.
    /// </summary>
    /// <remarks>Version 0</remarks>
    public class InvisibleModifier : ResourceBase, IModifier { }

    /// <summary>
    /// A track modifier for locking.
    /// </summary>
    /// <remarks>Version 0</remarks>
    public class LockedModifier : ResourceBase, IModifier { }
    
    /// <summary>
    /// A track modifier for disabling.
    /// </summary>
    /// <remarks>Version 0</remarks>
    public class DisableModifier : ResourceBase, IModifier { }
    
    /// <summary>
    /// A track modifier for linking. (not sure?)
    /// </summary>
    /// <remarks>Version 0</remarks>
    public class LinkModifier : ResourceBase, IModifier { }
}