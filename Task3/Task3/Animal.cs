using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public abstract class Animal
    {
        public string Name;
        public abstract void SetName(string name);
        public abstract string GetName(string dogName);
        public abstract void Eat();
    }
}
