using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test211017_Inheritance.Classes
{
    abstract class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        abstract public string Say();

        public virtual string GetData()
        {
            return "name:" + name + "\r\n" + "age:" + age + "\r\n";
        }
    }
}
