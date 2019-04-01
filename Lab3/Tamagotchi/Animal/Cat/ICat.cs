using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Animal.Behavior;
using Tamagotchi.Animal.Cat.States;
using Tamagotchi.Animal.Interfaces;
using Tamagotchi.Animal.Need.Eating;

namespace Tamagotchi.Animal.Cat
{
    public interface ICat : IAnimal
    {
        IEatingNeed EatingNeed { get; set; }
        IWalkBehavior WalkBehavior { get; set; }
        ITalkBehavior TalkBehavior { get; set; }
        ICatState State { get; set; }
    }
}
