using System;
using System.Linq;
using NUnit.Framework;

namespace turtl.io.web.tests
{
    [TestFixture]
    public class GameTests
    {
        public GameTests()
        {
        }

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test() { }
    }

    [TestFixture]
    public class TurtleTrackTests
    {
        private TurtleTrack _track;
        [SetUp]
        public void Setup()
        {
            _track = new TurtleTrack();
        }

        [Test]
        public void All_Turtles_Start_At_0_Y()
        {
            Assert.That(_track.Turtles.All(x => x.Y == 0));
        }

        [Test]
        public void Moving_Stacks_Turtle()
        {
            var turtle = _track.Turtles.Last();

            Assert.That(turtle.X, Is.EqualTo(12));
            _track.MoveTurtle(turtle.Id, 1);
            Assert.That(turtle.X, Is.EqualTo(11));
        }

        [Test]
        public void Test()
        {
            var first = _track.Turtles.First();
            
            Assert.That(first.X, Is.EqualTo(0));
            _track.MoveTurtle(first.Id, -1);
            Assert.That(first.X, Is.EqualTo(1));
        }
    }
}
