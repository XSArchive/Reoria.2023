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

    [Export]
    private string state = "idle";
    [Export]
    private string direction = "down";
    public override void _Ready()
    {
        this.Parent = this.GetOwner<Actor>();
        this.Input = Vector2.Zero;

        base._Ready();
    }

    public override void _PhysicsProcess(double delta)
    {
        this.Parent.Velocity = this.Input * this.Speed;

        this.state = "idle";

        if (this.Parent.Velocity != Vector2.Zero)
        {
            this.state = "moving";

            if (this.Parent.Velocity.X < 0) { this.direction = "left"; }
            if (this.Parent.Velocity.X > 0) { this.direction = "right"; }
            if (this.Parent.Velocity.Y < 0) { this.direction = "up"; }
            if (this.Parent.Velocity.Y > 0) { this.direction = "down"; }

            _ = this.Parent.MoveAndSlide();
        }

        this.Parent.AnimationPlayer.Play($"actor_animations/{this.state}_{this.direction}", 0, this.Speed / 16f * 2);

        base._PhysicsProcess(delta);
    }
}