using System;

namespace NullableDirective
{
    class Program
    {
        static void Main(string[] args)
        {
            new Disable().Run();
            new Enable().Run();
            new Restore().Run();
        }
    }
}
