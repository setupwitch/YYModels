namespace YYModels.Models;

[YYVersion(5)]
public class GMMainOptions : GMOptionsBase
{
    [GameMakerProperty("option_allow_instance_change")]
    public bool option_allow_instance_change { get; set; }

    [GameMakerProperty("option_audio_error_behaviour")]
    public bool option_audio_error_behaviour { get; set; }

    [GameMakerProperty("option_author")]
    public string option_author { get; set; }

    [GameMakerProperty("option_collision_compatibility")]
    public bool option_collision_compatibility { get; set; }

    [GameMakerProperty("option_copy_on_write_enabled")]
    public bool option_copy_on_write_enabled { get; set; }

    [GameMakerProperty("option_draw_colour")]
    public uint option_draw_colour { get; set; }

    [GameMakerProperty("option_game_speed")]
    public int option_game_speed { get; set; }

    [GameMakerProperty("option_gameguid")]
    public string option_gameguid { get; set; } = System.Guid.NewGuid().ToString();

    [GameMakerProperty("option_gameid")]
    public string option_gameid { get; set; }

    [GameMakerProperty("option_legacy_json_parsing")]
    public bool option_legacy_json_parsing { get; set; }

    [GameMakerProperty("option_legacy_number_conversion")]
    public bool option_legacy_number_conversion { get; set; }

    [GameMakerProperty("option_legacy_other_behaviour")]
    public bool option_legacy_other_behaviour { get; set; }

    [GameMakerProperty("option_legacy_primitive_drawing")]
    public bool option_legacy_primitive_drawing { get; set; }

    [GameMakerProperty("option_mips_for_3d_textures")]
    public bool option_mips_for_3d_textures { get; set; }

    [GameMakerProperty("option_remove_unused_assets")]
    public bool option_remove_unused_assets { get; set; }

    [GameMakerProperty("option_sci_usesci")]
    public bool option_sci_usesci { get; set; }

    [GameMakerProperty("option_spine_licence")]
    public bool option_spine_licence { get; set; }

    [GameMakerProperty("option_steam_app_id")]
    public string option_steam_app_id { get; set; }

    [GameMakerProperty("option_template_description")]
    public string? option_template_description { get; set; }

    [GameMakerProperty("option_template_icon")]
    public string option_template_icon { get; set; }

    [GameMakerProperty("option_template_image")]
    public string option_template_image { get; set; }

    [GameMakerProperty("option_window_colour")]
    public uint option_window_colour { get; set; }
}