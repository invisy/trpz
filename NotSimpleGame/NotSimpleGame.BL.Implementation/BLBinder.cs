using NotSimpleGame.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotSimpleGame.DL.Implementation;
using NotSimpleGame.BL.Abstraction;
using NotSimpleGame.BL.Implementation.Services;

namespace NotSimpleGame.BL.Implementation
{
    public static class BLBinder
    {
        public static void BindBL(this IIoCContainer container)
        {
            container.BindDL();
            container.Register<IPlayerManager, PlayerManagerService>();
        }
    }
}
