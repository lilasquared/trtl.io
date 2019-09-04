using System;
using System.Collections.Generic;
using System.Linq;

namespace turtl.io.web
{
    public class Deck
    {
        public IDictionary<Int32, Card> Cards { get; }
        public IList<Int32> CardsRemaining { get; }
        private readonly Random rng;

        public Deck()
        {
            Cards = new Dictionary<Int32, Card>
            {
                { 1, new LettuceCard(1) },
                { 2, new LettuceCard(2) },
                { 3, new LettuceCard(3) },
                { 4, new ToppleCard(4) },
                { 5, new ToppleCard(5) },
                { 6, new ToppleCard(6) },
                { 7, new ToppleCard(7) },
                { 8, new ToppleCard(8) },
                { 9, new ToppleCard(9) },
                { 10, new MovementCard(10, Color.Rainbow, 1) },
                { 11, new MovementCard(11, Color.Rainbow, 1) },
                { 12, new MovementCard(12, Color.Rainbow, 1) },
                { 13, new MovementCard(13, Color.Rainbow, 1) },
                { 14, new MovementCard(14, Color.Rainbow, 1) },
                { 15, new MovementCard(15, Color.Rainbow, 1) },
                { 16, new MovementCard(16, Color.Rainbow, 2) },
                { 17, new MovementCard(17, Color.Rainbow, 2) },
                { 18, new MovementCard(18, Color.Rainbow, 2) },
                { 19, new MovementCard(19, Color.Rainbow, 2) },
                { 20, new MovementCard(20, Color.Rainbow, 2) },
                { 21, new MovementCard(21, Color.Rainbow, 2) },
                { 22, new MovementCard(22, Color.Rainbow, -1) },
                { 23, new MovementCard(23, Color.Rainbow, -1) },
                { 24, new MovementCard(24, Color.Rainbow, -1) },
                { 25, new MovementCard(25, Color.Rainbow, -2) },
                { 26, new MovementCard(26, Color.Rainbow, -2) },
                { 27, new MovementCard(27, Color.Rainbow, -2) },
                { 28, new MovementCard(28, Color.Rainbow, -2) },
                { 29, new MovementCard(29, Color.Rainbow, -3) },
                { 30, new MovementCard(30, Color.Rainbow, -3) },
                { 31, new MovementCard(31, Color.Blue, -2) },
                { 32, new MovementCard(32, Color.Blue, 2) },
                { 33, new MovementCard(33, Color.Blue, 2) },
                { 34, new MovementCard(34, Color.Blue, 3) },
                { 35, new MovementCard(35, Color.Red, -2) },
                { 36, new MovementCard(36, Color.Red, 2) },
                { 37, new MovementCard(37, Color.Red, 2) },
                { 38, new MovementCard(38, Color.Red, 3) },
                { 39, new MovementCard(39, Color.Yellow, -2) },
                { 40, new MovementCard(40, Color.Yellow, 2) },
                { 41, new MovementCard(41, Color.Yellow, 2) },
                { 42, new MovementCard(42, Color.Yellow, 3) },
                { 43, new MovementCard(43, Color.Green, -2) },
                { 44, new MovementCard(44, Color.Green, 2) },
                { 45, new MovementCard(45, Color.Green, 2) },
                { 46, new MovementCard(46, Color.Green, 3) },
                { 47, new MovementCard(47, Color.Purple, -2) },
                { 48, new MovementCard(48, Color.Purple, 2) },
                { 49, new MovementCard(49, Color.Purple, 2) },
                { 50, new MovementCard(50, Color.Purple, 3) },
            };
            rng = new Random();
            CardsRemaining = Enumerable.Range(1, 50).Select(x => x).ToList();
        }

        public Card Draw()
        {
            var index = rng.Next(CardsRemaining.Count);
            var key = CardsRemaining[index];
            var card = Cards[key];

            CardsRemaining.Remove(key);
            return card;
        }
    }
}
