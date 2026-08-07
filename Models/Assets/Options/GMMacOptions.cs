namespace YYModels.Models;

[YYVersion(0)]
public class GMMacOptions : GMOptionsBase
{
    [GameMakerProperty("option_mac_allow_fullscreen")]
    public bool AllowFullscreen { get; set; }

    [GameMakerProperty("option_mac_allow_incoming_network")]
    public bool AllowIncomingNetwork { get; set; }

    [GameMakerProperty("option_mac_allow_outgoing_network")]
    public bool AllowOutgoingNetwork { get; set; }

    [GameMakerProperty("option_mac_app_category")]
    public string AppStoreCategory { get; set; }

    [GameMakerProperty("option_mac_app_id")]
    public string MacOSBundleId { get; set; }

    [GameMakerProperty("option_mac_apple_sign_in")]
    public bool MacAppleSignIn { get; set; }

    [GameMakerProperty("option_mac_arm64")]
    public bool IncludeARM64 { get; set; }

    [GameMakerProperty("option_mac_build_app_store")]
    public bool BuildToAppStore { get; set; }

    [GameMakerProperty("option_mac_build_number")]
    public int BuildVersionNumber { get; set; }

    [GameMakerProperty("option_mac_copyright")]
    public string CopyrightInfo { get; set; }

    [GameMakerProperty("option_mac_disable_sandbox")]
    public bool DisableSandbox { get; set; }

    [GameMakerProperty("option_mac_display_cursor")]
    public bool DisplayCursor { get; set; }

    [GameMakerProperty("option_mac_display_name")]
    public string DisplayName { get; set; }

    [GameMakerProperty("option_mac_enable_retina")]
    public bool EnableRetina { get; set; }

    [GameMakerProperty("option_mac_enable_steam")]
    public bool EnableSteam { get; set; }

    [GameMakerProperty("option_mac_icon_png")]
    public string IconPath { get; set; }

    [GameMakerProperty("option_mac_installer_background_png")]
    public string InstallerBackgroundPath { get; set; }

    [GameMakerProperty("option_mac_interpolate_pixels")]
    public bool InterpolateColors { get; set; }

    [GameMakerProperty("option_mac_menu_dock")]
    public bool DisplayIconInDock { get; set; }

    [GameMakerProperty("option_mac_min_version")]
    public string MinimumOSVersion { get; set; }

    [GameMakerProperty("option_mac_output_dir")]
    public string AppOutputDirectory { get; set; }

    [GameMakerProperty("option_mac_resize_window")]
    public bool AllowWindowResize { get; set; }

    /// <remarks>0 == Keep aspect ratio | 1 == Full scale"</remarks>
    [GameMakerProperty("option_mac_scale")]
    public int WindowScale { get; set; }

    [GameMakerProperty("option_mac_signing_identity")]
    public string SigningCertificate { get; set; }

    [GameMakerProperty("option_mac_splash_png")]
    public string SplashScreenPath { get; set; }

    [GameMakerProperty("option_mac_start_fullscreen")]
    public bool StartInFullscreen { get; set; }

    [GameMakerProperty("option_mac_team_id")]
    public string MacTeamId { get; set; }

    [GameMakerProperty("option_mac_texture_page")]
    public string TexturePageDimensions { get; set; }

    [GameMakerProperty("option_mac_version")]
    public string Version { get; set; }

    [GameMakerProperty("option_mac_vsync")]
    public bool EnableVsync { get; set; }

    [GameMakerProperty("option_mac_x86_64")]
    public bool IncludeX86_64 { get; set; }
}