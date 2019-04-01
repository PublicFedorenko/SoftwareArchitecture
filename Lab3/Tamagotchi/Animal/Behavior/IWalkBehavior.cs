using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.Animal.Behavior
{
    public interface IWalkBehavior
    {
        void StartWalking();
        void StopWalking();
    }
}
