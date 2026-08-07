namespace YYModels.Models;

/// <summary>
/// The playback type.
/// </summary>
public enum Playback
{
    None = -1,
        
    /// <summary>
    /// Start at beginning, go to end and stop.
    /// </summary>
    Normal = 0,
        
    /// <summary>
    /// Start at beginning, go to end and start over.
    /// </summary>
    Loop = 1,
        
    /// <summary>
    /// Start at beginning, go to end and go back in reverse.
    /// </summary>
    Pingpong = 2,
}