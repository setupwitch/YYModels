namespace YYModels.Models;

[YYVersion(5)]
public class GMMainOptions : GMOptionsBase
{
    [GameMakerProperty("option_allow_instance_change")]
    public bool AllowInstanceChange { get; set; }

    [GameMakerProperty("option_audio_error_behaviour")]
    public bool EnableAudioErrorBehavior { get; set; }

    [GameMakerProperty("option_author")]
    public string Author { get; set; }

    [GameMakerProperty("option_collision_compatibility")]
    public bool EnableCollisionCompatibilityMode { get; set; }

    [GameMakerProperty("option_copy_on_write_enabled")]
    public bool EnableCopyOnWrite { get; set; }

    [GameMakerProperty("option_draw_colour")]
    public uint DrawColor { get; set; }

    [GameMakerProperty("option_game_speed")]
    public int GameSpeed { get; set; }

    [GameMakerProperty("option_gameguid")]
    public string GameGuid { get; set; } = Guid.NewGuid().ToString();

    [GameMakerProperty("option_gameid")]
    public string GameId { get; set; }

    [GameMakerProperty("option_legacy_json_parsing")]
    public bool EnableLegacyJsonParsing { get; set; }

    [GameMakerProperty("option_legacy_number_conversion")]
    public bool EnableLegacyNumberConversion { get; set; }

    [GameMakerProperty("option_legacy_other_behaviour")]
    public bool EnableLegacyOtherBehavior { get; set; }

    [GameMakerProperty("option_legacy_primitive_drawing")]
    public bool EnableLegacyPrimitiveDrawing { get; set; }

    [GameMakerProperty("option_mips_for_3d_textures")]
    public bool GenerateMipMapsFor3dTextures { get; set; }

    [GameMakerProperty("option_remove_unused_assets")]
    public bool RemoveUnusedAssets { get; set; }

    [GameMakerProperty("option_sci_usesci")]
    public bool UseSourceControl { get; set; }

    [GameMakerProperty("option_spine_licence")]
    public bool SpineLicense { get; set; }

    [GameMakerProperty("option_steam_app_id")]
    public string SteamAppId { get; set; }

    [GameMakerProperty("option_template_description")]
    public string? TemplateDescription { get; set; }

    [GameMakerProperty("option_template_icon")]
    public string TemplateIcon { get; set; }

    [GameMakerProperty("option_template_image")]
    public string TemplateImage { get; set; }

    [GameMakerProperty("option_window_colour")]
    public uint WindowColor { get; set; }
}