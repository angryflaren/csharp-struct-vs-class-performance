using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Diagnosers;
using ArrayAccessExperimentCode;

namespace BenchmarkLab
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    [CategoriesColumn]
    public class ComparisonBenchmarkEvaluator
    {
        [Params(10000, 100000)] // Параметр для размера массивов
        public int ArraySize { get; set; }

        // Экземпляр класса с основной логикой
        private ArrayAccessMethods _experimentMethods;

        [GlobalSetup]
        public void Setup()
        {
            _experimentMethods = new ArrayAccessMethods();
            _experimentMethods.Setup(ArraySize); // Настройка данных
        }

        // --- Бенчмарки, вызывающие методы из ArrayAccessMethods ---

        [Benchmark]
        [BenchmarkCategory("Sequential")]
        public int SequentialAccess_Structs()
        {
            return _experimentMethods.SequentialAccessStructs();
        }

        [Benchmark]
        [BenchmarkCategory("Sequential")]
        public int SequentialAccess_Classes()
        {
            return _experimentMethods.SequentialAccessClasses();
        }

        [Benchmark]
        [BenchmarkCategory("Random")]
        public int RandomAccess_Structs()
        {
            return _experimentMethods.RandomAccessStructs();
        }

        [Benchmark]
        [BenchmarkCategory("Random")]
        public int RandomAccess_Classes()
        {
            return _experimentMethods.RandomAccessClasses();
        }
    }
}