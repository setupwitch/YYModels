namespace YYModels.Models;

[YYVersion(0)]
public class GMPS5Options : GMOptionsBase
{
    [GameMakerProperty("option_ps5_display_cursor")]
    public bool option_ps5_display_cursor { get; set; }

    [GameMakerProperty("option_ps5_foreground_screen")]
    public string option_ps5_foreground_screen { get; set; }

    [GameMakerProperty("option_ps5_icon")]
    public string option_ps5_icon { get; set; }

    [GameMakerProperty("option_ps5_interpolate_pixels")]
    public bool option_ps5_interpolate_pixels { get; set; }

    [GameMakerProperty("option_ps5_max_display_height")]
    public int option_ps5_max_display_height { get; set; }

    [GameMakerProperty("option_ps5_max_display_width")]
    public int option_ps5_max_display_width { get; set; }

    [GameMakerProperty("option_ps5_nptitledat")]
    public string option_ps5_nptitledat { get; set; }

    [GameMakerProperty("option_ps5_nptitledat_file")]
    public string option_ps5_nptitledat_file { get; set; }

    [GameMakerProperty("option_ps5_paramsfo")]
    public string option_ps5_paramsfo { get; set; }

    [GameMakerProperty("option_ps5_paramsfo_file")]
    public string option_ps5_paramsfo_file { get; set; }

    [GameMakerProperty("option_ps5_passcode")]
    public string option_ps5_passcode { get; set; }

    [GameMakerProperty("option_ps5_save_data_icon")]
    public string option_ps5_save_data_icon { get; set; }

    [GameMakerProperty("option_ps5_scale")]
    public int option_ps5_scale { get; set; }

    [GameMakerProperty("option_ps5_sharedbinarysubconfigs")]
    public string option_ps5_sharedbinarysubconfigs { get; set; }

    [GameMakerProperty("option_ps5_shareoverlay_image")]
    public string option_ps5_shareoverlay_image { get; set; }

    [GameMakerProperty("option_ps5_splash_screen")]
    public string option_ps5_splash_screen { get; set; }

    [GameMakerProperty("option_ps5_texture_page")]
    public string option_ps5_texture_page { get; set; }

    [GameMakerProperty("option_ps5_trophy00trp_file")]
    public string option_ps5_trophy00trp_file { get; set; }

    [GameMakerProperty("option_ps5_trophy_screen")]
    public string option_ps5_trophy_screen { get; set; }

    [GameMakerProperty("option_ps5_trophyedit")]
    public string option_ps5_trophyedit { get; set; }
}