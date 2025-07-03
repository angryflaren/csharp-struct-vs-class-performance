using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Diagnosers;
using Copying_the_structure_and_class;

namespace BenchmarkLab
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    [CategoriesColumn]
    public class CopyingBenchmarkEvaluator
    {
        // --- Экземпляры ---
        private readonly SimpleStruct3 originalStruct3 = new(1, 2, 3);
        private readonly SimpleClass3 originalClass3 = new(1, 2, 3);

        private readonly SimpleStruct10 originalStruct10 = new(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        private readonly SimpleClass10 originalClass10 = new(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

        private readonly SimpleStruct50 originalStruct50 = new(
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
            21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
            41, 42, 43, 44, 45, 46, 47, 48, 49, 50);
        private readonly SimpleClass50 originalClass50 = new(
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
            21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
            41, 42, 43, 44, 45, 46, 47, 48, 49, 50);

        // --- Категория: 3 Поля ---

        [Benchmark(Description = "Struct_3_Shallow")]
        [BenchmarkCategory("3_Fields")]
        public SimpleStruct3 Struct_Shallow_3() => originalStruct3.ShallowCopy();

        [Benchmark(Description = "Struct_3_Deep")]
        [BenchmarkCategory("3_Fields")]
        public SimpleStruct3 Struct_Deep_3() => originalStruct3.DeepCopy();

        [Benchmark(Description = "Class_3_Shallow")]
        [BenchmarkCategory("3_Fields")]
        public SimpleClass3 Class_Shallow_3() { var c = originalClass3; return c; }

        [Benchmark(Description = "Class_3_Deep")]
        [BenchmarkCategory("3_Fields")]
        public SimpleClass3 Class_Deep_3() => originalClass3.DeepCopy();

        // --- Категория: 10 Полей ---

        [Benchmark(Description = "Struct_10_Shallow")]
        [BenchmarkCategory("10_Fields")]
        public SimpleStruct10 Struct_Shallow_10() => originalStruct10.ShallowCopy();

        [Benchmark(Description = "Struct_10_Deep")]
        [BenchmarkCategory("10_Fields")]
        public SimpleStruct10 Struct_Deep_10() => originalStruct10.DeepCopy();

        [Benchmark(Description = "Class_10_Shallow")]
        [BenchmarkCategory("10_Fields")]
        public SimpleClass10 Class_Shallow_10() { var c = originalClass10; return c; }

        [Benchmark(Description = "Class_10_Deep")]
        [BenchmarkCategory("10_Fields")]
        public SimpleClass10 Class_Deep_10() => originalClass10.DeepCopy();

        // --- Категория: 50 Полей ---

        [Benchmark(Description = "Struct_50_Shallow")]
        [BenchmarkCategory("50_Fields")]
        public SimpleStruct50 Struct_Shallow_50() => originalStruct50.ShallowCopy();

        [Benchmark(Description = "Struct_50_Deep")]
        [BenchmarkCategory("50_Fields")]
        public SimpleStruct50 Struct_Deep_50() => originalStruct50.DeepCopy();

        [Benchmark(Description = "Class_50_Shallow")]
        [BenchmarkCategory("50_Fields")]
        public SimpleClass50 Class_Shallow_50() { var c = originalClass50; return c; }

        [Benchmark(Description = "Class_50_Deep")]
        [BenchmarkCategory("50_Fields")]
        public SimpleClass50 Class_Deep_50() => originalClass50.DeepCopy();
    }
}