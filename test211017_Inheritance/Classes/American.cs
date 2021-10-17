using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test211017_Inheritance.Classes
{
    class American : Person
    {
        public American(string name, int age) : base(name, age)
        {

        }

        public override string Say()
        {
            return "My name is " + base.name + ". I'm " + age + " years old.";
        }
    }
}
