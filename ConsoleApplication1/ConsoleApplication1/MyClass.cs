using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_1
{
    class MyClass
    {
        private string _s; //cannot be accessed outside of the class 

        public MyClass()
        {
            _s = "Constructor String!"; //need to create method in order to access that string 
        }

        public string getStr()
        {
            return _s;
        }

        public void setStr(string aString)
        {
            _s = aString;
        }


    }
}
