namespace MagicLib
{
    public class Terrain : ICard
    {
        public CardColor CardColor => throw new System.NotImplementedException();
        public string Name => throw new System.NotImplementedException();
        public CardType Type => throw new System.NotImplementedException();
        public CardRarity Rarity => throw new System.NotImplementedException();
        public string Image => throw new System.NotImplementedException();
        public Mana GivenMana { get; set; }
    }
}
