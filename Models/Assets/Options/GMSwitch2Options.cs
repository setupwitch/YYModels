namespace YYModels.Models;

[YYVersion(0)]
public class GMSwitch2Options : GMOptionsBase
{
    [GameMakerProperty("option_switch2_allow_debug_output")]
    public bool option_switch2_allow_debug_output { get; set; }

    [GameMakerProperty("option_switch2_check_nsp_publish_errors")]
    public bool option_switch2_check_nsp_publish_errors { get; set; }

    [GameMakerProperty("option_switch2_enable_fileaccess_checking")]
    public bool option_switch2_enable_fileaccess_checking { get; set; }

    [GameMakerProperty("option_switch2_enable_nex_libraries")]
    public bool option_switch2_enable_nex_libraries { get; set; }

    [GameMakerProperty("option_switch2_enable_npln_libraries")]
    public bool option_switch2_enable_npln_libraries { get; set; }

    [GameMakerProperty("option_switch2_gfx_mem_mb")]
    public int option_switch2_gfx_mem_mb { get; set; }

    [GameMakerProperty("option_switch2_interpolate_pixels")]
    public bool option_switch2_interpolate_pixels { get; set; }

    [GameMakerProperty("option_switch2_project_nmeta")]
    public string option_switch2_project_nmeta { get; set; }

    [GameMakerProperty("option_switch2_scale")]
    public int option_switch2_scale { get; set; }

    [GameMakerProperty("option_switch2_splash_screen")]
    public string option_switch2_splash_screen { get; set; }

    [GameMakerProperty("option_switch2_texture_page")]
    public string option_switch2_texture_page { get; set; }

    [GameMakerProperty("option_switch2_use_splash")]
    public bool option_switch2_use_splash { get; set; }
}