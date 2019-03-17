using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.Animal.Needs.Eating
{
    public interface IEatingNeed
    {
        event EventHandler<EatingEventArgs> StatusChanged;

        int TimesEaten { get; set; }
        bool IsStarving { get; set; }
        DateTime EatingInterval { get; set; }
        void Eat();
    }
}