using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Models.General.Characters;
using NotSimpleGame.Models.General.Skins;
using NotSimpleGame.Models.General.Weapons;

namespace NotSimpleGame.Models
{
    interface IСharacterManagerModel
    {
        List<Character> getCharacters();
        List<Weapon> getWeapons();
        List<Skin> getSkins();
    }
}
