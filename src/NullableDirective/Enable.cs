using System;

namespace NullableDirective
{
    class Enable
    {
        public void Run()
        {
#nullable enable
            int i1 = null; // error CS0037: Null 非許容の値型であるため、Null を 'int' に変換できません
            int? i2 = null;
            string s1 = null; // warning CS8600: Null リテラルまたは Null の可能性がある値を Null 非許容型に変換しています。
            string? s2 = null;
            string s3 = null!;
            Console.WriteLine($"{i1}, {i2}, {s1}, {s2}, {s3}");
        }
    }
}
