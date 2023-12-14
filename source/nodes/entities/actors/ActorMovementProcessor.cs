using Godot;
using Reoria.Enumerations;
using static Reoria.Extensions.Enumerations.DirectionExtensions;

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
    private Direction direction = Direction.Down;
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
            this.direction = CalculateDirectionFromVector2(this.Parent.Velocity);

            _ = this.Parent.MoveAndSlide();
        }

        this.Parent.AnimationPlayer.Play($"actor_animations/{this.state}_{this.direction}".ToLower(), 0, this.Speed / 16f * 2);

        base._PhysicsProcess(delta);
    }
}