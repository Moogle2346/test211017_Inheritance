using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test211017_Inheritance.Classes
{
    class Japanese : Person
    {
        public Japanese(string name, int age) : base(name, age)
        {
        }

        public override string Say()
        {
            return "私は" + base.name + "です。\n";
        }

        public override string GetData()
        {
            return "名前:" + name + "\r\n" + "年齢:" + age + "\r\n";
        }
    }
}
