using Godot;

namespace Reoria.Godot.Nodes.Entities.Interfaces;

/// <summary>
/// Provides a common properties and functions for Entity <see cref="Node"/>s.
/// </summary>
public interface IEntity
{
    /// <summary>
    /// A node that provides a <see cref="Shape2D"/> to a <see cref="CollisionObject2D"/> parent and
    /// allows to edit it. This can give a detection shape to an <see cref="Area2D"/> or turn
    /// a <see cref="PhysicsBody2D"/> into a solid object.
    /// </summary>
    CollisionShape2D? CollisionShape { get; }
}
