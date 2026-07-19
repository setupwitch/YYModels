namespace YYModels.Models;

/// <remarks>Version 1</remarks>
public class GMRUILayer : GMRUIContainer
{
    /// <inheritdoc cref="GMRFlexPanel.ContentAlignment"/>
    [GameMakerProperty("alignContent")]
    public Align ContentAlignment { get; set; }

    /// <inheritdoc cref="GMRFlexPanel.ItemAlignment"/>
    [GameMakerProperty("alignItems")]
    public Align ItemAlignment { get; set; }

    /// <inheritdoc cref="GMRFlexPanel.FlexDirection"/>
    [GameMakerProperty("flexDirection")]
    public UIFlexDirection FlexDirection { get; set; }

    /// <inheritdoc cref="GMRFlexPanel.WrapType"/>
    [GameMakerProperty("flexWrap")]
    public Wrap WrapType { get; set; }

    /// <inheritdoc cref="GMRFlexPanel.ColumnGap"/>
    [GameMakerProperty("gapColumn")]
    public float ColumnGap { get; set; }

    /// <inheritdoc cref="GMRFlexPanel.RowGap"/>
    [GameMakerProperty("gapRow")]
    public float RowGap { get; set; }

    /// <summary>
    /// X grid alignment for the layer.
    /// </summary>
    [GameMakerProperty("gridX")]
    public int GridX { get; set; }

    /// <summary>
    /// X grid alignment for the layer.
    /// </summary>
    [GameMakerProperty("gridY")]
    public int GridY { get; set; }

    /// <inheritdoc cref="GMRFlexPanel.ContentJustification"/>
    [GameMakerProperty("justifyContent")]
    public Justify ContentJustification { get; set; }

    /// <inheritdoc cref="GMRFlexPanel.LayoutDirection"/>
    [GameMakerProperty("layoutDirection")]
    public Direction LayoutDirection { get; set; }

    /// <summary>
    /// Whether the layer is locked.
    /// </summary>
    [GameMakerProperty("locked")]
    public bool IsLocked { get; set; }

    /// <inheritdoc cref="GMRFlexPanel.BottomPadding"/>
    [GameMakerProperty("paddingBottom")]
    public FlexValue BottomPadding { get; set; }

    /// <inheritdoc cref="GMRFlexPanel.LeftPadding"/>
    [GameMakerProperty("paddingLeft")]
    public FlexValue LeftPadding { get; set; }

    /// <inheritdoc cref="GMRFlexPanel.RightPadding"/>
    [GameMakerProperty("paddingRight")]
    public FlexValue RightPadding { get; set; }

    /// <inheritdoc cref="GMRFlexPanel.TopPadding"/>
    [GameMakerProperty("paddingTop")]
    public FlexValue TopPadding { get; set; }

    /// <summary>
    /// Whether the layer is visible.
    /// </summary>
    [GameMakerProperty("visible")]
    public bool IsVisible { get; set; }
    
    public enum Align
    {
        Auto = 0,
        FlexStart = 1,
        Center = 2,
        FlexEnd = 3,
        Stretch = 4,
        Baseline = 5,
        Between = 6,
        Around = 7,
        Evenly = 8,
    }

    public enum Justify
    {
        FlexStart = 0,
        Center = 1,
        FlexEnd = 2,
        Between = 3,
        Around = 4,
        Evenly = 5,
    }

    public enum UIFlexDirection
    {
        Column = 0,
        ColumnReverse = 1,
        Row = 2,
        RowReverse = 3,
    }

    public enum Direction
    {
        Inherit = 0,
        LeftToRight = 1,
        RightToLeft = 2,
    }
    
    public enum Wrap
    {
        No = 0,
        Yes = 1,
        Reverse = 2,
    }
}

/// <remarks>Unused</remarks>
/// <remarks>Version 0</remarks>
public class GMRUIEffectLayer : GMRUILayer
{
    
}