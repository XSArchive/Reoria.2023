using Godot;

namespace Reoria.Nodes.Interfaces;

/// <summary>
/// Provides a common properties and functions for a <see cref="Node"/> with a <see cref="Sprite2D"/>.
/// </summary>
public interface INodeWithSprite
{
    /// <summary>
    /// A node that displays a 2D texture. The texture displayed can be a region from
    /// a larger atlas texture, or a frame from a sprite sheet animation.
    /// </summary>
    Sprite2D? Sprite { get; }
}
