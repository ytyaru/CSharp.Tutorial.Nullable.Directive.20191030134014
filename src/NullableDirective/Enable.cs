using System;

namespace NullableDirective
{
    class Enable
    {
        public void Run()
        {
#nullable enable
            int i1 = null; // error CS0037: Null 非許容の値型であるため、Null を 'int' に変換できません
            // warning CS0219: 変数 'i2' は割り当てられていますが、その値は使用されていません。
            // warning CS8600: Null リテラルまたは Null の可能性がある値を Null 非許容型に変換しています。
            int? i2 = null; 
            string s1 = null; // warning CS0219
            string? s2 = null; // warning CS0219
        }
    }
}
