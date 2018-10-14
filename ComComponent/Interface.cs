using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ComComponent.Properties
{
    [Guid("781F73FA-644C-4191-80F2-85CE93850E14")]
    [ComVisible(true)]
    public interface ITransaction
    {
        [DispId(1)]
        int add(int a, int b);

        [DispId(2)]
        int multi(int a, int b);
    }

    [Guid("21A4283C-3C52-4C16-8E96-80F75DD64615")]
    [ComVisible(true)]
    public class MyClass : ITransaction
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
