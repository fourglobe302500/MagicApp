using System;
using System.Collections.Generic;

namespace MagicLib
{
    public class Deck
    {
        public List<ICard> Cards { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}