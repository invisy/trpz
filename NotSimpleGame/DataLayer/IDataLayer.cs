using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.DataLayer.Entities;

namespace NotSimpleGame.DAL
{
    interface IDataLayer
    {
        void Init();
        List<String> getWepons();
        List<String> getSkins();
    }
}
