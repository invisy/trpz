using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Collections.ObjectModel;

using NotSimpleGame.Models;
using NotSimpleGame.Models.General;
using NotSimpleGame.Models.General.Characters;
using NotSimpleGame.Models.General.Skins;
using NotSimpleGame.Models.General.Weapons;

namespace NotSimpleGame.UI.ViewModels
{
    public interface ISelectCharacterMenuVM : INotifyPropertyChanged
    {
        ObservableCollection<Character> Characters { get; }
        ObservableCollection<Weapon> Weapons { get; }
        ObservableCollection<Skin> Skins { get; }
        float Money { get; }

        Character SelectedCharacter { get; set; }
        Weapon SelectedWeapon { get; set; }
        Skin SelectedSkin { get; set; }

        RelayCommand GoNextCommand { get; }
    }
}
