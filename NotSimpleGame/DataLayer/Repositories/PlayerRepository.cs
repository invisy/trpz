using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.DataLayer.Entities;

namespace NotSimpleGame.DataLayer.Repositories
{
    public class PlayerRepository
    {
        private List<Player> _players = new List<Player>();

        public PlayerRepository()
        {
            Player player = new Player();
            player.money = 500;
            _players.Add(player);
        }

        public void Create(Player player)
        {
            _players.Add(player);
        }

        public Player Get(int id)
        {
            return new Player();
        }

        public IEnumerable<Player> GetList()
        {
            return _players;
        }

        public void Delete(int id)
        {

        }

        public void Update(Player player)
        {
        }

        public void Save()
        {

        }

        public void Dispose()
        {
        }
    }
}
