using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.Animal.Interfaces
{
    public interface IAlive
    {
        // there could be Health property
        bool IsAlive { get; set; }
    }
}
