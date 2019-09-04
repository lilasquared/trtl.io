using System;
using System.Collections.Generic;
using System.Linq;

namespace turtl.io.web
{
    public interface IGameRepository
    {
        IEnumerable<Game> GetGames();
        Game GetGame(Guid id);
        Game CreateGame();
    }

    //TODO: Persist
    public class GameRepository : IGameRepository
    {
        public IList<Game> Games { get; }


        public GameRepository()
        {
            Games = new List<Game>();
        }

        public IEnumerable<Game> GetGames()
        {
            return Games.AsEnumerable();
        }

        public Game GetGame(Guid id)
        {
            return Games.FirstOrDefault(x => x.Id == id);
        }

        public Game CreateGame()
        {
            var game = new Game();
            Games.Add(game);
            return game;
        }

    }

    public class Game
    {
        public Guid Id { get; set; }
        public Deck Deck { get; set; }
        public TurtleTrack Track { get; set; }

        public Game()
        {
            Id = Guid.NewGuid();
            Deck = new Deck();
            Track = new TurtleTrack();
        }
    }
}
