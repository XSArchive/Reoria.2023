using Godot;

namespace Reoria.Godot.Nodes.Entities.Data;

public partial class EntityData : Node
{
    public Guid Guid = Guid.Empty;
    [Export]
    public string GuidString = string.Empty;
    [Export]
    public Vector2 Position = Vector2.Zero;

    public EntityData()
    {
        this.Guid = Guid.NewGuid();
        this.GuidString = this.Guid.ToString();
    }
}