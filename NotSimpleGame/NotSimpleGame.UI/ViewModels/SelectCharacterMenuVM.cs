using NotSimpleGame.BL.Abstraction;
using NotSimpleGame.Models;
using NotSimpleGame.Models.Characters;
using NotSimpleGame.Models.Skins;
using NotSimpleGame.Models.Weapons;
using NotSimpleGame.UI.Views;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace NotSimpleGame.UI.ViewModels
{
    public class SelectCharacterMenuVM : ISelectCharacterMenuVM
    {
        private IPlayerManager _playerManager;

        private ObservableCollection<Character> characters;
        private ObservableCollection<Weapon> weapons;
        private ObservableCollection<Skin> skins;


        private Character selectedCharacter;
        private Weapon selectedWeapon;
        private Skin selectedSkin;
        private Player player;

        public ObservableCollection<Character> Characters { get { return characters; } }
        public ObservableCollection<Weapon> Weapons { get { return weapons; } }
        public ObservableCollection<Skin> Skins { get { return skins; } }
        public float Money { get { return player.UserWallet.Money; } }

        public Character SelectedCharacter
        {
            get { return selectedCharacter; }
            set
            {
                if (value != null)
                {
                    player.setCharacter(value);
                    selectedCharacter = value;
                    CharacterWasUpdated(value);
                    OnPropertyChanged("SelectedCharacter");
                }
            }
        }
        public Weapon SelectedWeapon
        {
            get { return selectedWeapon; }
            set
            {
                if (value != null)
                {
                    if (player.setWeapon(value))
                    {
                        selectedWeapon = value;
                        OnPropertyChanged("Money");
                    }
                    else
                    {
                        Window window = new SuccessDialog("Недостатньо грошей!");
                        window.Show();
                    }
                    OnPropertyChanged("SelectedWeapon");
                }
            }
        }

        public Skin SelectedSkin
        {
            get { return selectedSkin; }
            set
            {
                if (value != null)
                {
                    if (player.setSkin(value))
                    {
                        selectedSkin = value;
                        OnPropertyChanged("Money");
                    }
                    else
                    {
                        Window window = new SuccessDialog("Недостатньо грошей!");
                        window.Show();
                    }
                    OnPropertyChanged("SelectedSkin");
                }
            }
        }

        public RelayCommand GoNextCommand { get; private set; }

        public SelectCharacterMenuVM(IPlayerManager playerManager)
        {
            _playerManager = playerManager;

            player = _playerManager.getPlayerInfo();
            characters = new ObservableCollection<Character>(_playerManager.getCharacters());
            weapons = new ObservableCollection<Weapon>();
            skins = new ObservableCollection<Skin>();

            selectedCharacter = player.Character;
            IEnumerable<Skin> skinsList = _playerManager.getSkins(selectedCharacter);
            UpdateObservableFromIEnumerable<Skin>(skins, skinsList);
            IEnumerable<Weapon> weaponList = _playerManager.getWeapons(selectedCharacter);
            UpdateObservableFromIEnumerable(weapons, weaponList);

            selectedSkin = skins.Where(x => x.Id == player.Character.Skin.Id).FirstOrDefault();
            selectedWeapon = weapons.Where(x => x.Id == player.Character.Weapon.Id).FirstOrDefault();

            GoNextCommand = new RelayCommand(_ => GoNext());
        }

        void CharacterWasUpdated(Character character)
        {
            IEnumerable<Skin> skinsList = _playerManager.getSkins(character);
            UpdateObservableFromIEnumerable<Skin>(skins, skinsList);
            if (Skins.Count > 0)
                SelectedSkin = Skins[0];

            IEnumerable<Weapon> weaponList = _playerManager.getWeapons(character);
            UpdateObservableFromIEnumerable(weapons, weaponList);
            if (Weapons.Count > 0)
                SelectedWeapon = Weapons[0];
        }

        public void UpdateObservableFromIEnumerable<TItem>(ObservableCollection<TItem> obsCol, IEnumerable<TItem> list)
        {
            obsCol.Clear();
            foreach (TItem elem in list)
                obsCol.Add(elem);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private void GoNext()
        {
            _playerManager.SavePlayerInfo(selectedWeapon, selectedSkin);
            Window window = new SuccessDialog("Успіх!");
            window.Show();
        }
    }
}
