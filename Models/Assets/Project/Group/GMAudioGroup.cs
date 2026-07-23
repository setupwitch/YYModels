namespace YYModels.Models;

[YYVersion(1)]
public class GMAudioGroup : GMBaseGroup
{
    /// <summary>
    /// The directory to export the audiogroup to.
    /// </summary>
    [GameMakerProperty("exportDir")]
    public string ExportDirectory { get; set; }
}