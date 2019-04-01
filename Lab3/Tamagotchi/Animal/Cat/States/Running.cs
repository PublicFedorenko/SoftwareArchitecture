using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.Animal.Cat.States
{
    public class Running : ICatState
    {
        public ICat Context { get; set; }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void StartRunning()
        {
            throw new NotImplementedException();
        }

        public void StartTalking()
        {
            throw new NotImplementedException();
        }

        public void StartWalking()
        {
            throw new NotImplementedException();
        }

        public void StopRunning()
        {
            throw new NotImplementedException();
        }

        public void StopTalking()
        {
            throw new NotImplementedException();
        }

        public void StopWalking()
        {
            throw new NotImplementedException();
        }
    }
}
