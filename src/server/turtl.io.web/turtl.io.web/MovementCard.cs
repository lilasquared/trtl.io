using System;

namespace turtl.io.web
{
    public class MovementCard : Card
    {
        public Color Color { get; }
        public Int32 Number { get; }

        public MovementCard(Int32 id, Color color, Int32 number) : base(id, CardType.Movement)
        {
            Color = color;
            Number = number;
        }
    }
}
