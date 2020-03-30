using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

using NotSimpleGame.Models;
using NotSimpleGame.Models.General;
using NotSimpleGame.Models.General.Characters;
using NotSimpleGame.Models.General.Skins;
using NotSimpleGame.Models.General.Weapons;

using System.Windows;
using NotSimpleGame.UI.Views;

namespace NotSimpleGame.UI.ViewModels
{
    public class SelectCharacterMenuVM : ISelectCharacterMenuVM
    {
        private IPlayerManager _model;

        private ObservableCollection<Character> characters;
        private ObservableCollection<Weapon> weapons;
        private ObservableCollection<Skin> skins;


        private Character selectedCharacter;
        private Weapon selectedWeapon;
        private Skin selectedSkin;
        private Player player;
        private float weaponPrice;
        private float skinPrice;

        private float WeaponPrice { get { return weaponPrice; } set { weaponPrice = value; OnPropertyChanged("Money"); } }
        private float SkinPrice  { get { return skinPrice; } set { skinPrice = value; OnPropertyChanged("Money"); } }

        public ObservableCollection<Character> Characters { get { return characters; } }
        public ObservableCollection<Weapon> Weapons { get { return weapons; } }
        public ObservableCollection<Skin> Skins { get { return skins; } }
        public float Money { get { return player.userWallet.Money-weaponPrice-skinPrice; } }

        public Character SelectedCharacter
        {
            get { return selectedCharacter; }
            set
            {
                selectedCharacter = value;
                CharacterWasUpdated(value);
                OnPropertyChanged("SelectedCharacter");
            }
        }
        public Weapon SelectedWeapon
        {
            get { return selectedWeapon; }
            set
            {
                selectedWeapon = value;
                WeaponPrice = value.price;
                OnPropertyChanged("SelectedWeapon");
            }
        }

        public Skin SelectedSkin
        {
            get { return selectedSkin; }
            set
            {
                selectedSkin = value;
                SkinPrice = value.price;
                OnPropertyChanged("SelectedSkin");
            }
        }

        public RelayCommand GoNextCommand { get; private set; }

        public SelectCharacterMenuVM(IPlayerManager model)
        {
            _model = model;

            player = _model.getPlayerInfo();
            characters = new ObservableCollection<Character>(_model.getCharacters());
            weapons = new ObservableCollection<Weapon>();
            skins = new ObservableCollection<Skin>();
            if(Characters.Count > 0)
                SelectedCharacter = Characters[0];

            GoNextCommand = new RelayCommand(_ => GoNext());
        }

        void CharacterWasUpdated(Character character)
        {
            IEnumerable<Skin> skinsList = _model.getSkins(character);
            UpdateObservableFromIEnumerable<Skin>(skins, skinsList);
            if (Skins.Count > 0)
                SelectedSkin = Skins[0];

            IEnumerable<Weapon> weaponList = _model.getWeapons(character);
            UpdateObservableFromIEnumerable(weapons, weaponList);
            if (Weapons.Count > 0)
                SelectedWeapon = Weapons[0];
        }

        public void UpdateObservableFromIEnumerable<TItem> (ObservableCollection<TItem> obsCol, IEnumerable<TItem> list)
        {
            obsCol.Clear();
            foreach (TItem elem in list)
                obsCol.Add(elem);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private void GoNext()
        {
            _model.SavePlayerInfo(selectedCharacter, selectedWeapon, selectedSkin);
            Window window = new SuccessDialog();
            window.Show();
        }
    }
}
