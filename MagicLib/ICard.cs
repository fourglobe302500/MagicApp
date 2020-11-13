namespace MagicLib
{
    public interface ICard
    {
        CardColor CardColor { get; }
        string Name { get; }
        CardType Type { get; }
        CardRarity Rarity { get; }
        string Image { get; }
    }
}
