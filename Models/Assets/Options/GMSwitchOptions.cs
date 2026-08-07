namespace YYModels.Models;

[YYVersion(0)]
public class GMSwitchOptions : GMOptionsBase
{
    [GameMakerProperty("option_switch_allow_debug_output")]
    public bool option_switch_allow_debug_output { get; set; }

    [GameMakerProperty("option_switch_check_nsp_publish_errors")]
    public bool option_switch_check_nsp_publish_errors { get; set; }

    [GameMakerProperty("option_switch_enable_fileaccess_checking")]
    public bool option_switch_enable_fileaccess_checking { get; set; }

    [GameMakerProperty("option_switch_enable_nex_libraries")]
    public bool option_switch_enable_nex_libraries { get; set; }

    [GameMakerProperty("option_switch_enable_npln_libraries")]
    public bool option_switch_enable_npln_libraries { get; set; }

    [GameMakerProperty("option_switch_gfx_mem_mb")]
    public int option_switch_gfx_mem_mb { get; set; }

    [GameMakerProperty("option_switch_interpolate_pixels")]
    public bool option_switch_interpolate_pixels { get; set; }

    [GameMakerProperty("option_switch_project_nmeta")]
    public string option_switch_project_nmeta { get; set; }

    [GameMakerProperty("option_switch_scale")]
    public int option_switch_scale { get; set; }

    [GameMakerProperty("option_switch_splash_screen")]
    public string option_switch_splash_screen { get; set; }

    [GameMakerProperty("option_switch_texture_page")]
    public string option_switch_texture_page { get; set; }

    [GameMakerProperty("option_switch_use_splash")]
    public bool option_switch_use_splash { get; set; }
}