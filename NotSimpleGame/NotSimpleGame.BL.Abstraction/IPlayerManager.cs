using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Models;
using NotSimpleGame.Models.Characters;
using NotSimpleGame.Models.Skins;
using NotSimpleGame.Models.Weapons;

namespace NotSimpleGame.BL.Abstraction
{
    public interface IPlayerManager
    {
        IEnumerable<Character> getCharacters();
        IEnumerable<Weapon> getWeapons(Character selectedCharacter);
        IEnumerable<Skin> getSkins(Character selectedCharacter);
        Player getPlayerInfo();
        void SavePlayerInfo(Character character, Weapon weapon, Skin skin);
    }
}
