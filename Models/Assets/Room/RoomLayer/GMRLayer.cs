namespace YYModels.Models;

    /// <summary>
    /// A layer in a room.
    /// </summary>
    /// <remarks>Version 0</remarks>
    [GameMakerPolymorphic]
    [GameMakerDerivedType(typeof(GMRAssetLayer), nameof(GMRAssetLayer))]
    [GameMakerDerivedType(typeof(GMRBackgroundLayer), nameof(GMRBackgroundLayer))]
    [GameMakerDerivedType(typeof(GMRPathLayer), nameof(GMRPathLayer))]
    [GameMakerDerivedType(typeof(GMRInstanceLayer), nameof(GMRInstanceLayer))]
    [GameMakerDerivedType(typeof(GMREffectLayer), nameof(GMREffectLayer))]
    [GameMakerDerivedType(typeof(GMRTileLayer), nameof(GMRTileLayer))]
    public class GMRLayer : ResourceBase
    {
        /// <summary>
        /// The depth of the layer.
        /// </summary>
        [GameMakerProperty("depth")]
        public int Depth { get; set; }

        /// <summary>
        /// Whether the layer has effects enabled.
        /// </summary>
        [GameMakerProperty("effectEnabled")]
        public bool EffectIsEnabled { get; set; }

        /// <summary>
        /// The type of effect that the layer uses.
        /// </summary>
        [GameMakerProperty("effectType")]
        public string EffectType { get; set; }

        /// <summary>
        /// The grid width of the layer.
        /// </summary>
        [GameMakerProperty("gridX")]
        public int GridWidth { get; set; }

        /// <summary>
        /// The grid height of the layer.
        /// </summary>
        [GameMakerProperty("gridY")]
        public int GridHeight { get; set; }

        /// <summary>
        /// Unknown.
        /// </summary>
        [GameMakerProperty("hierarchyFrozen")]
        public bool HierarchyFrozen { get; set; }

        /// <summary>
        /// Whether to inherit depth from the previous layer?
        /// </summary>
        [GameMakerProperty("inheritLayerDepth")]
        public bool InheritLayerDepth { get; set; }

        /// <summary>
        /// Whether to inherit the layer settings from the previous layer?
        /// </summary>
        [GameMakerProperty("inheritLayerSettings")]
        public bool InheritLayerSettings { get; set; }

        /// <summary>
        /// Whether to inherit sub layers from the previous layer?
        /// </summary>
        [GameMakerProperty("inheritSubLayers")]
        public bool InheritSubLayers { get; set; }

        /// <summary>
        /// Whether to inherit the visibility from the previous layer?
        /// </summary>
        [GameMakerProperty("inheritVisibility")]
        public bool InheritVisibility { get; set; }

        /// <summary>
        /// The child layers of the room.
        /// </summary>
        [GameMakerProperty("layers")]
        public List<GMRLayer> Layers { get; set; }

        /// <summary>
        /// The effect properties of the layer.
        /// </summary>
        [GameMakerProperty("properties")]
        public List<EffectProperty> Properties { get; set; }

        /// <summary>
        /// Whether the <see cref="Depth"/> is defined by the user.
        /// </summary>
        [GameMakerProperty("userdefinedDepth")]
        public bool HasCustomDepth { get; set; }

        /// <summary>
        /// Whether the layer is visible.
        /// </summary>
        [GameMakerProperty("visible")]
        public bool IsVisible { get; set; }


    }