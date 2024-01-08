using Godot;
using Reoria.Godot.Nodes.Core;

namespace Reoria.Godot.Scenes;

/// <summary>
/// Defines functionality of the game's root <see cref="Node"/>.
/// </summary>
public partial class GameContainer : Node
{
	/// <summary>
	/// Defines the reference to the <see cref="Nodes.Core.Camera"/>.
	/// </summary>
	[Export]
	public Camera? Camera { get; protected set; }

	/// <summary>
	/// Called when the node is "ready", i.e. when both the node and its children have
	/// entered the scene tree. If the node has children, their <see cref="Node._Ready"/> 
	/// callbacks get triggered first, and the parent node will receive the ready 
	/// notification afterwards.
	/// </summary>
	public override void _Ready()
	{
		// Fetch and assign the child node variables if they have not been assigned yet.
		this.Camera ??= this.GetNode<Camera>("Camera");

		// Pass to the base class' function.
		base._Ready();
	}
}
