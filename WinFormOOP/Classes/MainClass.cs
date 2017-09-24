using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormOOP.Classes.Program;

namespace WinFormOOP.Classes
{
    class MainClass
    {
        private ControllClass controll;
        private HelperClass helper;
        MainClass()
        {
            controll = new ControllClass();
            helper = new HelperClass();
        }
    }
}
