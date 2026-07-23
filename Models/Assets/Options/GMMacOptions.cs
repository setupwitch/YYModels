namespace YYModels.Models;

[YYVersion(0)]
public class GMMacOptions : GMOptionsBase
{
    [GameMakerProperty("option_mac_allow_fullscreen")]
    public bool option_mac_allow_fullscreen { get; set; }

    [GameMakerProperty("option_mac_allow_incoming_network")]
    public bool option_mac_allow_incoming_network { get; set; }

    [GameMakerProperty("option_mac_allow_outgoing_network")]
    public bool option_mac_allow_outgoing_network { get; set; }

    [GameMakerProperty("option_mac_app_category")]
    public string option_mac_app_category { get; set; }

    [GameMakerProperty("option_mac_app_id")]
    public string option_mac_app_id { get; set; }

    [GameMakerProperty("option_mac_apple_sign_in")]
    public bool option_mac_apple_sign_in { get; set; }

    [GameMakerProperty("option_mac_arm64")]
    public bool option_mac_arm64 { get; set; }

    [GameMakerProperty("option_mac_build_app_store")]
    public bool option_mac_build_app_store { get; set; }

    [GameMakerProperty("option_mac_build_number")]
    public int option_mac_build_number { get; set; }

    [GameMakerProperty("option_mac_copyright")]
    public string option_mac_copyright { get; set; }

    [GameMakerProperty("option_mac_disable_sandbox")]
    public bool option_mac_disable_sandbox { get; set; }

    [GameMakerProperty("option_mac_display_cursor")]
    public bool option_mac_display_cursor { get; set; }

    [GameMakerProperty("option_mac_display_name")]
    public string option_mac_display_name { get; set; }

    [GameMakerProperty("option_mac_enable_retina")]
    public bool option_mac_enable_retina { get; set; }

    [GameMakerProperty("option_mac_enable_steam")]
    public bool option_mac_enable_steam { get; set; }

    [GameMakerProperty("option_mac_icon_png")]
    public string option_mac_icon_png { get; set; }

    [GameMakerProperty("option_mac_installer_background_png")]
    public string option_mac_installer_background_png { get; set; }

    [GameMakerProperty("option_mac_interpolate_pixels")]
    public bool option_mac_interpolate_pixels { get; set; }

    [GameMakerProperty("option_mac_menu_dock")]
    public bool option_mac_menu_dock { get; set; }

    [GameMakerProperty("option_mac_min_version")]
    public string option_mac_min_version { get; set; }

    [GameMakerProperty("option_mac_output_dir")]
    public string option_mac_output_dir { get; set; }

    [GameMakerProperty("option_mac_resize_window")]
    public bool option_mac_resize_window { get; set; }

    [GameMakerProperty("option_mac_scale")]
    public int option_mac_scale { get; set; }

    [GameMakerProperty("option_mac_signing_identity")]
    public string option_mac_signing_identity { get; set; }

    [GameMakerProperty("option_mac_splash_png")]
    public string option_mac_splash_png { get; set; }

    [GameMakerProperty("option_mac_start_fullscreen")]
    public bool option_mac_start_fullscreen { get; set; }

    [GameMakerProperty("option_mac_team_id")]
    public string option_mac_team_id { get; set; }

    [GameMakerProperty("option_mac_texture_page")]
    public string option_mac_texture_page { get; set; }

    [GameMakerProperty("option_mac_version")]
    public string option_mac_version { get; set; }

    [GameMakerProperty("option_mac_vsync")]
    public bool option_mac_vsync { get; set; }

    [GameMakerProperty("option_mac_x86_64")]
    public bool option_mac_x86_64 { get; set; }
}