// Определения структур и классов для эксперимента (№2) по сравнению производительности

namespace PerformanceComparisonLibrary
{
    public struct SmallStruct
    {
        public int IntegerValue;
    }

    public class SmallClass
    {
        public int IntegerValue;
    }

    public struct MediumStruct
    {
        public int IntegerValue;
        public string StringValue;
    }

    public class MediumClass
    {
        public int IntegerValue;
        public string StringValue;
    }

    public struct LargeStruct
    {
        public int IntegerValue;
        public string StringValue;
        public byte[] ByteArray;
    }

    public class LargeClass
    {
        public int IntegerValue;
        public string StringValue;
        public byte[] ByteArray;
    }
}