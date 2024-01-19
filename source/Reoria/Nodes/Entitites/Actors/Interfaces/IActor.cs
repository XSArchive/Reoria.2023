using Godot;
using Reoria.Nodes.Entities.Interfaces;
using Reoria.Nodes.Interfaces;

namespace Reoria.Nodes.Entities.Actors.Players.Interfaces;

/// <summary>
/// Provides a common properties and functions for <see cref="Actor"/> <see cref="Node"/>s.
/// </summary>
public interface IActor : IKinematicEntity, INodeWithSprite
{
}
