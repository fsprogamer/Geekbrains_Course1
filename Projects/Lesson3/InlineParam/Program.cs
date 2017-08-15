using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlineParam
{
    using System;

    class Program
    {
        static bool Test(out int size)
        {
            // This method has an out parameter.
            size = 1000;
            return size >= 1000;
        }

        static void Main()
        {
            // Declare out parameter directly inside method call.
            if (Test(out int size))
            {
                Console.WriteLine(size);
            }
        }
    }

}
