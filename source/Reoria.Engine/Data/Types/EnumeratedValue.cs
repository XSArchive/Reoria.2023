namespace Reoria.Engine.Data.Types;

/// <summary>
/// Stores values of <typeparamref name="TValue"/> in an array using the values of <typeparamref name="TEnum"/> as the array keys.
/// </summary>
/// <typeparam name="TEnum">The enumeration to use as the array keyring.</typeparam>
/// <typeparam name="TValue">The type of the values being stored.</typeparam>
[Serializable]
public class EnumeratedValue<TEnum, TValue> where TEnum: Enum
{
    /// <summary>
    /// The values array that stores values at specified enumeration values. 
    /// </summary>
    protected readonly TValue[] values;
    /// <summary>
    /// The minimum value in the enumeration values list.
    /// </summary>
    protected readonly int lower;
    /// <summary>
    /// The maximum value in the enumeration values list.
    /// </summary>
    protected readonly int upper;

    /// <summary>
    /// Constructs a new <see cref="EnumeratedValue{TEnum, TValue}"/> class instance.
    /// </summary>
    public EnumeratedValue()
    {
        // Generate and store a list of the values in the enumeration.
        IEnumerable<TEnum> _enumValues = Enum.GetValues(typeof(TEnum)).Cast<TEnum>();

        // Generate the value array.
        this.lower = Convert.ToInt32(_enumValues.Min());
        this.upper = Convert.ToInt32(_enumValues.Max());
        this.values = new TValue[1 + this.upper - this.lower];
    }

    /// <summary>
    /// Returns or sets the value in the array at the specified key.
    /// </summary>
    /// <param name="key">The <see cref="Enum"/> value to use as the array key.</param>
    /// <returns>The value in the array at the specified key.</returns>
    public TValue this[TEnum key]
    {
        get => this.GetValue(key);
        set => this.SetValue(key, value);
    }

    /// <summary>
    /// Converts an <see cref="Enum"/> value to an array key.
    /// </summary>
    /// <param name="key">The <see cref="Enum"/> value to convert to an array key.</param>
    /// <returns>The array key.</returns>
    protected int ConvertEnumToKey(TEnum key) =>
        // Remove the lower bound of the enum and return the value.
        Convert.ToInt32(key) - this.lower;

    /// <summary>
    /// Stores the value in the array at the specified key.
    /// </summary>
    /// <param name="key">The <see cref="Enum"/> value to use as the array key.</param>
    /// <param name="value">The value to store the value in the array at the specified key.</param>
    public virtual void SetValue(TEnum key, TValue value) =>
        // Store the value in the array at the specified key.
        this.values[this.ConvertEnumToKey(key)] = value;

    /// <summary>
    /// Returns the value in the array at the specified key.
    /// </summary>
    /// <param name="key">The <see cref="Enum"/> value to use as the array key.</param>
    /// <returns>The value in the array at the specified key.</returns>
    public virtual TValue GetValue(TEnum key) =>
        // Return the value in the array at the specified key.
        this.values[this.ConvertEnumToKey(key)];

    /// <summary>
    /// Returns the value in the array at the specified key, or the default value if no value exists in the array.
    /// </summary>
    /// <param name="key">The <see cref="Enum"/> value to use as the array key.</param>
    /// <param name="defaultValue">The default value to return if no value exists in the array.</param>
    /// <returns>Returns the value in the array at the specified key, or the default value if no value exists in the array.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public virtual TValue GetValue(TEnum key, TValue defaultValue)
    {
        // Check to see if the default value passed is null.
        if (defaultValue is null) { throw new ArgumentNullException(nameof(defaultValue)); }

        // Return the value in the array at the specified key, or the default value if no value exists in the array.
        return this.values[this.ConvertEnumToKey(key)] ?? defaultValue;
    }
}
