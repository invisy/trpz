using NotSimpleGame.Models;
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
