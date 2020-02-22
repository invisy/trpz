using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotSimpleGame.Views
{
    public partial class CharacterManagerView : Form, ICharacterManagerView
    {
        public CharacterManagerView()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            Application.Run(this);
        }
    }
}
