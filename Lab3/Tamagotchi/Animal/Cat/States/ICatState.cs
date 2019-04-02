using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.Animal.Cat.States
{
    public interface ICatState
    {
        ICat Context { get; set; }
        void Walk();
        void Run();
        void Talk();
        void Stop();
    }
}
