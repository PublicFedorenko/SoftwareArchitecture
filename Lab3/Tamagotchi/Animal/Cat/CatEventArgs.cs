using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.Animal.Cat
{
    public class CatEventArgs : EventArgs
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsStarving { get; set; }
        public bool TimesEaten { get; set; }
    }
}
