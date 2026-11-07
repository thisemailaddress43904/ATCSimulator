using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ExtensionClasses
{
    public static class ArrayExtensionClass
    {
        public static void CopyTo<T>(ref T[] source, ref T[] destination)
        {
            for (int i = 0; i < source.Length && i < destination.Length; i++)
            {
                destination[i] = source[i];
            }
        }
    }
}
