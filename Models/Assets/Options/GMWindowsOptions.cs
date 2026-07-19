namespace YYModels.Models;

/// <remarks>Version 2</remarks>
public class GMWindowsOptions : GMOptionsBase
{
    [GameMakerProperty("option_windows_allow_fullscreen_switching")]
    public bool option_windows_allow_fullscreen_switching { get; set; }

    [GameMakerProperty("option_windows_borderless")]
    public bool option_windows_borderless { get; set; }

    [GameMakerProperty("option_windows_company_info")]
    public string option_windows_company_info { get; set; }

    [GameMakerProperty("option_windows_copy_exe_to_dest")]
    public bool option_windows_copy_exe_to_dest { get; set; }

    [GameMakerProperty("option_windows_copyright_info")]
    public string option_windows_copyright_info { get; set; }

    [GameMakerProperty("option_windows_d3dswapeffectdiscard")]
    public bool option_windows_d3dswapeffectdiscard { get; set; }

    [GameMakerProperty("option_windows_description_info")]
    public string option_windows_description_info { get; set; }

    [GameMakerProperty("option_windows_disable_sandbox")]
    public bool option_windows_disable_sandbox { get; set; }

    [GameMakerProperty("option_windows_display_cursor")]
    public bool option_windows_display_cursor { get; set; }

    [GameMakerProperty("option_windows_display_name")]
    public string option_windows_display_name { get; set; }

    [GameMakerProperty("option_windows_enable_steam")]
    public bool option_windows_enable_steam { get; set; }

    [GameMakerProperty("option_windows_executable_name")]
    public string option_windows_executable_name { get; set; }

    [GameMakerProperty("option_windows_icon")]
    public string option_windows_icon { get; set; }

    [GameMakerProperty("option_windows_installer_finished")]
    public string option_windows_installer_finished { get; set; }

    [GameMakerProperty("option_windows_installer_header")]
    public string option_windows_installer_header { get; set; }

    [GameMakerProperty("option_windows_interpolate_pixels")]
    public bool option_windows_interpolate_pixels { get; set; }

    [GameMakerProperty("option_windows_license")]
    public string option_windows_license { get; set; }

    [GameMakerProperty("option_windows_nsis_file")]
    public string option_windows_nsis_file { get; set; }

    [GameMakerProperty("option_windows_product_info")]
    public string option_windows_product_info { get; set; }

    [GameMakerProperty("option_windows_resize_window")]
    public bool option_windows_resize_window { get; set; }

    [GameMakerProperty("option_windows_save_location")]
    public int option_windows_save_location { get; set; }

    [GameMakerProperty("option_windows_scale")]
    public int option_windows_scale { get; set; }

    [GameMakerProperty("option_windows_sleep_margin")]
    public int option_windows_sleep_margin { get; set; }

    [GameMakerProperty("option_windows_splash_screen")]
    public string option_windows_splash_screen { get; set; }

    [GameMakerProperty("option_windows_start_fullscreen")]
    public bool option_windows_start_fullscreen { get; set; }

    [GameMakerProperty("option_windows_steam_use_alternative_launcher")]
    public bool option_windows_steam_use_alternative_launcher { get; set; }

    [GameMakerProperty("option_windows_texture_page")]
    public string option_windows_texture_page { get; set; }

    [GameMakerProperty("option_windows_use_raw_mouse")]
    public bool option_windows_use_raw_mouse  { get; set; }

    [GameMakerProperty("option_windows_use_splash")]
    public bool option_windows_use_splash { get; set; }

    [GameMakerProperty("option_windows_version")]
    public string option_windows_version { get; set; }

    [GameMakerProperty("option_windows_vsync")]
    public bool option_windows_vsync { get; set; }
}