namespace YYModels.Models;

[YYVersion(1)]
public class GMExtensionFile : ResourceBase
{
    /// <summary>
    /// Files to add in place depending on the targets.
    /// </summary>
    [GameMakerProperty("ProxyFiles")]
    public List<GMProxyFile> ProxyFiles { get; set; } = new();

    /// <summary>
    /// The constants in the file.
    /// </summary>
    [GameMakerProperty("constants")]
    public List<GMExtensionConstant> ExtensionConstants { get; set; } = new();

    /// <summary>
    /// The targets to copy the file to.
    /// </summary>
    [GameMakerProperty("copyToTargets")]
    public TargetPlatforms TargetPlatforms { get; set; }

    /// <summary>
    /// The name of the file.
    /// </summary>
    [GameMakerProperty("filename")]
    public string FileName { get; set; }

    /// <summary>
    /// The <see cref="GMExtensionFunction"/> to execute on game end.
    /// </summary>
    [GameMakerProperty("final")]
    public string FinalAction { get; set; } // TODO: research

    /// <summary>
    /// The functions in the file.
    /// </summary>
    [GameMakerProperty("functions")]
    public List<GMExtensionFunction> ExtensionFunctions { get; set; } = new();

    /// <summary>
    /// The <see cref="GMExtensionFunction"/> to execute on game start.
    /// </summary>
    [GameMakerProperty("init")]
    public string InitAction { get; set; }

    /// <summary>
    /// The kind of file it is.
    /// </summary>
    [GameMakerProperty("kind")]
    public int FileKind { get; set; }

    /// <summary>
    /// The original name of the file.
    /// </summary>
    [GameMakerProperty("origname")]
    public string OriginalName { get; set; }

    /// <summary>
    /// Whether the file uncompresses itself on build.
    /// </summary>
    [GameMakerProperty("uncompress")]
    public bool IsUncompressed { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("usesRunnerInterface")]
    public bool UsesRunnerInterface { get; set; }
    
    [YYVersion(0)]
    public class GMProxyFile : ResourceBase
    {
        /// <summary>
        /// The targets to export the file to.
        /// </summary>
        [GameMakerProperty("TargetMask")]
        public TargetPlatforms TargetMask { get; set; }
    }
    
    [YYVersion(0)]
    public class GMExtensionConstant : ResourceBase
    {
        /// <summary>
        /// Whether the constant is hidden.
        /// </summary>
        [GameMakerProperty("hidden")]
        public bool IsHidden { get; set; }

        /// <summary>
        /// The value of the constant.
        /// </summary>
        [GameMakerProperty("value")]
        public string Value { get; set; }
    }
    
    [YYVersion(0)]
    public class GMExtensionFunction : ResourceBase
    {
        /// <summary>
        /// The amount of arguments in the function.
        /// </summary>
        [GameMakerProperty("argCount")]
        public int ArgumentCount { get; set; }

        /// <summary>
        /// The types of the arguments in the function.
        /// </summary>
        [GameMakerProperty("args")]
        public List<ValueType> Arguments { get; set; } = new();

        /// <summary>
        /// The documentation of the function
        /// </summary>
        [GameMakerProperty("documentation")]
        public string Documentation { get; set; }

        /// <summary>
        /// The external name of the function.
        /// </summary>
        [GameMakerProperty("externalName")]
        public string ExternalName { get; set; }

        /// <summary>
        /// The help message for the function.
        /// </summary>
        [GameMakerProperty("help")]
        public string HelpMessage { get; set; }

        /// <summary>
        /// Whether the function is hidden.
        /// </summary>
        [GameMakerProperty("hidden")]
        public bool IsHidden { get; set; }

        /// <summary>
        /// The kind of the function
        /// </summary>
        [GameMakerProperty("kind")]
        public int FunctionKind { get; set; }

        /// <summary>
        /// The type of the value returned by the function.
        /// </summary>
        [GameMakerProperty("returnType")]
        public ValueType ReturnValueType { get; set; }
    }
    
    public enum ExtensionKind
    {
        GML = 2,
        Generic = 4,
        JS = 5,
    }

    public enum ValueType
    {
        String = 1,
        Double = 2,
    }
}