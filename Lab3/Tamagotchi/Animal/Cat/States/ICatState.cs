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
        void Eat();
        void StartWalking();
        void StopWalking();
        void StartTalking();
        void StopTalking();
        void StartRunning();
        void StopRunning();
    }
}
