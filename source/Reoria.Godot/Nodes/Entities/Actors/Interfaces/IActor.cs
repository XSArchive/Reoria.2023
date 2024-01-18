using Godot;
using Reoria.Godot.Nodes.Entities.Interfaces;
using Reoria.Godot.Nodes.Interfaces;

namespace Reoria.Godot.Nodes.Entities.Actors.Players.Interfaces;

/// <summary>
/// Provides a common properties and functions for <see cref="Actor"/> <see cref="Node"/>s.
/// </summary>
public interface IActor : IKinematicEntity, INodeWithSprite
{
}
