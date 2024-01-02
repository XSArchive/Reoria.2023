using Godot;

namespace Reoria.Godot.Data.Types;

public abstract partial class EnumeratedType<TEnum, TValue> : Node where TEnum : Enum
{
    private readonly Dictionary<TEnum, TValue> values;

    public EnumeratedType() => this.values = new Dictionary<TEnum, TValue>();
    public EnumeratedType(Dictionary<TEnum, TValue> values) => this.values = values;

    public EnumeratedType<TEnum, TValue> Populate()
    {
        foreach (TEnum key in Enum.GetValues(typeof(TEnum)))
        {
            this.values.Add(key, default);
        }

        return this;
    }

    public virtual TValue GetValue(TEnum key, TValue defaultValue = default) => !this.values.ContainsKey(key) ? defaultValue : this.values[key];

    public virtual void SetValue(TEnum key, TValue value)
    {
        if (!this.values.ContainsKey(key)) { this.values.Add(key, value); }

        this.values[key] = value;
    }
}