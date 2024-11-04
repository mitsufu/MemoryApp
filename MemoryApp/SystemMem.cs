using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MemoryApp
{
    public class SystemMem
    {
        static public unsafe void Test()
        {
            IntPtr p = Marshal.AllocHGlobal(1_000_000);
            int* i = (int*)p;
            i++;
            int j = *i;
        }
        static unsafe void PerformOperation()
        {
            byte[] buf = new byte[1024];
            fixed (void* ptr = &buf[0])
            {
                //SomeUnmanagedFunction(new IntPtr(ptr));
            }
        }
    }
}
