using Godot;
using Reoria.Framework.Core.Interfaces;
using Reoria.Godot.Scenes;

namespace Reoria.Godot.Nodes.Core;

/// <summary>
/// Defines functionality and logic for the primary <see cref="Camera2D"/>.
/// </summary>
public partial class Camera : Camera2D, IOwnerPattern<GameContainer>
{
	/// <summary>
	/// Defines the reference to the owner of this <see cref="Node"/>.
	/// </summary>
	public new GameContainer? Owner { get; protected set; }

	/// <summary>
	/// Called when the node is "ready", i.e. when both the node and its children have
	/// entered the scene tree. If the node has children, their <see cref="Node._Ready"/> 
	/// callbacks get triggered first, and the parent node will receive the ready 
	/// notification afterwards.
	/// </summary>
	public override void _Ready()
	{
        // Fetch and assign the child node variables.
        this.Owner = this.GetOwner<GameContainer>();

		// Pass to the base class' function.
		base._Ready();
	}
}
