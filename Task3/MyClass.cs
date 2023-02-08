using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class MyClass
    {
        public string change;

        public static void ClassTaker(MyClass myClass) 
        {
            myClass.change = "змінено";
        }
    }

    struct MyStruct
    {
        public string change;

        public static void StruktTaker(MyStruct myStruct) 
        {
            myStruct.change = "змінено";
        }
    }
}
