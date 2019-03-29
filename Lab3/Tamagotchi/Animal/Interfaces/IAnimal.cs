﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.Animal.Interfaces
{
    public interface IAnimal : IAlive
    {
        string Name { get; set; }
        int Age { get; set; }
    }
}