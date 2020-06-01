using NotSimpleGame.Models;
using NotSimpleGame.Models.Characters;
using NotSimpleGame.Models.Skins;
using NotSimpleGame.Models.Weapons;
using System.Collections.Generic;

namespace NotSimpleGame.BL.Abstraction
{
    public interface IPlayerManager
    {
        IEnumerable<Character> getCharacters();
        IEnumerable<Weapon> getWeapons(Character selectedCharacter);
        IEnumerable<Skin> getSkins(Character selectedCharacter);
        Player getPlayerInfo();
        void SavePlayerInfo(Weapon weapon, Skin skin);
    }
}
