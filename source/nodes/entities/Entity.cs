using Godot;
using Reoria.Data.Entities;

namespace Reoria.Nodes.Entities;

public partial class Entity : CharacterBody2D
{
    [Export]
    public EntityData Data { get; private set; }
    [Export]
    public CollisionShape2D CollisionShape { get; private set; }

    public override void _Ready()
    {
        this.Data ??= this.GetNode<EntityData>("Data");

        base._Ready();
	}

    public override void _Process(double delta)
    {
        this.Data.Position = this.Position;

        base._Process(delta);
    }
}
