using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Animal.Interfaces;
using Tamagotchi.Animal.Need.Eating;

namespace Tamagotchi.Animal.Cat
{
    public interface ICat : IAnimal
    {
        IEatingNeed EatingNeed { get; set; }
    }
}
