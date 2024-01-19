using Godot;
using Reoria.Nodes.Entities.Interfaces;

namespace Reoria.Godot.Nodes.Entities;

/// <summary>
/// Defines the properties and functions of entity nodes that inherit from <see cref="CharacterBody2D"/>.
/// </summary>
public partial class KinematicEntity : CharacterBody2D, IKinematicEntity
{
	/// <summary>
	/// A node that provides a <see cref="Shape2D"/> to a <see cref="CollisionObject2D"/> parent and
	/// allows to edit it. This can give a detection shape to an <see cref="Area2D"/> or turn
	/// a <see cref="PhysicsBody2D"/> into a solid object.
	/// </summary>
	public CollisionShape2D? CollisionShape { get; protected set; }

	/// <summary>
	/// Called when the node is "ready", i.e. when both the node and its children have
	/// entered the scene tree. If the node has children, their <see cref="Node._Ready"/> 
	/// callbacks get triggered first, and the parent node will receive the ready 
	/// notification afterwards.
	/// </summary>
	public override void _Ready()
	{
		// Fetch and assign the owner node variable.
		this.CollisionShape = this.GetNode<CollisionShape2D?>("CollisionShape");

		// Pass to the base class' function.
		base._Ready();
	}
}
