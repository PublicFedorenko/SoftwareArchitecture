using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Animals;

namespace Tamagotchi.Owners
{
    public interface IOwner
    {
        event EventHandler PetFeeded;
        IAnimal Pet { get; set; }
        void FeedPat();
    }
}
