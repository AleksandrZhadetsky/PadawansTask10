using System;

namespace PadawansTask10
{
    public static class NullableTypeExtensions
    {
        public static bool IsNull(this object variable)
        {
            return ReferenceEquals(null, variable) ? true : false;
        }
    }
}
