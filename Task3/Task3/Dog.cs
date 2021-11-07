using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine(this.Name + " is Eating");
        }
        public override string GetName(string dogName)
        {
            this.Name = dogName;
            return Name;
        }

        public override void SetName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
