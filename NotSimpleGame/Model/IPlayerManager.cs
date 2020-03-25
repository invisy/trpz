using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Models.General;
using NotSimpleGame.Models.General.Characters;
using NotSimpleGame.Models.General.Skins;
using NotSimpleGame.Models.General.Weapons;

namespace NotSimpleGame.Models
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
