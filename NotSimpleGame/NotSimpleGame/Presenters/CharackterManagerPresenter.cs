using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Models;
using NotSimpleGame.Views;

namespace NotSimpleGame.Presenters
{
    class CharackterManagerPresenter : Presenter
    {
        public CharackterManagerPresenter(IСharacterManagerModel _model, ICharacterManagerView _view) : base(_model, _view)
        {
        }

        public override void Show()
        {
            _view.Show();
        }

        public override void Close()
        {
            _view.Close();
        }
    }
}
