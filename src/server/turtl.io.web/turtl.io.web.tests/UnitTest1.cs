using NUnit.Framework;
using turtl.io.web;

namespace Tests
{
    [TestFixture]
    public class DeckTests
    {
        private Deck _deck;

        [SetUp]
        public void Setup()
        {
            _deck = new Deck();
        }

        [Test]
        public void Test1()
        {
            Assert.That(_deck.CardsRemaining.Count, Is.EqualTo(50));

            var card = _deck.Draw();

            Assert.That(_deck.CardsRemaining.Count, Is.EqualTo(49));
        }
    }
}
