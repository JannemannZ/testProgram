using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormOOP.Classes.Program
{
    class ControllClass
    {
        string Name;
        object ControllObject;

        ControllClass(string name, object Object)
        {
            this.Name = name;
            this.ControllObject = Object;
        }
    }
}
