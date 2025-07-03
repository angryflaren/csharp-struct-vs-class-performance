using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Diagnosers;
using PerformanceComparisonLibrary;
using System;
using System.Security.Cryptography; // необходим для генерации случайных байтов
using System.Linq;

namespace BenchmarkLab
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    [CategoriesColumn]

    public class TransferBenchmarkEvaluator
    {
        private Random _random;
        private RNGCryptoServiceProvider _rng;

        [GlobalSetup]
        public void Setup()
        {
            _random = new Random();
            _rng = new RNGCryptoServiceProvider();
        }
        private SmallStruct CreateSmallStruct() => new SmallStruct { IntegerValue = _random.Next() };
        private SmallClass CreateSmallClass() => new SmallClass { IntegerValue = _random.Next() };

        private MediumStruct CreateMediumStruct() => new MediumStruct { IntegerValue = _random.Next(), StringValue = GenerateRandomString(50) }; // Увеличим длину строки для заметности
        private MediumClass CreateMediumClass() => new MediumClass { IntegerValue = _random.Next(), StringValue = GenerateRandomString(50) }; // Увеличим длину строки для заметности

        private LargeStruct CreateLargeStruct()
        {
            var bytes = new byte[1024];
            _rng.GetBytes(bytes); // Генерация случайных байтов
            return new LargeStruct
            {
                IntegerValue = _random.Next(),
                StringValue = GenerateRandomString(200), // Увеличиваем длину строки
                ByteArray = bytes
            };
        }

        private LargeClass CreateLargeClass()
        {
            var bytes = new byte[1024];
            _rng.GetBytes(bytes); // Генерация случайных байтов
            return new LargeClass
            {
                IntegerValue = _random.Next(),
                StringValue = GenerateRandomString(200), // Увеличиваем длину строки
                ByteArray = bytes
            };
        }

        private string GenerateRandomString(int length) // Генерация случайной строки
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringBytes = new byte[length];
            _rng.GetBytes(stringBytes); // Используем RNGCryptoServiceProvider для строк тоже
            return new string(stringBytes.Select(b => chars[b % chars.Length]).ToArray());
        }


        [Benchmark]
        [BenchmarkCategory("Small")]
        public int SmallStruct()
        {
            var data = CreateSmallStruct();
            return DataProcessorMethods.ProcessSmallStruct(data);
        }

        [Benchmark]
        [BenchmarkCategory("Small")]
        public int SmallClass()
        {
            var data = CreateSmallClass();
            return DataProcessorMethods.ProcessSmallClass(data);
        }

        [Benchmark]
        [BenchmarkCategory("Medium")]
        public int MediumStruct()
        {
            var data = CreateMediumStruct();
            return DataProcessorMethods.ProcessMediumStruct(data);
        }

        [Benchmark]
        [BenchmarkCategory("Medium")]
        public int MediumClass()
        {
            var data = CreateMediumClass();
            return DataProcessorMethods.ProcessMediumClass(data);
        }

        [Benchmark]
        [BenchmarkCategory("Large")]
        public int LargeStruct()
        {
            var data = CreateLargeStruct();
            return DataProcessorMethods.ProcessLargeStruct(data);
        }

        [Benchmark]
        [BenchmarkCategory("Large")]
        public int LargeClass()
        {
            var data = CreateLargeClass();
            return DataProcessorMethods.ProcessLargeClass(data);
        }
    }
}
