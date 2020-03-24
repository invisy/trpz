using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using NotSimpleGame.DAL;
using NotSimpleGame.Models.General.Skins;
using NotSimpleGame.Models.General.Characters;
using NotSimpleGame.Models.General.Weapons;

namespace NotSimpleGame.Models
{
    class СharacterManagerModel : IСharacterManagerModel
    {
        private List<Character> characters;
        private List<Weapon> weapons;
        private List<Skin> skins;
        //private IDataLayer _dataLayer;
        
        public СharacterManagerModel()
        {
            //this._dataLayer = dataLayer;
        }

        public List<Character> getCharacters()
        {
            return new List<Character>();
        }
        public List<Weapon> getWeapons()
        {
            return new List<Weapon>();
        }
        public List<Skin> getSkins()
        {
            return new List<Skin>();
        }
    }
}
