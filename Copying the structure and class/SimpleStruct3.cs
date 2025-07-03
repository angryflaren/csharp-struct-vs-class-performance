namespace Copying_the_structure_and_class
{
    // Структура с 3 полями
    public struct SimpleStruct3
    {
        public int Field1;
        public int Field2;
        public int Field3;

        public SimpleStruct3(int field1, int field2, int field3)
        {
            Field1 = field1;
            Field2 = field2;
            Field3 = field3;
        }

        // Тестируемый метод №1: Поверхностное копирование (побитовое копирование)
        public SimpleStruct3 ShallowCopy()
        {
            return this;
        }

        // Тестируемый метод №2: Глубокое копирование
        public SimpleStruct3 DeepCopy()
        {
            return new SimpleStruct3(
                Field1,
                Field2,
                Field3
            );
        }
    }
}