namespace YYModels.Models;

/// <remarks>Version 0</remarks>
[GMResource("shaders")]
public class GMShader : ResourceBase
{
    /// <summary>
    /// The type of the shader, see <see cref="ShaderType"/>.
    /// </summary>'
    [GameMakerProperty("type")]
    public ShaderType Type { get; set; }
    
    /// <summary>
    /// The type of the shader.
    /// </summary>
    public enum ShaderType
    {
        GLSLES = 1,
        GLSL = 2,
        
        /// <remarks>
        /// A pre-compiled shader.
        /// </remarks>
        HLSL11 = 3,
        
        /// <remarks>
        /// A pre-compiled shader.
        /// </remarks>
        PSSL = 4,
    }
    
}