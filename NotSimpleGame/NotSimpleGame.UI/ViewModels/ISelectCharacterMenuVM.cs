
using NotSimpleGame.Models.Characters;
using NotSimpleGame.Models.Skins;
using NotSimpleGame.Models.Weapons;
using System.Collections.ObjectModel;
using System.ComponentModel;

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
