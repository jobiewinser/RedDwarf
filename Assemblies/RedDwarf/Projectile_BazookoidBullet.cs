using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace Jobie.RedDwarf
{
    public class Projectile_BazookoidBullet : Bullet
    {
        #region Properties
        //
        public ThingDef_BazookoidBullet Def
        {
            get
            {
                return this.def as ThingDef_BazookoidBullet;
            }
        }
        #endregion Properties
    }
}
