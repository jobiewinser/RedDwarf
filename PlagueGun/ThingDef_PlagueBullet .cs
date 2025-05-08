using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace Jobie.Plague
{
    public class ThingDef_PlagueBullet : ThingDef
    {
        public float AddHediffChance = 0.05f; //The default chance of adding a hediff.
        public HediffDef HediffToAdd = HediffDefOf.Plague;
    }
}
