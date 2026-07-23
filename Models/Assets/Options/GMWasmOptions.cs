namespace YYModels.Models;

[YYVersion(0)]
public class GMWasmOptions : GMOptionsBase
{
    [GameMakerProperty("option_wasm_game_name")]
    public string option_wasm_game_name { get; set; }

    [GameMakerProperty("option_wasm_icon")]
    public string option_wasm_icon { get; set; }

    [GameMakerProperty("option_wasm_interpolate_pixels")]
    public bool option_wasm_interpolate_pixels { get; set; }

    [GameMakerProperty("option_wasm_scale")]
    public int option_wasm_scale { get; set; }

    [GameMakerProperty("option_wasm_splash_screen")]
    public string option_wasm_splash_screen { get; set; }

    [GameMakerProperty("option_wasm_texture_page")]
    public string option_wasm_texture_page { get; set; }

    [GameMakerProperty("option_wasm_version")]
    public string option_wasm_version { get; set; }
}