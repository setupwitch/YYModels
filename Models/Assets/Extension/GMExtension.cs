namespace YYModels.Models;

// TODO: More research on the history and stored information in extensions.

/// <remarks>Version 0</remarks>
[GMResource("extensions")]
public class GMExtension : ResourceBase
{
    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("HTML5CodeInjection")]
    public string HTMLCodeInjection { get; set; }

    /// <summary>
    /// The resources included in the extension
    /// </summary>
    [GameMakerProperty("IncludedResources")]
    public List<string> IncludedResources { get; set; }

    /// <summary>
    /// The permissions that the extension requires on android.
    /// </summary>
    [GameMakerProperty("androidPermissions")]
    public List<string> AndroidPermissions { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("androidProps")]
    public bool AndroidProps { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("androidactivityinject")]
    public string AndroidActivityInject { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("androidclassname")]
    public string AndroidClassName { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("androidcodeinjection")]
    public string AndroidCodeInjection { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("androidinject")]
    public string AndroidInject { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("androidmanifestinject")]
    public string AndroidManifestInject { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("androidsourcedir")]
    public string AndroidSourceDirectory { get; set; }

    /// <summary>
    /// The author of the extension.
    /// </summary>
    [GameMakerProperty("author")]
    public string Author { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("classname")]
    public string ClassName { get; set; }

    /// <summary>
    /// The targets that the extension copies to.
    /// </summary>
    [GameMakerProperty("copyToTargets")]
    public TargetPlatforms CopyToTargets { get; set; }

    /// <summary>
    /// The description of the extension.
    /// </summary>
    [GameMakerProperty("description")]
    public string Description { get; set; }

    /// <summary>
    /// Unknown always true.
    /// </summary>
    [GameMakerProperty("exportToGame")]
    public bool DoExport { get; set; }

    /// <summary>
    /// The version of the extension.
    /// </summary>
    [GameMakerProperty("extensionVersion")]
    public string ExtensionVersion { get; set; }

    /// <summary>
    /// The files in the extension.
    /// </summary>
    [GameMakerProperty("files")]
    public List<GMExtensionFile> ExtensionFiles { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("gradleinject")]
    public string GradleInject { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("hasConvertedCodeInjection")]
    public bool HasConvertedCodeInjection { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("helpfile")]
    public string HelpFile { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("html5Props")]
    public bool HTMLProps { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("installdir")]
    public string InstallDirectory { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("iosCocoaPodDependencies")]
    public string IOSCocoaPodDependencies { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("iosCocoaPods")]
    public string IOSCocoaPods { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("iosProps")]
    public bool IOSProps { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("iosSystemFrameworkEntries")]
    public List<GMExtensionFrameworkEntry> IOSSystemFrameworkEntries { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("iosThirdPartyFrameworkEntries")]
    public List<GMExtensionFrameworkEntry> IOSThirdPartyFrameworkEntries { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("ioscodeinjection")]
    public string IOSCodeInjection { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("iosdelegatename")]
    public string IOSDelegateName { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("iosplistinject")] 
    public string IOSPlistInject { get; set; }

    /// <summary>
    /// The license type of the extension.
    /// </summary>
    [GameMakerProperty("license")]
    public string License { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("maccompilerflags")]
    public string MacCompilerFlags { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("maclinkerflags")]
    public string MacLinkerFlags { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("macsourcedir")]
    public string MacSourceDirectory { get; set; }

    /// <summary>
    /// The Options that the extension has.
    /// </summary>
    [GameMakerProperty("options")]
    public List<GMExtensionOption> ExtensionOptions { get; set; }

    /// <summary>
    /// The name of the options INI file.
    /// </summary>
    [GameMakerProperty("optionsFile")]
    public string OptionsFileName { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("packageId")]
    public string PackageId { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("productId")]
    public string ProductId { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("sourcedir")]
    public string SourceDirectory { get; set; }

    /// <summary>
    /// The targets that are supported by the extension.
    /// </summary>
    [GameMakerProperty("supportedTargets")]
    public TargetPlatforms ExportTargets { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("tvosCocoaPodDependencies")]
    public string TVOSCocoaPodDependencies { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("tvosCocoaPods")]
    public string TVOSCocoaPods { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("tvosProps")]
    public bool TVOSProps { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("tvosSystemFrameworkEntries")]
    public List<GMExtensionFrameworkEntry> TVOSSystemFrameworkEntries { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("tvosThirdPartyFrameworkEntries")]
    public List<GMExtensionFrameworkEntry> TVOSThirdPartyFrameworkEntries { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("tvosclassname")]
    public string TVOSClassName { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("tvoscodeinjection")]
    public string TVOSCodeInjection { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("tvosdelegatename")]
    public string TVOSDelegateName { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("tvosmaccompilerflags")]
    public string TVOSMacCompilerFlags { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("tvosmaclinkerflags")]
    public string TVOSMacLinkerFlags { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("tvosplistinject")]
    public string TVOSPlistInject { get; set; }
}   