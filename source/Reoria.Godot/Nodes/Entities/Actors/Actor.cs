using Godot;
using Reoria.Godot.Nodes.Entities.Actors.Players.Interfaces;

namespace Reoria.Godot.Nodes.Entities.Actors.Players;

public partial class Actor : KinematicEntity, IActor
{
    /// <summary>
    /// A node that displays a 2D texture. The texture displayed can be a region from
    /// a larger atlas texture, or a frame from a sprite sheet animation.
    /// </summary>
	public Sprite2D? Sprite { get; protected set; }

    /// <summary>
    /// Called when the node is "ready", i.e. when both the node and its children have
    /// entered the scene tree. If the node has children, their <see cref="Node._Ready"/> 
    /// callbacks get triggered first, and the parent node will receive the ready 
    /// notification afterwards.
    /// </summary>
    public override void _Ready()
    {
        // Fetch and assign the owner node variable.
        this.Sprite = this.GetNode<Sprite2D?>("Sprite");

        // Pass to the base class' function.
        base._Ready();
    }
}
