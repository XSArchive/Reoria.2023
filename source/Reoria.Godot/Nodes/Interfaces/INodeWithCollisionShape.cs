using Godot;

namespace Reoria.Godot.Nodes.Interfaces;

/// <summary>
/// Provides a common properties and functions for a <see cref="Node"/> with a <see cref="CollisionShape2D"/>.
/// </summary>
public interface INodeWithCollisionShape
{
    /// <summary>
    /// A node that provides a <see cref="Shape2D"/> to a <see cref="CollisionObject2D"/> parent and
    /// allows to edit it. This can give a detection shape to an <see cref="Area2D"/> or turn
    /// a <see cref="PhysicsBody2D"/> into a solid object.
    /// </summary>
    CollisionShape2D? CollisionShape { get; }
}
