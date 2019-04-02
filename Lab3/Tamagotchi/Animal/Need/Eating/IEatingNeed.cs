using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Animal.Cat;

namespace Tamagotchi.Animal.Need.Eating
{
    public interface IEatingNeed
    {
        int TimesEaten { get; set; }
        bool IsHungry { get; set; }
        DateTime EatingInterval { get; set; }
        void Eat();
    }
}
