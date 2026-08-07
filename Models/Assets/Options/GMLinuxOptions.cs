namespace YYModels.Models;

[YYVersion(0)]    
public class GMLinuxOptions : GMOptionsBase
{
    [GameMakerProperty("option_linux_allow_fullscreen")]
    public bool AllowFullscreen { get; set; }

    [GameMakerProperty("option_linux_disable_sandbox")]
    public bool DisableSandbox { get; set; }

    [GameMakerProperty("option_linux_display_cursor")]
    public bool DisplayCursor { get; set; }

    [GameMakerProperty("option_linux_display_name")]
    public string DisplayName { get; set; }

    [GameMakerProperty("option_linux_display_splash")]
    public bool UseSplashScreen { get; set; }

    [GameMakerProperty("option_linux_enable_steam")]
    public bool EnableSteam { get; set; }

    [GameMakerProperty("option_linux_homepage")]
    public string Homepage { get; set; }

    [GameMakerProperty("option_linux_icon")]
    public string IconPath { get; set; }

    [GameMakerProperty("option_linux_interpolate_pixels")]
    public bool InterpolateColors { get; set; }

    [GameMakerProperty("option_linux_long_desc")]
    public string LongDescription { get; set; }

    [GameMakerProperty("option_linux_maintainer_email")]
    public string MaintainerEmail { get; set; }

    [GameMakerProperty("option_linux_resize_window")]
    public bool AllowWindowResize { get; set; }

    /// <remarks>0 == Keep aspect ratio | 1 == Full scale"</remarks>
    [GameMakerProperty("option_linux_scale")]
    public int WindowScale { get; set; }

    [GameMakerProperty("option_linux_short_desc")]
    public string ShortDescription { get; set; }

    [GameMakerProperty("option_linux_splash_screen")]
    public string SplashScreenPath { get; set; }

    [GameMakerProperty("option_linux_start_fullscreen")]
    public bool StartInFullscreen { get; set; }

    [GameMakerProperty("option_linux_sync")]
    public bool EnableVsync { get; set; }

    [GameMakerProperty("option_linux_texture_page")]
    public string TexturePageDimensions { get; set; }

    [GameMakerProperty("option_linux_version")]
    public string Version { get; set; }
}