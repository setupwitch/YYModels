namespace YYModels.Models;

/// <remarks>Version 0</remarks>
public class GMRFlexPanel : GMRUIContainer
{
    /// <summary>
    /// "Align content defines the distribution of lines across the cross-axis. This only has effect when items are wrapped to multiple lines using flex wrap."
    /// </summary>
    [GameMakerProperty("alignContent")]
    public GMRUILayer.Align ContentAlignment { get; set; }

    /// <summary>
    /// "Align children along the cross axis of their container"
    /// </summary>
    [GameMakerProperty("alignItems")]
    public GMRUILayer.Align ItemAlignment { get; set; }

    /// <summary>
    /// The alignment of the node.
    /// </summary>
    [GameMakerProperty("alignSelf")]
    public GMRUILayer.Align Alignment { get; set; }

    /// <summary>
    /// "Hide items behind the panel bounds".
    /// </summary>
    [GameMakerProperty("clipContent")]
    public bool ClipContent { get; set; }

    /// <summary>
    /// "The main axis or direction nodes are laid out. This influences the direction of other flex properties e.g. align items, flex wrap."
    /// </summary>
    [GameMakerProperty("flexDirection")]
    public GMRUILayer.UIFlexDirection FlexDirection { get; set; }

    /// <summary>
    /// "Describes how remaining space in the container node should be distributed among its children along the main axis"
    /// </summary>
    [GameMakerProperty("flexGrow")]
    public float Grow { get; set; }

    /// <inheritdoc cref="Grow"/>
    [GameMakerProperty("flexShrink")]
    public float Shrink { get; set; }

    /// <summary>
    /// "Move items to the next row/column when it exceeds dimensions"
    /// </summary>
    [GameMakerProperty("flexWrap")]
    public GMRUILayer.Wrap WrapType { get; set; }

    /// <summary>
    /// Space between the columns.
    /// </summary>
    [GameMakerProperty("gapColumn")]
    public float ColumnGap { get; set; }

    /// <summary>
    /// Space between the rows.
    /// </summary>
    [GameMakerProperty("gapRow")]
    public float RowGap { get; set; }

    /// <summary>
    /// The height of the node.
    /// </summary>
    [GameMakerProperty("height")]
    public FlexValue Height { get; set; }

    /// <summary>
    /// "Align children along the node's main axis (<see cref="FlexDirection"/>)"
    /// </summary>
    [GameMakerProperty("justifyContent")]
    public GMRUILayer.Justify ContentJustification { get; set; }

    /// <summary>
    /// "Layout direction of the node and its children"
    /// </summary>
    [GameMakerProperty("layoutDirection")]
    public GMRUILayer.Direction LayoutDirection { get; set; }

    /// <summary>
    /// The bottom margin of the node.
    /// </summary>
    [GameMakerProperty("marginBottom")]
    public FlexValue BottomMargin { get; set; }

    /// <summary>
    /// The left margin of the node.
    /// </summary>
    [GameMakerProperty("marginLeft")]
    public FlexValue LeftMargin { get; set; }

    /// <summary>
    /// The right margin of the node.
    /// </summary>
    [GameMakerProperty("marginRight")]
    public FlexValue RightMargin { get; set; }

    /// <summary>
    /// The top margin of the node.
    /// </summary>
    [GameMakerProperty("marginTop")]
    public FlexValue TopMargin { get; set; }

    /// <summary>
    /// The maximum height that the node can be.
    /// </summary>
    [GameMakerProperty("maxHeight")]
    public FlexValue MaxHeight { get; set; }

    /// <summary>
    /// The maximum width that the node can be.
    /// </summary>
    [GameMakerProperty("maxWidth")]
    public FlexValue MaxWidth { get; set; }

    /// <summary>
    /// The minimum height that the node can be.
    /// </summary>
    [GameMakerProperty("minHeight")]
    public FlexValue MinHeight { get; set; }

    /// <summary>
    /// The minimum width that the node can be.
    /// </summary>
    [GameMakerProperty("minWidth")]
    public FlexValue MinWidth { get; set; }

    /// <summary>
    /// The bottom padding of the node.
    /// </summary>
    [GameMakerProperty("paddingBottom")]
    public FlexValue BottomPadding { get; set; }

    /// <summary>
    /// The left padding of the node.
    /// </summary>
    [GameMakerProperty("paddingLeft")]
    public FlexValue LeftPadding { get; set; }

    /// <summary>
    /// The right padding of the node.
    /// </summary>
    [GameMakerProperty("paddingRight")]
    public FlexValue RightPadding { get; set; }

    /// <summary>
    /// The top padding of the node.
    /// </summary>
    [GameMakerProperty("paddingTop")]
    public FlexValue TopPadding { get; set; }

    /// <summary>
    /// Distance between the bottom edge of the node and its parent
    /// </summary>
    [GameMakerProperty("positionBottom")]
    public FlexValue BottomOffset { get; set; }

    /// <summary>
    /// Distance between the left edge of the node and its parent
    /// </summary>
    [GameMakerProperty("positionLeft")]
    public FlexValue LeftOffset { get; set; }

    /// <summary>
    /// Distance between the right edge of the node and its parent
    /// </summary>
    [GameMakerProperty("positionRight")]
    public FlexValue RightOffset { get; set; }

    /// <summary>
    /// Distance between the top edge of the node and its parent
    /// </summary>
    [GameMakerProperty("positionTop")]
    public FlexValue TopOffset { get; set; }

    /// <summary>
    /// The type of position to use for the node.
    /// </summary>
    [GameMakerProperty("positionType")]
    public PanelPositionType PositionType { get; set; }

    /// <summary>
    /// The width of the node.
    /// </summary>
    [GameMakerProperty("width")]
    public FlexValue Width { get; set; }
    
    /// <summary>
    /// The position type of the panel
    /// </summary>
    public enum PanelPositionType
    {
        /// <summary>
        /// "Behaves like relative except it will ignore position offsets"
        /// </summary>
        Static,
        
        /// <summary>
        /// "Laid out according to the flow of the flex container it is part of"
        /// </summary>
        Relative,
        
        /// <summary>
        /// "Absolute nodes do not take up space in its flex container"
        /// </summary>
        Absolute,
    }
}