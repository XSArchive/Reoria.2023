using Godot;

namespace Reoria.Nodes.Entities.Actors;

public partial class ActorMovementProcessor : Node2D
{
    [Export]
    public Actor Parent { get; private set; }
    [Export]
    public Vector2 Input = Vector2.Zero;
    [Export]
    public float Speed = 16f;

    public override void _Ready()
    {
        this.Parent = this.GetOwner<Actor>();
        this.Input = Vector2.Zero;

        base._Ready();
    }

    public override void _PhysicsProcess(double delta)
    {
        this.Parent.Velocity = this.Input * this.Speed;

        if (this.Parent.Velocity != Vector2.Zero)
        {
            _ = this.Parent.MoveAndSlide();
        }

        base._PhysicsProcess(delta);
    }
}