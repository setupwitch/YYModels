namespace YYModels.Models;

[YYVersion(0)]    
public class GMLinuxOptions : GMOptionsBase
{
    [GameMakerProperty("option_linux_allow_fullscreen")]
    public bool option_linux_allow_fullscreen { get; set; }

    [GameMakerProperty("option_linux_disable_sandbox")]
    public bool option_linux_disable_sandbox { get; set; }

    [GameMakerProperty("option_linux_display_cursor")]
    public bool option_linux_display_cursor { get; set; }

    [GameMakerProperty("option_linux_display_name")]
    public string option_linux_display_name { get; set; }

    [GameMakerProperty("option_linux_display_splash")]
    public bool option_linux_display_splash { get; set; }

    [GameMakerProperty("option_linux_enable_steam")]
    public bool option_linux_enable_steam { get; set; }

    [GameMakerProperty("option_linux_homepage")]
    public string option_linux_homepage { get; set; }

    [GameMakerProperty("option_linux_icon")]
    public string option_linux_icon { get; set; }

    [GameMakerProperty("option_linux_interpolate_pixels")]
    public bool option_linux_interpolate_pixels { get; set; }

    [GameMakerProperty("option_linux_long_desc")]
    public string option_linux_long_desc { get; set; }

    [GameMakerProperty("option_linux_maintainer_email")]
    public string option_linux_maintainer_email { get; set; }

    [GameMakerProperty("option_linux_resize_window")]
    public bool option_linux_resize_window { get; set; }

    [GameMakerProperty("option_linux_scale")]
    public int option_linux_scale { get; set; }

    [GameMakerProperty("option_linux_short_desc")]
    public string option_linux_short_desc { get; set; }

    [GameMakerProperty("option_linux_splash_screen")]
    public string option_linux_splash_screen { get; set; }

    [GameMakerProperty("option_linux_start_fullscreen")]
    public bool option_linux_start_fullscreen { get; set; }

    [GameMakerProperty("option_linux_sync")]
    public bool option_linux_sync { get; set; }

    [GameMakerProperty("option_linux_texture_page")]
    public string option_linux_texture_page { get; set; }

    [GameMakerProperty("option_linux_version")]
    public string option_linux_version { get; set; }
}