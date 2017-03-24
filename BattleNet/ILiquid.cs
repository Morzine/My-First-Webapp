using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleNet
{
    interface ILiquid
    {
        void Flow();
    }

    public class Liquid : ILiquid
    {
        public void Flow()
        {

        }
    }
}
