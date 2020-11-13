using System.Collections.Generic;

namespace MagicLib
{
    public class Creature : ICard
    {
        public CardColor CardColor => throw new System.NotImplementedException();
        public string Name => throw new System.NotImplementedException();
        public CardType Type => throw new System.NotImplementedException();
        public CardRarity Rarity => throw new System.NotImplementedException();
        public string Image => throw new System.NotImplementedException();
        public List<Mana> Cost { get; }
        public Stats Status { get; set; }
        public string Description { get; set; }
        public List<CreatureSpecies> Species { get; set; }
        public List<Action> Actions { get; set; }
    }
}
