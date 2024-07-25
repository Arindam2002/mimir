using Bencodex.Types;

namespace Lib9c.Models.Item;

/// <summary>
/// <see cref="Nekoyume.Model.Item.Ring"/>
/// </summary>
public record Ring : Equipment
{
    public Ring(IValue bencoded) : base(bencoded)
    {
    }
}
