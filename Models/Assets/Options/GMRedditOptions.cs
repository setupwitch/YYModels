namespace YYModels.Models;

/// <remarks>Version 2</remarks>
public class GMRedditOptions : GMOptionsBase
{
    [GameMakerProperty("option_reddit_devvit_project_id")]
    public string option_reddit_devvit_project_id { get; set; }

    [GameMakerProperty("option_reddit_devvit_project_path")]
    public string option_reddit_devvit_project_path { get; set; }

    [GameMakerProperty("option_reddit_display_cursor")]
    public bool option_reddit_display_cursor { get; set; }

    [GameMakerProperty("option_reddit_game_name")]
    public string option_reddit_game_name { get; set; }

    [GameMakerProperty("option_reddit_interpolate_pixels")]
    public bool option_reddit_interpolate_pixels { get; set; }

    [GameMakerProperty("option_reddit_scale")]
    public int option_reddit_scale { get; set; }

    [GameMakerProperty("option_reddit_texture_page")]
    public string option_reddit_texture_page { get; set; }

    [GameMakerProperty("option_reddit_transparent_background")]
    public bool option_reddit_transparent_background { get; set; }
}