namespace YYModels.Models;

/// <remarks>Version 1</remarks>
public class GMAudioGroup : GMBaseGroup
{
    /// <summary>
    /// The directory to export the audiogroup to.
    /// </summary>
    [GameMakerProperty("exportDir")]
    public string ExportDirectory { get; set; }
}