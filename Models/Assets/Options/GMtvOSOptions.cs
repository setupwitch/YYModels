namespace YYModels.Models;

[YYVersion(1)]
public class GMtvOSOptions : GMOptionsBase
{
    [GameMakerProperty("option_tvos_build_number")]
    public int option_tvos_build_number { get; set; }

    [GameMakerProperty("option_tvos_bundle_name")]
    public string option_tvos_bundle_name { get; set; }

    [GameMakerProperty("option_tvos_display_cursor")]
    public bool option_tvos_display_cursor { get; set; }

    [GameMakerProperty("option_tvos_display_name")]
    public string option_tvos_display_name { get; set; }

    [GameMakerProperty("option_tvos_enable_broadcast")]
    public bool option_tvos_enable_broadcast { get; set; }

    [GameMakerProperty("option_tvos_icon_1280")]
    public string option_tvos_icon_1280 { get; set; }

    [GameMakerProperty("option_tvos_icon_400")]
    public string option_tvos_icon_400 { get; set; }

    [GameMakerProperty("option_tvos_icon_400_2x")]
    public string option_tvos_icon_400_2x { get; set; }

    [GameMakerProperty("option_tvos_interpolate_pixels")]
    public bool option_tvos_interpolate_pixels { get; set; }

    [GameMakerProperty("option_tvos_min_version")]
    public string option_tvos_min_version { get; set; }

    [GameMakerProperty("option_tvos_output_dir")]
    public string option_tvos_output_dir { get; set; }

    [GameMakerProperty("option_tvos_podfile_lock_path")]
    public string option_tvos_podfile_lock_path { get; set; }

    [GameMakerProperty("option_tvos_podfile_path")]
    public string option_tvos_podfile_path { get; set; }

    [GameMakerProperty("option_tvos_scale")]
    public int option_tvos_scale { get; set; }

    [GameMakerProperty("option_tvos_splash_time")]
    public int option_tvos_splash_time { get; set; }

    [GameMakerProperty("option_tvos_splashscreen")]
    public string option_tvos_splashscreen { get; set; }

    [GameMakerProperty("option_tvos_splashscreen_2x")]
    public string option_tvos_splashscreen_2x { get; set; }

    [GameMakerProperty("option_tvos_team_id")]
    public string option_tvos_team_id { get; set; }

    [GameMakerProperty("option_tvos_texture_page")]
    public string option_tvos_texture_page { get; set; }

    [GameMakerProperty("option_tvos_topshelf")]
    public string option_tvos_topshelf { get; set; }

    [GameMakerProperty("option_tvos_topshelf_2x")]
    public string option_tvos_topshelf_2x { get; set; }

    [GameMakerProperty("option_tvos_topshelf_wide")]
    public string option_tvos_topshelf_wide { get; set; }

    [GameMakerProperty("option_tvos_topshelf_wide_2x")]
    public string option_tvos_topshelf_wide_2x { get; set; }

    [GameMakerProperty("option_tvos_version")]
    public string option_tvos_version { get; set; }
}