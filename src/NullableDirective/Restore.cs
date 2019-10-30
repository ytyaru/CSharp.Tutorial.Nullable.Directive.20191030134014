using System;

namespace NullableDirective
{
    class Restore
    {
        public void Run()
        {
#nullable restore
            int i1 = null;
            int? i2 = null;
            string s1 = null;
            string? s2 = null;
        }
    }
}
