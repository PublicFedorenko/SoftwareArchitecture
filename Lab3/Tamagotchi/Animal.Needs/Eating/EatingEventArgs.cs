using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.Animal.Needs.Eating
{
    public class EatingEventArgs : EventArgs
    {
        public int TimesEaten { get; private set; }
        public bool IsStarving { get; private set; }

        public EatingEventArgs(int timesEaten, bool isStarving)
        {
            TimesEaten = timesEaten;
            IsStarving = isStarving;
        }
    }
}
