namespace Reoria.Framework.Core.Interfaces;

/// <summary>
/// Provides a mechanism for accessing the owner of an <see cref="object"/>.
/// </summary>
/// <typeparam name="TOwnerType">The <see cref="Type"/> of the owner of this <see cref="object"/>.</typeparam>
public interface IOwnerPattern<TOwnerType> : IDisposable
{
    /// <summary>
    /// Defines the reference to the owner of this <see cref="object"/>.
    /// </summary>
    TOwnerType? Owner { get; }
}
