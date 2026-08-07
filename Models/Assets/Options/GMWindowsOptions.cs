namespace YYModels.Models;

[YYVersion(2)]
public class GMWindowsOptions : GMOptionsBase
{
    [GameMakerProperty("option_windows_allow_fullscreen_switching")]
    public bool AllowFullscreenSwitching { get; set; }

    [GameMakerProperty("option_windows_borderless")]
    public bool EnableBorderlessWindowed { get; set; }

    [GameMakerProperty("option_windows_company_info")]
    public string CompanyInfo { get; set; }

    [GameMakerProperty("option_windows_copy_exe_to_dest")]
    public bool CopyExecutable { get; set; }

    [GameMakerProperty("option_windows_copyright_info")]
    public string CopyrightInfo { get; set; }
    
    /// <remarks>Written to options.ini</remarks>
    [GameMakerProperty("option_windows_d3dswapeffectdiscard")]
    public bool D3DSwapChainDiscard { get; set; }
    
    /// <remarks>Written to the runner executable</remarks>
    [GameMakerProperty("option_windows_description_info")]
    public string Description { get; set; }

    [GameMakerProperty("option_windows_disable_sandbox")]
    public bool DisableSandbox { get; set; }

    [GameMakerProperty("option_windows_display_cursor")]
    public bool DisplayCursor { get; set; }

    [GameMakerProperty("option_windows_display_name")]
    public string DisplayName { get; set; }

    [GameMakerProperty("option_windows_enable_steam")]
    public bool EnableSteam { get; set; }

    [GameMakerProperty("option_windows_executable_name")]
    public string option_windows_executable_name { get; set; }

    [GameMakerProperty("option_windows_icon")]
    public string IconPath { get; set; }

    /// <remarks>Written to the installer export</remarks>
    [GameMakerProperty("option_windows_installer_finished")]
    public string InstallerFinishedMessage { get; set; }

    /// <remarks>Written to the installer export</remarks>
    [GameMakerProperty("option_windows_installer_header")]
    public string InstallerHeaderMessage { get; set; }

    [GameMakerProperty("option_windows_interpolate_pixels")]
    public bool InterpolatePixels { get; set; }

    [GameMakerProperty("option_windows_license")]
    public string License { get; set; }

    [GameMakerProperty("option_windows_nsis_file")]
    public string NsisScriptFilePath { get; set; }

    /// <remarks>Written to the runner executable</remarks>
    [GameMakerProperty("option_windows_product_info")]
    public string ProductInfo { get; set; }

    
    [GameMakerProperty("option_windows_resize_window")]
    public bool AllowWindowResize { get; set; }

    /// <remarks>0 == "%LOCALAPPDATA%" | 1 == "%APPDATA%"</remarks>
    [GameMakerProperty("option_windows_save_location")]
    public int SaveLocation { get; set; }

    /// <remarks>0 == Keep aspect ratio | 1 == Full scale"</remarks>
    [GameMakerProperty("option_windows_scale")]
    public int WindowScale { get; set; }

    [GameMakerProperty("option_windows_sleep_margin")]
    public int SleepMargin { get; set; }

    [GameMakerProperty("option_windows_splash_screen")]
    public string SplashScreenPath { get; set; }

    [GameMakerProperty("option_windows_start_fullscreen")]
    public bool StartInFullscreen { get; set; }

    [GameMakerProperty("option_windows_steam_use_alternative_launcher")]
    public bool UseAlternativeSteamLauncher { get; set; }

    [GameMakerProperty("option_windows_texture_page")]
    public string TexturePageDimensions { get; set; }

    [GameMakerProperty("option_windows_use_raw_mouse")]
    public bool UseRawMouseInput  { get; set; }

    [GameMakerProperty("option_windows_use_splash")]
    public bool UseSplashScreen { get; set; }

    [GameMakerProperty("option_windows_version")]
    public string Version { get; set; }

    [GameMakerProperty("option_windows_vsync")]
    public bool EnableVsync { get; set; }
}