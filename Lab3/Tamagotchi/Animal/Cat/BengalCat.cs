using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Animal.Need.Eating;

namespace Tamagotchi.Animal.Cat
{
    public class BengalCat : ICat
    {
        public event EventHandler<CatEventArgs> StatusChanged;

        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsAlive { get; set; }
        public IEatingNeed EatingNeed { get; set; }

        public BengalCat(string name, int age)
        {
            Name = name;
            Age = age;
            IsAlive = true;
            //EatingNeed = new CatEatingFiveTimes();
        }

        public void Eat()
        {
            EatingNeed.Eat();
        }
    }
}
