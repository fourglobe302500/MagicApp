using System.Collections.Generic;

namespace MagicLib
{
    public class Player
    {
        public List<Deck> Decks { get; set; } = new List<Deck>();
        public Deck CurrentDeck { get; set; }
        public List<ICard> Grimoire { get; set; }
        public List<ICard> Graveyard { get; set; }
        public List<ICard> Hand { get; set; }
        public List<ICard> Camp { get; set; }
        public List<Terrain> Territories { get; set; }
        public bool HasPlayedTerrain { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public string PassWord { get; }
        public int id { get; }
        public int HP { get; set; }
        public List<Mana> ManaToUse { get; set; }
    }
}