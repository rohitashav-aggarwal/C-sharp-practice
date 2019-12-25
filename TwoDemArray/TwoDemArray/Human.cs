using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDemArray
{
    class Human
    {
        private string name = "human";
        private int age = 0;

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public int getAge()
        {
            return age;
        }
        public void setAge(int age)
        {
            this.age = age;
        }

    }
}
