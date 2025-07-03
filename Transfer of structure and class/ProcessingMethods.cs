// Описаны статические методы для имитации обработки данных.
// Они принимают тестовые структуры и классы, чтобы измерить
// производительность операции передачи параметров (по значению и по ссылке)

namespace PerformanceComparisonLibrary
{
    public static class DataProcessorMethods
    {
        // --- малые объекты ---
        public static int ProcessSmallStruct(SmallStruct data)
        {
            return data.IntegerValue;
        }

        public static int ProcessSmallClass(SmallClass data)
        {
            return data.IntegerValue;
        }

        // --- средние объекты ---
        public static int ProcessMediumStruct(MediumStruct data)
        {
            // Простое вычисление для имитации нагрузки
            return data.IntegerValue + (data.StringValue?.Length ?? 0);
        }

        public static int ProcessMediumClass(MediumClass data)
        {
            // Простое вычисление для имитации нагрузки
            return data.IntegerValue + (data.StringValue?.Length ?? 0);
        }

        // --- крупные объекты ---
        public static int ProcessLargeStruct(LargeStruct data)
        {
            // Простое вычисление для имитации нагрузки
            return data.IntegerValue + (data.StringValue?.Length ?? 0) + (data.ByteArray != null && data.ByteArray.Length > 0 ? data.ByteArray[0] : 0);
        }

        public static int ProcessLargeClass(LargeClass data)
        {
            // Простое вычисление для имитации нагрузки
            return data.IntegerValue + (data.StringValue?.Length ?? 0) + (data.ByteArray != null && data.ByteArray.Length > 0 ? data.ByteArray[0] : 0);
        }
    }
}