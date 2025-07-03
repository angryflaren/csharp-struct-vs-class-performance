using System;
using System.Linq;

// Инкапсулирует логику эксперимента по измерению скорости доступа
// к элементам в массивах структур и классов

namespace ArrayAccessExperimentCode
{
    public class ArrayAccessMethods
    {
        public int ArraySize { get; private set; }

        // --- Приватные поля для хранения тестовых данных ---
        private PointStruct[] _structArray;
        private PointClass[] _classArray;
        private int[] _randomIndices;

        // Подготавливаем тестовые данные: создаем и заполняем массивы
        public void Setup(int size)
        {
            ArraySize = size;
            _structArray = new PointStruct[ArraySize];
            _classArray = new PointClass[ArraySize];
            _randomIndices = new int[ArraySize];

            Random random = new Random(42); // Используем фиксированный seed. Константа, известная во всех уголках Галактики xD.

            for (int i = 0; i < ArraySize; i++)
            {
                // Заполняем массивы одинаковыми данными
                _structArray[i] = new PointStruct { X = random.Next(), Y = random.Next() };
                _classArray[i] = new PointClass { X = random.Next(), Y = random.Next() };

                // Создаем массив случайных индексов
                _randomIndices[i] = random.Next(0, ArraySize);
            }
        }

        // --- Методы для измерения производительности ---

        // Тест 1: Последовательный доступ к элементам массива структур
        public int SequentialAccessStructs()
        {
            int sum = 0;
            for (int i = 0; i < ArraySize; i++)
            {
                sum += _structArray[i].X;
            }
            return sum;
        }

        // Тест 2: Последовательный доступ к элементам массива классов
        public int SequentialAccessClasses()
        {
            int sum = 0;
            for (int i = 0; i < ArraySize; i++)
            {
                sum += _classArray[i].X;
            }
            return sum;
        }

        // Тест 3: Случайный доступ к элементам массива структур
        public int RandomAccessStructs()
        {
            int sum = 0;
            int[] localIndices = _randomIndices;
            PointStruct[] localArray = _structArray;
            for (int i = 0; i < localIndices.Length; i++)
            {
                sum += localArray[localIndices[i]].X;
            }
            return sum;
        }

        // Тест 4: Случайный доступ к элементам массива классов
        public int RandomAccessClasses()
        {
            int sum = 0;
            int[] localIndices = _randomIndices;
            PointClass[] localArray = _classArray;
            for (int i = 0; i < localIndices.Length; i++)
            {
                sum += localArray[localIndices[i]].X;
            }
            return sum;
        }
    }
}