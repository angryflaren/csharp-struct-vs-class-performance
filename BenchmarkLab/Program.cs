using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

namespace BenchmarkLab
{
    public class Program
    {
        static void Main(string[] args)
        {
            var config = ManualConfig.Create(DefaultConfig.Instance)
            .AddJob(Job.LongRun
                .WithPlatform(BenchmarkDotNet.Environments.Platform.X64)
                .WithJit(BenchmarkDotNet.Environments.Jit.RyuJit)
                .WithWarmupCount(100) // Количество "прогревочных" итераций
                .WithIterationCount(100) // Количество итераций для измерения
                .WithInvocationCount(500) // Сколько раз вызывается метод за одну итерацию измерения
                .WithUnrollFactor(1)); // Уровень "раскрутки" цикла

            BenchmarkRunner.Run<CopyingBenchmarkEvaluator>(config);
            BenchmarkRunner.Run<TransferBenchmarkEvaluator>(config);
            BenchmarkRunner.Run<ComparisonBenchmarkEvaluator>(config);
        }
    }
}