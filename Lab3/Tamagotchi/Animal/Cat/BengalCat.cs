using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Animal.Behavior;
using Tamagotchi.Animal.Cat.States;
using Tamagotchi.Animal.Need.Eating;

namespace Tamagotchi.Animal.Cat
{
    public class BengalCat : ICat
    {
        public event EventHandler<CatEventArgs> StatusChanged;

        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsAlive { get; set; }
        public ICatState State { get; set; }
        public IEatingNeed EatingNeed { get; set; }
        public IWalkBehavior WalkBehavior { get; set; }
        public ITalkBehavior TalkBehavior { get; set; }

        public BengalCat(string name, int age)
        {
            Name = name;
            Age = age;
            IsAlive = true;
            State = new Idle();
        }

        public void Eat()
        {
            State.Eat();
        }

        public void StartWalking()
        {
            State.StartWalking();
        }

        public void StopWalking()
        {
            State.StopWalking();
        }

        public void StartTalking()
        {
            State.StartTalking();
        }

        public void StopTalking()
        {
            State.StopTalking();
        }

        public void StartRunning()
        {
            State.StartRunning();
        }

        public void StopRunning()
        {
            State.StopRunning();
        }
    }
}
