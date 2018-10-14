using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace COM.Properties
{
    [Guid("EA652E4A-175F-4218-B6B6-2498031AA135")]
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    [Description("实现接口")]
    class Implemtation : ITransaction
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int multi(int a, int b)
        {
            return a * b;
        }
    }
}
