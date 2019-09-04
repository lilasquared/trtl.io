using System;
using System.Collections.Generic;
using System.Linq;

namespace turtl.io.web
{
    public class Turtle
    {
        public Int32 Id { get; set; }
        public Color Color { get; set; }
        public Int32 X { get; set; }
        public Int32 Y { get; set; }

        public Turtle TurtleBehind { get; set; }
        public Turtle TurtleInfront { get; set; }
        public IList<Turtle> TurtlesOnTop { get; set; }

        public Turtle(Int32 id, Color color)
        {
            Id = id;
            Color = color;
        }

        public static List<Turtle> AllTurtles = new List<Turtle>
        {
            new Turtle(1, Color.Red),
            new Turtle(2, Color.Red),
            new Turtle(3, Color.Green),
            new Turtle(4, Color.Green),
            new Turtle(5, Color.Blue),
            new Turtle(6, Color.Blue),
            new Turtle(7, Color.Yellow),
            new Turtle(8, Color.Yellow),
            new Turtle(9, Color.Purple),
            new Turtle(10, Color.Purple),
            new Turtle(11, Color.Black),
            new Turtle(12, Color.Black)
        };
    }

    public class TurtleTrack
    {
        public IList<Turtle> Turtles { get; set; }
        //public IList<IList<Turtle>> Turtles { get; set; }

        public TurtleTrack()
        {
            var rng = new Random();
            Turtles = Turtle.AllTurtles
                .OrderBy(x => rng.Next())
                .Select((turtle, index) =>
                {
                    turtle.X = index;
                    return turtle;
                })
                .ToList();
        }

        public void MoveTurtle(Int32 id, Int32 movement)
        {
            var turtle = Turtles.First(x => x.Id == id);
            var stack = Turtles.Where(x => x.X == turtle.X && x.Y >= turtle.Y);

            foreach(var t in stack)
            {
                t.X += movement;

            }
        }
    }
}
