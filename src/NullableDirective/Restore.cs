using System;

namespace NullableDirective
{
    class Restore
    {
        public void Run()
        {
#nullable restore
            int i1 = null; // error CS0037: Null 非許容の値型であるため、Null を 'int' に変換できません
            int? i2 = null; // warning CS0219: 変数 'i2' は割り当てられていますが、その値は使用されていません。
            string s1 = null; // warning CS0219: 変数 's1' は割り当てられていますが、その値は使用されていません。
            string? s2 = null; // warning CS8632: '#nullable' 注釈コンテキスト内のコードでのみ、Null 許容参照型の注釈を使用する必要があります。
        }
    }
}
