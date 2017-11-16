using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1
{
   partial class Class1
    {  
        void g() { f(); } 
    }

    partial class Class1
    {
        void g() { }
        void f() { }
    }
}
