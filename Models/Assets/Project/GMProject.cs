namespace YYModels.Models;

[YYVersion(1)]
public class GMProject : ResourceBase
{
    /// <summary>
    /// The audio groups in the project.
    /// </summary>
    [GameMakerProperty("AudioGroups")]
    public List<GMAudioGroup> AudioGroups { get; set; } = new();

    /// <summary>
    /// The folders in the project.
    /// </summary>
    [GameMakerProperty("Folders")]
    public List<GMFolder> Folders { get; set; } = new();

    /// <summary>
    /// The prefab references
    /// </summary>
    [GameMakerProperty("ForcedPrefabProjectReferences")]
    public List<PrefabReference> ForcedPrefabProjectReferences { get; set; } = new();

    /// <summary>
    /// A list of <see cref="GMIncludedFile"/> instances.
    /// </summary>
    [GameMakerProperty("IncludedFiles")]
    public List<GMIncludedFile> IncludedFiles { get; set; } = new();

    /// <summary>
    /// The shared particle emitters saved in the project.
    /// </summary>
    [GameMakerProperty("LibraryEmitters")]
    public List<ResourceReference<GMPSEmitter>> Emitters { get; set; } = new();

    /// <summary>
    ///  Contains information about the project, only ever "IDEVersion"
    /// </summary>
    [GameMakerProperty("MetaData")]
    public Dictionary<string, string> MetaData { get; set; } = new();

    /// <summary>
    /// A list of <see cref="RoomOrderNode"/> instances to ensure the room order.
    /// </summary>
    [GameMakerProperty("RoomOrderNodes")]
    public List<RoomOrderNode> RoomOrderNodes { get; set; } = new();

    /// <summary>
    /// The texture groups in the project.
    /// </summary>
    [GameMakerProperty("TextureGroups")]
    public List<GMTextureGroup> TextureGroups { get; set; } = new();

    /// <summary>
    /// Build configs for the project.
    /// </summary>
    [GameMakerProperty("configs")]
    public BuildConfig BuildConfigs { get; set; }

    /// <summary>
    /// The default script type of the project, see <see cref="DefaultScriptType"/>.
    /// </summary>
    [GameMakerProperty("defaultScriptType")]
    public DefaultScriptType ScriptType { get; set; }

    /// <summary>
    /// Unknown
    /// </summary>
    [GameMakerProperty("isEcma")]
    public bool IsEcma { get; set; }

    /// <summary>
    /// A list of <see cref="Resource"/> instances for every asset in the project.
    /// </summary>
    [GameMakerProperty("resources")]
    public List<Resource> Assets { get; set; } = new();

    /// <summary>
    /// Unimportant metadata, dependant on which template you choose.
    /// </summary>
    [GameMakerProperty("templateType")]
    public string TemplateType { get; set; }
    
    public enum DefaultScriptType
    {
        None = 0,
        GML = 1,
        Visual = 2,
    }
    
    public class BuildConfig
    {
        /// <summary>
        /// The child build configs.
        /// </summary>
        [GameMakerProperty("children")]
        public List<BuildConfig> ChildConfigs { get; set; } = new();

        /// <summary>
        /// The name of the build config.
        /// </summary>
        [GameMakerProperty("name")]
        public string Name { get; set; }
    }
    
    [YYVersion(0)]
    [GMResource("datafiles")]
    public class GMIncludedFile : ResourceBase
    {
        /// <summary>
        /// The targets to export the included file to.
        /// </summary>
        [GameMakerProperty("CopyToMask")]
        public TargetPlatforms CopyTargets { get; set; }

        /// <summary>
        /// The path of the included file.
        /// </summary>
        [GameMakerProperty("filePath")]
        public string FilePath { get; set; }
    }
    
    public class Resource
    {
        /// <summary>
        /// The resource in the project.
        /// </summary>
        [GameMakerProperty("id")]
        public ResourceReference<ResourceBase> Id { get; set; }
    }
    
    public class RoomOrderNode
    {
        /// <summary>
        /// The room in the node.
        /// </summary>
        [GameMakerProperty("roomId")]
        public ResourceReference<GMRoom> RoomId { get; set; }
    }

    public class PrefabReference
    {
        [GameMakerProperty("link")]
        public string PrefabLink { get; set; }

        [GameMakerProperty("name")]
        public string Name { get; set; }

        [GameMakerProperty("path")]
        public string Path { get; set; }
    }
}