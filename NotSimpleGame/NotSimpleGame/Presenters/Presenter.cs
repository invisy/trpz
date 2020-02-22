using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.Models;
using NotSimpleGame.Views;

namespace NotSimpleGame.Presenters
{
    abstract class Presenter
    {
        protected IСharacterManagerModel _model;
        protected IView _view;

        public Presenter(IСharacterManagerModel model, IView view)
        {
            this._model = model;
            this._view = view;
        }

        public abstract void Show();
        public abstract void Close();
    }
}
