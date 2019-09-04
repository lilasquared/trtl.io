using System;

namespace turtl.io.web
{
    public class Card
    {
        public Int32 Id { get; set; }
        public CardType Type { get; set; }

        public Card(Int32 id, CardType type)
        {
            Id = id;
            Type = type;
        }
    }
}
