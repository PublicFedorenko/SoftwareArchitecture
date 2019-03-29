using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.Animal.Need.Eating
{
    public interface IEatingNeed
    {
        event EventHandler<EatingEventArgs> GotHungry;
        event EventHandler<EatingEventArgs> StartEating;

        int TimesEaten { get; set; }
        bool IsHungry { get; set; }
        DateTime EatingInterval { get; set; }
        void Eat();
    }
}
