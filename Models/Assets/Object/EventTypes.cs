namespace YYModels.Models;
// taken from 
// https://github.com/UnderminersTeam/UndertaleModTool/blob/master/UndertaleModLib/Models/UndertaleGameObject.cs
// and tweaked

/// <summary>
/// The types of <see cref="GMEvent.EventType"/>.
/// </summary>
/// <remarks>Note, that subtypes exist as well.</remarks>
public enum EventTypeEnum
{
    /// <summary>
    /// A creation event type. Has no subtypes, it's always 0
    /// </summary>
    Create = 0,
    /// <summary>
    /// A destroy event type. Has no subtypes, it's always 0.
    /// </summary>
    Destroy = 1,
    /// <summary>
    /// An alarm event type. The subtype is 0-11, depending on the alarm id.
    /// </summary>
    Alarm = 2,
    /// <summary>
    /// A step event type.
    /// </summary>
    Step = 3, // subtype is EventSubtypeStep
    /// <summary>
    /// A collision event type. The subtype is always 0.
    /// </summary>
    Collision = 4,
    /// <summary>
    /// A key down event type.
    /// </summary>
    Keyboard = 5,
    /// <summary>
    /// A mouse event type.
    /// </summary>
    Mouse = 6, // subtype is EventSubtypeMouse
    /// <summary>
    /// A miscellaneous event type.
    /// </summary>
    Other = 7,
    /// <summary>
    /// A draw event type.
    /// </summary>
    Draw = 8,
    /// <summary>
    /// A key pressed event type.
    /// </summary>
    KeyPress = 9,
    /// <summary>
    /// A key released event type.
    /// </summary>
    KeyRelease = 10,
    /// <summary>
    /// A trigger event type. Only used in Pre- GameMaker Studio.
    /// </summary>
    Trigger = 11, // no subtypes, always 0
    /// <summary>
    /// A cleanup event type. Has no subtypes, always 0.
    /// </summary>
    CleanUp = 12,
    /// <summary>
    /// A gesture event type.
    /// </summary>
    Gesture = 13,
}