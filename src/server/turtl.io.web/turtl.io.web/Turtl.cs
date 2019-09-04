using System;
using System.Collections.Generic;
using DotNetify;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace turtl.io.web
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Color
    {
        Blue,
        Green,
        Red,
        Yellow,
        Purple,
        Black,
        Rainbow
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CardType
    {
        Lettuce,
        Topple,
        Movement
    }

    public class Turtl : MulticastVM
    {
        public IEnumerable<Card> Cards;

        private IEnumerable<Game> Games { get; set; }
        private readonly IConnectionContext _connectionContext;
        private readonly IGameRepository _repo;

        public Turtl(IConnectionContext connectionContext, IGameRepository repo)
        {
            _connectionContext = connectionContext;
            _repo = repo;

            Games = _repo.GetGames();
            AddProperty("Games", Games);
        }

        public Action CreateGame => () =>
        {
            _repo.CreateGame();
            Games = _repo.GetGames();
            Changed("Games");
        };
    }
}
