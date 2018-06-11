using System;
using System.Collections.Generic;

namespace ProjectLibrary
{
    public static class TypeHelper
    {
        private static readonly HashSet<Type> NumericTypes = new HashSet<Type>
        {
            typeof(int),  typeof(double),  typeof(decimal),
            typeof(long), typeof(short),   typeof(sbyte),
            typeof(byte), typeof(ulong),   typeof(ushort),
            typeof(uint), typeof(float)
        };

        public static bool IsNumeric<T>(this T myType)
        {
            var іsNumeric = false;

            if (myType != null) { іsNumeric = NumericTypes.Contains(myType.GetType());}

            return іsNumeric;
        }
    }
}
